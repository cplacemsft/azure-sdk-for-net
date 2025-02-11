// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The type of the target. </summary>
    public readonly partial struct ContainerRegistryPipelineRunTargetType : IEquatable<ContainerRegistryPipelineRunTargetType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryPipelineRunTargetType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryPipelineRunTargetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureStorageBlobValue = "AzureStorageBlob";

        /// <summary> AzureStorageBlob. </summary>
        public static ContainerRegistryPipelineRunTargetType AzureStorageBlob { get; } = new ContainerRegistryPipelineRunTargetType(AzureStorageBlobValue);
        /// <summary> Determines if two <see cref="ContainerRegistryPipelineRunTargetType"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryPipelineRunTargetType left, ContainerRegistryPipelineRunTargetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryPipelineRunTargetType"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryPipelineRunTargetType left, ContainerRegistryPipelineRunTargetType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerRegistryPipelineRunTargetType"/>. </summary>
        public static implicit operator ContainerRegistryPipelineRunTargetType(string value) => new ContainerRegistryPipelineRunTargetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryPipelineRunTargetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryPipelineRunTargetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
