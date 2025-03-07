// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the evaluation summary for the project's intents. </summary>
    public partial class IntentsEvaluationSummary
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

        /// <summary> Initializes a new instance of <see cref="IntentsEvaluationSummary"/>. </summary>
        /// <param name="confusionMatrix"> Represents the confusion matrix between two intents (the two intents can be the same). The matrix is between the intent that was labelled and the intent that was predicted. </param>
        /// <param name="intents"> Represents the intents evaluation summary. </param>
        /// <param name="microF1"> Represents the micro F1. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="microPrecision"> Represents the micro precision. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="microRecall"> Represents the micro recall. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroF1"> Represents the macro F1. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroPrecision"> Represents the macro precision. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroRecall"> Represents the macro recall. Expected value is a float between 0 and 1 inclusive. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="confusionMatrix"/> or <paramref name="intents"/> is null. </exception>
        internal IntentsEvaluationSummary(IReadOnlyDictionary<string, ConversationAuthoringConfusionMatrixRow> confusionMatrix, IReadOnlyDictionary<string, IntentEvaluationSummary> intents, float microF1, float microPrecision, float microRecall, float macroF1, float macroPrecision, float macroRecall)
        {
            Argument.AssertNotNull(confusionMatrix, nameof(confusionMatrix));
            Argument.AssertNotNull(intents, nameof(intents));

            ConfusionMatrix = confusionMatrix;
            Intents = intents;
            MicroF1 = microF1;
            MicroPrecision = microPrecision;
            MicroRecall = microRecall;
            MacroF1 = macroF1;
            MacroPrecision = macroPrecision;
            MacroRecall = macroRecall;
        }

        /// <summary> Initializes a new instance of <see cref="IntentsEvaluationSummary"/>. </summary>
        /// <param name="confusionMatrix"> Represents the confusion matrix between two intents (the two intents can be the same). The matrix is between the intent that was labelled and the intent that was predicted. </param>
        /// <param name="intents"> Represents the intents evaluation summary. </param>
        /// <param name="microF1"> Represents the micro F1. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="microPrecision"> Represents the micro precision. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="microRecall"> Represents the micro recall. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroF1"> Represents the macro F1. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroPrecision"> Represents the macro precision. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="macroRecall"> Represents the macro recall. Expected value is a float between 0 and 1 inclusive. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IntentsEvaluationSummary(IReadOnlyDictionary<string, ConversationAuthoringConfusionMatrixRow> confusionMatrix, IReadOnlyDictionary<string, IntentEvaluationSummary> intents, float microF1, float microPrecision, float microRecall, float macroF1, float macroPrecision, float macroRecall, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConfusionMatrix = confusionMatrix;
            Intents = intents;
            MicroF1 = microF1;
            MicroPrecision = microPrecision;
            MicroRecall = microRecall;
            MacroF1 = macroF1;
            MacroPrecision = macroPrecision;
            MacroRecall = macroRecall;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IntentsEvaluationSummary"/> for deserialization. </summary>
        internal IntentsEvaluationSummary()
        {
        }

        /// <summary> Represents the confusion matrix between two intents (the two intents can be the same). The matrix is between the intent that was labelled and the intent that was predicted. </summary>
        public IReadOnlyDictionary<string, ConversationAuthoringConfusionMatrixRow> ConfusionMatrix { get; }
        /// <summary> Represents the intents evaluation summary. </summary>
        public IReadOnlyDictionary<string, IntentEvaluationSummary> Intents { get; }
        /// <summary> Represents the micro F1. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MicroF1 { get; }
        /// <summary> Represents the micro precision. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MicroPrecision { get; }
        /// <summary> Represents the micro recall. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MicroRecall { get; }
        /// <summary> Represents the macro F1. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MacroF1 { get; }
        /// <summary> Represents the macro precision. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MacroPrecision { get; }
        /// <summary> Represents the macro recall. Expected value is a float between 0 and 1 inclusive. </summary>
        public float MacroRecall { get; }
    }
}
