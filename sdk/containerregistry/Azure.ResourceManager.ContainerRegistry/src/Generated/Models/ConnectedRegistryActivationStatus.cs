// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The activation status of the connected registry. </summary>
    public readonly partial struct ConnectedRegistryActivationStatus : IEquatable<ConnectedRegistryActivationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectedRegistryActivationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectedRegistryActivationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string InactiveValue = "Inactive";

        /// <summary> Active. </summary>
        public static ConnectedRegistryActivationStatus Active { get; } = new ConnectedRegistryActivationStatus(ActiveValue);
        /// <summary> Inactive. </summary>
        public static ConnectedRegistryActivationStatus Inactive { get; } = new ConnectedRegistryActivationStatus(InactiveValue);
        /// <summary> Determines if two <see cref="ConnectedRegistryActivationStatus"/> values are the same. </summary>
        public static bool operator ==(ConnectedRegistryActivationStatus left, ConnectedRegistryActivationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectedRegistryActivationStatus"/> values are not the same. </summary>
        public static bool operator !=(ConnectedRegistryActivationStatus left, ConnectedRegistryActivationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConnectedRegistryActivationStatus"/>. </summary>
        public static implicit operator ConnectedRegistryActivationStatus(string value) => new ConnectedRegistryActivationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectedRegistryActivationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectedRegistryActivationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
