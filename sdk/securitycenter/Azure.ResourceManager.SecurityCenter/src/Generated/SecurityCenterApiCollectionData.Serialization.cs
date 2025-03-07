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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityCenterApiCollectionData : IUtf8JsonSerializable, IJsonModel<SecurityCenterApiCollectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityCenterApiCollectionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityCenterApiCollectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(DiscoveredVia))
            {
                writer.WritePropertyName("discoveredVia"u8);
                writer.WriteStringValue(DiscoveredVia);
            }
            if (options.Format != "W" && Optional.IsDefined(BaseUri))
            {
                writer.WritePropertyName("baseUrl"u8);
                writer.WriteStringValue(BaseUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfApiEndpoints))
            {
                writer.WritePropertyName("numberOfApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfInactiveApiEndpoints))
            {
                writer.WritePropertyName("numberOfInactiveApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfInactiveApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfUnauthenticatedApiEndpoints))
            {
                writer.WritePropertyName("numberOfUnauthenticatedApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfUnauthenticatedApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfExternalApiEndpoints))
            {
                writer.WritePropertyName("numberOfExternalApiEndpoints"u8);
                writer.WriteNumberValue(NumberOfExternalApiEndpoints.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NumberOfApiEndpointsWithSensitiveDataExposed))
            {
                writer.WritePropertyName("numberOfApiEndpointsWithSensitiveDataExposed"u8);
                writer.WriteNumberValue(NumberOfApiEndpointsWithSensitiveDataExposed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteStringValue(SensitivityLabel);
            }
            writer.WriteEndObject();
        }

        SecurityCenterApiCollectionData IJsonModel<SecurityCenterApiCollectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityCenterApiCollectionData(document.RootElement, options);
        }

        internal static SecurityCenterApiCollectionData DeserializeSecurityCenterApiCollectionData(JsonElement element, ModelReaderWriterOptions options = null)
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
            SecurityFamilyProvisioningState? provisioningState = default;
            string displayName = default;
            ResourceIdentifier discoveredVia = default;
            Uri baseUrl = default;
            long? numberOfApiEndpoints = default;
            long? numberOfInactiveApiEndpoints = default;
            long? numberOfUnauthenticatedApiEndpoints = default;
            long? numberOfExternalApiEndpoints = default;
            long? numberOfApiEndpointsWithSensitiveDataExposed = default;
            string sensitivityLabel = default;
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
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SecurityFamilyProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("discoveredVia"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            discoveredVia = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("baseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            baseUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("numberOfApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfInactiveApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfInactiveApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfUnauthenticatedApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfUnauthenticatedApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfExternalApiEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfExternalApiEndpoints = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("numberOfApiEndpointsWithSensitiveDataExposed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfApiEndpointsWithSensitiveDataExposed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            sensitivityLabel = property0.Value.GetString();
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
            return new SecurityCenterApiCollectionData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                displayName,
                discoveredVia,
                baseUrl,
                numberOfApiEndpoints,
                numberOfInactiveApiEndpoints,
                numberOfUnauthenticatedApiEndpoints,
                numberOfExternalApiEndpoints,
                numberOfApiEndpointsWithSensitiveDataExposed,
                sensitivityLabel,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityCenterApiCollectionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityCenterApiCollectionData IPersistableModel<SecurityCenterApiCollectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityCenterApiCollectionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityCenterApiCollectionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityCenterApiCollectionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityCenterApiCollectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
