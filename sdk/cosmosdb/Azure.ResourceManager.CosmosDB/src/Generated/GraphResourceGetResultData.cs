// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the GraphResourceGetResult data model.
    /// An Azure Cosmos DB Graph resource.
    /// </summary>
    public partial class GraphResourceGetResultData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultData"/>. </summary>
        /// <param name="location"> The location. </param>
        public GraphResourceGetResultData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> Gets or sets the resource. </param>
        /// <param name="options"></param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GraphResourceGetResultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WritableSubResource resource, GraphResourceGetPropertiesOptions options, ManagedServiceIdentity identity, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultData"/> for deserialization. </summary>
        internal GraphResourceGetResultData()
        {
        }

        /// <summary> Gets or sets the resource. </summary>
        internal WritableSubResource Resource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        [WirePath("properties.resource.id")]
        public ResourceIdentifier ResourceId
        {
            get => Resource is null ? default : Resource.Id;
            set
            {
                if (Resource is null)
                    Resource = new WritableSubResource();
                Resource.Id = value;
            }
        }

        /// <summary> Gets or sets the options. </summary>
        [WirePath("properties.options")]
        public GraphResourceGetPropertiesOptions Options { get; set; }
        /// <summary> Identity for the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
    }
}
