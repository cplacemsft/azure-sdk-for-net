// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyDetectionConfigurationList. </summary>
    internal partial class AnomalyDetectionConfigurationList
    {
        /// <summary> Initializes a new instance of <see cref="AnomalyDetectionConfigurationList"/>. </summary>
        internal AnomalyDetectionConfigurationList()
        {
            Value = new ChangeTrackingList<AnomalyDetectionConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetectionConfigurationList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal AnomalyDetectionConfigurationList(IReadOnlyList<AnomalyDetectionConfiguration> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<AnomalyDetectionConfiguration> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
