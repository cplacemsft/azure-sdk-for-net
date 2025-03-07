// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> Settings concerning key vault encryption for a configuration store. </summary>
    public partial class AppConfigurationKeyVaultProperties
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

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyVaultProperties"/>. </summary>
        public AppConfigurationKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationKeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier"> The URI of the key vault key used to encrypt data. </param>
        /// <param name="identityClientId"> The client id of the identity which will be used to access key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationKeyVaultProperties(string keyIdentifier, string identityClientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyIdentifier = keyIdentifier;
            IdentityClientId = identityClientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The URI of the key vault key used to encrypt data. </summary>
        [WirePath("keyIdentifier")]
        public string KeyIdentifier { get; set; }
        /// <summary> The client id of the identity which will be used to access key vault. </summary>
        [WirePath("identityClientId")]
        public string IdentityClientId { get; set; }
    }
}
