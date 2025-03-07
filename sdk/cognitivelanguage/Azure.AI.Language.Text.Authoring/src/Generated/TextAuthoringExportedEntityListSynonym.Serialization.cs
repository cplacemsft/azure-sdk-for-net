// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class TextAuthoringExportedEntityListSynonym : IUtf8JsonSerializable, IJsonModel<TextAuthoringExportedEntityListSynonym>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringExportedEntityListSynonym>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringExportedEntityListSynonym>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedEntityListSynonym>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedEntityListSynonym)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsCollectionDefined(Values))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        TextAuthoringExportedEntityListSynonym IJsonModel<TextAuthoringExportedEntityListSynonym>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedEntityListSynonym>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedEntityListSynonym)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringExportedEntityListSynonym(document.RootElement, options);
        }

        internal static TextAuthoringExportedEntityListSynonym DeserializeTextAuthoringExportedEntityListSynonym(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string language = default;
            IList<string> values = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    values = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringExportedEntityListSynonym(language, values ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringExportedEntityListSynonym>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedEntityListSynonym>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedEntityListSynonym)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringExportedEntityListSynonym IPersistableModel<TextAuthoringExportedEntityListSynonym>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedEntityListSynonym>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringExportedEntityListSynonym(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedEntityListSynonym)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringExportedEntityListSynonym>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringExportedEntityListSynonym FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringExportedEntityListSynonym(document.RootElement);
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
