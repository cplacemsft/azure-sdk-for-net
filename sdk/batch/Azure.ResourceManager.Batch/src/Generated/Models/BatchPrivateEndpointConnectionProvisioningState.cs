// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The provisioning state of the private endpoint connection. </summary>
    public readonly partial struct BatchPrivateEndpointConnectionProvisioningState : IEquatable<BatchPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";

        /// <summary> The connection is creating. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Creating { get; } = new BatchPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> The user has requested that the connection status be updated, but the update operation has not yet completed. You may not reference the connection when connecting the Batch account. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Updating { get; } = new BatchPrivateEndpointConnectionProvisioningState(UpdatingValue);
        /// <summary> The connection is deleting. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Deleting { get; } = new BatchPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> The connection status is final and is ready for use if Status is Approved. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Succeeded { get; } = new BatchPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> The user requested that the connection be updated and it failed. You may retry the update operation. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Failed { get; } = new BatchPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> The user has cancelled the connection creation. </summary>
        public static BatchPrivateEndpointConnectionProvisioningState Cancelled { get; } = new BatchPrivateEndpointConnectionProvisioningState(CancelledValue);
        /// <summary> Determines if two <see cref="BatchPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(BatchPrivateEndpointConnectionProvisioningState left, BatchPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(BatchPrivateEndpointConnectionProvisioningState left, BatchPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator BatchPrivateEndpointConnectionProvisioningState(string value) => new BatchPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
