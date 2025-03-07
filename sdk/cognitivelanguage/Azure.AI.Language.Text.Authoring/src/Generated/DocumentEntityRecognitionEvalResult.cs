// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the entity recognition evaluation result for a document. </summary>
    public partial class DocumentEntityRecognitionEvalResult
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

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRecognitionEvalResult"/>. </summary>
        /// <param name="entities"> Represents the document labelled entities. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entities"/> is null. </exception>
        internal DocumentEntityRecognitionEvalResult(IEnumerable<DocumentEntityRegionEvalResult> entities)
        {
            Argument.AssertNotNull(entities, nameof(entities));

            Entities = entities.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRecognitionEvalResult"/>. </summary>
        /// <param name="entities"> Represents the document labelled entities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentEntityRecognitionEvalResult(IReadOnlyList<DocumentEntityRegionEvalResult> entities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Entities = entities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentEntityRecognitionEvalResult"/> for deserialization. </summary>
        internal DocumentEntityRecognitionEvalResult()
        {
        }

        /// <summary> Represents the document labelled entities. </summary>
        public IReadOnlyList<DocumentEntityRegionEvalResult> Entities { get; }
    }
}
