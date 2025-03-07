// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingEndpointListResult : IUtf8JsonSerializable, IJsonModel<StreamingEndpointListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingEndpointListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingEndpointListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingEndpointListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OdataCount))
            {
                writer.WritePropertyName("@odata.count"u8);
                writer.WriteNumberValue(OdataCount.Value);
            }
            if (Optional.IsDefined(OdataNextLink))
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(OdataNextLink);
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

        StreamingEndpointListResult IJsonModel<StreamingEndpointListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingEndpointListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingEndpointListResult(document.RootElement, options);
        }

        internal static StreamingEndpointListResult DeserializeStreamingEndpointListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<StreamingEndpointData> value = default;
            int? odataCount = default;
            string odataNextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingEndpointData> array = new List<StreamingEndpointData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingEndpointData.DeserializeStreamingEndpointData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    odataCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamingEndpointListResult(value ?? new ChangeTrackingList<StreamingEndpointData>(), odataCount, odataNextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingEndpointListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingEndpointListResult)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingEndpointListResult IPersistableModel<StreamingEndpointListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingEndpointListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingEndpointListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingEndpointListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingEndpointListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
