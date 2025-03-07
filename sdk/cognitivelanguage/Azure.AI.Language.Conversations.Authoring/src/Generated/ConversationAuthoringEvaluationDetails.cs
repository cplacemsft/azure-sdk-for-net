// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the options used running the evaluation. </summary>
    public partial class ConversationAuthoringEvaluationDetails
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

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringEvaluationDetails"/>. </summary>
        public ConversationAuthoringEvaluationDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringEvaluationDetails"/>. </summary>
        /// <param name="kind"> Represents the evaluation kind. By default, the evaluation kind is set to percentage. </param>
        /// <param name="trainingSplitPercentage"> Represents the training dataset split percentage. Only needed in case the evaluation kind is percentage. </param>
        /// <param name="testingSplitPercentage"> Represents the testing dataset split percentage. Only needed in case the evaluation kind is percentage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringEvaluationDetails(ConversationAuthoringEvaluationKind? kind, int? trainingSplitPercentage, int? testingSplitPercentage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            TrainingSplitPercentage = trainingSplitPercentage;
            TestingSplitPercentage = testingSplitPercentage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Represents the evaluation kind. By default, the evaluation kind is set to percentage. </summary>
        public ConversationAuthoringEvaluationKind? Kind { get; set; }
        /// <summary> Represents the training dataset split percentage. Only needed in case the evaluation kind is percentage. </summary>
        public int? TrainingSplitPercentage { get; set; }
        /// <summary> Represents the testing dataset split percentage. Only needed in case the evaluation kind is percentage. </summary>
        public int? TestingSplitPercentage { get; set; }
    }
}
