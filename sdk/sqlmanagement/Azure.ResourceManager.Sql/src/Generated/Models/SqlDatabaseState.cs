// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The SqlDatabaseState. </summary>
    public readonly partial struct SqlDatabaseState : IEquatable<SqlDatabaseState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlDatabaseState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlDatabaseState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllValue = "All";
        private const string LiveValue = "Live";
        private const string DeletedValue = "Deleted";

        /// <summary> All. </summary>
        public static SqlDatabaseState All { get; } = new SqlDatabaseState(AllValue);
        /// <summary> Live. </summary>
        public static SqlDatabaseState Live { get; } = new SqlDatabaseState(LiveValue);
        /// <summary> Deleted. </summary>
        public static SqlDatabaseState Deleted { get; } = new SqlDatabaseState(DeletedValue);
        /// <summary> Determines if two <see cref="SqlDatabaseState"/> values are the same. </summary>
        public static bool operator ==(SqlDatabaseState left, SqlDatabaseState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlDatabaseState"/> values are not the same. </summary>
        public static bool operator !=(SqlDatabaseState left, SqlDatabaseState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlDatabaseState"/>. </summary>
        public static implicit operator SqlDatabaseState(string value) => new SqlDatabaseState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlDatabaseState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlDatabaseState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
