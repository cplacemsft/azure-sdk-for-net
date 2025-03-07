// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Instances of Message represent printf-like trace statements that are text-searched. Log4Net, NLog and other text-based log file entries are translated into instances of this type. The message does not have measurements. </summary>
    internal partial class MessageData : MonitorDomain
    {
        /// <summary> Initializes a new instance of <see cref="MessageData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="message"> Trace message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        public MessageData(int version, string message) : base(version)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Initializes a new instance of <see cref="MessageData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="message"> Trace message. </param>
        /// <param name="severityLevel"> Trace severity level. </param>
        /// <param name="properties"> Collection of custom properties. </param>
        /// <param name="measurements"> Collection of custom measurements. </param>
        internal MessageData(int version, IDictionary<string, object> additionalProperties, string message, SeverityLevel? severityLevel, IDictionary<string, string> properties, IDictionary<string, double> measurements) : base(version, additionalProperties)
        {
            Message = message;
            SeverityLevel = severityLevel;
            Properties = properties;
            Measurements = measurements;
        }

        /// <summary> Trace message. </summary>
        public string Message { get; }
        /// <summary> Trace severity level. </summary>
        public SeverityLevel? SeverityLevel { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
