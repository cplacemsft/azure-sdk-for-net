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
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    internal partial class WatchlistItemsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WatchlistItemsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WatchlistItemsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-01-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken)
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
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all watchlist Items. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WatchlistItemList>> ListAsync(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WatchlistItemList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = WatchlistItemList.DeserializeWatchlistItemList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all watchlist Items. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WatchlistItemList> List(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WatchlistItemList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = WatchlistItemList.DeserializeWatchlistItemList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
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
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a watchlist, without its watchlist items. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityInsightsWatchlistItemData>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityInsightsWatchlistItemData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityInsightsWatchlistItemData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a watchlist, without its watchlist items. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityInsightsWatchlistItemData> Get(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityInsightsWatchlistItemData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityInsightsWatchlistItemData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a watchlist item. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId);
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

        /// <summary> Delete a watchlist item. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId);
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

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, SecurityInsightsWatchlistItemData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, SecurityInsightsWatchlistItemData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.OperationalInsights/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/providers/Microsoft.SecurityInsights/watchlists/", false);
            uri.AppendPath(watchlistAlias, true);
            uri.AppendPath("/watchlistItems/", false);
            uri.AppendPath(watchlistItemId, true);
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

        /// <summary> Creates or updates a watchlist item. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="data"> The watchlist item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/>, <paramref name="watchlistItemId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityInsightsWatchlistItemData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, SecurityInsightsWatchlistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityInsightsWatchlistItemData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a watchlist item. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="watchlistItemId"> Watchlist Item Id (GUID). </param>
        /// <param name="data"> The watchlist item. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/>, <paramref name="watchlistItemId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="watchlistAlias"/> or <paramref name="watchlistItemId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityInsightsWatchlistItemData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string watchlistItemId, SecurityInsightsWatchlistItemData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNullOrEmpty(watchlistItemId, nameof(watchlistItemId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, workspaceName, watchlistAlias, watchlistItemId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityInsightsWatchlistItemData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = SecurityInsightsWatchlistItemData.DeserializeSecurityInsightsWatchlistItemData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken)
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

        /// <summary> Gets all watchlist Items. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WatchlistItemList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, watchlistAlias, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WatchlistItemList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = WatchlistItemList.DeserializeWatchlistItemList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all watchlist Items. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> The name of the workspace. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/> or <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WatchlistItemList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string watchlistAlias, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workspaceName, nameof(workspaceName));
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, watchlistAlias, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WatchlistItemList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = WatchlistItemList.DeserializeWatchlistItemList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
