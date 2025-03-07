// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Indicates the new subscription status of the OS or Product Features. </summary>
    public readonly partial struct LicenseProfileSubscriptionStatusUpdate : IEquatable<LicenseProfileSubscriptionStatusUpdate>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LicenseProfileSubscriptionStatusUpdate"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LicenseProfileSubscriptionStatusUpdate(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static LicenseProfileSubscriptionStatusUpdate Enable { get; } = new LicenseProfileSubscriptionStatusUpdate(EnableValue);
        /// <summary> Disable. </summary>
        public static LicenseProfileSubscriptionStatusUpdate Disable { get; } = new LicenseProfileSubscriptionStatusUpdate(DisableValue);
        /// <summary> Determines if two <see cref="LicenseProfileSubscriptionStatusUpdate"/> values are the same. </summary>
        public static bool operator ==(LicenseProfileSubscriptionStatusUpdate left, LicenseProfileSubscriptionStatusUpdate right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LicenseProfileSubscriptionStatusUpdate"/> values are not the same. </summary>
        public static bool operator !=(LicenseProfileSubscriptionStatusUpdate left, LicenseProfileSubscriptionStatusUpdate right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LicenseProfileSubscriptionStatusUpdate"/>. </summary>
        public static implicit operator LicenseProfileSubscriptionStatusUpdate(string value) => new LicenseProfileSubscriptionStatusUpdate(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LicenseProfileSubscriptionStatusUpdate other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LicenseProfileSubscriptionStatusUpdate other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
