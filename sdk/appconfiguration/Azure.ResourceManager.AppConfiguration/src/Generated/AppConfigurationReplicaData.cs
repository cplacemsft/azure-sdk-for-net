// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing the AppConfigurationReplica data model.
    /// The replica resource.
    /// </summary>
    public partial class AppConfigurationReplicaData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AppConfigurationReplicaData"/>. </summary>
        public AppConfigurationReplicaData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationReplicaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the replica. </param>
        /// <param name="endpoint"> The URI of the replica where the replica API will be available. </param>
        /// <param name="provisioningState"> The provisioning state of the replica. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationReplicaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string endpoint, AppConfigurationReplicaProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Endpoint = endpoint;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the replica. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> The URI of the replica where the replica API will be available. </summary>
        [WirePath("properties.endpoint")]
        public string Endpoint { get; }
        /// <summary> The provisioning state of the replica. </summary>
        [WirePath("properties.provisioningState")]
        public AppConfigurationReplicaProvisioningState? ProvisioningState { get; }
    }
}
