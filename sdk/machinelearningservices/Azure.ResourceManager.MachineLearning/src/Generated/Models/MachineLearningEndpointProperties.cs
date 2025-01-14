// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Inference Endpoint base definition. </summary>
    public partial class MachineLearningEndpointProperties
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointProperties"/>. </summary>
        /// <param name="authMode"> [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does. </param>
        public MachineLearningEndpointProperties(MachineLearningEndpointAuthMode authMode)
        {
            AuthMode = authMode;
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointProperties"/>. </summary>
        /// <param name="authMode"> [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does. </param>
        /// <param name="description"> Description of the inference endpoint. </param>
        /// <param name="keys">
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="scoringUri"> Endpoint URI. </param>
        /// <param name="swaggerUri"> Endpoint Swagger URI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningEndpointProperties(MachineLearningEndpointAuthMode authMode, string description, MachineLearningEndpointAuthKeys keys, IDictionary<string, string> properties, Uri scoringUri, Uri swaggerUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AuthMode = authMode;
            Description = description;
            Keys = keys;
            Properties = properties;
            ScoringUri = scoringUri;
            SwaggerUri = swaggerUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningEndpointProperties"/> for deserialization. </summary>
        internal MachineLearningEndpointProperties()
        {
        }

        /// <summary> [Required] Use 'Key' for key based authentication and 'AMLToken' for Azure Machine Learning token-based authentication. 'Key' doesn't expire but 'AMLToken' does. </summary>
        public MachineLearningEndpointAuthMode AuthMode { get; set; }
        /// <summary> Description of the inference endpoint. </summary>
        public string Description { get; set; }
        /// <summary>
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </summary>
        public MachineLearningEndpointAuthKeys Keys { get; set; }
        /// <summary> Property dictionary. Properties can be added, but not removed or altered. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Endpoint URI. </summary>
        public Uri ScoringUri { get; }
        /// <summary> Endpoint Swagger URI. </summary>
        public Uri SwaggerUri { get; }
    }
}
