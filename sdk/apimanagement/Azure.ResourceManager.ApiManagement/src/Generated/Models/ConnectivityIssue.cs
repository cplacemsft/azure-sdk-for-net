// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Information about an issue encountered in the process of checking for connectivity. </summary>
    public partial class ConnectivityIssue
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityIssue"/>. </summary>
        internal ConnectivityIssue()
        {
            Context = new ChangeTrackingList<IDictionary<string, string>>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityIssue"/>. </summary>
        /// <param name="origin"> The origin of the issue. </param>
        /// <param name="severity"> The severity of the issue. </param>
        /// <param name="issueType"> The type of issue. </param>
        /// <param name="context"> Provides additional context on the issue. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityIssue(IssueOrigin? origin, IssueSeverity? severity, IssueType? issueType, IReadOnlyList<IDictionary<string, string>> context, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Origin = origin;
            Severity = severity;
            IssueType = issueType;
            Context = context;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The origin of the issue. </summary>
        [WirePath("origin")]
        public IssueOrigin? Origin { get; }
        /// <summary> The severity of the issue. </summary>
        [WirePath("severity")]
        public IssueSeverity? Severity { get; }
        /// <summary> The type of issue. </summary>
        [WirePath("type")]
        public IssueType? IssueType { get; }
        /// <summary> Provides additional context on the issue. </summary>
        [WirePath("context")]
        public IReadOnlyList<IDictionary<string, string>> Context { get; }
    }
}
