// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents an exported document of a custom multi-label classification project. </summary>
    public partial class ExportedCustomMultiLabelClassificationDocument
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

        /// <summary> Initializes a new instance of <see cref="ExportedCustomMultiLabelClassificationDocument"/>. </summary>
        public ExportedCustomMultiLabelClassificationDocument()
        {
            Classes = new ChangeTrackingList<ExportedDocumentClass>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportedCustomMultiLabelClassificationDocument"/>. </summary>
        /// <param name="classes"> The document classes. </param>
        /// <param name="location"> The location of the document in the storage. </param>
        /// <param name="language"> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="dataset"> The dataset for this document. Allowed values are 'Train' and 'Test'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportedCustomMultiLabelClassificationDocument(IList<ExportedDocumentClass> classes, string location, string language, string dataset, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Classes = classes;
            Location = location;
            Language = language;
            Dataset = dataset;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The document classes. </summary>
        public IList<ExportedDocumentClass> Classes { get; }
        /// <summary> The location of the document in the storage. </summary>
        public string Location { get; set; }
        /// <summary> Represents the document language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </summary>
        public string Language { get; set; }
        /// <summary> The dataset for this document. Allowed values are 'Train' and 'Test'. </summary>
        public string Dataset { get; set; }
    }
}
