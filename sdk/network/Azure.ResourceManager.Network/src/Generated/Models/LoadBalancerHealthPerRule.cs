// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The response for a Health API. </summary>
    public partial class LoadBalancerHealthPerRule
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

        /// <summary> Initializes a new instance of <see cref="LoadBalancerHealthPerRule"/>. </summary>
        internal LoadBalancerHealthPerRule()
        {
            LoadBalancerBackendAddresses = new ChangeTrackingList<LoadBalancerHealthPerRulePerBackendAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerHealthPerRule"/>. </summary>
        /// <param name="up"> Number of backend instances associated to the LB rule that are considered healthy. </param>
        /// <param name="down"> Number of backend instances associated to the LB rule that are considered unhealthy. </param>
        /// <param name="loadBalancerBackendAddresses"> Information about the health per rule of the backend addresses. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LoadBalancerHealthPerRule(int? up, int? down, IReadOnlyList<LoadBalancerHealthPerRulePerBackendAddress> loadBalancerBackendAddresses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Up = up;
            Down = down;
            LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of backend instances associated to the LB rule that are considered healthy. </summary>
        public int? Up { get; }
        /// <summary> Number of backend instances associated to the LB rule that are considered unhealthy. </summary>
        public int? Down { get; }
        /// <summary> Information about the health per rule of the backend addresses. </summary>
        public IReadOnlyList<LoadBalancerHealthPerRulePerBackendAddress> LoadBalancerBackendAddresses { get; }
    }
}
