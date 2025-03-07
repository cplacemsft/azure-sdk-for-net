// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The capabilities to add or drop from a container. </summary>
    public partial class ContainerSecurityContextCapabilitiesDefinition
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

        /// <summary> Initializes a new instance of <see cref="ContainerSecurityContextCapabilitiesDefinition"/>. </summary>
        public ContainerSecurityContextCapabilitiesDefinition()
        {
            Add = new ChangeTrackingList<string>();
            Drop = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerSecurityContextCapabilitiesDefinition"/>. </summary>
        /// <param name="add"> The capabilities to add to the container. </param>
        /// <param name="drop"> The capabilities to drop from the container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerSecurityContextCapabilitiesDefinition(IList<string> @add, IList<string> drop, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Add = @add;
            Drop = drop;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The capabilities to add to the container. </summary>
        public IList<string> Add { get; }
        /// <summary> The capabilities to drop from the container. </summary>
        public IList<string> Drop { get; }
    }
}
