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
    public partial class VirtualHubEffectiveRoute : IUtf8JsonSerializable, IJsonModel<VirtualHubEffectiveRoute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualHubEffectiveRoute>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualHubEffectiveRoute>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NextHops))
            {
                writer.WritePropertyName("nextHops"u8);
                writer.WriteStartArray();
                foreach (var item in NextHops)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextHopType))
            {
                writer.WritePropertyName("nextHopType"u8);
                writer.WriteStringValue(NextHopType);
            }
            if (Optional.IsDefined(AsPath))
            {
                writer.WritePropertyName("asPath"u8);
                writer.WriteStringValue(AsPath);
            }
            if (Optional.IsDefined(RouteOrigin))
            {
                writer.WritePropertyName("routeOrigin"u8);
                writer.WriteStringValue(RouteOrigin);
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

        VirtualHubEffectiveRoute IJsonModel<VirtualHubEffectiveRoute>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualHubEffectiveRoute(document.RootElement, options);
        }

        internal static VirtualHubEffectiveRoute DeserializeVirtualHubEffectiveRoute(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> addressPrefixes = default;
            IReadOnlyList<string> nextHops = default;
            string nextHopType = default;
            string asPath = default;
            string routeOrigin = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressPrefixes"u8))
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
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("nextHops"u8))
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
                    nextHops = array;
                    continue;
                }
                if (property.NameEquals("nextHopType"u8))
                {
                    nextHopType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asPath"u8))
                {
                    asPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routeOrigin"u8))
                {
                    routeOrigin = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualHubEffectiveRoute(
                addressPrefixes ?? new ChangeTrackingList<string>(),
                nextHops ?? new ChangeTrackingList<string>(),
                nextHopType,
                asPath,
                routeOrigin,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualHubEffectiveRoute>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualHubEffectiveRoute IPersistableModel<VirtualHubEffectiveRoute>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualHubEffectiveRoute>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualHubEffectiveRoute(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualHubEffectiveRoute)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualHubEffectiveRoute>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
