// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Inference
{
    /// <summary> The details of the input audio data. </summary>
    public partial class ChatMessageInputAudio
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

        /// <summary> Initializes a new instance of <see cref="ChatMessageInputAudio"/>. </summary>
        /// <param name="data"> Base64 encoded audio data. </param>
        /// <param name="format"> The audio format of the audio content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public ChatMessageInputAudio(string data, AudioContentFormat format)
        {
            Argument.AssertNotNull(data, nameof(data));

            Data = data;
            Format = format;
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessageInputAudio"/>. </summary>
        /// <param name="data"> Base64 encoded audio data. </param>
        /// <param name="format"> The audio format of the audio content. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatMessageInputAudio(string data, AudioContentFormat format, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Data = data;
            Format = format;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessageInputAudio"/> for deserialization. </summary>
        internal ChatMessageInputAudio()
        {
        }

        /// <summary> Base64 encoded audio data. </summary>
        public string Data { get; }
        /// <summary> The audio format of the audio content. </summary>
        public AudioContentFormat Format { get; }
    }
}
