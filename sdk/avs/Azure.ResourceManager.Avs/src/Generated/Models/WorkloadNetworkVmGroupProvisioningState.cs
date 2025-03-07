// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Workload Network VM Group provisioning state. </summary>
    public readonly partial struct WorkloadNetworkVmGroupProvisioningState : IEquatable<WorkloadNetworkVmGroupProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkVmGroupProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadNetworkVmGroupProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";

        /// <summary> Resource has been created. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Succeeded { get; } = new WorkloadNetworkVmGroupProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Failed { get; } = new WorkloadNetworkVmGroupProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Canceled { get; } = new WorkloadNetworkVmGroupProvisioningState(CanceledValue);
        /// <summary> is building. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Building { get; } = new WorkloadNetworkVmGroupProvisioningState(BuildingValue);
        /// <summary> is deleting. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Deleting { get; } = new WorkloadNetworkVmGroupProvisioningState(DeletingValue);
        /// <summary> is updating. </summary>
        public static WorkloadNetworkVmGroupProvisioningState Updating { get; } = new WorkloadNetworkVmGroupProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="WorkloadNetworkVmGroupProvisioningState"/> values are the same. </summary>
        public static bool operator ==(WorkloadNetworkVmGroupProvisioningState left, WorkloadNetworkVmGroupProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadNetworkVmGroupProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(WorkloadNetworkVmGroupProvisioningState left, WorkloadNetworkVmGroupProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WorkloadNetworkVmGroupProvisioningState"/>. </summary>
        public static implicit operator WorkloadNetworkVmGroupProvisioningState(string value) => new WorkloadNetworkVmGroupProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadNetworkVmGroupProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadNetworkVmGroupProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
