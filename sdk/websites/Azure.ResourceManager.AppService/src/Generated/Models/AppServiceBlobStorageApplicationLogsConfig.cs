// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs azure blob storage configuration. </summary>
    public partial class AppServiceBlobStorageApplicationLogsConfig
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

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageApplicationLogsConfig"/>. </summary>
        public AppServiceBlobStorageApplicationLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceBlobStorageApplicationLogsConfig"/>. </summary>
        /// <param name="level"> Log level. </param>
        /// <param name="sasUri"> SAS url to a azure blob container with read/write/list/delete permissions. </param>
        /// <param name="retentionInDays">
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceBlobStorageApplicationLogsConfig(WebAppLogLevel? level, Uri sasUri, int? retentionInDays, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Level = level;
            SasUri = sasUri;
            RetentionInDays = retentionInDays;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Log level. </summary>
        [WirePath("level")]
        public WebAppLogLevel? Level { get; set; }
        /// <summary> SAS url to a azure blob container with read/write/list/delete permissions. </summary>
        [WirePath("sasUrl")]
        public Uri SasUri { get; set; }
        /// <summary>
        /// Retention in days.
        /// Remove blobs older than X days.
        /// 0 or lower means no retention.
        /// </summary>
        [WirePath("retentionInDays")]
        public int? RetentionInDays { get; set; }
    }
}
