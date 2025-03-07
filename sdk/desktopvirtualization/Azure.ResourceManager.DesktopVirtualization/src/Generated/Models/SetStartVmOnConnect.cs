// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The desired configuration of Start VM On Connect for the hostpool during the ramp up phase. If this is disabled, session hosts must be turned on using rampUpAutoStartHosts or by turning them on manually. </summary>
    public readonly partial struct SetStartVmOnConnect : IEquatable<SetStartVmOnConnect>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SetStartVmOnConnect"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SetStartVmOnConnect(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static SetStartVmOnConnect Enable { get; } = new SetStartVmOnConnect(EnableValue);
        /// <summary> Disable. </summary>
        public static SetStartVmOnConnect Disable { get; } = new SetStartVmOnConnect(DisableValue);
        /// <summary> Determines if two <see cref="SetStartVmOnConnect"/> values are the same. </summary>
        public static bool operator ==(SetStartVmOnConnect left, SetStartVmOnConnect right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SetStartVmOnConnect"/> values are not the same. </summary>
        public static bool operator !=(SetStartVmOnConnect left, SetStartVmOnConnect right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SetStartVmOnConnect"/>. </summary>
        public static implicit operator SetStartVmOnConnect(string value) => new SetStartVmOnConnect(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SetStartVmOnConnect other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SetStartVmOnConnect other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
