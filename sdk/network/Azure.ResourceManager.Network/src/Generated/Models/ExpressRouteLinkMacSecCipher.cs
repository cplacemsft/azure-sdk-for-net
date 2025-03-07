// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Mac security cipher. </summary>
    public readonly partial struct ExpressRouteLinkMacSecCipher : IEquatable<ExpressRouteLinkMacSecCipher>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpressRouteLinkMacSecCipher"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRouteLinkMacSecCipher(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string GcmAes256Value = "GcmAes256";
        private const string GcmAes128Value = "GcmAes128";
        private const string GcmAesXpn128Value = "GcmAesXpn128";
        private const string GcmAesXpn256Value = "GcmAesXpn256";

        /// <summary> GcmAes256. </summary>
        public static ExpressRouteLinkMacSecCipher GcmAes256 { get; } = new ExpressRouteLinkMacSecCipher(GcmAes256Value);
        /// <summary> GcmAes128. </summary>
        public static ExpressRouteLinkMacSecCipher GcmAes128 { get; } = new ExpressRouteLinkMacSecCipher(GcmAes128Value);
        /// <summary> GcmAesXpn128. </summary>
        public static ExpressRouteLinkMacSecCipher GcmAesXpn128 { get; } = new ExpressRouteLinkMacSecCipher(GcmAesXpn128Value);
        /// <summary> GcmAesXpn256. </summary>
        public static ExpressRouteLinkMacSecCipher GcmAesXpn256 { get; } = new ExpressRouteLinkMacSecCipher(GcmAesXpn256Value);
        /// <summary> Determines if two <see cref="ExpressRouteLinkMacSecCipher"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteLinkMacSecCipher left, ExpressRouteLinkMacSecCipher right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteLinkMacSecCipher"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteLinkMacSecCipher left, ExpressRouteLinkMacSecCipher right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExpressRouteLinkMacSecCipher"/>. </summary>
        public static implicit operator ExpressRouteLinkMacSecCipher(string value) => new ExpressRouteLinkMacSecCipher(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteLinkMacSecCipher other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteLinkMacSecCipher other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
