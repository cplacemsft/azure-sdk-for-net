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
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    internal partial class StorageTaskAssignmentInstancesReportRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of StorageTaskAssignmentInstancesReportRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public StorageTaskAssignmentInstancesReportRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/storageTaskAssignments/", false);
            uri.AppendPath(storageTaskAssignmentName, true);
            uri.AppendPath("/reports", false);
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize, string filter)
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
            uri.AppendPath("/providers/Microsoft.Storage/storageAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/storageTaskAssignments/", false);
            uri.AppendPath(storageTaskAssignmentName, true);
            uri.AppendPath("/reports", false);
            if (maxpagesize != null)
            {
                uri.AppendQuery("$maxpagesize", maxpagesize.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Fetch the report summary of a single storage task assignment's instances. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment instances to be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, it can be used to query using reporting properties. See [Constructing Filter Strings](https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#constructing-filter-strings) for details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StorageTaskReportSummary>> ListAsync(string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, storageTaskAssignmentName, maxpagesize, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageTaskReportSummary value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StorageTaskReportSummary.DeserializeStorageTaskReportSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Fetch the report summary of a single storage task assignment's instances. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment instances to be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, it can be used to query using reporting properties. See [Constructing Filter Strings](https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#constructing-filter-strings) for details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StorageTaskReportSummary> List(string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, storageTaskAssignmentName, maxpagesize, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageTaskReportSummary value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StorageTaskReportSummary.DeserializeStorageTaskReportSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize, string filter)
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

        /// <summary> Fetch the report summary of a single storage task assignment's instances. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment instances to be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, it can be used to query using reporting properties. See [Constructing Filter Strings](https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#constructing-filter-strings) for details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<StorageTaskReportSummary>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, storageTaskAssignmentName, maxpagesize, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageTaskReportSummary value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = StorageTaskReportSummary.DeserializeStorageTaskReportSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Fetch the report summary of a single storage task assignment's instances. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="storageTaskAssignmentName"> The name of the storage task assignment within the specified resource group. Storage task assignment names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="maxpagesize"> Optional, specifies the maximum number of storage task assignment instances to be included in the list response. </param>
        /// <param name="filter"> Optional. When specified, it can be used to query using reporting properties. See [Constructing Filter Strings](https://learn.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities#constructing-filter-strings) for details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="storageTaskAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<StorageTaskReportSummary> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string storageTaskAssignmentName, int? maxpagesize = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(storageTaskAssignmentName, nameof(storageTaskAssignmentName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, storageTaskAssignmentName, maxpagesize, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        StorageTaskReportSummary value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = StorageTaskReportSummary.DeserializeStorageTaskReportSummary(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
