// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudNetworkInterface : IUtf8JsonSerializable, IJsonModel<NetworkCloudNetworkInterface>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudNetworkInterface>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkCloudNetworkInterface>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudNetworkInterface)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceConnectionType))
            {
                writer.WritePropertyName("deviceConnectionType"u8);
                writer.WriteStringValue(DeviceConnectionType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalSlot))
            {
                writer.WritePropertyName("physicalSlot"u8);
                writer.WriteNumberValue(PhysicalSlot.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PortCount))
            {
                writer.WritePropertyName("portCount"u8);
                writer.WriteNumberValue(PortCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PortSpeed))
            {
                writer.WritePropertyName("portSpeed"u8);
                writer.WriteNumberValue(PortSpeed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
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

        NetworkCloudNetworkInterface IJsonModel<NetworkCloudNetworkInterface>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudNetworkInterface)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudNetworkInterface(document.RootElement, options);
        }

        internal static NetworkCloudNetworkInterface DeserializeNetworkCloudNetworkInterface(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string address = default;
            DeviceConnectionType? deviceConnectionType = default;
            string model = default;
            long? physicalSlot = default;
            long? portCount = default;
            long? portSpeed = default;
            string vendor = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceConnectionType = new DeviceConnectionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    physicalSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("portSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portSpeed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("vendor"u8))
                {
                    vendor = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkCloudNetworkInterface(
                address,
                deviceConnectionType,
                model,
                physicalSlot,
                portCount,
                portSpeed,
                vendor,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudNetworkInterface>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudNetworkInterface)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkCloudNetworkInterface IPersistableModel<NetworkCloudNetworkInterface>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudNetworkInterface>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkCloudNetworkInterface(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudNetworkInterface)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudNetworkInterface>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
