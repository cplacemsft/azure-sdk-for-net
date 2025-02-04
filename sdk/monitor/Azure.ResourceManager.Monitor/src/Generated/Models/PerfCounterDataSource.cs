// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which performance counters will be collected and how they will be collected by this data collection rule.
    /// Collected from both Windows and Linux machines where the counter is present.
    /// </summary>
    public partial class PerfCounterDataSource
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

        /// <summary> Initializes a new instance of <see cref="PerfCounterDataSource"/>. </summary>
        public PerfCounterDataSource()
        {
            Streams = new ChangeTrackingList<PerfCounterDataSourceStream>();
            CounterSpecifiers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PerfCounterDataSource"/>. </summary>
        /// <param name="streams">
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </param>
        /// <param name="samplingFrequencyInSeconds"> The number of seconds between consecutive counter measurements (samples). </param>
        /// <param name="counterSpecifiers">
        /// A list of specifier names of the performance counters you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command 'typeperf'.
        /// </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PerfCounterDataSource(IList<PerfCounterDataSourceStream> streams, int? samplingFrequencyInSeconds, IList<string> counterSpecifiers, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            SamplingFrequencyInSeconds = samplingFrequencyInSeconds;
            CounterSpecifiers = counterSpecifiers;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IList<PerfCounterDataSourceStream> Streams { get; }
        /// <summary> The number of seconds between consecutive counter measurements (samples). </summary>
        public int? SamplingFrequencyInSeconds { get; set; }
        /// <summary>
        /// A list of specifier names of the performance counters you want to collect.
        /// Use a wildcard (*) to collect a counter for all instances.
        /// To get a list of performance counters on Windows, run the command 'typeperf'.
        /// </summary>
        public IList<string> CounterSpecifiers { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
