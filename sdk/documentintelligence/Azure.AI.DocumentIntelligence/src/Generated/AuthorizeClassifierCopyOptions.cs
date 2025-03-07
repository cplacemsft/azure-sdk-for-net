// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Request body to authorize document classifier copy. </summary>
    public partial class AuthorizeClassifierCopyOptions
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

        /// <summary> Initializes a new instance of <see cref="AuthorizeClassifierCopyOptions"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> is null. </exception>
        public AuthorizeClassifierCopyOptions(string classifierId)
        {
            Argument.AssertNotNull(classifierId, nameof(classifierId));

            ClassifierId = classifierId;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizeClassifierCopyOptions"/>. </summary>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="description"> Document classifier description. </param>
        /// <param name="tags"> List of key-value tag attributes associated with the document classifier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizeClassifierCopyOptions(string classifierId, string description, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ClassifierId = classifierId;
            Description = description;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizeClassifierCopyOptions"/> for deserialization. </summary>
        internal AuthorizeClassifierCopyOptions()
        {
        }

        /// <summary> Unique document classifier name. </summary>
        public string ClassifierId { get; }
        /// <summary> Document classifier description. </summary>
        public string Description { get; set; }
        /// <summary> List of key-value tag attributes associated with the document classifier. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
