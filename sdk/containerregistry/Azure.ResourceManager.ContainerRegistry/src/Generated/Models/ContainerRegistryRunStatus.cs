// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The current status of the run. </summary>
    public readonly partial struct ContainerRegistryRunStatus : IEquatable<ContainerRegistryRunStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryRunStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerRegistryRunStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueuedValue = "Queued";
        private const string StartedValue = "Started";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ErrorValue = "Error";
        private const string TimeoutValue = "Timeout";

        /// <summary> Queued. </summary>
        public static ContainerRegistryRunStatus Queued { get; } = new ContainerRegistryRunStatus(QueuedValue);
        /// <summary> Started. </summary>
        public static ContainerRegistryRunStatus Started { get; } = new ContainerRegistryRunStatus(StartedValue);
        /// <summary> Running. </summary>
        public static ContainerRegistryRunStatus Running { get; } = new ContainerRegistryRunStatus(RunningValue);
        /// <summary> Succeeded. </summary>
        public static ContainerRegistryRunStatus Succeeded { get; } = new ContainerRegistryRunStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static ContainerRegistryRunStatus Failed { get; } = new ContainerRegistryRunStatus(FailedValue);
        /// <summary> Canceled. </summary>
        public static ContainerRegistryRunStatus Canceled { get; } = new ContainerRegistryRunStatus(CanceledValue);
        /// <summary> Error. </summary>
        public static ContainerRegistryRunStatus Error { get; } = new ContainerRegistryRunStatus(ErrorValue);
        /// <summary> Timeout. </summary>
        public static ContainerRegistryRunStatus Timeout { get; } = new ContainerRegistryRunStatus(TimeoutValue);
        /// <summary> Determines if two <see cref="ContainerRegistryRunStatus"/> values are the same. </summary>
        public static bool operator ==(ContainerRegistryRunStatus left, ContainerRegistryRunStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerRegistryRunStatus"/> values are not the same. </summary>
        public static bool operator !=(ContainerRegistryRunStatus left, ContainerRegistryRunStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerRegistryRunStatus"/>. </summary>
        public static implicit operator ContainerRegistryRunStatus(string value) => new ContainerRegistryRunStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerRegistryRunStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerRegistryRunStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
