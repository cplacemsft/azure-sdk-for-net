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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class ConfigurationPolicyGroupsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConfigurationPolicyGroupsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConfigurationPolicyGroupsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
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

        /// <summary> Creates a ConfigurationPolicyGroup if it doesn't exist else updates the existing one. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the ConfigurationPolicyGroup. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="data"> Parameters supplied to create or update a VpnServerConfiguration PolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, <paramref name="configurationPolicyGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName, data);
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

        /// <summary> Creates a ConfigurationPolicyGroup if it doesn't exist else updates the existing one. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the ConfigurationPolicyGroup. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="data"> Parameters supplied to create or update a VpnServerConfiguration PolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/>, <paramref name="configurationPolicyGroupName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, VpnServerConfigurationPolicyGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName, data);
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

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a ConfigurationPolicyGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the ConfigurationPolicyGroup. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a ConfigurationPolicyGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the ConfigurationPolicyGroup. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups/", false);
            uri.AppendPath(configurationPolicyGroupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves the details of a ConfigurationPolicyGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VpnServerConfigurationPolicyGroupData>> GetAsync(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationPolicyGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnServerConfigurationPolicyGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves the details of a ConfigurationPolicyGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="configurationPolicyGroupName"> The name of the ConfigurationPolicyGroup being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vpnServerConfigurationName"/> or <paramref name="configurationPolicyGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VpnServerConfigurationPolicyGroupData> Get(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, string configurationPolicyGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));
            Argument.AssertNotNullOrEmpty(configurationPolicyGroupName, nameof(configurationPolicyGroupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName, configurationPolicyGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VpnServerConfigurationPolicyGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = VpnServerConfigurationPolicyGroupData.DeserializeVpnServerConfigurationPolicyGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VpnServerConfigurationPolicyGroupData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByVpnServerConfigurationRequestUri(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByVpnServerConfigurationRequest(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnServerConfigurations/", false);
            uri.AppendPath(vpnServerConfigurationName, true);
            uri.AppendPath("/configurationPolicyGroups", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnServerConfigurationPolicyGroupsResult>> ListByVpnServerConfigurationAsync(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var message = CreateListByVpnServerConfigurationRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationPolicyGroupsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationPolicyGroupsResult.DeserializeListVpnServerConfigurationPolicyGroupsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnServerConfigurationPolicyGroupsResult> ListByVpnServerConfiguration(string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var message = CreateListByVpnServerConfigurationRequest(subscriptionId, resourceGroupName, vpnServerConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationPolicyGroupsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ListVpnServerConfigurationPolicyGroupsResult.DeserializeListVpnServerConfigurationPolicyGroupsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByVpnServerConfigurationNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string vpnServerConfigurationName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByVpnServerConfigurationNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string vpnServerConfigurationName)
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

        /// <summary> Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnServerConfigurationPolicyGroupsResult>> ListByVpnServerConfigurationNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var message = CreateListByVpnServerConfigurationNextPageRequest(nextLink, subscriptionId, resourceGroupName, vpnServerConfigurationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationPolicyGroupsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = ListVpnServerConfigurationPolicyGroupsResult.DeserializeListVpnServerConfigurationPolicyGroupsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the configurationPolicyGroups in a resource group for a vpnServerConfiguration. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the VpnServerConfiguration. </param>
        /// <param name="vpnServerConfigurationName"> The name of the VpnServerConfiguration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vpnServerConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnServerConfigurationPolicyGroupsResult> ListByVpnServerConfigurationNextPage(string nextLink, string subscriptionId, string resourceGroupName, string vpnServerConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vpnServerConfigurationName, nameof(vpnServerConfigurationName));

            using var message = CreateListByVpnServerConfigurationNextPageRequest(nextLink, subscriptionId, resourceGroupName, vpnServerConfigurationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnServerConfigurationPolicyGroupsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = ListVpnServerConfigurationPolicyGroupsResult.DeserializeListVpnServerConfigurationPolicyGroupsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
