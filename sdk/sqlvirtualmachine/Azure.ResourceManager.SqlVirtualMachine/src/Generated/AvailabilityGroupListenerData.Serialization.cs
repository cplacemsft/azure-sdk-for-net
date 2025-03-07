// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class AvailabilityGroupListenerData : IUtf8JsonSerializable, IJsonModel<AvailabilityGroupListenerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityGroupListenerData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailabilityGroupListenerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AvailabilityGroupName))
            {
                writer.WritePropertyName("availabilityGroupName"u8);
                writer.WriteStringValue(AvailabilityGroupName);
            }
            if (Optional.IsCollectionDefined(LoadBalancerConfigurations))
            {
                writer.WritePropertyName("loadBalancerConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in LoadBalancerConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MultiSubnetIPConfigurations))
            {
                writer.WritePropertyName("multiSubnetIpConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in MultiSubnetIPConfigurations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CreateDefaultAvailabilityGroupIfNotExist))
            {
                writer.WritePropertyName("createDefaultAvailabilityGroupIfNotExist"u8);
                writer.WriteBooleanValue(CreateDefaultAvailabilityGroupIfNotExist.Value);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(AvailabilityGroupConfiguration))
            {
                writer.WritePropertyName("availabilityGroupConfiguration"u8);
                writer.WriteObjectValue(AvailabilityGroupConfiguration, options);
            }
            writer.WriteEndObject();
        }

        AvailabilityGroupListenerData IJsonModel<AvailabilityGroupListenerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupListenerData(document.RootElement, options);
        }

        internal static AvailabilityGroupListenerData DeserializeAvailabilityGroupListenerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string provisioningState = default;
            string availabilityGroupName = default;
            IList<AvailabilityGroupListenerLoadBalancerConfiguration> loadBalancerConfigurations = default;
            IList<MultiSubnetIPConfiguration> multiSubnetIPConfigurations = default;
            bool? createDefaultAvailabilityGroupIfNotExist = default;
            int? port = default;
            AvailabilityGroupConfiguration availabilityGroupConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityGroupName"u8))
                        {
                            availabilityGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AvailabilityGroupListenerLoadBalancerConfiguration> array = new List<AvailabilityGroupListenerLoadBalancerConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AvailabilityGroupListenerLoadBalancerConfiguration.DeserializeAvailabilityGroupListenerLoadBalancerConfiguration(item, options));
                            }
                            loadBalancerConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("multiSubnetIpConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MultiSubnetIPConfiguration> array = new List<MultiSubnetIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MultiSubnetIPConfiguration.DeserializeMultiSubnetIPConfiguration(item, options));
                            }
                            multiSubnetIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("createDefaultAvailabilityGroupIfNotExist"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createDefaultAvailabilityGroupIfNotExist = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("port"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("availabilityGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityGroupConfiguration = AvailabilityGroupConfiguration.DeserializeAvailabilityGroupConfiguration(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailabilityGroupListenerData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                availabilityGroupName,
                loadBalancerConfigurations ?? new ChangeTrackingList<AvailabilityGroupListenerLoadBalancerConfiguration>(),
                multiSubnetIPConfigurations ?? new ChangeTrackingList<MultiSubnetIPConfiguration>(),
                createDefaultAvailabilityGroupIfNotExist,
                port,
                availabilityGroupConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailabilityGroupListenerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support writing '{options.Format}' format.");
            }
        }

        AvailabilityGroupListenerData IPersistableModel<AvailabilityGroupListenerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityGroupListenerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvailabilityGroupListenerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailabilityGroupListenerData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailabilityGroupListenerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
