// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Gets the Operating System type. </summary>
    public readonly partial struct OperatingSystemType : IEquatable<OperatingSystemType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OperatingSystemType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperatingSystemType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";

        /// <summary> Windows. </summary>
        public static OperatingSystemType Windows { get; } = new OperatingSystemType(WindowsValue);
        /// <summary> Linux. </summary>
        public static OperatingSystemType Linux { get; } = new OperatingSystemType(LinuxValue);
        /// <summary> Determines if two <see cref="OperatingSystemType"/> values are the same. </summary>
        public static bool operator ==(OperatingSystemType left, OperatingSystemType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperatingSystemType"/> values are not the same. </summary>
        public static bool operator !=(OperatingSystemType left, OperatingSystemType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OperatingSystemType"/>. </summary>
        public static implicit operator OperatingSystemType(string value) => new OperatingSystemType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperatingSystemType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperatingSystemType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
