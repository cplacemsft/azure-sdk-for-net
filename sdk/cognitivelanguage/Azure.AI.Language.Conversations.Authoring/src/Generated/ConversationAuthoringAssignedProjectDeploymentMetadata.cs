// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the metadata for an assigned deployment. </summary>
    public partial class ConversationAuthoringAssignedProjectDeploymentMetadata
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

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringAssignedProjectDeploymentMetadata"/>. </summary>
        /// <param name="deploymentName"> Represents the deployment name. </param>
        /// <param name="lastDeployedOn"> Represents deployment last deployed time. </param>
        /// <param name="deploymentExpiresOn"> Represents deployment expiration date in the runtime. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> is null. </exception>
        internal ConversationAuthoringAssignedProjectDeploymentMetadata(string deploymentName, DateTimeOffset lastDeployedOn, DateTimeOffset deploymentExpiresOn)
        {
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            DeploymentName = deploymentName;
            LastDeployedOn = lastDeployedOn;
            DeploymentExpiresOn = deploymentExpiresOn;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringAssignedProjectDeploymentMetadata"/>. </summary>
        /// <param name="deploymentName"> Represents the deployment name. </param>
        /// <param name="lastDeployedOn"> Represents deployment last deployed time. </param>
        /// <param name="deploymentExpiresOn"> Represents deployment expiration date in the runtime. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringAssignedProjectDeploymentMetadata(string deploymentName, DateTimeOffset lastDeployedOn, DateTimeOffset deploymentExpiresOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeploymentName = deploymentName;
            LastDeployedOn = lastDeployedOn;
            DeploymentExpiresOn = deploymentExpiresOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringAssignedProjectDeploymentMetadata"/> for deserialization. </summary>
        internal ConversationAuthoringAssignedProjectDeploymentMetadata()
        {
        }

        /// <summary> Represents the deployment name. </summary>
        public string DeploymentName { get; }
        /// <summary> Represents deployment last deployed time. </summary>
        public DateTimeOffset LastDeployedOn { get; }
        /// <summary> Represents deployment expiration date in the runtime. </summary>
        public DateTimeOffset DeploymentExpiresOn { get; }
    }
}
