// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class EventHubCompatibleEndpointProperties : IUtf8JsonSerializable, IJsonModel<EventHubCompatibleEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubCompatibleEndpointProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventHubCompatibleEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RetentionTimeInDays))
            {
                writer.WritePropertyName("retentionTimeInDays"u8);
                writer.WriteNumberValue(RetentionTimeInDays.Value);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PartitionIds))
            {
                writer.WritePropertyName("partitionIds"u8);
                writer.WriteStartArray();
                foreach (var item in PartitionIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EventHubCompatibleName))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(EventHubCompatibleName);
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
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

        EventHubCompatibleEndpointProperties IJsonModel<EventHubCompatibleEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubCompatibleEndpointProperties(document.RootElement, options);
        }

        internal static EventHubCompatibleEndpointProperties DeserializeEventHubCompatibleEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? retentionTimeInDays = default;
            int? partitionCount = default;
            IReadOnlyList<string> partitionIds = default;
            string path = default;
            string endpoint = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionTimeInDays = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("partitionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partitionIds"u8))
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
                    partitionIds = array;
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventHubCompatibleEndpointProperties(
                retentionTimeInDays,
                partitionCount,
                partitionIds ?? new ChangeTrackingList<string>(),
                path,
                endpoint,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubCompatibleEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support writing '{options.Format}' format.");
            }
        }

        EventHubCompatibleEndpointProperties IPersistableModel<EventHubCompatibleEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubCompatibleEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventHubCompatibleEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubCompatibleEndpointProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubCompatibleEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
