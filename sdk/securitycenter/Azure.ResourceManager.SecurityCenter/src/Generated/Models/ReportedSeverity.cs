// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Assessed alert severity. </summary>
    public readonly partial struct ReportedSeverity : IEquatable<ReportedSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReportedSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReportedSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InformationalValue = "Informational";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Informational. </summary>
        public static ReportedSeverity Informational { get; } = new ReportedSeverity(InformationalValue);
        /// <summary> Low. </summary>
        public static ReportedSeverity Low { get; } = new ReportedSeverity(LowValue);
        /// <summary> Medium. </summary>
        public static ReportedSeverity Medium { get; } = new ReportedSeverity(MediumValue);
        /// <summary> High. </summary>
        public static ReportedSeverity High { get; } = new ReportedSeverity(HighValue);
        /// <summary> Determines if two <see cref="ReportedSeverity"/> values are the same. </summary>
        public static bool operator ==(ReportedSeverity left, ReportedSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReportedSeverity"/> values are not the same. </summary>
        public static bool operator !=(ReportedSeverity left, ReportedSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ReportedSeverity"/>. </summary>
        public static implicit operator ReportedSeverity(string value) => new ReportedSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReportedSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReportedSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
