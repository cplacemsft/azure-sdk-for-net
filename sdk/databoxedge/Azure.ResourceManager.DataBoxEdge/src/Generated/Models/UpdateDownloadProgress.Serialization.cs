// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UpdateDownloadProgress : IUtf8JsonSerializable, IJsonModel<UpdateDownloadProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateDownloadProgress>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateDownloadProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDownloadProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateDownloadProgress)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(DownloadPhase))
            {
                writer.WritePropertyName("downloadPhase"u8);
                writer.WriteStringValue(DownloadPhase.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalBytesToDownload))
            {
                writer.WritePropertyName("totalBytesToDownload"u8);
                writer.WriteNumberValue(TotalBytesToDownload.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalBytesDownloaded))
            {
                writer.WritePropertyName("totalBytesDownloaded"u8);
                writer.WriteNumberValue(TotalBytesDownloaded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfUpdatesToDownload))
            {
                writer.WritePropertyName("numberOfUpdatesToDownload"u8);
                writer.WriteNumberValue(NumberOfUpdatesToDownload.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfUpdatesDownloaded))
            {
                writer.WritePropertyName("numberOfUpdatesDownloaded"u8);
                writer.WriteNumberValue(NumberOfUpdatesDownloaded.Value);
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

        UpdateDownloadProgress IJsonModel<UpdateDownloadProgress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDownloadProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateDownloadProgress)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateDownloadProgress(document.RootElement, options);
        }

        internal static UpdateDownloadProgress DeserializeUpdateDownloadProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeDownloadPhase? downloadPhase = default;
            int? percentComplete = default;
            double? totalBytesToDownload = default;
            double? totalBytesDownloaded = default;
            int? numberOfUpdatesToDownload = default;
            int? numberOfUpdatesDownloaded = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("downloadPhase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    downloadPhase = new DataBoxEdgeDownloadPhase(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("totalBytesToDownload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesToDownload = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("totalBytesDownloaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesDownloaded = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("numberOfUpdatesToDownload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfUpdatesToDownload = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numberOfUpdatesDownloaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfUpdatesDownloaded = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateDownloadProgress(
                downloadPhase,
                percentComplete,
                totalBytesToDownload,
                totalBytesDownloaded,
                numberOfUpdatesToDownload,
                numberOfUpdatesDownloaded,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateDownloadProgress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDownloadProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateDownloadProgress)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateDownloadProgress IPersistableModel<UpdateDownloadProgress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDownloadProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateDownloadProgress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateDownloadProgress)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateDownloadProgress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
