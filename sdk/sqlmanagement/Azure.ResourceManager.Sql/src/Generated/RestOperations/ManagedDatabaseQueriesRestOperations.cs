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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    internal partial class ManagedDatabaseQueriesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ManagedDatabaseQueriesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ManagedDatabaseQueriesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/queries/", false);
            uri.AppendPath(queryId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/queries/", false);
            uri.AppendPath(queryId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get query by query id. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ManagedInstanceQuery>> GetAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQuery value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ManagedInstanceQuery.DeserializeManagedInstanceQuery(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get query by query id. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ManagedInstanceQuery> Get(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQuery value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ManagedInstanceQuery.DeserializeManagedInstanceQuery(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByQueryRequestUri(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime, string endTime, QueryTimeGrainType? interval)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/queries/", false);
            uri.AppendPath(queryId, true);
            uri.AppendPath("/statistics", false);
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime, true);
            }
            if (endTime != null)
            {
                uri.AppendQuery("endTime", endTime, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByQueryRequest(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime, string endTime, QueryTimeGrainType? interval)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Sql/managedInstances/", false);
            uri.AppendPath(managedInstanceName, true);
            uri.AppendPath("/databases/", false);
            uri.AppendPath(databaseName, true);
            uri.AppendPath("/queries/", false);
            uri.AppendPath(queryId, true);
            uri.AppendPath("/statistics", false);
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime, true);
            }
            if (endTime != null)
            {
                uri.AppendQuery("endTime", endTime, true);
            }
            if (interval != null)
            {
                uri.AppendQuery("interval", interval.Value.ToString(), true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get query execution statistics by query id. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="startTime"> Start time for observed period. </param>
        /// <param name="endTime"> End time for observed period. </param>
        /// <param name="interval"> The time step to be used to summarize the metric values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ManagedInstanceQueryStatistics>> ListByQueryAsync(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = null, string endTime = null, QueryTimeGrainType? interval = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateListByQueryRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQueryStatistics value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ManagedInstanceQueryStatistics.DeserializeManagedInstanceQueryStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get query execution statistics by query id. </summary>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="startTime"> Start time for observed period. </param>
        /// <param name="endTime"> End time for observed period. </param>
        /// <param name="interval"> The time step to be used to summarize the metric values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ManagedInstanceQueryStatistics> ListByQuery(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = null, string endTime = null, QueryTimeGrainType? interval = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateListByQueryRequest(subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQueryStatistics value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ManagedInstanceQueryStatistics.DeserializeManagedInstanceQueryStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByQueryNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime, string endTime, QueryTimeGrainType? interval)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByQueryNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime, string endTime, QueryTimeGrainType? interval)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get query execution statistics by query id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="startTime"> Start time for observed period. </param>
        /// <param name="endTime"> End time for observed period. </param>
        /// <param name="interval"> The time step to be used to summarize the metric values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ManagedInstanceQueryStatistics>> ListByQueryNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = null, string endTime = null, QueryTimeGrainType? interval = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateListByQueryNextPageRequest(nextLink, subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQueryStatistics value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ManagedInstanceQueryStatistics.DeserializeManagedInstanceQueryStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get query execution statistics by query id. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="managedInstanceName"> The name of the managed instance. </param>
        /// <param name="databaseName"> The name of the database. </param>
        /// <param name="queryId"> The <see cref="string"/> to use. </param>
        /// <param name="startTime"> Start time for observed period. </param>
        /// <param name="endTime"> End time for observed period. </param>
        /// <param name="interval"> The time step to be used to summarize the metric values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="managedInstanceName"/>, <paramref name="databaseName"/> or <paramref name="queryId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ManagedInstanceQueryStatistics> ListByQueryNextPage(string nextLink, string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string queryId, string startTime = null, string endTime = null, QueryTimeGrainType? interval = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(managedInstanceName, nameof(managedInstanceName));
            Argument.AssertNotNullOrEmpty(databaseName, nameof(databaseName));
            Argument.AssertNotNullOrEmpty(queryId, nameof(queryId));

            using var message = CreateListByQueryNextPageRequest(nextLink, subscriptionId, resourceGroupName, managedInstanceName, databaseName, queryId, startTime, endTime, interval);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ManagedInstanceQueryStatistics value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ManagedInstanceQueryStatistics.DeserializeManagedInstanceQueryStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
