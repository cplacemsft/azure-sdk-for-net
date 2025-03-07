// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The SynapseDedicatedSqlMinimalTlsSettingName. </summary>
    public readonly partial struct SynapseDedicatedSqlMinimalTlsSettingName : IEquatable<SynapseDedicatedSqlMinimalTlsSettingName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseDedicatedSqlMinimalTlsSettingName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseDedicatedSqlMinimalTlsSettingName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary> default. </summary>
        public static SynapseDedicatedSqlMinimalTlsSettingName Default { get; } = new SynapseDedicatedSqlMinimalTlsSettingName(DefaultValue);
        /// <summary> Determines if two <see cref="SynapseDedicatedSqlMinimalTlsSettingName"/> values are the same. </summary>
        public static bool operator ==(SynapseDedicatedSqlMinimalTlsSettingName left, SynapseDedicatedSqlMinimalTlsSettingName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseDedicatedSqlMinimalTlsSettingName"/> values are not the same. </summary>
        public static bool operator !=(SynapseDedicatedSqlMinimalTlsSettingName left, SynapseDedicatedSqlMinimalTlsSettingName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseDedicatedSqlMinimalTlsSettingName"/>. </summary>
        public static implicit operator SynapseDedicatedSqlMinimalTlsSettingName(string value) => new SynapseDedicatedSqlMinimalTlsSettingName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseDedicatedSqlMinimalTlsSettingName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseDedicatedSqlMinimalTlsSettingName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
