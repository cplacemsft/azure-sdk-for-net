// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Auto scale properties. </summary>
    public partial class MachineLearningAutoScaleProperties
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningAutoScaleProperties"/>. </summary>
        public MachineLearningAutoScaleProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAutoScaleProperties"/>. </summary>
        /// <param name="minNodeCount"></param>
        /// <param name="isEnabled"></param>
        /// <param name="maxNodeCount"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningAutoScaleProperties(int? minNodeCount, bool? isEnabled, int? maxNodeCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MinNodeCount = minNodeCount;
            IsEnabled = isEnabled;
            MaxNodeCount = maxNodeCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the min node count. </summary>
        [WirePath("minNodeCount")]
        public int? MinNodeCount { get; set; }
        /// <summary> Gets or sets the is enabled. </summary>
        [WirePath("enabled")]
        public bool? IsEnabled { get; set; }
        /// <summary> Gets or sets the max node count. </summary>
        [WirePath("maxNodeCount")]
        public int? MaxNodeCount { get; set; }
    }
}
