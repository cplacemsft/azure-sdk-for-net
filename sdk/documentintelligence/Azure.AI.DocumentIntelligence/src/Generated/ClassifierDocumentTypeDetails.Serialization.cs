// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class ClassifierDocumentTypeDetails : IUtf8JsonSerializable, IJsonModel<ClassifierDocumentTypeDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClassifierDocumentTypeDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClassifierDocumentTypeDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassifierDocumentTypeDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassifierDocumentTypeDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SourceKind))
            {
                writer.WritePropertyName("sourceKind"u8);
                writer.WriteStringValue(SourceKind.Value.ToString());
            }
            if (Optional.IsDefined(BlobSource))
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue<BlobContentSource>(BlobSource, options);
            }
            if (Optional.IsDefined(BlobFileListSource))
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue<BlobFileListContentSource>(BlobFileListSource, options);
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

        ClassifierDocumentTypeDetails IJsonModel<ClassifierDocumentTypeDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassifierDocumentTypeDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClassifierDocumentTypeDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClassifierDocumentTypeDetails(document.RootElement, options);
        }

        internal static ClassifierDocumentTypeDetails DeserializeClassifierDocumentTypeDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContentSourceKind? sourceKind = default;
            BlobContentSource azureBlobSource = default;
            BlobFileListContentSource azureBlobFileListSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceKind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceKind = new ContentSourceKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = BlobContentSource.DeserializeBlobContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = BlobFileListContentSource.DeserializeBlobFileListContentSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClassifierDocumentTypeDetails(sourceKind, azureBlobSource, azureBlobFileListSource, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClassifierDocumentTypeDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassifierDocumentTypeDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClassifierDocumentTypeDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ClassifierDocumentTypeDetails IPersistableModel<ClassifierDocumentTypeDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClassifierDocumentTypeDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClassifierDocumentTypeDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClassifierDocumentTypeDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClassifierDocumentTypeDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ClassifierDocumentTypeDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeClassifierDocumentTypeDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
