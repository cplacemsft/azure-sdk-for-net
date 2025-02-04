// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Patch schedule entry for a Premium Redis Cache. </summary>
    public partial class RedisPatchScheduleSetting
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

        /// <summary> Initializes a new instance of <see cref="RedisPatchScheduleSetting"/>. </summary>
        /// <param name="dayOfWeek"> Day of the week when a cache can be patched. </param>
        /// <param name="startHourUtc"> Start hour after which cache patching can start. </param>
        public RedisPatchScheduleSetting(RedisDayOfWeek dayOfWeek, int startHourUtc)
        {
            DayOfWeek = dayOfWeek;
            StartHourUtc = startHourUtc;
        }

        /// <summary> Initializes a new instance of <see cref="RedisPatchScheduleSetting"/>. </summary>
        /// <param name="dayOfWeek"> Day of the week when a cache can be patched. </param>
        /// <param name="startHourUtc"> Start hour after which cache patching can start. </param>
        /// <param name="maintenanceWindow"> ISO8601 timespan specifying how much time cache patching can take. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisPatchScheduleSetting(RedisDayOfWeek dayOfWeek, int startHourUtc, TimeSpan? maintenanceWindow, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DayOfWeek = dayOfWeek;
            StartHourUtc = startHourUtc;
            MaintenanceWindow = maintenanceWindow;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisPatchScheduleSetting"/> for deserialization. </summary>
        internal RedisPatchScheduleSetting()
        {
        }

        /// <summary> Day of the week when a cache can be patched. </summary>
        public RedisDayOfWeek DayOfWeek { get; set; }
        /// <summary> Start hour after which cache patching can start. </summary>
        public int StartHourUtc { get; set; }
        /// <summary> ISO8601 timespan specifying how much time cache patching can take. </summary>
        public TimeSpan? MaintenanceWindow { get; set; }
    }
}
