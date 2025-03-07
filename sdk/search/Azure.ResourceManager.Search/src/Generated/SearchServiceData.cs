// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    /// <summary>
    /// A class representing the SearchService data model.
    /// Describes an Azure AI Search service and its current state.
    /// </summary>
    public partial class SearchServiceData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SearchServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SearchServiceData(AzureLocation location) : base(location)
        {
            DisabledDataExfiltrationOptions = new ChangeTrackingList<SearchDisabledDataExfiltrationOption>();
            PrivateEndpointConnections = new ChangeTrackingList<SearchPrivateEndpointConnectionData>();
            SharedPrivateLinkResources = new ChangeTrackingList<SharedSearchServicePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="searchSku"> The SKU of the search service, which determines price tier and capacity limits. This property is required when creating a new search service. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="replicaCount"> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </param>
        /// <param name="partitionCount"> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </param>
        /// <param name="endpoint"> The endpoint of the Azure AI Search service. </param>
        /// <param name="hostingMode"> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </param>
        /// <param name="computeType"> Configure this property to support the search service using either the default compute or Azure Confidential Compute. </param>
        /// <param name="publicInternetAccess"> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </param>
        /// <param name="status"> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. 'stopped': The search service is in a subscription that's disabled. If your service is in the degraded, disabled, or error states, it means the Azure AI Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </param>
        /// <param name="statusDetails"> The details of the search service status. </param>
        /// <param name="provisioningState"> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'Succeeded' or 'Failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'Succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </param>
        /// <param name="networkRuleSet"> Network specific rules that determine how the Azure AI Search service may be reached. </param>
        /// <param name="disabledDataExfiltrationOptions"> A list of data exfiltration scenarios that are explicitly disallowed for the search service. Currently, the only supported value is 'All' to disable all possible data export scenarios with more fine grained controls planned for the future. </param>
        /// <param name="encryptionWithCmk"> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </param>
        /// <param name="isLocalAuthDisabled"> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </param>
        /// <param name="authOptions"> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </param>
        /// <param name="semanticSearch"> Sets options that control the availability of semantic search. This configuration is only possible for certain Azure AI Search SKUs in certain locations. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections to the Azure AI Search service. </param>
        /// <param name="sharedPrivateLinkResources"> The list of shared private link resources managed by the Azure AI Search service. </param>
        /// <param name="eTag"> A system generated property representing the service's etag that can be for optimistic concurrency control during updates. </param>
        /// <param name="isUpgradeAvailable"> Indicates whether or not the search service has an upgrade available. </param>
        /// <param name="serviceUpgradeOn"> The date and time the search service was last upgraded. This field will be null until the service gets upgraded for the first time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SearchSku searchSku, ManagedServiceIdentity identity, int? replicaCount, int? partitionCount, Uri endpoint, SearchServiceHostingMode? hostingMode, SearchServiceComputeType? computeType, SearchServicePublicInternetAccess? publicInternetAccess, SearchServiceStatus? status, string statusDetails, SearchServiceProvisioningState? provisioningState, SearchServiceNetworkRuleSet networkRuleSet, IList<SearchDisabledDataExfiltrationOption> disabledDataExfiltrationOptions, SearchEncryptionWithCmk encryptionWithCmk, bool? isLocalAuthDisabled, SearchAadAuthDataPlaneAuthOptions authOptions, SearchSemanticSearch? semanticSearch, IReadOnlyList<SearchPrivateEndpointConnectionData> privateEndpointConnections, IReadOnlyList<SharedSearchServicePrivateLinkResourceData> sharedPrivateLinkResources, ETag? eTag, bool? isUpgradeAvailable, DateTimeOffset? serviceUpgradeOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            SearchSku = searchSku;
            Identity = identity;
            ReplicaCount = replicaCount;
            PartitionCount = partitionCount;
            Endpoint = endpoint;
            HostingMode = hostingMode;
            ComputeType = computeType;
            PublicInternetAccess = publicInternetAccess;
            Status = status;
            StatusDetails = statusDetails;
            ProvisioningState = provisioningState;
            NetworkRuleSet = networkRuleSet;
            DisabledDataExfiltrationOptions = disabledDataExfiltrationOptions;
            EncryptionWithCmk = encryptionWithCmk;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            AuthOptions = authOptions;
            SemanticSearch = semanticSearch;
            PrivateEndpointConnections = privateEndpointConnections;
            SharedPrivateLinkResources = sharedPrivateLinkResources;
            ETag = eTag;
            IsUpgradeAvailable = isUpgradeAvailable;
            ServiceUpgradeOn = serviceUpgradeOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SearchServiceData"/> for deserialization. </summary>
        internal SearchServiceData()
        {
        }

        /// <summary> The SKU of the search service, which determines price tier and capacity limits. This property is required when creating a new search service. </summary>
        internal SearchSku SearchSku { get; set; }
        /// <summary> The SKU of the search service. Valid values include: 'free': Shared service. 'basic': Dedicated service with up to 3 replicas. 'standard': Dedicated service with up to 12 partitions and 12 replicas. 'standard2': Similar to standard, but with more capacity per search unit. 'standard3': The largest Standard offering with up to 12 partitions and 12 replicas (or up to 3 partitions with more indexes if you also set the hostingMode property to 'highDensity'). 'storage_optimized_l1': Supports 1TB per partition, up to 12 partitions. 'storage_optimized_l2': Supports 2TB per partition, up to 12 partitions.'. </summary>
        [WirePath("sku.name")]
        public SearchServiceSkuName? SearchSkuName
        {
            get => SearchSku is null ? default : SearchSku.Name;
            set
            {
                if (SearchSku is null)
                    SearchSku = new SearchSku();
                SearchSku.Name = value;
            }
        }

        /// <summary> The identity of the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The number of replicas in the search service. If specified, it must be a value between 1 and 12 inclusive for standard SKUs or between 1 and 3 inclusive for basic SKU. </summary>
        [WirePath("properties.replicaCount")]
        public int? ReplicaCount { get; set; }
        /// <summary> The number of partitions in the search service; if specified, it can be 1, 2, 3, 4, 6, or 12. Values greater than 1 are only valid for standard SKUs. For 'standard3' services with hostingMode set to 'highDensity', the allowed values are between 1 and 3. </summary>
        [WirePath("properties.partitionCount")]
        public int? PartitionCount { get; set; }
        /// <summary> The endpoint of the Azure AI Search service. </summary>
        [WirePath("properties.endpoint")]
        public Uri Endpoint { get; set; }
        /// <summary> Applicable only for the standard3 SKU. You can set this property to enable up to 3 high density partitions that allow up to 1000 indexes, which is much higher than the maximum indexes allowed for any other SKU. For the standard3 SKU, the value is either 'default' or 'highDensity'. For all other SKUs, this value must be 'default'. </summary>
        [WirePath("properties.hostingMode")]
        public SearchServiceHostingMode? HostingMode { get; set; }
        /// <summary> Configure this property to support the search service using either the default compute or Azure Confidential Compute. </summary>
        [WirePath("properties.computeType")]
        public SearchServiceComputeType? ComputeType { get; set; }
        /// <summary> This value can be set to 'enabled' to avoid breaking changes on existing customer resources and templates. If set to 'disabled', traffic over public interface is not allowed, and private endpoint connections would be the exclusive access method. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public SearchServicePublicInternetAccess? PublicInternetAccess { get; set; }
        /// <summary> The status of the search service. Possible values include: 'running': The search service is running and no provisioning operations are underway. 'provisioning': The search service is being provisioned or scaled up or down. 'deleting': The search service is being deleted. 'degraded': The search service is degraded. This can occur when the underlying search units are not healthy. The search service is most likely operational, but performance might be slow and some requests might be dropped. 'disabled': The search service is disabled. In this state, the service will reject all API requests. 'error': The search service is in an error state. 'stopped': The search service is in a subscription that's disabled. If your service is in the degraded, disabled, or error states, it means the Azure AI Search team is actively investigating the underlying issue. Dedicated services in these states are still chargeable based on the number of search units provisioned. </summary>
        [WirePath("properties.status")]
        public SearchServiceStatus? Status { get; }
        /// <summary> The details of the search service status. </summary>
        [WirePath("properties.statusDetails")]
        public string StatusDetails { get; }
        /// <summary> The state of the last provisioning operation performed on the search service. Provisioning is an intermediate state that occurs while service capacity is being established. After capacity is set up, provisioningState changes to either 'Succeeded' or 'Failed'. Client applications can poll provisioning status (the recommended polling interval is from 30 seconds to one minute) by using the Get Search Service operation to see when an operation is completed. If you are using the free service, this value tends to come back as 'Succeeded' directly in the call to Create search service. This is because the free service uses capacity that is already set up. </summary>
        [WirePath("properties.provisioningState")]
        public SearchServiceProvisioningState? ProvisioningState { get; }
        /// <summary> Network specific rules that determine how the Azure AI Search service may be reached. </summary>
        [WirePath("properties.networkRuleSet")]
        public SearchServiceNetworkRuleSet NetworkRuleSet { get; set; }
        /// <summary> A list of data exfiltration scenarios that are explicitly disallowed for the search service. Currently, the only supported value is 'All' to disable all possible data export scenarios with more fine grained controls planned for the future. </summary>
        [WirePath("properties.disabledDataExfiltrationOptions")]
        public IList<SearchDisabledDataExfiltrationOption> DisabledDataExfiltrationOptions { get; }
        /// <summary> Specifies any policy regarding encryption of resources (such as indexes) using customer manager keys within a search service. </summary>
        [WirePath("properties.encryptionWithCmk")]
        public SearchEncryptionWithCmk EncryptionWithCmk { get; set; }
        /// <summary> When set to true, calls to the search service will not be permitted to utilize API keys for authentication. This cannot be set to true if 'dataPlaneAuthOptions' are defined. </summary>
        [WirePath("properties.disableLocalAuth")]
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary> Defines the options for how the data plane API of a search service authenticates requests. This cannot be set if 'disableLocalAuth' is set to true. </summary>
        [WirePath("properties.authOptions")]
        public SearchAadAuthDataPlaneAuthOptions AuthOptions { get; set; }
        /// <summary> Sets options that control the availability of semantic search. This configuration is only possible for certain Azure AI Search SKUs in certain locations. </summary>
        [WirePath("properties.semanticSearch")]
        public SearchSemanticSearch? SemanticSearch { get; set; }
        /// <summary> The list of private endpoint connections to the Azure AI Search service. </summary>
        [WirePath("properties.privateEndpointConnections")]
        public IReadOnlyList<SearchPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The list of shared private link resources managed by the Azure AI Search service. </summary>
        [WirePath("properties.sharedPrivateLinkResources")]
        public IReadOnlyList<SharedSearchServicePrivateLinkResourceData> SharedPrivateLinkResources { get; }
        /// <summary> A system generated property representing the service's etag that can be for optimistic concurrency control during updates. </summary>
        [WirePath("properties.eTag")]
        public ETag? ETag { get; }
        /// <summary> Indicates whether or not the search service has an upgrade available. </summary>
        [WirePath("properties.upgradeAvailable")]
        public bool? IsUpgradeAvailable { get; }
        /// <summary> The date and time the search service was last upgraded. This field will be null until the service gets upgraded for the first time. </summary>
        [WirePath("properties.serviceUpgradeDate")]
        public DateTimeOffset? ServiceUpgradeOn { get; }
    }
}
