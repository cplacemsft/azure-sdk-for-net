// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> A policy at subscription scope. </summary>
    public partial class SubscriptionPolicyProperties
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

        /// <summary> Initializes a new instance of <see cref="SubscriptionPolicyProperties"/>. </summary>
        public SubscriptionPolicyProperties()
        {
            Policies = new ChangeTrackingList<BillingPolicySummary>();
        }

        /// <summary> Initializes a new instance of <see cref="SubscriptionPolicyProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the resource during a long-running operation. </param>
        /// <param name="policies"> List of all policies defined at the billing scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SubscriptionPolicyProperties(BillingProvisioningState? provisioningState, IList<BillingPolicySummary> policies, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            Policies = policies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the resource during a long-running operation. </summary>
        [WirePath("provisioningState")]
        public BillingProvisioningState? ProvisioningState { get; }
        /// <summary> List of all policies defined at the billing scope. </summary>
        [WirePath("policies")]
        public IList<BillingPolicySummary> Policies { get; }
    }
}
