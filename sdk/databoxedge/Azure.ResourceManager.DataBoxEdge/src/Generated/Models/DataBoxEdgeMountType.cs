// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Mounting type. </summary>
    public readonly partial struct DataBoxEdgeMountType : IEquatable<DataBoxEdgeMountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeMountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeMountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VolumeValue = "Volume";
        private const string HostPathValue = "HostPath";

        /// <summary> Volume. </summary>
        public static DataBoxEdgeMountType Volume { get; } = new DataBoxEdgeMountType(VolumeValue);
        /// <summary> HostPath. </summary>
        public static DataBoxEdgeMountType HostPath { get; } = new DataBoxEdgeMountType(HostPathValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeMountType"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeMountType left, DataBoxEdgeMountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeMountType"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeMountType left, DataBoxEdgeMountType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxEdgeMountType"/>. </summary>
        public static implicit operator DataBoxEdgeMountType(string value) => new DataBoxEdgeMountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeMountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeMountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
