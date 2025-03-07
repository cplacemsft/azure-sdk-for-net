// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Gateway Type of the resource. </summary>
    public readonly partial struct InternetGatewayType : IEquatable<InternetGatewayType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternetGatewayType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternetGatewayType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InfrastructureValue = "Infrastructure";
        private const string WorkloadValue = "Workload";

        /// <summary> Infrastructure. </summary>
        public static InternetGatewayType Infrastructure { get; } = new InternetGatewayType(InfrastructureValue);
        /// <summary> Workload. </summary>
        public static InternetGatewayType Workload { get; } = new InternetGatewayType(WorkloadValue);
        /// <summary> Determines if two <see cref="InternetGatewayType"/> values are the same. </summary>
        public static bool operator ==(InternetGatewayType left, InternetGatewayType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternetGatewayType"/> values are not the same. </summary>
        public static bool operator !=(InternetGatewayType left, InternetGatewayType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InternetGatewayType"/>. </summary>
        public static implicit operator InternetGatewayType(string value) => new InternetGatewayType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternetGatewayType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternetGatewayType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
