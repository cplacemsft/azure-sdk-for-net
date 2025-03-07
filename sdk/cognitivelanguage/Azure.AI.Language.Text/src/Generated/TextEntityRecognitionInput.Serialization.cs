// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class TextEntityRecognitionInput : IUtf8JsonSerializable, IJsonModel<TextEntityRecognitionInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextEntityRecognitionInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextEntityRecognitionInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextEntityRecognitionInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextEntityRecognitionInput)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(TextInput))
            {
                writer.WritePropertyName("analysisInput"u8);
                writer.WriteObjectValue(TextInput, options);
            }
            if (Optional.IsDefined(ActionContent))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(ActionContent, options);
            }
        }

        TextEntityRecognitionInput IJsonModel<TextEntityRecognitionInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextEntityRecognitionInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextEntityRecognitionInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextEntityRecognitionInput(document.RootElement, options);
        }

        internal static TextEntityRecognitionInput DeserializeTextEntityRecognitionInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MultiLanguageTextInput analysisInput = default;
            EntitiesActionContent parameters = default;
            AnalyzeTextInputKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("analysisInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analysisInput = MultiLanguageTextInput.DeserializeMultiLanguageTextInput(property.Value, options);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = EntitiesActionContent.DeserializeEntitiesActionContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextInputKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextEntityRecognitionInput(kind, serializedAdditionalRawData, analysisInput, parameters);
        }

        BinaryData IPersistableModel<TextEntityRecognitionInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextEntityRecognitionInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextEntityRecognitionInput)} does not support writing '{options.Format}' format.");
            }
        }

        TextEntityRecognitionInput IPersistableModel<TextEntityRecognitionInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextEntityRecognitionInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextEntityRecognitionInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextEntityRecognitionInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextEntityRecognitionInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new TextEntityRecognitionInput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextEntityRecognitionInput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
