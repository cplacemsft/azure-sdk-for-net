// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class DedicatedHsmProperties : IUtf8JsonSerializable, IJsonModel<DedicatedHsmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHsmProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DedicatedHsmProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHsmProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile"u8);
                writer.WriteObjectValue(NetworkProfile, options);
            }
            if (Optional.IsDefined(ManagementNetworkProfile))
            {
                writer.WritePropertyName("managementNetworkProfile"u8);
                writer.WriteObjectValue(ManagementNetworkProfile, options);
            }
            if (Optional.IsDefined(StampId))
            {
                writer.WritePropertyName("stampId"u8);
                writer.WriteStringValue(StampId);
            }
            if (options.Format != "W" && Optional.IsDefined(StatusMessage))
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        DedicatedHsmProperties IJsonModel<DedicatedHsmProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHsmProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHsmProperties(document.RootElement, options);
        }

        internal static DedicatedHsmProperties DeserializeDedicatedHsmProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DedicatedHsmNetworkProfile networkProfile = default;
            DedicatedHsmNetworkProfile managementNetworkProfile = default;
            string stampId = default;
            string statusMessage = default;
            DedicatedHsmJsonWebKeyType? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProfile = DedicatedHsmNetworkProfile.DeserializeDedicatedHsmNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("managementNetworkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managementNetworkProfile = DedicatedHsmNetworkProfile.DeserializeDedicatedHsmNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stampId"u8))
                {
                    stampId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DedicatedHsmJsonWebKeyType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DedicatedHsmProperties(
                networkProfile,
                managementNetworkProfile,
                stampId,
                statusMessage,
                provisioningState,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkProfile))
                {
                    builder.Append("  networkProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkProfile, options, 2, false, "  networkProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagementNetworkProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managementNetworkProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagementNetworkProfile))
                {
                    builder.Append("  managementNetworkProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ManagementNetworkProfile, options, 2, false, "  managementNetworkProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StampId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  stampId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StampId))
                {
                    builder.Append("  stampId: ");
                    if (StampId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StampId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StampId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusMessage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statusMessage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StatusMessage))
                {
                    builder.Append("  statusMessage: ");
                    if (StatusMessage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{StatusMessage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{StatusMessage}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DedicatedHsmProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHsmProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DedicatedHsmProperties IPersistableModel<DedicatedHsmProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDedicatedHsmProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHsmProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHsmProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
