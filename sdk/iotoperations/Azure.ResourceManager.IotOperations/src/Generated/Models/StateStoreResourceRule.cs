// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> State Store Resource Rule properties. </summary>
    public partial class StateStoreResourceRule
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

        /// <summary> Initializes a new instance of <see cref="StateStoreResourceRule"/>. </summary>
        /// <param name="keyType"> Allowed keyTypes pattern, string, binary. The key type used for matching, for example pattern tries to match the key to a glob-style pattern and string checks key is equal to value provided in keys. </param>
        /// <param name="keys"> Give access to state store keys for the corresponding principals defined. When key type is pattern set glob-style pattern (e.g., '*', 'clients/*'). </param>
        /// <param name="method"> Give access for `Read`, `Write` and `ReadWrite` access level. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keys"/> is null. </exception>
        public StateStoreResourceRule(StateStoreResourceKeyType keyType, IEnumerable<string> keys, StateStoreResourceDefinitionMethod method)
        {
            Argument.AssertNotNull(keys, nameof(keys));

            KeyType = keyType;
            Keys = keys.ToList();
            Method = method;
        }

        /// <summary> Initializes a new instance of <see cref="StateStoreResourceRule"/>. </summary>
        /// <param name="keyType"> Allowed keyTypes pattern, string, binary. The key type used for matching, for example pattern tries to match the key to a glob-style pattern and string checks key is equal to value provided in keys. </param>
        /// <param name="keys"> Give access to state store keys for the corresponding principals defined. When key type is pattern set glob-style pattern (e.g., '*', 'clients/*'). </param>
        /// <param name="method"> Give access for `Read`, `Write` and `ReadWrite` access level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StateStoreResourceRule(StateStoreResourceKeyType keyType, IList<string> keys, StateStoreResourceDefinitionMethod method, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            Keys = keys;
            Method = method;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StateStoreResourceRule"/> for deserialization. </summary>
        internal StateStoreResourceRule()
        {
        }

        /// <summary> Allowed keyTypes pattern, string, binary. The key type used for matching, for example pattern tries to match the key to a glob-style pattern and string checks key is equal to value provided in keys. </summary>
        public StateStoreResourceKeyType KeyType { get; set; }
        /// <summary> Give access to state store keys for the corresponding principals defined. When key type is pattern set glob-style pattern (e.g., '*', 'clients/*'). </summary>
        public IList<string> Keys { get; }
        /// <summary> Give access for `Read`, `Write` and `ReadWrite` access level. </summary>
        public StateStoreResourceDefinitionMethod Method { get; set; }
    }
}
