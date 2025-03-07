// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The blob service properties for blob restore policy. </summary>
    public partial class RestorePolicy
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

        /// <summary> Initializes a new instance of <see cref="RestorePolicy"/>. </summary>
        /// <param name="isEnabled"> Blob restore is enabled if set to true. </param>
        public RestorePolicy(bool isEnabled)
        {
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="RestorePolicy"/>. </summary>
        /// <param name="isEnabled"> Blob restore is enabled if set to true. </param>
        /// <param name="days"> how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days. </param>
        /// <param name="lastEnabledOn"> Deprecated in favor of minRestoreTime property. </param>
        /// <param name="minRestoreOn"> Returns the minimum date and time that the restore can be started. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorePolicy(bool isEnabled, int? days, DateTimeOffset? lastEnabledOn, DateTimeOffset? minRestoreOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Days = days;
            LastEnabledOn = lastEnabledOn;
            MinRestoreOn = minRestoreOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RestorePolicy"/> for deserialization. </summary>
        internal RestorePolicy()
        {
        }

        /// <summary> Blob restore is enabled if set to true. </summary>
        [WirePath("enabled")]
        public bool IsEnabled { get; set; }
        /// <summary> how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days. </summary>
        [WirePath("days")]
        public int? Days { get; set; }
        /// <summary> Deprecated in favor of minRestoreTime property. </summary>
        [WirePath("lastEnabledTime")]
        public DateTimeOffset? LastEnabledOn { get; }
        /// <summary> Returns the minimum date and time that the restore can be started. </summary>
        [WirePath("minRestoreTime")]
        public DateTimeOffset? MinRestoreOn { get; }
    }
}
