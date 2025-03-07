// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list pipeline runs. </summary>
    internal partial class DataFactoryPipelineRunsQueryResult
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineRunsQueryResult"/>. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DataFactoryPipelineRunsQueryResult(IEnumerable<DataFactoryPipelineRunInfo> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineRunsQueryResult"/>. </summary>
        /// <param name="value"> List of pipeline runs. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryPipelineRunsQueryResult(IReadOnlyList<DataFactoryPipelineRunInfo> value, string continuationToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            ContinuationToken = continuationToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryPipelineRunsQueryResult"/> for deserialization. </summary>
        internal DataFactoryPipelineRunsQueryResult()
        {
        }

        /// <summary> List of pipeline runs. </summary>
        public IReadOnlyList<DataFactoryPipelineRunInfo> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
