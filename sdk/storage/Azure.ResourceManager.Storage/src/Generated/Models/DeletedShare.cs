// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The deleted share to be restored. </summary>
    public partial class DeletedShare
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

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/>. </summary>
        /// <param name="deletedShareName"> Required. Identify the name of the deleted share that will be restored. </param>
        /// <param name="deletedShareVersion"> Required. Identify the version of the deleted share that will be restored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShareName"/> or <paramref name="deletedShareVersion"/> is null. </exception>
        public DeletedShare(string deletedShareName, string deletedShareVersion)
        {
            Argument.AssertNotNull(deletedShareName, nameof(deletedShareName));
            Argument.AssertNotNull(deletedShareVersion, nameof(deletedShareVersion));

            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/>. </summary>
        /// <param name="deletedShareName"> Required. Identify the name of the deleted share that will be restored. </param>
        /// <param name="deletedShareVersion"> Required. Identify the version of the deleted share that will be restored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedShare(string deletedShareName, string deletedShareVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeletedShare"/> for deserialization. </summary>
        internal DeletedShare()
        {
        }

        /// <summary> Required. Identify the name of the deleted share that will be restored. </summary>
        [WirePath("deletedShareName")]
        public string DeletedShareName { get; }
        /// <summary> Required. Identify the version of the deleted share that will be restored. </summary>
        [WirePath("deletedShareVersion")]
        public string DeletedShareVersion { get; }
    }
}
