// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Metadata for search results. </summary>
    internal partial class SearchMetadata
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

        /// <summary> Initializes a new instance of <see cref="SearchMetadata"/>. </summary>
        internal SearchMetadata()
        {
            CoreSummaries = new ChangeTrackingList<OperationalInsightsSearchCoreSummary>();
            Sort = new ChangeTrackingList<SearchSort>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchMetadata"/>. </summary>
        /// <param name="searchId"> The request id of the search. </param>
        /// <param name="resultType"> The search result type. </param>
        /// <param name="total"> The total number of search results. </param>
        /// <param name="top"> The number of top search results. </param>
        /// <param name="id"> The id of the search results request. </param>
        /// <param name="coreSummaries"> The core summaries. </param>
        /// <param name="status"> The status of the search results. </param>
        /// <param name="startOn"> The start time for the search. </param>
        /// <param name="lastUpdated"> The time of last update. </param>
        /// <param name="etag"> The ETag of the search results. </param>
        /// <param name="sort"> How the results are sorted. </param>
        /// <param name="requestTime"> The request time. </param>
        /// <param name="aggregatedValueField"> The aggregated value field. </param>
        /// <param name="aggregatedGroupingFields"> The aggregated grouping fields. </param>
        /// <param name="sum"> The sum of all aggregates returned in the result set. </param>
        /// <param name="max"> The max of all aggregates returned in the result set. </param>
        /// <param name="schema"> The schema. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchMetadata(string searchId, string resultType, long? total, long? top, string id, IReadOnlyList<OperationalInsightsSearchCoreSummary> coreSummaries, string status, DateTimeOffset? startOn, DateTimeOffset? lastUpdated, ETag? etag, IReadOnlyList<SearchSort> sort, long? requestTime, string aggregatedValueField, string aggregatedGroupingFields, long? sum, long? max, SearchMetadataSchema schema, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SearchId = searchId;
            ResultType = resultType;
            Total = total;
            Top = top;
            Id = id;
            CoreSummaries = coreSummaries;
            Status = status;
            StartOn = startOn;
            LastUpdated = lastUpdated;
            ETag = etag;
            Sort = sort;
            RequestTime = requestTime;
            AggregatedValueField = aggregatedValueField;
            AggregatedGroupingFields = aggregatedGroupingFields;
            Sum = sum;
            Max = max;
            Schema = schema;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The request id of the search. </summary>
        [WirePath("requestId")]
        public string SearchId { get; }
        /// <summary> The search result type. </summary>
        [WirePath("resultType")]
        public string ResultType { get; }
        /// <summary> The total number of search results. </summary>
        [WirePath("total")]
        public long? Total { get; }
        /// <summary> The number of top search results. </summary>
        [WirePath("top")]
        public long? Top { get; }
        /// <summary> The id of the search results request. </summary>
        [WirePath("id")]
        public string Id { get; }
        /// <summary> The core summaries. </summary>
        [WirePath("coreSummaries")]
        public IReadOnlyList<OperationalInsightsSearchCoreSummary> CoreSummaries { get; }
        /// <summary> The status of the search results. </summary>
        [WirePath("status")]
        public string Status { get; }
        /// <summary> The start time for the search. </summary>
        [WirePath("startTime")]
        public DateTimeOffset? StartOn { get; }
        /// <summary> The time of last update. </summary>
        [WirePath("lastUpdated")]
        public DateTimeOffset? LastUpdated { get; }
        /// <summary> The ETag of the search results. </summary>
        [WirePath("eTag")]
        public ETag? ETag { get; }
        /// <summary> How the results are sorted. </summary>
        [WirePath("sort")]
        public IReadOnlyList<SearchSort> Sort { get; }
        /// <summary> The request time. </summary>
        [WirePath("requestTime")]
        public long? RequestTime { get; }
        /// <summary> The aggregated value field. </summary>
        [WirePath("aggregatedValueField")]
        public string AggregatedValueField { get; }
        /// <summary> The aggregated grouping fields. </summary>
        [WirePath("aggregatedGroupingFields")]
        public string AggregatedGroupingFields { get; }
        /// <summary> The sum of all aggregates returned in the result set. </summary>
        [WirePath("sum")]
        public long? Sum { get; }
        /// <summary> The max of all aggregates returned in the result set. </summary>
        [WirePath("max")]
        public long? Max { get; }
        /// <summary> The schema. </summary>
        [WirePath("schema")]
        public SearchMetadataSchema Schema { get; }
    }
}
