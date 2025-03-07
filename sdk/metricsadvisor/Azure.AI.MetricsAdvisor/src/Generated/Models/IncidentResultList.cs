// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IncidentResultList. </summary>
    internal partial class IncidentResultList
    {
        /// <summary> Initializes a new instance of <see cref="IncidentResultList"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal IncidentResultList(IEnumerable<AnomalyIncident> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="IncidentResultList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value"></param>
        internal IncidentResultList(string nextLink, IReadOnlyList<AnomalyIncident> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary> Gets the value. </summary>
        public IReadOnlyList<AnomalyIncident> Value { get; }
    }
}
