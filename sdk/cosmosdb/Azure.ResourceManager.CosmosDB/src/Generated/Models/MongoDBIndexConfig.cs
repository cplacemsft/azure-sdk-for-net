// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB MongoDB collection index options. </summary>
    public partial class MongoDBIndexConfig
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

        /// <summary> Initializes a new instance of <see cref="MongoDBIndexConfig"/>. </summary>
        public MongoDBIndexConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBIndexConfig"/>. </summary>
        /// <param name="expireAfterSeconds"> Expire after seconds. </param>
        /// <param name="isUnique"> Is unique or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBIndexConfig(int? expireAfterSeconds, bool? isUnique, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExpireAfterSeconds = expireAfterSeconds;
            IsUnique = isUnique;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Expire after seconds. </summary>
        [WirePath("expireAfterSeconds")]
        public int? ExpireAfterSeconds { get; set; }
        /// <summary> Is unique or not. </summary>
        [WirePath("unique")]
        public bool? IsUnique { get; set; }
    }
}
