// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class VpnConfigurationPatchableProperties : IUtf8JsonSerializable, IJsonModel<VpnConfigurationPatchableProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnConfigurationPatchableProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VpnConfigurationPatchableProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NetworkToNetworkInterconnectId))
            {
                writer.WritePropertyName("networkToNetworkInterconnectId"u8);
                writer.WriteStringValue(NetworkToNetworkInterconnectId);
            }
            if (Optional.IsDefined(PeeringOption))
            {
                writer.WritePropertyName("peeringOption"u8);
                writer.WriteStringValue(PeeringOption.Value.ToString());
            }
            if (Optional.IsDefined(OptionBProperties))
            {
                writer.WritePropertyName("optionBProperties"u8);
                writer.WriteObjectValue(OptionBProperties, options);
            }
            if (Optional.IsDefined(OptionAProperties))
            {
                writer.WritePropertyName("optionAProperties"u8);
                writer.WriteObjectValue(OptionAProperties, options);
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

        VpnConfigurationPatchableProperties IJsonModel<VpnConfigurationPatchableProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
        }

        internal static VpnConfigurationPatchableProperties DeserializeVpnConfigurationPatchableProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier networkToNetworkInterconnectId = default;
            PeeringOption? peeringOption = default;
            OptionBProperties optionBProperties = default;
            VpnConfigurationPatchableOptionAProperties optionAProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkToNetworkInterconnectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkToNetworkInterconnectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringOption = new PeeringOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optionBProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionBProperties = OptionBProperties.DeserializeOptionBProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("optionAProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionAProperties = VpnConfigurationPatchableOptionAProperties.DeserializeVpnConfigurationPatchableOptionAProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VpnConfigurationPatchableProperties(networkToNetworkInterconnectId, peeringOption, optionBProperties, optionAProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnConfigurationPatchableProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VpnConfigurationPatchableProperties IPersistableModel<VpnConfigurationPatchableProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnConfigurationPatchableProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
