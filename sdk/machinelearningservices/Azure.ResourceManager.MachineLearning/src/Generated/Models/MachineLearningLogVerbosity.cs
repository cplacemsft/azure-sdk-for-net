// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Enum for setting log verbosity. </summary>
    public readonly partial struct MachineLearningLogVerbosity : IEquatable<MachineLearningLogVerbosity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningLogVerbosity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningLogVerbosity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSetValue = "NotSet";
        private const string DebugValue = "Debug";
        private const string InfoValue = "Info";
        private const string WarningValue = "Warning";
        private const string ErrorValue = "Error";
        private const string CriticalValue = "Critical";

        /// <summary> No logs emitted. </summary>
        public static MachineLearningLogVerbosity NotSet { get; } = new MachineLearningLogVerbosity(NotSetValue);
        /// <summary> Debug and above log statements logged. </summary>
        public static MachineLearningLogVerbosity Debug { get; } = new MachineLearningLogVerbosity(DebugValue);
        /// <summary> Info and above log statements logged. </summary>
        public static MachineLearningLogVerbosity Info { get; } = new MachineLearningLogVerbosity(InfoValue);
        /// <summary> Warning and above log statements logged. </summary>
        public static MachineLearningLogVerbosity Warning { get; } = new MachineLearningLogVerbosity(WarningValue);
        /// <summary> Error and above log statements logged. </summary>
        public static MachineLearningLogVerbosity Error { get; } = new MachineLearningLogVerbosity(ErrorValue);
        /// <summary> Only critical statements logged. </summary>
        public static MachineLearningLogVerbosity Critical { get; } = new MachineLearningLogVerbosity(CriticalValue);
        /// <summary> Determines if two <see cref="MachineLearningLogVerbosity"/> values are the same. </summary>
        public static bool operator ==(MachineLearningLogVerbosity left, MachineLearningLogVerbosity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningLogVerbosity"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningLogVerbosity left, MachineLearningLogVerbosity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MachineLearningLogVerbosity"/>. </summary>
        public static implicit operator MachineLearningLogVerbosity(string value) => new MachineLearningLogVerbosity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningLogVerbosity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningLogVerbosity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
