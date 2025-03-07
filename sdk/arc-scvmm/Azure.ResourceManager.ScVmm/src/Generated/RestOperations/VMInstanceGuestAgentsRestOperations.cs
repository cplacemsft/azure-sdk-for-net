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
using Azure.ResourceManager.ScVmm.Models;

namespace Azure.ResourceManager.ScVmm
{
    internal partial class VMInstanceGuestAgentsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VMInstanceGuestAgentsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VMInstanceGuestAgentsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-10-07";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string resourceUri, ScVmmGuestAgentData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string resourceUri, ScVmmGuestAgentData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create Or Update GuestAgent. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response> CreateAsync(string resourceUri, ScVmmGuestAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceUri, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create Or Update GuestAgent. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> or <paramref name="data"/> is null. </exception>
        public Response Create(string resourceUri, ScVmmGuestAgentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceUri, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements GuestAgent GET method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<ScVmmGuestAgentData>> GetAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateGetRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScVmmGuestAgentData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ScVmmGuestAgentData.DeserializeScVmmGuestAgentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScVmmGuestAgentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements GuestAgent GET method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<ScVmmGuestAgentData> Get(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateGetRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScVmmGuestAgentData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ScVmmGuestAgentData.DeserializeScVmmGuestAgentData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScVmmGuestAgentData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements GuestAgent DELETE method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateDeleteRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements GuestAgent DELETE method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response Delete(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateDeleteRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ScVmm/virtualMachineInstances/default/guestAgents", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns the list of GuestAgent of the given vm. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<GuestAgentList>> ListAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestAgentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = GuestAgentList.DeserializeGuestAgentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of GuestAgent of the given vm. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<GuestAgentList> List(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestAgentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = GuestAgentList.DeserializeGuestAgentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceUri)
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

        /// <summary> Returns the list of GuestAgent of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<GuestAgentList>> ListNextPageAsync(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestAgentList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = GuestAgentList.DeserializeGuestAgentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of GuestAgent of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public Response<GuestAgentList> ListNextPage(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GuestAgentList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = GuestAgentList.DeserializeGuestAgentList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
