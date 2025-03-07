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
    public partial class DocumentStyle : IUtf8JsonSerializable, IJsonModel<DocumentStyle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentStyle>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentStyle>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStyle)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsHandwritten))
            {
                writer.WritePropertyName("isHandwritten"u8);
                writer.WriteBooleanValue(IsHandwritten.Value);
            }
            if (Optional.IsDefined(SimilarFontFamily))
            {
                writer.WritePropertyName("similarFontFamily"u8);
                writer.WriteStringValue(SimilarFontFamily);
            }
            if (Optional.IsDefined(FontStyle))
            {
                writer.WritePropertyName("fontStyle"u8);
                writer.WriteStringValue(FontStyle.Value.ToString());
            }
            if (Optional.IsDefined(FontWeight))
            {
                writer.WritePropertyName("fontWeight"u8);
                writer.WriteStringValue(FontWeight.Value.ToString());
            }
            if (Optional.IsDefined(Color))
            {
                writer.WritePropertyName("color"u8);
                writer.WriteStringValue(Color);
            }
            if (Optional.IsDefined(BackgroundColor))
            {
                writer.WritePropertyName("backgroundColor"u8);
                writer.WriteStringValue(BackgroundColor);
            }
            writer.WritePropertyName("spans"u8);
            writer.WriteStartArray();
            foreach (var item in Spans)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("confidence"u8);
            writer.WriteNumberValue(Confidence);
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

        DocumentStyle IJsonModel<DocumentStyle>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentStyle)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentStyle(document.RootElement, options);
        }

        internal static DocumentStyle DeserializeDocumentStyle(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isHandwritten = default;
            string similarFontFamily = default;
            DocumentFontStyle? fontStyle = default;
            DocumentFontWeight? fontWeight = default;
            string color = default;
            string backgroundColor = default;
            IReadOnlyList<DocumentSpan> spans = default;
            float confidence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isHandwritten"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHandwritten = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("similarFontFamily"u8))
                {
                    similarFontFamily = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fontStyle"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fontStyle = new DocumentFontStyle(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fontWeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fontWeight = new DocumentFontWeight(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("color"u8))
                {
                    color = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backgroundColor"u8))
                {
                    backgroundColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item, options));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentStyle(
                isHandwritten,
                similarFontFamily,
                fontStyle,
                fontWeight,
                color,
                backgroundColor,
                spans,
                confidence,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentStyle>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentStyle)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentStyle IPersistableModel<DocumentStyle>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentStyle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDocumentStyle(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentStyle)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentStyle>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentStyle FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentStyle(document.RootElement);
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
