// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class ExportDiskDetails : IUtf8JsonSerializable, IJsonModel<ExportDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportDiskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDiskDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ManifestFile))
            {
                writer.WritePropertyName("manifestFile"u8);
                writer.WriteStringValue(ManifestFile);
            }
            if (options.Format != "W" && Optional.IsDefined(ManifestHash))
            {
                writer.WritePropertyName("manifestHash"u8);
                writer.WriteStringValue(ManifestHash);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupManifestCloudPath))
            {
                writer.WritePropertyName("backupManifestCloudPath"u8);
                writer.WriteStringValue(BackupManifestCloudPath);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExportDiskDetails IJsonModel<ExportDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportDiskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportDiskDetails(document.RootElement, options);
        }

        internal static ExportDiskDetails DeserializeExportDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string manifestFile = default;
            string manifestHash = default;
            string backupManifestCloudPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifestFile"u8))
                {
                    manifestFile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestHash"u8))
                {
                    manifestHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManifestCloudPath"u8))
                {
                    backupManifestCloudPath = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportDiskDetails(manifestFile, manifestHash, backupManifestCloudPath, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExportDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExportDiskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ExportDiskDetails IPersistableModel<ExportDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExportDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportDiskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
