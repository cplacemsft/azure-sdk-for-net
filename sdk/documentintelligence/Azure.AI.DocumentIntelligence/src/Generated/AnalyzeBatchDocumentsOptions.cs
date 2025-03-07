// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Batch document analysis parameters. </summary>
    public partial class AnalyzeBatchDocumentsOptions
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchDocumentsOptions"/>. </summary>
        /// <param name="blobSource">
        /// Azure Blob Storage location containing the batch documents.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </param>
        /// <param name="blobFileListSource">
        /// Azure Blob Storage file list specifying the batch documents.  Either
        /// azureBlobSource or azureBlobFileListSource must be specified.
        /// </param>
        /// <param name="resultContainerUri"> Azure Blob Storage container URL where analyze result files will be stored. </param>
        /// <param name="resultPrefix"> Blob name prefix of result files. </param>
        /// <param name="overwriteExisting"> Overwrite existing analyze result files?. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeBatchDocumentsOptions(BlobContentSource blobSource, BlobFileListContentSource blobFileListSource, Uri resultContainerUri, string resultPrefix, bool? overwriteExisting, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlobSource = blobSource;
            BlobFileListSource = blobFileListSource;
            ResultContainerUri = resultContainerUri;
            ResultPrefix = resultPrefix;
            OverwriteExisting = overwriteExisting;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeBatchDocumentsOptions"/> for deserialization. </summary>
        internal AnalyzeBatchDocumentsOptions()
        {
        }
        /// <summary> Azure Blob Storage container URL where analyze result files will be stored. </summary>
        public Uri ResultContainerUri { get; }
        /// <summary> Blob name prefix of result files. </summary>
        public string ResultPrefix { get; set; }
        /// <summary> Overwrite existing analyze result files?. </summary>
        public bool? OverwriteExisting { get; set; }
    }
}
