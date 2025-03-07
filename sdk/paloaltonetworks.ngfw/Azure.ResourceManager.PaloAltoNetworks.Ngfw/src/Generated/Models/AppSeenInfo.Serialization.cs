// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class AppSeenInfo : IUtf8JsonSerializable, IJsonModel<AppSeenInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppSeenInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppSeenInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppSeenInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppSeenInfo)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("title"u8);
            writer.WriteStringValue(Title);
            writer.WritePropertyName("category"u8);
            writer.WriteStringValue(Category);
            writer.WritePropertyName("subCategory"u8);
            writer.WriteStringValue(SubCategory);
            writer.WritePropertyName("risk"u8);
            writer.WriteStringValue(Risk);
            writer.WritePropertyName("tag"u8);
            writer.WriteStringValue(Tag);
            writer.WritePropertyName("technology"u8);
            writer.WriteStringValue(Technology);
            writer.WritePropertyName("standardPorts"u8);
            writer.WriteStringValue(StandardPorts);
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

        AppSeenInfo IJsonModel<AppSeenInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppSeenInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppSeenInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppSeenInfo(document.RootElement, options);
        }

        internal static AppSeenInfo DeserializeAppSeenInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string title = default;
            string category = default;
            string subCategory = default;
            string risk = default;
            string tag = default;
            string technology = default;
            string standardPorts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subCategory"u8))
                {
                    subCategory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("risk"u8))
                {
                    risk = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("technology"u8))
                {
                    technology = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("standardPorts"u8))
                {
                    standardPorts = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppSeenInfo(
                title,
                category,
                subCategory,
                risk,
                tag,
                technology,
                standardPorts,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppSeenInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppSeenInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppSeenInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AppSeenInfo IPersistableModel<AppSeenInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppSeenInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppSeenInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppSeenInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppSeenInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
