// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageFabric switch provider blocking error details. </summary>
    public partial class InMageFabricSwitchProviderBlockingErrorDetails
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

        /// <summary> Initializes a new instance of <see cref="InMageFabricSwitchProviderBlockingErrorDetails"/>. </summary>
        internal InMageFabricSwitchProviderBlockingErrorDetails()
        {
            ErrorMessageParameters = new ChangeTrackingDictionary<string, string>();
            ErrorTags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="InMageFabricSwitchProviderBlockingErrorDetails"/>. </summary>
        /// <param name="errorCode"> The error code. </param>
        /// <param name="errorMessage"> The error message. </param>
        /// <param name="possibleCauses"> The possible causes. </param>
        /// <param name="recommendedAction"> The recommended action. </param>
        /// <param name="errorMessageParameters"> The error message parameters. </param>
        /// <param name="errorTags"> The error tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageFabricSwitchProviderBlockingErrorDetails(string errorCode, string errorMessage, string possibleCauses, string recommendedAction, IReadOnlyDictionary<string, string> errorMessageParameters, IReadOnlyDictionary<string, string> errorTags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            ErrorMessageParameters = errorMessageParameters;
            ErrorTags = errorTags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The error code. </summary>
        public string ErrorCode { get; }
        /// <summary> The error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> The possible causes. </summary>
        public string PossibleCauses { get; }
        /// <summary> The recommended action. </summary>
        public string RecommendedAction { get; }
        /// <summary> The error message parameters. </summary>
        public IReadOnlyDictionary<string, string> ErrorMessageParameters { get; }
        /// <summary> The error tags. </summary>
        public IReadOnlyDictionary<string, string> ErrorTags { get; }
    }
}
