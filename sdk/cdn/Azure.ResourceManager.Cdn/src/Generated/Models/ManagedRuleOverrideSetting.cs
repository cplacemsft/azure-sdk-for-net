// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines a managed rule group override setting. </summary>
    public partial class ManagedRuleOverrideSetting
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

        /// <summary> Initializes a new instance of <see cref="ManagedRuleOverrideSetting"/>. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleId"/> is null. </exception>
        public ManagedRuleOverrideSetting(string ruleId)
        {
            Argument.AssertNotNull(ruleId, nameof(ruleId));

            RuleId = ruleId;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleOverrideSetting"/>. </summary>
        /// <param name="ruleId"> Identifier for the managed rule. </param>
        /// <param name="enabledState"> Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified. </param>
        /// <param name="action"> Describes the override action to be applied when rule matches. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRuleOverrideSetting(string ruleId, ManagedRuleSetupState? enabledState, OverrideActionType? action, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RuleId = ruleId;
            EnabledState = enabledState;
            Action = action;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRuleOverrideSetting"/> for deserialization. </summary>
        internal ManagedRuleOverrideSetting()
        {
        }

        /// <summary> Identifier for the managed rule. </summary>
        public string RuleId { get; set; }
        /// <summary> Describes if the managed rule is in enabled or disabled state. Defaults to Disabled if not specified. </summary>
        public ManagedRuleSetupState? EnabledState { get; set; }
        /// <summary> Describes the override action to be applied when rule matches. </summary>
        public OverrideActionType? Action { get; set; }
    }
}
