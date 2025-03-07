// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryCreateReplicationNetworkMappingProperties : IUtf8JsonSerializable, IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RecoveryFabricName))
            {
                writer.WritePropertyName("recoveryFabricName"u8);
                writer.WriteStringValue(RecoveryFabricName);
            }
            writer.WritePropertyName("recoveryNetworkId"u8);
            writer.WriteStringValue(RecoveryNetworkId);
            if (Optional.IsDefined(FabricSpecificDetails))
            {
                writer.WritePropertyName("fabricSpecificDetails"u8);
                writer.WriteObjectValue(FabricSpecificDetails, options);
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

        SiteRecoveryCreateReplicationNetworkMappingProperties IJsonModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(document.RootElement, options);
        }

        internal static SiteRecoveryCreateReplicationNetworkMappingProperties DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryFabricName = default;
            ResourceIdentifier recoveryNetworkId = default;
            FabricSpecificCreateNetworkMappingContent fabricSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryFabricName"u8))
                {
                    recoveryFabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkId"u8))
                {
                    recoveryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificDetails = FabricSpecificCreateNetworkMappingContent.DeserializeFabricSpecificCreateNetworkMappingContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteRecoveryCreateReplicationNetworkMappingProperties(recoveryFabricName, recoveryNetworkId, fabricSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SiteRecoveryCreateReplicationNetworkMappingProperties IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSiteRecoveryCreateReplicationNetworkMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryCreateReplicationNetworkMappingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryCreateReplicationNetworkMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
