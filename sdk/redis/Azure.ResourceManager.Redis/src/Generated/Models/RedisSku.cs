// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> SKU parameters supplied to the create Redis operation. </summary>
    public partial class RedisSku
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

        /// <summary> Initializes a new instance of <see cref="RedisSku"/>. </summary>
        /// <param name="name"> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </param>
        /// <param name="family"> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </param>
        /// <param name="capacity"> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </param>
        public RedisSku(RedisSkuName name, RedisSkuFamily family, int capacity)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
        }

        /// <summary> Initializes a new instance of <see cref="RedisSku"/>. </summary>
        /// <param name="name"> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </param>
        /// <param name="family"> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </param>
        /// <param name="capacity"> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisSku(RedisSkuName name, RedisSkuFamily family, int capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisSku"/> for deserialization. </summary>
        internal RedisSku()
        {
        }

        /// <summary> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </summary>
        [WirePath("name")]
        public RedisSkuName Name { get; set; }
        /// <summary> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </summary>
        [WirePath("family")]
        public RedisSkuFamily Family { get; set; }
        /// <summary> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </summary>
        [WirePath("capacity")]
        public int Capacity { get; set; }
    }
}
