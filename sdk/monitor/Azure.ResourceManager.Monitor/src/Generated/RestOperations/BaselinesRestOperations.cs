// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    internal partial class BaselinesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BaselinesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BaselinesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceUri, string metricnames, string metricnamespace, string timespan, TimeSpan? interval, string aggregation, string sensitivities, string filter, MonitorResultType? resultType)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.Insights/metricBaselines", false);
            if (metricnames != null)
            {
                uri.AppendQuery("metricnames", metricnames, true);
            }
            if (metricnamespace != null)
            {
                uri.AppendQuery("metricnamespace", metricnamespace, true);
            }
            if (timespan != null)
            {
                uri.AppendQuery("timespan", timespan, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value, "P", true);
            }
            if (aggregation != null)
            {
                uri.AppendQuery("aggregation", aggregation, true);
            }
            if (sensitivities != null)
            {
                uri.AppendQuery("sensitivities", sensitivities, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (resultType != null)
            {
                uri.AppendQuery("resultType", resultType.Value.ToSerialString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceUri, string metricnames, string metricnamespace, string timespan, TimeSpan? interval, string aggregation, string sensitivities, string filter, MonitorResultType? resultType)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.Insights/metricBaselines", false);
            if (metricnames != null)
            {
                uri.AppendQuery("metricnames", metricnames, true);
            }
            if (metricnamespace != null)
            {
                uri.AppendQuery("metricnamespace", metricnamespace, true);
            }
            if (timespan != null)
            {
                uri.AppendQuery("timespan", timespan, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value, "P", true);
            }
            if (aggregation != null)
            {
                uri.AppendQuery("aggregation", aggregation, true);
            }
            if (sensitivities != null)
            {
                uri.AppendQuery("sensitivities", sensitivities, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (resultType != null)
            {
                uri.AppendQuery("resultType", resultType.Value.ToSerialString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> **Lists the metric baseline values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. Special case: If a metricname itself has a comma in it then use %2 to indicate it. Eg: 'Metric,Name1' should be **'Metric%2Name1'**. </param>
        /// <param name="metricnamespace"> Metric namespace that contains the requested metric names. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format 'startDateTime_ISO/endDateTime_ISO'. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="sensitivities"> The list of sensitivities (comma separated) to retrieve. </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned. Example: Metric contains metadata A, B and C. - Return all time series of C where A = a1 and B = b1 or b2 **$filter=A eq 'a1' and B eq 'b1' or B eq 'b2' and C eq '*'** - Invalid variant: **$filter=A eq 'a1' and B eq 'b1' and C eq '*' or B = 'b2'** This is invalid because the logical or operator cannot separate two different metadata names. - Return all time series where A = a1, B = b1 and C = c1: **$filter=A eq 'a1' and B eq 'b1' and C eq 'c1'** - Return all time series where A = a1 **$filter=A eq 'a1' and B eq '*' and C eq '*'**. Special case: When dimension name or dimension value uses round brackets. Eg: When dimension name is **dim (test) 1** Instead of using $filter= "dim (test) 1 eq '*' " use **$filter= "dim %2528test%2529 1 eq '*' "** When dimension name is **dim (test) 3** and dimension value is **dim3 (test) val** Instead of using $filter= "dim (test) 3 eq 'dim3 (test) val' " use **$filter= "dim %2528test%2529 3 eq 'dim3 %2528test%2529 val' "**. </param>
        /// <param name="resultType"> Allows retrieving only metadata of the baseline. On data request all information is retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<MetricBaselinesResponse>> ListAsync(string resourceUri, string metricnames = null, string metricnamespace = null, string timespan = null, TimeSpan? interval = null, string aggregation = null, string sensitivities = null, string filter = null, MonitorResultType? resultType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri, metricnames, metricnamespace, timespan, interval, aggregation, sensitivities, filter, resultType);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MetricBaselinesResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = MetricBaselinesResponse.DeserializeMetricBaselinesResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> **Lists the metric baseline values for a resource**. </summary>
        /// <param name="resourceUri"> The identifier of the resource. </param>
        /// <param name="metricnames"> The names of the metrics (comma separated) to retrieve. Special case: If a metricname itself has a comma in it then use %2 to indicate it. Eg: 'Metric,Name1' should be **'Metric%2Name1'**. </param>
        /// <param name="metricnamespace"> Metric namespace that contains the requested metric names. </param>
        /// <param name="timespan"> The timespan of the query. It is a string with the following format 'startDateTime_ISO/endDateTime_ISO'. </param>
        /// <param name="interval"> The interval (i.e. timegrain) of the query. </param>
        /// <param name="aggregation"> The list of aggregation types (comma separated) to retrieve. </param>
        /// <param name="sensitivities"> The list of sensitivities (comma separated) to retrieve. </param>
        /// <param name="filter"> The **$filter** is used to reduce the set of metric data returned. Example: Metric contains metadata A, B and C. - Return all time series of C where A = a1 and B = b1 or b2 **$filter=A eq 'a1' and B eq 'b1' or B eq 'b2' and C eq '*'** - Invalid variant: **$filter=A eq 'a1' and B eq 'b1' and C eq '*' or B = 'b2'** This is invalid because the logical or operator cannot separate two different metadata names. - Return all time series where A = a1, B = b1 and C = c1: **$filter=A eq 'a1' and B eq 'b1' and C eq 'c1'** - Return all time series where A = a1 **$filter=A eq 'a1' and B eq '*' and C eq '*'**. Special case: When dimension name or dimension value uses round brackets. Eg: When dimension name is **dim (test) 1** Instead of using $filter= "dim (test) 1 eq '*' " use **$filter= "dim %2528test%2529 1 eq '*' "** When dimension name is **dim (test) 3** and dimension value is **dim3 (test) val** Instead of using $filter= "dim (test) 3 eq 'dim3 (test) val' " use **$filter= "dim %2528test%2529 3 eq 'dim3 %2528test%2529 val' "**. </param>
        /// <param name="resultType"> Allows retrieving only metadata of the baseline. On data request all information is retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<MetricBaselinesResponse> List(string resourceUri, string metricnames = null, string metricnamespace = null, string timespan = null, TimeSpan? interval = null, string aggregation = null, string sensitivities = null, string filter = null, MonitorResultType? resultType = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri, metricnames, metricnamespace, timespan, interval, aggregation, sensitivities, filter, resultType);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MetricBaselinesResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = MetricBaselinesResponse.DeserializeMetricBaselinesResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
