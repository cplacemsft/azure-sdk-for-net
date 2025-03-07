// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Allows you to configure the encoder settings to control the balance between speed and quality. Example: set Complexity as Speed for faster encoding but less compression efficiency. </summary>
    public readonly partial struct EncodingComplexity : IEquatable<EncodingComplexity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncodingComplexity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncodingComplexity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpeedValue = "Speed";
        private const string BalancedValue = "Balanced";
        private const string QualityValue = "Quality";

        /// <summary> Configures the encoder to use settings optimized for faster encoding. Quality is sacrificed to decrease encoding time. </summary>
        public static EncodingComplexity Speed { get; } = new EncodingComplexity(SpeedValue);
        /// <summary> Configures the encoder to use settings that achieve a balance between speed and quality. </summary>
        public static EncodingComplexity Balanced { get; } = new EncodingComplexity(BalancedValue);
        /// <summary> Configures the encoder to use settings optimized to produce higher quality output at the expense of slower overall encode time. </summary>
        public static EncodingComplexity Quality { get; } = new EncodingComplexity(QualityValue);
        /// <summary> Determines if two <see cref="EncodingComplexity"/> values are the same. </summary>
        public static bool operator ==(EncodingComplexity left, EncodingComplexity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncodingComplexity"/> values are not the same. </summary>
        public static bool operator !=(EncodingComplexity left, EncodingComplexity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EncodingComplexity"/>. </summary>
        public static implicit operator EncodingComplexity(string value) => new EncodingComplexity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncodingComplexity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncodingComplexity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
