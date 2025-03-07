// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> The status of the Traffic Manager profile. </summary>
    public readonly partial struct TrafficManagerProfileStatus : IEquatable<TrafficManagerProfileStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TrafficManagerProfileStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TrafficManagerProfileStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static TrafficManagerProfileStatus Enabled { get; } = new TrafficManagerProfileStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static TrafficManagerProfileStatus Disabled { get; } = new TrafficManagerProfileStatus(DisabledValue);
        /// <summary> Determines if two <see cref="TrafficManagerProfileStatus"/> values are the same. </summary>
        public static bool operator ==(TrafficManagerProfileStatus left, TrafficManagerProfileStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TrafficManagerProfileStatus"/> values are not the same. </summary>
        public static bool operator !=(TrafficManagerProfileStatus left, TrafficManagerProfileStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TrafficManagerProfileStatus"/>. </summary>
        public static implicit operator TrafficManagerProfileStatus(string value) => new TrafficManagerProfileStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TrafficManagerProfileStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TrafficManagerProfileStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
