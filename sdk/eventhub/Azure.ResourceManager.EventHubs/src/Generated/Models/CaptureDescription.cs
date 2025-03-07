// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure capture description for eventhub. </summary>
    public partial class CaptureDescription
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

        /// <summary> Initializes a new instance of <see cref="CaptureDescription"/>. </summary>
        public CaptureDescription()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CaptureDescription"/>. </summary>
        /// <param name="enabled"> A value that indicates whether capture description is enabled. </param>
        /// <param name="encoding"> Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version. </param>
        /// <param name="intervalInSeconds"> The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds. </param>
        /// <param name="sizeLimitInBytes"> The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes. </param>
        /// <param name="destination"> Properties of Destination where capture will be stored. (Storage Account, Blob Names). </param>
        /// <param name="skipEmptyArchives"> A value that indicates whether to Skip Empty Archives. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CaptureDescription(bool? enabled, EncodingCaptureDescription? encoding, int? intervalInSeconds, int? sizeLimitInBytes, EventHubDestination destination, bool? skipEmptyArchives, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            Encoding = encoding;
            IntervalInSeconds = intervalInSeconds;
            SizeLimitInBytes = sizeLimitInBytes;
            Destination = destination;
            SkipEmptyArchives = skipEmptyArchives;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A value that indicates whether capture description is enabled. </summary>
        [WirePath("enabled")]
        public bool? Enabled { get; set; }
        /// <summary> Enumerates the possible values for the encoding format of capture description. Note: 'AvroDeflate' will be deprecated in New API Version. </summary>
        [WirePath("encoding")]
        public EncodingCaptureDescription? Encoding { get; set; }
        /// <summary> The time window allows you to set the frequency with which the capture to Azure Blobs will happen, value should between 60 to 900 seconds. </summary>
        [WirePath("intervalInSeconds")]
        public int? IntervalInSeconds { get; set; }
        /// <summary> The size window defines the amount of data built up in your Event Hub before an capture operation, value should be between 10485760 to 524288000 bytes. </summary>
        [WirePath("sizeLimitInBytes")]
        public int? SizeLimitInBytes { get; set; }
        /// <summary> Properties of Destination where capture will be stored. (Storage Account, Blob Names). </summary>
        [WirePath("destination")]
        public EventHubDestination Destination { get; set; }
        /// <summary> A value that indicates whether to Skip Empty Archives. </summary>
        [WirePath("skipEmptyArchives")]
        public bool? SkipEmptyArchives { get; set; }
    }
}
