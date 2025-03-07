// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabVirtualNetworkData : IUtf8JsonSerializable, IJsonModel<DevTestLabVirtualNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabVirtualNetworkData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabVirtualNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVirtualNetworkData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedSubnets))
            {
                writer.WritePropertyName("allowedSubnets"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedSubnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ExternalProviderResourceId))
            {
                writer.WritePropertyName("externalProviderResourceId"u8);
                writer.WriteStringValue(ExternalProviderResourceId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExternalSubnets))
            {
                writer.WritePropertyName("externalSubnets"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalSubnets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SubnetOverrides))
            {
                writer.WritePropertyName("subnetOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in SubnetOverrides)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
            }
            writer.WriteEndObject();
        }

        DevTestLabVirtualNetworkData IJsonModel<DevTestLabVirtualNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVirtualNetworkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabVirtualNetworkData(document.RootElement, options);
        }

        internal static DevTestLabVirtualNetworkData DeserializeDevTestLabVirtualNetworkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IList<DevTestLabSubnet> allowedSubnets = default;
            string description = default;
            string externalProviderResourceId = default;
            IReadOnlyList<DevTestLabExternalSubnet> externalSubnets = default;
            IList<DevTestLabSubnetOverride> subnetOverrides = default;
            DateTimeOffset? createdDate = default;
            string provisioningState = default;
            Guid? uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("allowedSubnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabSubnet> array = new List<DevTestLabSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabSubnet.DeserializeDevTestLabSubnet(item, options));
                            }
                            allowedSubnets = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalProviderResourceId"u8))
                        {
                            externalProviderResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalSubnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabExternalSubnet> array = new List<DevTestLabExternalSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabExternalSubnet.DeserializeDevTestLabExternalSubnet(item, options));
                            }
                            externalSubnets = array;
                            continue;
                        }
                        if (property0.NameEquals("subnetOverrides"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabSubnetOverride> array = new List<DevTestLabSubnetOverride>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabSubnetOverride.DeserializeDevTestLabSubnetOverride(item, options));
                            }
                            subnetOverrides = array;
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabVirtualNetworkData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                allowedSubnets ?? new ChangeTrackingList<DevTestLabSubnet>(),
                description,
                externalProviderResourceId,
                externalSubnets ?? new ChangeTrackingList<DevTestLabExternalSubnet>(),
                subnetOverrides ?? new ChangeTrackingList<DevTestLabSubnetOverride>(),
                createdDate,
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabVirtualNetworkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVirtualNetworkData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabVirtualNetworkData IPersistableModel<DevTestLabVirtualNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVirtualNetworkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabVirtualNetworkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVirtualNetworkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabVirtualNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
