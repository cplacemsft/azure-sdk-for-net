// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The status of the resource regarding a single assessment. </summary>
    public readonly partial struct SecurityAssessmentResourceStatus : IEquatable<SecurityAssessmentResourceStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentResourceStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAssessmentResourceStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HealthyValue = "Healthy";
        private const string NotApplicableValue = "NotApplicable";
        private const string OffByPolicyValue = "OffByPolicy";
        private const string NotHealthyValue = "NotHealthy";

        /// <summary> This assessment on the resource is healthy. </summary>
        public static SecurityAssessmentResourceStatus Healthy { get; } = new SecurityAssessmentResourceStatus(HealthyValue);
        /// <summary> This assessment is not applicable to this resource. </summary>
        public static SecurityAssessmentResourceStatus NotApplicable { get; } = new SecurityAssessmentResourceStatus(NotApplicableValue);
        /// <summary> This assessment is turned off by policy on this subscription. </summary>
        public static SecurityAssessmentResourceStatus OffByPolicy { get; } = new SecurityAssessmentResourceStatus(OffByPolicyValue);
        /// <summary> This assessment on the resource is not healthy. </summary>
        public static SecurityAssessmentResourceStatus NotHealthy { get; } = new SecurityAssessmentResourceStatus(NotHealthyValue);
        /// <summary> Determines if two <see cref="SecurityAssessmentResourceStatus"/> values are the same. </summary>
        public static bool operator ==(SecurityAssessmentResourceStatus left, SecurityAssessmentResourceStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAssessmentResourceStatus"/> values are not the same. </summary>
        public static bool operator !=(SecurityAssessmentResourceStatus left, SecurityAssessmentResourceStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityAssessmentResourceStatus"/>. </summary>
        public static implicit operator SecurityAssessmentResourceStatus(string value) => new SecurityAssessmentResourceStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAssessmentResourceStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAssessmentResourceStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
