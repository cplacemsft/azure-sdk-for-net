// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Web.BackupOperationFailed event. </summary>
    public partial class WebBackupOperationFailedEventData
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

        /// <summary> Initializes a new instance of <see cref="WebBackupOperationFailedEventData"/>. </summary>
        /// <param name="appEventTypeDetail"> Detail of action on the app. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appEventTypeDetail"/> is null. </exception>
        internal WebBackupOperationFailedEventData(AppEventTypeDetail appEventTypeDetail)
        {
            Argument.AssertNotNull(appEventTypeDetail, nameof(appEventTypeDetail));

            AppEventTypeDetail = appEventTypeDetail;
        }

        /// <summary> Initializes a new instance of <see cref="WebBackupOperationFailedEventData"/>. </summary>
        /// <param name="appEventTypeDetail"> Detail of action on the app. </param>
        /// <param name="name"> name of the web site that had this event. </param>
        /// <param name="clientRequestId"> The client request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="correlationRequestId"> The correlation request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the app service for the site API operation that triggered this event. </param>
        /// <param name="address"> HTTP request URL of this operation. </param>
        /// <param name="verb"> HTTP verb of this operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebBackupOperationFailedEventData(AppEventTypeDetail appEventTypeDetail, string name, string clientRequestId, string correlationRequestId, string requestId, string address, string verb, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppEventTypeDetail = appEventTypeDetail;
            Name = name;
            ClientRequestId = clientRequestId;
            CorrelationRequestId = correlationRequestId;
            RequestId = requestId;
            Address = address;
            Verb = verb;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebBackupOperationFailedEventData"/> for deserialization. </summary>
        internal WebBackupOperationFailedEventData()
        {
        }

        /// <summary> Detail of action on the app. </summary>
        public AppEventTypeDetail AppEventTypeDetail { get; }
        /// <summary> name of the web site that had this event. </summary>
        public string Name { get; }
        /// <summary> The client request id generated by the app service for the site API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The correlation request id generated by the app service for the site API operation that triggered this event. </summary>
        public string CorrelationRequestId { get; }
        /// <summary> The request id generated by the app service for the site API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> HTTP request URL of this operation. </summary>
        public string Address { get; }
        /// <summary> HTTP verb of this operation. </summary>
        public string Verb { get; }
    }
}
