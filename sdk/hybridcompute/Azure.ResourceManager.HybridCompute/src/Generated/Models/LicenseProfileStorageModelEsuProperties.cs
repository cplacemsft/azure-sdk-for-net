// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> License profile storage model for ESU properties. </summary>
    public partial class LicenseProfileStorageModelEsuProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LicenseProfileStorageModelEsuProperties"/>. </summary>
        public LicenseProfileStorageModelEsuProperties()
        {
            EsuKeys = new ChangeTrackingList<EsuKey>();
        }

        /// <summary> Initializes a new instance of <see cref="LicenseProfileStorageModelEsuProperties"/>. </summary>
        /// <param name="assignedLicenseImmutableId"> The guid id of the license. </param>
        /// <param name="esuKeys"> The list of ESU keys. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LicenseProfileStorageModelEsuProperties(Guid? assignedLicenseImmutableId, IReadOnlyList<EsuKey> esuKeys, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssignedLicenseImmutableId = assignedLicenseImmutableId;
            EsuKeys = esuKeys;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The guid id of the license. </summary>
        [WirePath("assignedLicenseImmutableId")]
        public Guid? AssignedLicenseImmutableId { get; }
        /// <summary> The list of ESU keys. </summary>
        [WirePath("esuKeys")]
        public IReadOnlyList<EsuKey> EsuKeys { get; }
    }
}
