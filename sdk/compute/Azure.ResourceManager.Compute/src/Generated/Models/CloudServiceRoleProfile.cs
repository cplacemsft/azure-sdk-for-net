// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the role profile for the cloud service. </summary>
    internal partial class CloudServiceRoleProfile
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

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleProfile"/>. </summary>
        public CloudServiceRoleProfile()
        {
            Roles = new ChangeTrackingList<CloudServiceRoleProfileProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="CloudServiceRoleProfile"/>. </summary>
        /// <param name="roles"> List of roles for the cloud service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudServiceRoleProfile(IList<CloudServiceRoleProfileProperties> roles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Roles = roles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of roles for the cloud service. </summary>
        public IList<CloudServiceRoleProfileProperties> Roles { get; }
    }
}
