// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmentSubnetNetworkHealth : IUtf8JsonSerializable, IJsonModel<IntegrationServiceEnvironmentSubnetNetworkHealth>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationServiceEnvironmentSubnetNetworkHealth>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationServiceEnvironmentSubnetNetworkHealth>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSubnetNetworkHealth)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(OutboundNetworkDependencies))
            {
                writer.WritePropertyName("outboundNetworkDependencies"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundNetworkDependencies)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OutboundNetworkHealth))
            {
                writer.WritePropertyName("outboundNetworkHealth"u8);
                writer.WriteObjectValue(OutboundNetworkHealth, options);
            }
            writer.WritePropertyName("networkDependencyHealthState"u8);
            writer.WriteStringValue(NetworkDependencyHealthState.ToString());
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

        IntegrationServiceEnvironmentSubnetNetworkHealth IJsonModel<IntegrationServiceEnvironmentSubnetNetworkHealth>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSubnetNetworkHealth)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(document.RootElement, options);
        }

        internal static IntegrationServiceEnvironmentSubnetNetworkHealth DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<IntegrationServiceEnvironmentNetworkDependency> outboundNetworkDependencies = default;
            IntegrationServiceEnvironmentNetworkDependencyHealth outboundNetworkHealth = default;
            IntegrationServiceEnvironmentNetworkEndPointAccessibilityState networkDependencyHealthState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outboundNetworkDependencies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationServiceEnvironmentNetworkDependency> array = new List<IntegrationServiceEnvironmentNetworkDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationServiceEnvironmentNetworkDependency.DeserializeIntegrationServiceEnvironmentNetworkDependency(item, options));
                    }
                    outboundNetworkDependencies = array;
                    continue;
                }
                if (property.NameEquals("outboundNetworkHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundNetworkHealth = IntegrationServiceEnvironmentNetworkDependencyHealth.DeserializeIntegrationServiceEnvironmentNetworkDependencyHealth(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkDependencyHealthState"u8))
                {
                    networkDependencyHealthState = new IntegrationServiceEnvironmentNetworkEndPointAccessibilityState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationServiceEnvironmentSubnetNetworkHealth(outboundNetworkDependencies ?? new ChangeTrackingList<IntegrationServiceEnvironmentNetworkDependency>(), outboundNetworkHealth, networkDependencyHealthState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSubnetNetworkHealth)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationServiceEnvironmentSubnetNetworkHealth IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIntegrationServiceEnvironmentSubnetNetworkHealth(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationServiceEnvironmentSubnetNetworkHealth)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationServiceEnvironmentSubnetNetworkHealth>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
