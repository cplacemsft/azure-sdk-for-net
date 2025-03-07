// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Http logs configuration. </summary>
    public partial class AppServiceHttpLogsConfig
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

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpLogsConfig"/>. </summary>
        public AppServiceHttpLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceHttpLogsConfig"/>. </summary>
        /// <param name="fileSystem"> Http logs to file system configuration. </param>
        /// <param name="azureBlobStorage"> Http logs to azure blob storage configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceHttpLogsConfig(FileSystemHttpLogsConfig fileSystem, AppServiceBlobStorageHttpLogsConfig azureBlobStorage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileSystem = fileSystem;
            AzureBlobStorage = azureBlobStorage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Http logs to file system configuration. </summary>
        [WirePath("fileSystem")]
        public FileSystemHttpLogsConfig FileSystem { get; set; }
        /// <summary> Http logs to azure blob storage configuration. </summary>
        [WirePath("azureBlobStorage")]
        public AppServiceBlobStorageHttpLogsConfig AzureBlobStorage { get; set; }
    }
}
