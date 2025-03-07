// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration name availability reason. </summary>
    public readonly partial struct PostgreSqlMigrationNameUnavailableReason : IEquatable<PostgreSqlMigrationNameUnavailableReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationNameUnavailableReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PostgreSqlMigrationNameUnavailableReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AlreadyExistsValue = "AlreadyExists";

        /// <summary> Invalid. </summary>
        public static PostgreSqlMigrationNameUnavailableReason Invalid { get; } = new PostgreSqlMigrationNameUnavailableReason(InvalidValue);
        /// <summary> AlreadyExists. </summary>
        public static PostgreSqlMigrationNameUnavailableReason AlreadyExists { get; } = new PostgreSqlMigrationNameUnavailableReason(AlreadyExistsValue);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationNameUnavailableReason"/> values are the same. </summary>
        public static bool operator ==(PostgreSqlMigrationNameUnavailableReason left, PostgreSqlMigrationNameUnavailableReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PostgreSqlMigrationNameUnavailableReason"/> values are not the same. </summary>
        public static bool operator !=(PostgreSqlMigrationNameUnavailableReason left, PostgreSqlMigrationNameUnavailableReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PostgreSqlMigrationNameUnavailableReason"/>. </summary>
        public static implicit operator PostgreSqlMigrationNameUnavailableReason(string value) => new PostgreSqlMigrationNameUnavailableReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PostgreSqlMigrationNameUnavailableReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PostgreSqlMigrationNameUnavailableReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
