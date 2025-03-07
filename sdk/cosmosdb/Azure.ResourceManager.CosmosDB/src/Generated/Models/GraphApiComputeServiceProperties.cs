// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties for GraphAPIComputeServiceResource. </summary>
    public partial class GraphApiComputeServiceProperties : CosmosDBServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="GraphApiComputeServiceProperties"/>. </summary>
        public GraphApiComputeServiceProperties()
        {
            Locations = new ChangeTrackingList<GraphApiComputeRegionalService>();
            ServiceType = CosmosDBServiceType.GraphApiCompute;
        }

        /// <summary> Initializes a new instance of <see cref="GraphApiComputeServiceProperties"/>. </summary>
        /// <param name="createdOn"> Time of the last state change (ISO-8601 format). </param>
        /// <param name="instanceSize"> Instance type for the service. </param>
        /// <param name="instanceCount"> Instance count for the service. </param>
        /// <param name="serviceType"> ServiceType for the service. </param>
        /// <param name="status"> Describes the status of a service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="graphApiComputeEndpoint"> GraphAPICompute endpoint for the service. </param>
        /// <param name="locations"> An array that contains all of the locations for the service. </param>
        internal GraphApiComputeServiceProperties(DateTimeOffset? createdOn, CosmosDBServiceSize? instanceSize, int? instanceCount, CosmosDBServiceType serviceType, CosmosDBServiceStatus? status, IDictionary<string, BinaryData> additionalProperties, string graphApiComputeEndpoint, IReadOnlyList<GraphApiComputeRegionalService> locations) : base(createdOn, instanceSize, instanceCount, serviceType, status, additionalProperties)
        {
            GraphApiComputeEndpoint = graphApiComputeEndpoint;
            Locations = locations;
            ServiceType = serviceType;
        }

        /// <summary> GraphAPICompute endpoint for the service. </summary>
        [WirePath("graphApiComputeEndpoint")]
        public string GraphApiComputeEndpoint { get; set; }
        /// <summary> An array that contains all of the locations for the service. </summary>
        [WirePath("locations")]
        public IReadOnlyList<GraphApiComputeRegionalService> Locations { get; }
    }
}
