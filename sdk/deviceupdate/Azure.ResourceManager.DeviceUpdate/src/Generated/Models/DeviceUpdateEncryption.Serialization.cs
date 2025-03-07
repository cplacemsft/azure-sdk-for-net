// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class DeviceUpdateEncryption : IUtf8JsonSerializable, IJsonModel<DeviceUpdateEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdateEncryption>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceUpdateEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateEncryption)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(UserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(UserAssignedIdentity);
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

        DeviceUpdateEncryption IJsonModel<DeviceUpdateEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateEncryption)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateEncryption(document.RootElement, options);
        }

        internal static DeviceUpdateEncryption DeserializeDeviceUpdateEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri keyVaultKeyUri = default;
            ResourceIdentifier userAssignedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentity = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceUpdateEncryption(keyVaultKeyUri, userAssignedIdentity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdateEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateEncryption)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceUpdateEncryption IPersistableModel<DeviceUpdateEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDeviceUpdateEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateEncryption)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdateEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
