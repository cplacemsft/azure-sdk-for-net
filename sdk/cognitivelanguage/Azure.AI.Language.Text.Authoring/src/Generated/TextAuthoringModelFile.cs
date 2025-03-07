// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the properties for the model file. </summary>
    public partial class TextAuthoringModelFile
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

        /// <summary> Initializes a new instance of <see cref="TextAuthoringModelFile"/>. </summary>
        /// <param name="name"> The name of the file. </param>
        /// <param name="contentUri"> The URI to retrieve the content of the file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="contentUri"/> is null. </exception>
        internal TextAuthoringModelFile(string name, Uri contentUri)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(contentUri, nameof(contentUri));

            Name = name;
            ContentUri = contentUri;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringModelFile"/>. </summary>
        /// <param name="name"> The name of the file. </param>
        /// <param name="contentUri"> The URI to retrieve the content of the file. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAuthoringModelFile(string name, Uri contentUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ContentUri = contentUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringModelFile"/> for deserialization. </summary>
        internal TextAuthoringModelFile()
        {
        }

        /// <summary> The name of the file. </summary>
        public string Name { get; }
        /// <summary> The URI to retrieve the content of the file. </summary>
        public Uri ContentUri { get; }
    }
}
