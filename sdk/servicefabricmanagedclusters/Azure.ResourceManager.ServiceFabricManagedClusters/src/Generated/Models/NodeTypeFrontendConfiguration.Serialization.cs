// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeFrontendConfiguration : IUtf8JsonSerializable, IJsonModel<NodeTypeFrontendConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeFrontendConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NodeTypeFrontendConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerBackendAddressPoolId))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPoolId"u8);
                writer.WriteStringValue(LoadBalancerBackendAddressPoolId);
            }
            if (Optional.IsDefined(LoadBalancerInboundNatPoolId))
            {
                writer.WritePropertyName("loadBalancerInboundNatPoolId"u8);
                writer.WriteStringValue(LoadBalancerInboundNatPoolId);
            }
            if (Optional.IsDefined(ApplicationGatewayBackendAddressPoolId))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPoolId"u8);
                writer.WriteStringValue(ApplicationGatewayBackendAddressPoolId);
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

        NodeTypeFrontendConfiguration IJsonModel<NodeTypeFrontendConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeFrontendConfiguration(document.RootElement, options);
        }

        internal static NodeTypeFrontendConfiguration DeserializeNodeTypeFrontendConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NodeTypeFrontendConfigurationIPAddressType? ipAddressType = default;
            ResourceIdentifier loadBalancerBackendAddressPoolId = default;
            ResourceIdentifier loadBalancerInboundNatPoolId = default;
            ResourceIdentifier applicationGatewayBackendAddressPoolId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NodeTypeFrontendConfigurationIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerInboundNatPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerInboundNatPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationGatewayBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    applicationGatewayBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NodeTypeFrontendConfiguration(ipAddressType, loadBalancerBackendAddressPoolId, loadBalancerInboundNatPoolId, applicationGatewayBackendAddressPoolId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeTypeFrontendConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        NodeTypeFrontendConfiguration IPersistableModel<NodeTypeFrontendConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNodeTypeFrontendConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeTypeFrontendConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
