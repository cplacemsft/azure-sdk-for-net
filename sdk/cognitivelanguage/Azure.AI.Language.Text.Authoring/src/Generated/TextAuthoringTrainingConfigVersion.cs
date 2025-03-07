// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents a training config version. </summary>
    public partial class TextAuthoringTrainingConfigVersion
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

        /// <summary> Initializes a new instance of <see cref="TextAuthoringTrainingConfigVersion"/>. </summary>
        /// <param name="modelExpiredOn"> Represents the training config version expiration date. </param>
        internal TextAuthoringTrainingConfigVersion(DateTimeOffset modelExpiredOn)
        {
            ModelExpiredOn = modelExpiredOn;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringTrainingConfigVersion"/>. </summary>
        /// <param name="trainingConfigVersion"> Represents the version of the config. </param>
        /// <param name="modelExpiredOn"> Represents the training config version expiration date. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAuthoringTrainingConfigVersion(string trainingConfigVersion, DateTimeOffset modelExpiredOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TrainingConfigVersion = trainingConfigVersion;
            ModelExpiredOn = modelExpiredOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringTrainingConfigVersion"/> for deserialization. </summary>
        internal TextAuthoringTrainingConfigVersion()
        {
        }

        /// <summary> Represents the version of the config. </summary>
        public string TrainingConfigVersion { get; }
        /// <summary> Represents the training config version expiration date. </summary>
        public DateTimeOffset ModelExpiredOn { get; }
    }
}
