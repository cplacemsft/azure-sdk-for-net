// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Type of action of the operation. </summary>
    public readonly partial struct AppAction : IEquatable<AppAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RestartedValue = "Restarted";
        private const string StoppedValue = "Stopped";
        private const string ChangedAppSettingsValue = "ChangedAppSettings";
        private const string StartedValue = "Started";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";

        /// <summary> Web app was restarted. </summary>
        public static AppAction Restarted { get; } = new AppAction(RestartedValue);
        /// <summary> Web app was stopped. </summary>
        public static AppAction Stopped { get; } = new AppAction(StoppedValue);
        /// <summary> There was an operation to change app setting on the web app. </summary>
        public static AppAction ChangedAppSettings { get; } = new AppAction(ChangedAppSettingsValue);
        /// <summary> The job has started. </summary>
        public static AppAction Started { get; } = new AppAction(StartedValue);
        /// <summary> The job has completed. </summary>
        public static AppAction Completed { get; } = new AppAction(CompletedValue);
        /// <summary> The job has failed to complete. </summary>
        public static AppAction Failed { get; } = new AppAction(FailedValue);
        /// <summary> Determines if two <see cref="AppAction"/> values are the same. </summary>
        public static bool operator ==(AppAction left, AppAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppAction"/> values are not the same. </summary>
        public static bool operator !=(AppAction left, AppAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppAction"/>. </summary>
        public static implicit operator AppAction(string value) => new AppAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
