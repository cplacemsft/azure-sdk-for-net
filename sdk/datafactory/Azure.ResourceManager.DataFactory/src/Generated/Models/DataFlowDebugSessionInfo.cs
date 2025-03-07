// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Data flow debug session info. </summary>
    public partial class DataFlowDebugSessionInfo
    {
        /// <summary> Initializes a new instance of <see cref="DataFlowDebugSessionInfo"/>. </summary>
        internal DataFlowDebugSessionInfo()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataFlowDebugSessionInfo"/>. </summary>
        /// <param name="dataFlowName"> The name of the data flow. </param>
        /// <param name="computeType"> Compute type of the cluster. </param>
        /// <param name="coreCount"> Core count of the cluster. </param>
        /// <param name="nodeCount"> Node count of the cluster. (deprecated property). </param>
        /// <param name="integrationRuntimeName"> Attached integration runtime name of data flow debug session. </param>
        /// <param name="sessionId"> The ID of data flow debug session. </param>
        /// <param name="startOn"> Start time of data flow debug session. </param>
        /// <param name="timeToLiveInMinutes"> Compute type of the cluster. </param>
        /// <param name="lastActivityOn"> Last activity time of data flow debug session. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFlowDebugSessionInfo(string dataFlowName, string computeType, int? coreCount, int? nodeCount, string integrationRuntimeName, Guid? sessionId, DateTimeOffset? startOn, int? timeToLiveInMinutes, DateTimeOffset? lastActivityOn, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            DataFlowName = dataFlowName;
            ComputeType = computeType;
            CoreCount = coreCount;
            NodeCount = nodeCount;
            IntegrationRuntimeName = integrationRuntimeName;
            SessionId = sessionId;
            StartOn = startOn;
            TimeToLiveInMinutes = timeToLiveInMinutes;
            LastActivityOn = lastActivityOn;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The name of the data flow. </summary>
        public string DataFlowName { get; }
        /// <summary> Compute type of the cluster. </summary>
        public string ComputeType { get; }
        /// <summary> Core count of the cluster. </summary>
        public int? CoreCount { get; }
        /// <summary> Node count of the cluster. (deprecated property). </summary>
        public int? NodeCount { get; }
        /// <summary> Attached integration runtime name of data flow debug session. </summary>
        public string IntegrationRuntimeName { get; }
        /// <summary> The ID of data flow debug session. </summary>
        public Guid? SessionId { get; }
        /// <summary> Start time of data flow debug session. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Compute type of the cluster. </summary>
        public int? TimeToLiveInMinutes { get; }
        /// <summary> Last activity time of data flow debug session. </summary>
        public DateTimeOffset? LastActivityOn { get; }
        /// <summary>
        /// Additional Properties
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
