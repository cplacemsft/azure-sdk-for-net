// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class CloudHsmClusterRestoreContent : IUtf8JsonSerializable, IJsonModel<CloudHsmClusterRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudHsmClusterRestoreContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudHsmClusterRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudHsmClusterRestoreContent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("backupId"u8);
            writer.WriteStringValue(BackupId);
        }

        CloudHsmClusterRestoreContent IJsonModel<CloudHsmClusterRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudHsmClusterRestoreContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudHsmClusterRestoreContent(document.RootElement, options);
        }

        internal static CloudHsmClusterRestoreContent DeserializeCloudHsmClusterRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string backupId = default;
            Uri azureStorageBlobContainerUri = default;
            string token = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupId"u8))
                {
                    backupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureStorageBlobContainerUri"u8))
                {
                    azureStorageBlobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudHsmClusterRestoreContent(azureStorageBlobContainerUri, token, serializedAdditionalRawData, backupId);
        }

        BinaryData IPersistableModel<CloudHsmClusterRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudHsmClusterRestoreContent)} does not support writing '{options.Format}' format.");
            }
        }

        CloudHsmClusterRestoreContent IPersistableModel<CloudHsmClusterRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudHsmClusterRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCloudHsmClusterRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudHsmClusterRestoreContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudHsmClusterRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
