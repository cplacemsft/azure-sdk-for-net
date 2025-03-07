// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The WafMetricsResponseSeriesItem. </summary>
    public partial class WafMetricsResponseSeriesItem
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

        /// <summary> Initializes a new instance of <see cref="WafMetricsResponseSeriesItem"/>. </summary>
        internal WafMetricsResponseSeriesItem()
        {
            Groups = new ChangeTrackingList<WafMetricsResponseSeriesPropertiesItemsItem>();
            Data = new ChangeTrackingList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
        }

        /// <summary> Initializes a new instance of <see cref="WafMetricsResponseSeriesItem"/>. </summary>
        /// <param name="metric"></param>
        /// <param name="unit"></param>
        /// <param name="groups"></param>
        /// <param name="data"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WafMetricsResponseSeriesItem(string metric, WafMetricsResponseSeriesItemUnit? unit, IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem> groups, IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> data, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metric = metric;
            Unit = unit;
            Groups = groups;
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the metric. </summary>
        public string Metric { get; }
        /// <summary> Gets the unit. </summary>
        public WafMetricsResponseSeriesItemUnit? Unit { get; }
        /// <summary> Gets the groups. </summary>
        public IReadOnlyList<WafMetricsResponseSeriesPropertiesItemsItem> Groups { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Components18OrqelSchemasWafmetricsresponsePropertiesSeriesItemsPropertiesDataItems> Data { get; }
    }
}
