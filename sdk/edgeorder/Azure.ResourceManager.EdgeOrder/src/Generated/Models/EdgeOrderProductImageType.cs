// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Type of the image. </summary>
    public readonly partial struct EdgeOrderProductImageType : IEquatable<EdgeOrderProductImageType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductImageType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EdgeOrderProductImageType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MainImageValue = "MainImage";
        private const string BulletImageValue = "BulletImage";
        private const string GenericImageValue = "GenericImage";

        /// <summary> Main image. </summary>
        public static EdgeOrderProductImageType MainImage { get; } = new EdgeOrderProductImageType(MainImageValue);
        /// <summary> Bullet image. </summary>
        public static EdgeOrderProductImageType BulletImage { get; } = new EdgeOrderProductImageType(BulletImageValue);
        /// <summary> Generic image. </summary>
        public static EdgeOrderProductImageType GenericImage { get; } = new EdgeOrderProductImageType(GenericImageValue);
        /// <summary> Determines if two <see cref="EdgeOrderProductImageType"/> values are the same. </summary>
        public static bool operator ==(EdgeOrderProductImageType left, EdgeOrderProductImageType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EdgeOrderProductImageType"/> values are not the same. </summary>
        public static bool operator !=(EdgeOrderProductImageType left, EdgeOrderProductImageType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EdgeOrderProductImageType"/>. </summary>
        public static implicit operator EdgeOrderProductImageType(string value) => new EdgeOrderProductImageType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EdgeOrderProductImageType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EdgeOrderProductImageType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
