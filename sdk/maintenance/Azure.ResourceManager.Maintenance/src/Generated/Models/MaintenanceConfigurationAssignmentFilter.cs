// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Maintenance;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Azure query for the update configuration. </summary>
    public partial class MaintenanceConfigurationAssignmentFilter
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

        /// <summary> Initializes a new instance of <see cref="MaintenanceConfigurationAssignmentFilter"/>. </summary>
        public MaintenanceConfigurationAssignmentFilter()
        {
            ResourceTypes = new ChangeTrackingList<ResourceType>();
            ResourceGroups = new ChangeTrackingList<string>();
            OSTypes = new ChangeTrackingList<string>();
            Locations = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceConfigurationAssignmentFilter"/>. </summary>
        /// <param name="resourceTypes"> List of allowed resources. </param>
        /// <param name="resourceGroups"> List of allowed resource groups. </param>
        /// <param name="osTypes"> List of allowed operating systems. </param>
        /// <param name="locations"> List of locations to scope the query to. </param>
        /// <param name="tagSettings"> Tag settings for the VM. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceConfigurationAssignmentFilter(IList<ResourceType> resourceTypes, IList<string> resourceGroups, IList<string> osTypes, IList<AzureLocation> locations, VmTagSettings tagSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceTypes = resourceTypes;
            ResourceGroups = resourceGroups;
            OSTypes = osTypes;
            Locations = locations;
            TagSettings = tagSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of allowed resources. </summary>
        public IList<ResourceType> ResourceTypes { get; }
        /// <summary> List of allowed resource groups. </summary>
        public IList<string> ResourceGroups { get; }
        /// <summary> List of allowed operating systems. </summary>
        public IList<string> OSTypes { get; }
        /// <summary> List of locations to scope the query to. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> Tag settings for the VM. </summary>
        public VmTagSettings TagSettings { get; set; }
    }
}
