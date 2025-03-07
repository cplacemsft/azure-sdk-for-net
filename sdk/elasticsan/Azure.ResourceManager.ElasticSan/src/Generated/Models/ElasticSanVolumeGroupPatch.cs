// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Volume Group request. </summary>
    public partial class ElasticSanVolumeGroupPatch
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

        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumeGroupPatch"/>. </summary>
        public ElasticSanVolumeGroupPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanVolumeGroupPatch"/>. </summary>
        /// <param name="identity"> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="protocolType"> Type of storage target. </param>
        /// <param name="encryption"> Type of encryption. </param>
        /// <param name="encryptionProperties"> Encryption Properties describing Key Vault and Identity information. </param>
        /// <param name="networkAcls"> A collection of rules governing the accessibility from specific network locations. </param>
        /// <param name="enforceDataIntegrityCheckForIscsi"> A boolean indicating whether or not Data Integrity Check is enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanVolumeGroupPatch(ManagedServiceIdentity identity, ElasticSanStorageTargetType? protocolType, ElasticSanEncryptionType? encryption, ElasticSanEncryptionProperties encryptionProperties, NetworkRuleSet networkAcls, bool? enforceDataIntegrityCheckForIscsi, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            ProtocolType = protocolType;
            Encryption = encryption;
            EncryptionProperties = encryptionProperties;
            NetworkAcls = networkAcls;
            EnforceDataIntegrityCheckForIscsi = enforceDataIntegrityCheckForIscsi;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Type of storage target. </summary>
        public ElasticSanStorageTargetType? ProtocolType { get; set; }
        /// <summary> Type of encryption. </summary>
        public ElasticSanEncryptionType? Encryption { get; set; }
        /// <summary> Encryption Properties describing Key Vault and Identity information. </summary>
        public ElasticSanEncryptionProperties EncryptionProperties { get; set; }
        /// <summary> A collection of rules governing the accessibility from specific network locations. </summary>
        internal NetworkRuleSet NetworkAcls { get; set; }
        /// <summary> The list of virtual network rules. </summary>
        public IList<ElasticSanVirtualNetworkRule> VirtualNetworkRules
        {
            get
            {
                if (NetworkAcls is null)
                    NetworkAcls = new NetworkRuleSet();
                return NetworkAcls.VirtualNetworkRules;
            }
        }

        /// <summary> A boolean indicating whether or not Data Integrity Check is enabled. </summary>
        public bool? EnforceDataIntegrityCheckForIscsi { get; set; }
    }
}
