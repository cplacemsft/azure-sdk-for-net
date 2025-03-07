// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The inference results for the Radiology Insights request. If field 'status' has value 'succeeded', then field 'result' will contain an instance of RadiologyInsightsInferenceResult. </summary>
    public partial class RadiologyInsightsInferenceResult
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

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/>. </summary>
        /// <param name="patientResults"> Results for the patients given in the request. </param>
        /// <param name="modelVersion"> The version of the model used for inference, expressed as the model date. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patientResults"/> or <paramref name="modelVersion"/> is null. </exception>
        internal RadiologyInsightsInferenceResult(IEnumerable<RadiologyInsightsPatientResult> patientResults, string modelVersion)
        {
            Argument.AssertNotNull(patientResults, nameof(patientResults));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            PatientResults = patientResults.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/>. </summary>
        /// <param name="patientResults"> Results for the patients given in the request. </param>
        /// <param name="modelVersion"> The version of the model used for inference, expressed as the model date. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyInsightsInferenceResult(IReadOnlyList<RadiologyInsightsPatientResult> patientResults, string modelVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PatientResults = patientResults;
            ModelVersion = modelVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceResult"/> for deserialization. </summary>
        internal RadiologyInsightsInferenceResult()
        {
        }

        /// <summary> Results for the patients given in the request. </summary>
        public IReadOnlyList<RadiologyInsightsPatientResult> PatientResults { get; }
        /// <summary> The version of the model used for inference, expressed as the model date. </summary>
        public string ModelVersion { get; }
    }
}
