// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Tier of an application gateway. </summary>
    public readonly partial struct ApplicationGatewayTier : IEquatable<ApplicationGatewayTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationGatewayTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string WAFValue = "WAF";
        private const string StandardV2Value = "Standard_v2";
        private const string WAFV2Value = "WAF_v2";
        private const string BasicValue = "Basic";

        /// <summary> Standard. </summary>
        public static ApplicationGatewayTier Standard { get; } = new ApplicationGatewayTier(StandardValue);
        /// <summary> WAF. </summary>
        public static ApplicationGatewayTier WAF { get; } = new ApplicationGatewayTier(WAFValue);
        /// <summary> Standard_v2. </summary>
        public static ApplicationGatewayTier StandardV2 { get; } = new ApplicationGatewayTier(StandardV2Value);
        /// <summary> WAF_v2. </summary>
        public static ApplicationGatewayTier WAFV2 { get; } = new ApplicationGatewayTier(WAFV2Value);
        /// <summary> Basic. </summary>
        public static ApplicationGatewayTier Basic { get; } = new ApplicationGatewayTier(BasicValue);
        /// <summary> Determines if two <see cref="ApplicationGatewayTier"/> values are the same. </summary>
        public static bool operator ==(ApplicationGatewayTier left, ApplicationGatewayTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationGatewayTier"/> values are not the same. </summary>
        public static bool operator !=(ApplicationGatewayTier left, ApplicationGatewayTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ApplicationGatewayTier"/>. </summary>
        public static implicit operator ApplicationGatewayTier(string value) => new ApplicationGatewayTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationGatewayTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationGatewayTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
