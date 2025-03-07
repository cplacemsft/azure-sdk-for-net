// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text.Authoring
{
    /// <summary> Represents the state of an export job. </summary>
    public partial class TextAuthoringExportProjectState
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

        /// <summary> Initializes a new instance of <see cref="TextAuthoringExportProjectState"/>. </summary>
        /// <param name="createdOn"> The creation date time of the job. </param>
        /// <param name="lastUpdatedOn"> The last date time the job was updated. </param>
        /// <param name="status"> The job status. </param>
        internal TextAuthoringExportProjectState(DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, TextAuthoringOperationStatus status)
        {
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Status = status;
            Warnings = new ChangeTrackingList<ResponseError>();
            Errors = new ChangeTrackingList<ResponseError>();
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringExportProjectState"/>. </summary>
        /// <param name="jobId"> The job ID. </param>
        /// <param name="createdOn"> The creation date time of the job. </param>
        /// <param name="lastUpdatedOn"> The last date time the job was updated. </param>
        /// <param name="expiresOn"> The expiration date time of the job. </param>
        /// <param name="status"> The job status. </param>
        /// <param name="warnings"> The warnings that were encountered while executing the job. </param>
        /// <param name="errors"> The errors encountered while executing the job. </param>
        /// <param name="resultUrl"> The URL to use in order to download the exported project. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextAuthoringExportProjectState(string jobId, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, DateTimeOffset? expiresOn, TextAuthoringOperationStatus status, IReadOnlyList<ResponseError> warnings, IReadOnlyList<ResponseError> errors, string resultUrl, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobId = jobId;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ExpiresOn = expiresOn;
            Status = status;
            Warnings = warnings;
            Errors = errors;
            ResultUrl = resultUrl;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextAuthoringExportProjectState"/> for deserialization. </summary>
        internal TextAuthoringExportProjectState()
        {
        }

        /// <summary> The job ID. </summary>
        public string JobId { get; }
        /// <summary> The creation date time of the job. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> The last date time the job was updated. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> The expiration date time of the job. </summary>
        public DateTimeOffset? ExpiresOn { get; }
        /// <summary> The job status. </summary>
        public TextAuthoringOperationStatus Status { get; }
        /// <summary> The warnings that were encountered while executing the job. </summary>
        public IReadOnlyList<ResponseError> Warnings { get; }
        /// <summary> The errors encountered while executing the job. </summary>
        public IReadOnlyList<ResponseError> Errors { get; }
        /// <summary> The URL to use in order to download the exported project. </summary>
        public string ResultUrl { get; }
    }
}
