// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class DiscoveryGroup : IUtf8JsonSerializable, IJsonModel<DiscoveryGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiscoveryGroup>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiscoveryGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryGroup)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (Optional.IsDefined(FrequencyMilliseconds))
            {
                writer.WritePropertyName("frequencyMilliseconds"u8);
                writer.WriteNumberValue(FrequencyMilliseconds.Value);
            }
            if (Optional.IsCollectionDefined(Seeds))
            {
                writer.WritePropertyName("seeds"u8);
                writer.WriteStartArray();
                foreach (var item in Seeds)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Names))
            {
                writer.WritePropertyName("names"u8);
                writer.WriteStartArray();
                foreach (var item in Names)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Excludes))
            {
                writer.WritePropertyName("excludes"u8);
                writer.WriteStartArray();
                foreach (var item in Excludes)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LatestRun))
            {
                writer.WritePropertyName("latestRun"u8);
                writer.WriteObjectValue(LatestRun, options);
            }
            if (Optional.IsDefined(CreatedDate))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedDate.Value, "O");
            }
            if (Optional.IsDefined(TemplateId))
            {
                writer.WritePropertyName("templateId"u8);
                writer.WriteStringValue(TemplateId);
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

        DiscoveryGroup IJsonModel<DiscoveryGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiscoveryGroup)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiscoveryGroup(document.RootElement, options);
        }

        internal static DiscoveryGroup DeserializeDiscoveryGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            string displayName = default;
            string description = default;
            string tier = default;
            long? frequencyMilliseconds = default;
            IReadOnlyList<DiscoverySource> seeds = default;
            IReadOnlyList<string> names = default;
            IReadOnlyList<DiscoverySource> excludes = default;
            DiscoveryRunResult latestRun = default;
            DateTimeOffset? createdDate = default;
            string templateId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("frequencyMilliseconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyMilliseconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("seeds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    seeds = array;
                    continue;
                }
                if (property.NameEquals("names"u8))
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
                    names = array;
                    continue;
                }
                if (property.NameEquals("excludes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoverySource> array = new List<DiscoverySource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoverySource.DeserializeDiscoverySource(item, options));
                    }
                    excludes = array;
                    continue;
                }
                if (property.NameEquals("latestRun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latestRun = DiscoveryRunResult.DeserializeDiscoveryRunResult(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("templateId"u8))
                {
                    templateId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DiscoveryGroup(
                id,
                name,
                displayName,
                description,
                tier,
                frequencyMilliseconds,
                seeds ?? new ChangeTrackingList<DiscoverySource>(),
                names ?? new ChangeTrackingList<string>(),
                excludes ?? new ChangeTrackingList<DiscoverySource>(),
                latestRun,
                createdDate,
                templateId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiscoveryGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiscoveryGroup)} does not support writing '{options.Format}' format.");
            }
        }

        DiscoveryGroup IPersistableModel<DiscoveryGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiscoveryGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDiscoveryGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiscoveryGroup)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiscoveryGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DiscoveryGroup FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDiscoveryGroup(document.RootElement);
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
