// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Determines the type of the dialog. </summary>
    public readonly partial struct DialogInputType : IEquatable<DialogInputType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DialogInputType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DialogInputType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PowerVirtualAgentsValue = "powerVirtualAgents";
        private const string AzureOpenAIValue = "azureOpenAI";

        /// <summary> powerVirtualAgents. </summary>
        public static DialogInputType PowerVirtualAgents { get; } = new DialogInputType(PowerVirtualAgentsValue);
        /// <summary> azureOpenAI. </summary>
        public static DialogInputType AzureOpenAI { get; } = new DialogInputType(AzureOpenAIValue);
        /// <summary> Determines if two <see cref="DialogInputType"/> values are the same. </summary>
        public static bool operator ==(DialogInputType left, DialogInputType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DialogInputType"/> values are not the same. </summary>
        public static bool operator !=(DialogInputType left, DialogInputType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DialogInputType"/>. </summary>
        public static implicit operator DialogInputType(string value) => new DialogInputType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DialogInputType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DialogInputType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
