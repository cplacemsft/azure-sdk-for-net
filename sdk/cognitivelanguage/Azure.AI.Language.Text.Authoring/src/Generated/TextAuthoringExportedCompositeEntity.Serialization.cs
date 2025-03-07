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
    public partial class TextAuthoringExportedCompositeEntity : IUtf8JsonSerializable, IJsonModel<TextAuthoringExportedCompositeEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringExportedCompositeEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringExportedCompositeEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedCompositeEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedCompositeEntity)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CompositionSetting))
            {
                writer.WritePropertyName("compositionSetting"u8);
                writer.WriteStringValue(CompositionSetting.Value.ToString());
            }
            if (Optional.IsDefined(List))
            {
                writer.WritePropertyName("list"u8);
                writer.WriteObjectValue(List, options);
            }
            if (Optional.IsCollectionDefined(Prebuilts))
            {
                writer.WritePropertyName("prebuilts"u8);
                writer.WriteStartArray();
                foreach (var item in Prebuilts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
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

        TextAuthoringExportedCompositeEntity IJsonModel<TextAuthoringExportedCompositeEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedCompositeEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringExportedCompositeEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringExportedCompositeEntity(document.RootElement, options);
        }

        internal static TextAuthoringExportedCompositeEntity DeserializeTextAuthoringExportedCompositeEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextAuthoringCompositionMode? compositionSetting = default;
            TextAuthoringExportedEntityList list = default;
            IList<TextAuthoringExportedPrebuiltEntity> prebuilts = default;
            string category = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compositionSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compositionSetting = new TextAuthoringCompositionMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("list"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    list = TextAuthoringExportedEntityList.DeserializeTextAuthoringExportedEntityList(property.Value, options);
                    continue;
                }
                if (property.NameEquals("prebuilts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TextAuthoringExportedPrebuiltEntity> array = new List<TextAuthoringExportedPrebuiltEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAuthoringExportedPrebuiltEntity.DeserializeTextAuthoringExportedPrebuiltEntity(item, options));
                    }
                    prebuilts = array;
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringExportedCompositeEntity(compositionSetting, list, prebuilts ?? new ChangeTrackingList<TextAuthoringExportedPrebuiltEntity>(), category, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringExportedCompositeEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedCompositeEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedCompositeEntity)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringExportedCompositeEntity IPersistableModel<TextAuthoringExportedCompositeEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringExportedCompositeEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringExportedCompositeEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringExportedCompositeEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringExportedCompositeEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringExportedCompositeEntity FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringExportedCompositeEntity(document.RootElement);
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
