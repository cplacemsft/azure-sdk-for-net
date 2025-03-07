// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Properties of an environment. </summary>
    public partial class DevCenterEnvironment
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

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironment"/>. </summary>
        /// <param name="parameters"> Parameters object for the environment. </param>
        /// <param name="name"> Environment name. </param>
        /// <param name="environmentTypeName"> Environment type. </param>
        /// <param name="userId"> The AAD object id of the owner of this Environment. </param>
        /// <param name="provisioningState"> The provisioning state of the environment. </param>
        /// <param name="resourceGroupId"> The identifier of the resource group containing the environment's resources. </param>
        /// <param name="catalogName"> Name of the catalog. </param>
        /// <param name="environmentDefinitionName"> Name of the environment definition. </param>
        /// <param name="error"> Provisioning error details. Populated only for error states. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevCenterEnvironment(IDictionary<string, BinaryData> parameters, string name, string environmentTypeName, Guid? userId, EnvironmentProvisioningState? provisioningState, ResourceIdentifier resourceGroupId, string catalogName, string environmentDefinitionName, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Parameters = parameters;
            Name = name;
            EnvironmentTypeName = environmentTypeName;
            UserId = userId;
            ProvisioningState = provisioningState;
            ResourceGroupId = resourceGroupId;
            CatalogName = catalogName;
            EnvironmentDefinitionName = environmentDefinitionName;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironment"/> for deserialization. </summary>
        internal DevCenterEnvironment()
        {
        }

        /// <summary>
        /// Parameters object for the environment.
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
        public IDictionary<string, BinaryData> Parameters { get; }
        /// <summary> Environment name. </summary>
        public string Name { get; }
        /// <summary> Environment type. </summary>
        public string EnvironmentTypeName { get; set; }
        /// <summary> The AAD object id of the owner of this Environment. </summary>
        public Guid? UserId { get; }
        /// <summary> The provisioning state of the environment. </summary>
        public EnvironmentProvisioningState? ProvisioningState { get; }
        /// <summary> Name of the catalog. </summary>
        public string CatalogName { get; set; }
        /// <summary> Name of the environment definition. </summary>
        public string EnvironmentDefinitionName { get; set; }
        /// <summary> Provisioning error details. Populated only for error states. </summary>
        public ResponseError Error { get; }
    }
}
