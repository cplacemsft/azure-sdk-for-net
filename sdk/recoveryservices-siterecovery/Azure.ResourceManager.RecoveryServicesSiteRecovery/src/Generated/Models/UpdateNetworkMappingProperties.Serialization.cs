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
    public partial class UpdateNetworkMappingProperties : IUtf8JsonSerializable, IJsonModel<UpdateNetworkMappingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateNetworkMappingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateNetworkMappingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateNetworkMappingProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RecoveryFabricName))
            {
                writer.WritePropertyName("recoveryFabricName"u8);
                writer.WriteStringValue(RecoveryFabricName);
            }
            if (Optional.IsDefined(RecoveryNetworkId))
            {
                writer.WritePropertyName("recoveryNetworkId"u8);
                writer.WriteStringValue(RecoveryNetworkId);
            }
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

        UpdateNetworkMappingProperties IJsonModel<UpdateNetworkMappingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateNetworkMappingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateNetworkMappingProperties(document.RootElement, options);
        }

        internal static UpdateNetworkMappingProperties DeserializeUpdateNetworkMappingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string recoveryFabricName = default;
            ResourceIdentifier recoveryNetworkId = default;
            FabricSpecificUpdateNetworkMappingContent fabricSpecificDetails = default;
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricSpecificDetails = FabricSpecificUpdateNetworkMappingContent.DeserializeFabricSpecificUpdateNetworkMappingContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateNetworkMappingProperties(recoveryFabricName, recoveryNetworkId, fabricSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateNetworkMappingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateNetworkMappingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateNetworkMappingProperties IPersistableModel<UpdateNetworkMappingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateNetworkMappingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateNetworkMappingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateNetworkMappingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateNetworkMappingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
