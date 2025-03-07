// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create compilation job operation. </summary>
    public partial class DscCompilationJobCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="DscCompilationJobCreateOrUpdateContent"/>. </summary>
        /// <param name="configuration"> Gets or sets the configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="configuration"/> is null. </exception>
        public DscCompilationJobCreateOrUpdateContent(DscConfigurationAssociationProperty configuration)
        {
            Argument.AssertNotNull(configuration, nameof(configuration));

            Tags = new ChangeTrackingDictionary<string, string>();
            Configuration = configuration;
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DscCompilationJobCreateOrUpdateContent"/>. </summary>
        /// <param name="name"> Gets or sets name of the resource. </param>
        /// <param name="location"> Gets or sets the location of the resource. </param>
        /// <param name="tags"> Gets or sets the tags attached to the resource. </param>
        /// <param name="configuration"> Gets or sets the configuration. </param>
        /// <param name="parameters"> Gets or sets the parameters of the job. </param>
        /// <param name="isIncrementNodeConfigurationBuildRequired"> If a new build version of NodeConfiguration is required. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscCompilationJobCreateOrUpdateContent(string name, AzureLocation? location, IDictionary<string, string> tags, DscConfigurationAssociationProperty configuration, IDictionary<string, string> parameters, bool? isIncrementNodeConfigurationBuildRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Location = location;
            Tags = tags;
            Configuration = configuration;
            Parameters = parameters;
            IsIncrementNodeConfigurationBuildRequired = isIncrementNodeConfigurationBuildRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DscCompilationJobCreateOrUpdateContent"/> for deserialization. </summary>
        internal DscCompilationJobCreateOrUpdateContent()
        {
        }

        /// <summary> Gets or sets name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the configuration. </summary>
        internal DscConfigurationAssociationProperty Configuration { get; }
        /// <summary> Gets or sets the name of the Dsc configuration. </summary>
        public string ConfigurationName
        {
            get => Configuration?.ConfigurationName;
        }

        /// <summary> Gets or sets the parameters of the job. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> If a new build version of NodeConfiguration is required. </summary>
        public bool? IsIncrementNodeConfigurationBuildRequired { get; set; }
    }
}
