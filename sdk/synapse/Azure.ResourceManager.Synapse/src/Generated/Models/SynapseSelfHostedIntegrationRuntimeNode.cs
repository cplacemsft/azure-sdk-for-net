// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Properties of Self-hosted integration runtime node. </summary>
    public partial class SynapseSelfHostedIntegrationRuntimeNode
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSelfHostedIntegrationRuntimeNode"/>. </summary>
        internal SynapseSelfHostedIntegrationRuntimeNode()
        {
            Capabilities = new ChangeTrackingDictionary<string, string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSelfHostedIntegrationRuntimeNode"/>. </summary>
        /// <param name="nodeName"> Name of the integration runtime node. </param>
        /// <param name="machineName"> Machine name of the integration runtime node. </param>
        /// <param name="hostServiceUri"> URI for the host machine of the integration runtime. </param>
        /// <param name="status"> Status of the integration runtime node. </param>
        /// <param name="capabilities"> The integration runtime capabilities dictionary. </param>
        /// <param name="versionStatus"> Status of the integration runtime node version. </param>
        /// <param name="version"> Version of the integration runtime node. </param>
        /// <param name="registerOn"> The time at which the integration runtime node was registered in ISO8601 format. </param>
        /// <param name="lastConnectedOn"> The most recent time at which the integration runtime was connected in ISO8601 format. </param>
        /// <param name="expireOn"> The time at which the integration runtime will expire in ISO8601 format. </param>
        /// <param name="lastStartedOn"> The time the node last started up. </param>
        /// <param name="lastStopOn"> The integration runtime node last stop time. </param>
        /// <param name="lastUpdateResult"> The result of the last integration runtime node update. </param>
        /// <param name="lastStartUpdateOn"> The last time for the integration runtime node update start. </param>
        /// <param name="lastEndUpdateOn"> The last time for the integration runtime node update end. </param>
        /// <param name="isActiveDispatcher"> Indicates whether this node is the active dispatcher for integration runtime requests. </param>
        /// <param name="concurrentJobsLimit"> Maximum concurrent jobs on the integration runtime node. </param>
        /// <param name="maxConcurrentJobs"> The maximum concurrent jobs in this integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SynapseSelfHostedIntegrationRuntimeNode(string nodeName, string machineName, Uri hostServiceUri, SynapseSelfHostedIntegrationRuntimeNodeStatus? status, IReadOnlyDictionary<string, string> capabilities, string versionStatus, string version, DateTimeOffset? registerOn, DateTimeOffset? lastConnectedOn, DateTimeOffset? expireOn, DateTimeOffset? lastStartedOn, DateTimeOffset? lastStopOn, SynapseIntegrationRuntimeUpdateResult? lastUpdateResult, DateTimeOffset? lastStartUpdateOn, DateTimeOffset? lastEndUpdateOn, bool? isActiveDispatcher, int? concurrentJobsLimit, int? maxConcurrentJobs, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            NodeName = nodeName;
            MachineName = machineName;
            HostServiceUri = hostServiceUri;
            Status = status;
            Capabilities = capabilities;
            VersionStatus = versionStatus;
            Version = version;
            RegisterOn = registerOn;
            LastConnectedOn = lastConnectedOn;
            ExpireOn = expireOn;
            LastStartedOn = lastStartedOn;
            LastStopOn = lastStopOn;
            LastUpdateResult = lastUpdateResult;
            LastStartUpdateOn = lastStartUpdateOn;
            LastEndUpdateOn = lastEndUpdateOn;
            IsActiveDispatcher = isActiveDispatcher;
            ConcurrentJobsLimit = concurrentJobsLimit;
            MaxConcurrentJobs = maxConcurrentJobs;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the integration runtime node. </summary>
        public string NodeName { get; }
        /// <summary> Machine name of the integration runtime node. </summary>
        public string MachineName { get; }
        /// <summary> URI for the host machine of the integration runtime. </summary>
        public Uri HostServiceUri { get; }
        /// <summary> Status of the integration runtime node. </summary>
        public SynapseSelfHostedIntegrationRuntimeNodeStatus? Status { get; }
        /// <summary> The integration runtime capabilities dictionary. </summary>
        public IReadOnlyDictionary<string, string> Capabilities { get; }
        /// <summary> Status of the integration runtime node version. </summary>
        public string VersionStatus { get; }
        /// <summary> Version of the integration runtime node. </summary>
        public string Version { get; }
        /// <summary> The time at which the integration runtime node was registered in ISO8601 format. </summary>
        public DateTimeOffset? RegisterOn { get; }
        /// <summary> The most recent time at which the integration runtime was connected in ISO8601 format. </summary>
        public DateTimeOffset? LastConnectedOn { get; }
        /// <summary> The time at which the integration runtime will expire in ISO8601 format. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The time the node last started up. </summary>
        public DateTimeOffset? LastStartedOn { get; }
        /// <summary> The integration runtime node last stop time. </summary>
        public DateTimeOffset? LastStopOn { get; }
        /// <summary> The result of the last integration runtime node update. </summary>
        public SynapseIntegrationRuntimeUpdateResult? LastUpdateResult { get; }
        /// <summary> The last time for the integration runtime node update start. </summary>
        public DateTimeOffset? LastStartUpdateOn { get; }
        /// <summary> The last time for the integration runtime node update end. </summary>
        public DateTimeOffset? LastEndUpdateOn { get; }
        /// <summary> Indicates whether this node is the active dispatcher for integration runtime requests. </summary>
        public bool? IsActiveDispatcher { get; }
        /// <summary> Maximum concurrent jobs on the integration runtime node. </summary>
        public int? ConcurrentJobsLimit { get; }
        /// <summary> The maximum concurrent jobs in this integration runtime. </summary>
        public int? MaxConcurrentJobs { get; }
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
