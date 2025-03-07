// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Outbound connection to an ip that isn't allowed. Allow list consists of ipv4 or ipv6 range in CIDR notation. </summary>
    public partial class ConnectionToIPNotAllowed : AllowlistCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionToIPNotAllowed"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowlistValues"/> is null. </exception>
        public ConnectionToIPNotAllowed(bool isEnabled, IEnumerable<string> allowlistValues) : base(isEnabled, allowlistValues)
        {
            Argument.AssertNotNull(allowlistValues, nameof(allowlistValues));

            RuleType = "ConnectionToIpNotAllowed";
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionToIPNotAllowed"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="valueType"> The value type of the items in the list. </param>
        /// <param name="allowlistValues"> The values to allow. The format of the values depends on the rule type. </param>
        internal ConnectionToIPNotAllowed(string displayName, string description, bool isEnabled, string ruleType, IDictionary<string, BinaryData> serializedAdditionalRawData, SecurityValueType? valueType, IList<string> allowlistValues) : base(displayName, description, isEnabled, ruleType, serializedAdditionalRawData, valueType, allowlistValues)
        {
            RuleType = ruleType ?? "ConnectionToIpNotAllowed";
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionToIPNotAllowed"/> for deserialization. </summary>
        internal ConnectionToIPNotAllowed()
        {
        }
    }
}
