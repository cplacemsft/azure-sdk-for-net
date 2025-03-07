// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the MongoDBCollection data model.
    /// An Azure Cosmos DB MongoDB collection.
    /// </summary>
    public partial class MongoDBCollectionData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MongoDBCollectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"></param>
        /// <param name="options"></param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBCollectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedMongoDBCollectionResourceInfo resource, MongoDBCollectionPropertiesConfig options, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBCollectionData"/> for deserialization. </summary>
        internal MongoDBCollectionData()
        {
        }

        /// <summary> Gets or sets the resource. </summary>
        [WirePath("properties.resource")]
        public ExtendedMongoDBCollectionResourceInfo Resource { get; set; }
        /// <summary> Gets or sets the options. </summary>
        [WirePath("properties.options")]
        public MongoDBCollectionPropertiesConfig Options { get; set; }
        /// <summary> Identity for the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
    }
}
