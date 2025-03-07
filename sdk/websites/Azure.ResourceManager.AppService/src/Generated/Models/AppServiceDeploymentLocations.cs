// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// List of available locations (regions or App Service Environments) for
    /// deployment of App Service resources.
    /// </summary>
    public partial class AppServiceDeploymentLocations
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

        /// <summary> Initializes a new instance of <see cref="AppServiceDeploymentLocations"/>. </summary>
        internal AppServiceDeploymentLocations()
        {
            Locations = new ChangeTrackingList<AppServiceGeoRegion>();
            HostingEnvironments = new ChangeTrackingList<AppServiceEnvironmentProperties>();
            HostingEnvironmentDeploymentInfos = new ChangeTrackingList<HostingEnvironmentDeploymentInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceDeploymentLocations"/>. </summary>
        /// <param name="locations"> Available regions. </param>
        /// <param name="hostingEnvironments"> Available App Service Environments with full descriptions of the environments. </param>
        /// <param name="hostingEnvironmentDeploymentInfos"> Available App Service Environments with basic information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceDeploymentLocations(IReadOnlyList<AppServiceGeoRegion> locations, IReadOnlyList<AppServiceEnvironmentProperties> hostingEnvironments, IReadOnlyList<HostingEnvironmentDeploymentInfo> hostingEnvironmentDeploymentInfos, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Locations = locations;
            HostingEnvironments = hostingEnvironments;
            HostingEnvironmentDeploymentInfos = hostingEnvironmentDeploymentInfos;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Available regions. </summary>
        [WirePath("locations")]
        public IReadOnlyList<AppServiceGeoRegion> Locations { get; }
        /// <summary> Available App Service Environments with full descriptions of the environments. </summary>
        [WirePath("hostingEnvironments")]
        public IReadOnlyList<AppServiceEnvironmentProperties> HostingEnvironments { get; }
        /// <summary> Available App Service Environments with basic information. </summary>
        [WirePath("hostingEnvironmentDeploymentInfos")]
        public IReadOnlyList<HostingEnvironmentDeploymentInfo> HostingEnvironmentDeploymentInfos { get; }
    }
}
