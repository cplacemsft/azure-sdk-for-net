// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class RoutingRuleNextHop : IUtf8JsonSerializable, IJsonModel<RoutingRuleNextHop>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingRuleNextHop>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoutingRuleNextHop>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleNextHop>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleNextHop)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("nextHopType"u8);
            writer.WriteStringValue(NextHopType.ToString());
            if (Optional.IsDefined(NextHopAddress))
            {
                writer.WritePropertyName("nextHopAddress"u8);
                writer.WriteStringValue(NextHopAddress);
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

        RoutingRuleNextHop IJsonModel<RoutingRuleNextHop>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleNextHop>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleNextHop)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingRuleNextHop(document.RootElement, options);
        }

        internal static RoutingRuleNextHop DeserializeRoutingRuleNextHop(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RoutingRuleNextHopType nextHopType = default;
            string nextHopAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextHopType"u8))
                {
                    nextHopType = new RoutingRuleNextHopType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextHopAddress"u8))
                {
                    nextHopAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoutingRuleNextHop(nextHopType, nextHopAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingRuleNextHop>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleNextHop>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleNextHop)} does not support writing '{options.Format}' format.");
            }
        }

        RoutingRuleNextHop IPersistableModel<RoutingRuleNextHop>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleNextHop>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoutingRuleNextHop(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleNextHop)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingRuleNextHop>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
