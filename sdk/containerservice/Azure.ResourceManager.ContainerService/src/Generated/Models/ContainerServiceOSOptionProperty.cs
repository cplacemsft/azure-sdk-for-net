// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> OS option property. </summary>
    public partial class ContainerServiceOSOptionProperty
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOSOptionProperty"/>. </summary>
        /// <param name="osType"> The OS type. </param>
        /// <param name="enableFipsImage"> Whether the image is FIPS-enabled. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osType"/> is null. </exception>
        internal ContainerServiceOSOptionProperty(string osType, bool enableFipsImage)
        {
            Argument.AssertNotNull(osType, nameof(osType));

            OSType = osType;
            EnableFipsImage = enableFipsImage;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOSOptionProperty"/>. </summary>
        /// <param name="osType"> The OS type. </param>
        /// <param name="enableFipsImage"> Whether the image is FIPS-enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceOSOptionProperty(string osType, bool enableFipsImage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSType = osType;
            EnableFipsImage = enableFipsImage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOSOptionProperty"/> for deserialization. </summary>
        internal ContainerServiceOSOptionProperty()
        {
        }

        /// <summary> The OS type. </summary>
        [WirePath("os-type")]
        public string OSType { get; }
        /// <summary> Whether the image is FIPS-enabled. </summary>
        [WirePath("enable-fips-image")]
        public bool EnableFipsImage { get; }
    }
}
