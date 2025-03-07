// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ScVmm.Models
{
    /// <summary> Network Interface model. </summary>
    public partial class ScVmmNetworkInterfaceUpdate
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

        /// <summary> Initializes a new instance of <see cref="ScVmmNetworkInterfaceUpdate"/>. </summary>
        public ScVmmNetworkInterfaceUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmNetworkInterfaceUpdate"/>. </summary>
        /// <param name="name"> Gets or sets the name of the network interface. </param>
        /// <param name="macAddress"> Gets or sets the nic MAC address. </param>
        /// <param name="virtualNetworkId"> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </param>
        /// <param name="ipv4AddressType"> Gets or sets the ipv4 address type. </param>
        /// <param name="ipv6AddressType"> Gets or sets the ipv6 address type. </param>
        /// <param name="macAddressType"> Gets or sets the mac address type. </param>
        /// <param name="nicId"> Gets or sets the nic id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmNetworkInterfaceUpdate(string name, string macAddress, string virtualNetworkId, AllocationMethod? ipv4AddressType, AllocationMethod? ipv6AddressType, AllocationMethod? macAddressType, string nicId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MacAddress = macAddress;
            VirtualNetworkId = virtualNetworkId;
            IPv4AddressType = ipv4AddressType;
            IPv6AddressType = ipv6AddressType;
            MacAddressType = macAddressType;
            NicId = nicId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the name of the network interface. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the nic MAC address. </summary>
        public string MacAddress { get; set; }
        /// <summary> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </summary>
        public string VirtualNetworkId { get; set; }
        /// <summary> Gets or sets the ipv4 address type. </summary>
        public AllocationMethod? IPv4AddressType { get; set; }
        /// <summary> Gets or sets the ipv6 address type. </summary>
        public AllocationMethod? IPv6AddressType { get; set; }
        /// <summary> Gets or sets the mac address type. </summary>
        public AllocationMethod? MacAddressType { get; set; }
        /// <summary> Gets or sets the nic id. </summary>
        public string NicId { get; set; }
    }
}
