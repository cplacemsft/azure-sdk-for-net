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
using Azure.ResourceManager.Blueprint.Models;

namespace Azure.ResourceManager.Blueprint
{
    internal partial class PublishedBlueprintsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PublishedBlueprintsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PublishedBlueprintsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2018-11-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateRequestUri(string resourceScope, string blueprintName, string versionId, PublishedBlueprintData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string resourceScope, string blueprintName, string versionId, PublishedBlueprintData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
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

        /// <summary> Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/>, <paramref name="versionId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PublishedBlueprintData>> CreateAsync(string resourceScope, string blueprintName, string versionId, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceScope, blueprintName, versionId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        PublishedBlueprintData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/>, <paramref name="versionId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PublishedBlueprintData> Create(string resourceScope, string blueprintName, string versionId, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(resourceScope, blueprintName, versionId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        PublishedBlueprintData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceScope, string blueprintName, string versionId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceScope, string blueprintName, string versionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a published version of a blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PublishedBlueprintData>> GetAsync(string resourceScope, string blueprintName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateGetRequest(resourceScope, blueprintName, versionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PublishedBlueprintData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a published version of a blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PublishedBlueprintData> Get(string resourceScope, string blueprintName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateGetRequest(resourceScope, blueprintName, versionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PublishedBlueprintData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string resourceScope, string blueprintName, string versionId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string resourceScope, string blueprintName, string versionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a published version of a blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PublishedBlueprintData>> DeleteAsync(string resourceScope, string blueprintName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateDeleteRequest(resourceScope, blueprintName, versionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((PublishedBlueprintData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a published version of a blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/>, <paramref name="blueprintName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PublishedBlueprintData> Delete(string resourceScope, string blueprintName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateDeleteRequest(resourceScope, blueprintName, versionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = PublishedBlueprintData.DeserializePublishedBlueprintData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 204:
                    return Response.FromValue((PublishedBlueprintData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceScope, string blueprintName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceScope, string blueprintName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceScope, false);
            uri.AppendPath("/providers/Microsoft.Blueprint/blueprints/", false);
            uri.AppendPath(blueprintName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List published versions of given blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PublishedBlueprintList>> ListAsync(string resourceScope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var message = CreateListRequest(resourceScope, blueprintName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = PublishedBlueprintList.DeserializePublishedBlueprintList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List published versions of given blueprint definition. </summary>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceScope"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PublishedBlueprintList> List(string resourceScope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var message = CreateListRequest(resourceScope, blueprintName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = PublishedBlueprintList.DeserializePublishedBlueprintList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceScope, string blueprintName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceScope, string blueprintName)
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

        /// <summary> List published versions of given blueprint definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceScope"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PublishedBlueprintList>> ListNextPageAsync(string nextLink, string resourceScope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, blueprintName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = PublishedBlueprintList.DeserializePublishedBlueprintList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List published versions of given blueprint definition. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceScope"> The scope of the resource. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'). </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceScope"/> or <paramref name="blueprintName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PublishedBlueprintList> ListNextPage(string nextLink, string resourceScope, string blueprintName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceScope, nameof(resourceScope));
            Argument.AssertNotNullOrEmpty(blueprintName, nameof(blueprintName));

            using var message = CreateListNextPageRequest(nextLink, resourceScope, blueprintName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PublishedBlueprintList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = PublishedBlueprintList.DeserializePublishedBlueprintList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
