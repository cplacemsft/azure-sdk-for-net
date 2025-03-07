// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisEnvironmentReference : IUtf8JsonSerializable, IJsonModel<SsisEnvironmentReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisEnvironmentReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SsisEnvironmentReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisEnvironmentReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisEnvironmentReference)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(EnvironmentFolderName))
            {
                writer.WritePropertyName("environmentFolderName"u8);
                writer.WriteStringValue(EnvironmentFolderName);
            }
            if (Optional.IsDefined(EnvironmentName))
            {
                writer.WritePropertyName("environmentName"u8);
                writer.WriteStringValue(EnvironmentName);
            }
            if (Optional.IsDefined(ReferenceType))
            {
                writer.WritePropertyName("referenceType"u8);
                writer.WriteStringValue(ReferenceType);
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

        SsisEnvironmentReference IJsonModel<SsisEnvironmentReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisEnvironmentReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisEnvironmentReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisEnvironmentReference(document.RootElement, options);
        }

        internal static SsisEnvironmentReference DeserializeSsisEnvironmentReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? id = default;
            string environmentFolderName = default;
            string environmentName = default;
            string referenceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("environmentFolderName"u8))
                {
                    environmentFolderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentName"u8))
                {
                    environmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceType"u8))
                {
                    referenceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SsisEnvironmentReference(id, environmentFolderName, environmentName, referenceType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SsisEnvironmentReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisEnvironmentReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisEnvironmentReference)} does not support writing '{options.Format}' format.");
            }
        }

        SsisEnvironmentReference IPersistableModel<SsisEnvironmentReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisEnvironmentReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSsisEnvironmentReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisEnvironmentReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisEnvironmentReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
