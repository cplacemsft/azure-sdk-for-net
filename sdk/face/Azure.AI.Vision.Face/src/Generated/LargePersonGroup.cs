// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The container of the uploaded person data, including face recognition feature, and up to 1,000,000 people. </summary>
    public partial class LargePersonGroup
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

        /// <summary> Initializes a new instance of <see cref="LargePersonGroup"/>. </summary>
        /// <param name="name"> User defined name, maximum length is 128. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal LargePersonGroup(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="LargePersonGroup"/>. </summary>
        /// <param name="name"> User defined name, maximum length is 128. </param>
        /// <param name="userData"> Optional user defined data. Length should not exceed 16K. </param>
        /// <param name="recognitionModel"> Name of recognition model. Recognition model is used when the face features are extracted and associated with detected faceIds. </param>
        /// <param name="largePersonGroupId"> ID of the container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LargePersonGroup(string name, string userData, FaceRecognitionModel? recognitionModel, string largePersonGroupId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            UserData = userData;
            RecognitionModel = recognitionModel;
            LargePersonGroupId = largePersonGroupId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LargePersonGroup"/> for deserialization. </summary>
        internal LargePersonGroup()
        {
        }

        /// <summary> User defined name, maximum length is 128. </summary>
        public string Name { get; }
        /// <summary> Optional user defined data. Length should not exceed 16K. </summary>
        public string UserData { get; }
        /// <summary> Name of recognition model. Recognition model is used when the face features are extracted and associated with detected faceIds. </summary>
        public FaceRecognitionModel? RecognitionModel { get; }
        /// <summary> ID of the container. </summary>
        public string LargePersonGroupId { get; }
    }
}
