// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Various states of the SSO resource. </summary>
    public readonly partial struct DynatraceSingleSignOnState : IEquatable<DynatraceSingleSignOnState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynatraceSingleSignOnState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynatraceSingleSignOnState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InitialValue = "Initial";
        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";
        private const string ExistingValue = "Existing";

        /// <summary> Initial. </summary>
        public static DynatraceSingleSignOnState Initial { get; } = new DynatraceSingleSignOnState(InitialValue);
        /// <summary> Enable. </summary>
        public static DynatraceSingleSignOnState Enable { get; } = new DynatraceSingleSignOnState(EnableValue);
        /// <summary> Disable. </summary>
        public static DynatraceSingleSignOnState Disable { get; } = new DynatraceSingleSignOnState(DisableValue);
        /// <summary> Existing. </summary>
        public static DynatraceSingleSignOnState Existing { get; } = new DynatraceSingleSignOnState(ExistingValue);
        /// <summary> Determines if two <see cref="DynatraceSingleSignOnState"/> values are the same. </summary>
        public static bool operator ==(DynatraceSingleSignOnState left, DynatraceSingleSignOnState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynatraceSingleSignOnState"/> values are not the same. </summary>
        public static bool operator !=(DynatraceSingleSignOnState left, DynatraceSingleSignOnState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DynatraceSingleSignOnState"/>. </summary>
        public static implicit operator DynatraceSingleSignOnState(string value) => new DynatraceSingleSignOnState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynatraceSingleSignOnState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynatraceSingleSignOnState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
