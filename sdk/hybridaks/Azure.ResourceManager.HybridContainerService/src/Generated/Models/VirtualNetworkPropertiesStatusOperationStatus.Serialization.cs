// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class VirtualNetworkPropertiesStatusOperationStatus : IUtf8JsonSerializable, IJsonModel<VirtualNetworkPropertiesStatusOperationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualNetworkPropertiesStatusOperationStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualNetworkPropertiesStatusOperationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkPropertiesStatusOperationStatus)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error, options);
            }
            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
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

        VirtualNetworkPropertiesStatusOperationStatus IJsonModel<VirtualNetworkPropertiesStatusOperationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualNetworkPropertiesStatusOperationStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkPropertiesStatusOperationStatus(document.RootElement, options);
        }

        internal static VirtualNetworkPropertiesStatusOperationStatus DeserializeVirtualNetworkPropertiesStatusOperationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridContainerServiceNetworkOperationError error = default;
            string operationId = default;
            string status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = HybridContainerServiceNetworkOperationError.DeserializeHybridContainerServiceNetworkOperationError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualNetworkPropertiesStatusOperationStatus(error, operationId, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkPropertiesStatusOperationStatus)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualNetworkPropertiesStatusOperationStatus IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualNetworkPropertiesStatusOperationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualNetworkPropertiesStatusOperationStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualNetworkPropertiesStatusOperationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
