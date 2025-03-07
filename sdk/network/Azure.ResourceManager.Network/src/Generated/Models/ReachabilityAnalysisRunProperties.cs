// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Represents the Reachability Analysis Run properties. </summary>
    public partial class ReachabilityAnalysisRunProperties
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

        /// <summary> Initializes a new instance of <see cref="ReachabilityAnalysisRunProperties"/>. </summary>
        /// <param name="intentId"> Id of the intent resource to run analysis on. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="intentId"/> is null. </exception>
        public ReachabilityAnalysisRunProperties(string intentId)
        {
            Argument.AssertNotNull(intentId, nameof(intentId));

            IntentId = intentId;
        }

        /// <summary> Initializes a new instance of <see cref="ReachabilityAnalysisRunProperties"/>. </summary>
        /// <param name="description"></param>
        /// <param name="intentId"> Id of the intent resource to run analysis on. </param>
        /// <param name="intentContent"> Intent information. </param>
        /// <param name="analysisResult"></param>
        /// <param name="errorMessage"></param>
        /// <param name="provisioningState"> Provisioning states of a resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReachabilityAnalysisRunProperties(string description, string intentId, AnalysisRunIntentContent intentContent, string analysisResult, string errorMessage, NetworkProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            IntentId = intentId;
            IntentContent = intentContent;
            AnalysisResult = analysisResult;
            ErrorMessage = errorMessage;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReachabilityAnalysisRunProperties"/> for deserialization. </summary>
        internal ReachabilityAnalysisRunProperties()
        {
        }

        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Id of the intent resource to run analysis on. </summary>
        public string IntentId { get; set; }
        /// <summary> Intent information. </summary>
        public AnalysisRunIntentContent IntentContent { get; }
        /// <summary> Gets the analysis result. </summary>
        public string AnalysisResult { get; }
        /// <summary> Gets the error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Provisioning states of a resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; set; }
    }
}
