// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The event response message received from the service URI. </summary>
    public partial class ContainerRegistryWebhookEventResponseMessage
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

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventResponseMessage"/>. </summary>
        internal ContainerRegistryWebhookEventResponseMessage()
        {
            Headers = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWebhookEventResponseMessage"/>. </summary>
        /// <param name="content"> The content of the event response message. </param>
        /// <param name="headers"> The headers of the event response message. </param>
        /// <param name="reasonPhrase"> The reason phrase of the event response message. </param>
        /// <param name="statusCode"> The status code of the event response message. </param>
        /// <param name="version"> The HTTP message version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWebhookEventResponseMessage(string content, IReadOnlyDictionary<string, string> headers, string reasonPhrase, string statusCode, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Headers = headers;
            ReasonPhrase = reasonPhrase;
            StatusCode = statusCode;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The content of the event response message. </summary>
        [WirePath("content")]
        public string Content { get; }
        /// <summary> The headers of the event response message. </summary>
        [WirePath("headers")]
        public IReadOnlyDictionary<string, string> Headers { get; }
        /// <summary> The reason phrase of the event response message. </summary>
        [WirePath("reasonPhrase")]
        public string ReasonPhrase { get; }
        /// <summary> The status code of the event response message. </summary>
        [WirePath("statusCode")]
        public string StatusCode { get; }
        /// <summary> The HTTP message version. </summary>
        [WirePath("version")]
        public string Version { get; }
    }
}
