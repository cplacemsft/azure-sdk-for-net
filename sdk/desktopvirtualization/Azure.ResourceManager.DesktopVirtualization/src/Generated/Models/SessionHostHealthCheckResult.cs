// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents the Health state of the health check we performed. </summary>
    public readonly partial struct SessionHostHealthCheckResult : IEquatable<SessionHostHealthCheckResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionHostHealthCheckResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionHostHealthCheckResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string HealthCheckSucceededValue = "HealthCheckSucceeded";
        private const string HealthCheckFailedValue = "HealthCheckFailed";
        private const string SessionHostShutdownValue = "SessionHostShutdown";

        /// <summary> Health check result is not currently known. </summary>
        public static SessionHostHealthCheckResult Unknown { get; } = new SessionHostHealthCheckResult(UnknownValue);
        /// <summary> Health check passed. </summary>
        public static SessionHostHealthCheckResult HealthCheckSucceeded { get; } = new SessionHostHealthCheckResult(HealthCheckSucceededValue);
        /// <summary> Health check failed. </summary>
        public static SessionHostHealthCheckResult HealthCheckFailed { get; } = new SessionHostHealthCheckResult(HealthCheckFailedValue);
        /// <summary> We received a Shutdown notification. </summary>
        public static SessionHostHealthCheckResult SessionHostShutdown { get; } = new SessionHostHealthCheckResult(SessionHostShutdownValue);
        /// <summary> Determines if two <see cref="SessionHostHealthCheckResult"/> values are the same. </summary>
        public static bool operator ==(SessionHostHealthCheckResult left, SessionHostHealthCheckResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionHostHealthCheckResult"/> values are not the same. </summary>
        public static bool operator !=(SessionHostHealthCheckResult left, SessionHostHealthCheckResult right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SessionHostHealthCheckResult"/>. </summary>
        public static implicit operator SessionHostHealthCheckResult(string value) => new SessionHostHealthCheckResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionHostHealthCheckResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionHostHealthCheckResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
