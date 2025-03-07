// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The authorization use status. </summary>
    public readonly partial struct ExpressRoutePortAuthorizationUseStatus : IEquatable<ExpressRoutePortAuthorizationUseStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpressRoutePortAuthorizationUseStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRoutePortAuthorizationUseStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string InUseValue = "InUse";

        /// <summary> Available. </summary>
        public static ExpressRoutePortAuthorizationUseStatus Available { get; } = new ExpressRoutePortAuthorizationUseStatus(AvailableValue);
        /// <summary> InUse. </summary>
        public static ExpressRoutePortAuthorizationUseStatus InUse { get; } = new ExpressRoutePortAuthorizationUseStatus(InUseValue);
        /// <summary> Determines if two <see cref="ExpressRoutePortAuthorizationUseStatus"/> values are the same. </summary>
        public static bool operator ==(ExpressRoutePortAuthorizationUseStatus left, ExpressRoutePortAuthorizationUseStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRoutePortAuthorizationUseStatus"/> values are not the same. </summary>
        public static bool operator !=(ExpressRoutePortAuthorizationUseStatus left, ExpressRoutePortAuthorizationUseStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExpressRoutePortAuthorizationUseStatus"/>. </summary>
        public static implicit operator ExpressRoutePortAuthorizationUseStatus(string value) => new ExpressRoutePortAuthorizationUseStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRoutePortAuthorizationUseStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRoutePortAuthorizationUseStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
