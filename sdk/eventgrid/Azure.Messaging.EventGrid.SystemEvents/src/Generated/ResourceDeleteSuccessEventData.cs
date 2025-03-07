// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Resources.ResourceDeleteSuccess event. This is raised when a resource delete operation succeeds. </summary>
    public partial class ResourceDeleteSuccessEventData
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

        /// <summary> Initializes a new instance of <see cref="ResourceDeleteSuccessEventData"/>. </summary>
        /// <param name="authorization"> The requested authorization for the operation. </param>
        /// <param name="claims"> The properties of the claims. </param>
        /// <param name="httpRequest"> The details of the operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorization"/>, <paramref name="claims"/> or <paramref name="httpRequest"/> is null. </exception>
        internal ResourceDeleteSuccessEventData(ResourceAuthorization authorization, IReadOnlyDictionary<string, string> claims, ResourceHttpRequest httpRequest)
        {
            Argument.AssertNotNull(authorization, nameof(authorization));
            Argument.AssertNotNull(claims, nameof(claims));
            Argument.AssertNotNull(httpRequest, nameof(httpRequest));

            Authorization = authorization;
            Claims = claims;
            HttpRequest = httpRequest;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceDeleteSuccessEventData"/>. </summary>
        /// <param name="tenantId"> The tenant ID of the resource. </param>
        /// <param name="subscriptionId"> The subscription ID of the resource. </param>
        /// <param name="resourceGroup"> The resource group of the resource. </param>
        /// <param name="resourceProvider"> The resource provider performing the operation. </param>
        /// <param name="resourceUri"> The URI of the resource in the operation. </param>
        /// <param name="operationName"> The operation that was performed. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="authorization"> The requested authorization for the operation. </param>
        /// <param name="claims"> The properties of the claims. </param>
        /// <param name="correlationId"> An operation ID used for troubleshooting. </param>
        /// <param name="httpRequest"> The details of the operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceDeleteSuccessEventData(string tenantId, string subscriptionId, string resourceGroup, string resourceProvider, string resourceUri, string operationName, string status, ResourceAuthorization authorization, IReadOnlyDictionary<string, string> claims, string correlationId, ResourceHttpRequest httpRequest, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            ResourceProvider = resourceProvider;
            ResourceUri = resourceUri;
            OperationName = operationName;
            Status = status;
            Authorization = authorization;
            Claims = claims;
            CorrelationId = correlationId;
            HttpRequest = httpRequest;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceDeleteSuccessEventData"/> for deserialization. </summary>
        internal ResourceDeleteSuccessEventData()
        {
        }

        /// <summary> The tenant ID of the resource. </summary>
        public string TenantId { get; }
        /// <summary> The subscription ID of the resource. </summary>
        public string SubscriptionId { get; }
        /// <summary> The resource group of the resource. </summary>
        public string ResourceGroup { get; }
        /// <summary> The resource provider performing the operation. </summary>
        public string ResourceProvider { get; }
        /// <summary> The URI of the resource in the operation. </summary>
        public string ResourceUri { get; }
        /// <summary> The operation that was performed. </summary>
        public string OperationName { get; }
        /// <summary> The status of the operation. </summary>
        public string Status { get; }
        /// <summary> The requested authorization for the operation. </summary>
        public ResourceAuthorization Authorization { get; }
        /// <summary> The properties of the claims. </summary>
        public IReadOnlyDictionary<string, string> Claims { get; }
        /// <summary> An operation ID used for troubleshooting. </summary>
        public string CorrelationId { get; }
        /// <summary> The details of the operation. </summary>
        public ResourceHttpRequest HttpRequest { get; }
    }
}
