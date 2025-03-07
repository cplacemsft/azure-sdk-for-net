// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents an Azure resource assigned to a deployment. </summary>
    public partial class ConversationAuthoringDeploymentResource
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

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringDeploymentResource"/>. </summary>
        /// <param name="resourceId"> Represents the Azure resource Id. </param>
        /// <param name="region"> Represents the resource region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="region"/> is null. </exception>
        internal ConversationAuthoringDeploymentResource(string resourceId, string region)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNull(region, nameof(region));

            ResourceId = resourceId;
            Region = region;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringDeploymentResource"/>. </summary>
        /// <param name="resourceId"> Represents the Azure resource Id. </param>
        /// <param name="region"> Represents the resource region. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringDeploymentResource(string resourceId, string region, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            Region = region;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringDeploymentResource"/> for deserialization. </summary>
        internal ConversationAuthoringDeploymentResource()
        {
        }

        /// <summary> Represents the Azure resource Id. </summary>
        public string ResourceId { get; }
        /// <summary> Represents the resource region. </summary>
        public string Region { get; }
    }
}
