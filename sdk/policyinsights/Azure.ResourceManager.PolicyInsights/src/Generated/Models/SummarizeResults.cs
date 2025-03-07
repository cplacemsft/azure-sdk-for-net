// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Summarize action results. </summary>
    internal partial class SummarizeResults
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

        /// <summary> Initializes a new instance of <see cref="SummarizeResults"/>. </summary>
        internal SummarizeResults()
        {
            Value = new ChangeTrackingList<PolicySummary>();
        }

        /// <summary> Initializes a new instance of <see cref="SummarizeResults"/>. </summary>
        /// <param name="odataContext"> OData context string; used by OData clients to resolve type information based on metadata. </param>
        /// <param name="odataCount"> OData entity count; represents the number of summaries returned; always set to 1. </param>
        /// <param name="value"> Summarize action results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SummarizeResults(string odataContext, int? odataCount, IReadOnlyList<PolicySummary> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ODataContext = odataContext;
            ODataCount = odataCount;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> OData context string; used by OData clients to resolve type information based on metadata. </summary>
        public string ODataContext { get; }
        /// <summary> OData entity count; represents the number of summaries returned; always set to 1. </summary>
        public int? ODataCount { get; }
        /// <summary> Summarize action results. </summary>
        public IReadOnlyList<PolicySummary> Value { get; }
    }
}
