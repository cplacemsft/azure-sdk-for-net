// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Result of the address validation. </summary>
    public partial class BillingAddressValidationResult
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

        /// <summary> Initializes a new instance of <see cref="BillingAddressValidationResult"/>. </summary>
        internal BillingAddressValidationResult()
        {
            SuggestedAddresses = new ChangeTrackingList<BillingAddressDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingAddressValidationResult"/>. </summary>
        /// <param name="status"> Status of the address validation. </param>
        /// <param name="suggestedAddresses"> The list of suggested addresses. </param>
        /// <param name="validationMessage"> Validation error message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingAddressValidationResult(BillingAddressValidationStatus? status, IReadOnlyList<BillingAddressDetails> suggestedAddresses, string validationMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            SuggestedAddresses = suggestedAddresses;
            ValidationMessage = validationMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Status of the address validation. </summary>
        [WirePath("status")]
        public BillingAddressValidationStatus? Status { get; }
        /// <summary> The list of suggested addresses. </summary>
        [WirePath("suggestedAddresses")]
        public IReadOnlyList<BillingAddressDetails> SuggestedAddresses { get; }
        /// <summary> Validation error message. </summary>
        [WirePath("validationMessage")]
        public string ValidationMessage { get; }
    }
}
