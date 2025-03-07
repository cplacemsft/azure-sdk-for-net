// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    [PersistableModelProxy(typeof(UnknownAddonProperties))]
    public partial class AvsPrivateCloudAddonProperties : IUtf8JsonSerializable, IJsonModel<AvsPrivateCloudAddonProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsPrivateCloudAddonProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsPrivateCloudAddonProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudAddonProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudAddonProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("addonType"u8);
            writer.WriteStringValue(AddonType.ToString());
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

        AvsPrivateCloudAddonProperties IJsonModel<AvsPrivateCloudAddonProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudAddonProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsPrivateCloudAddonProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudAddonProperties(document.RootElement, options);
        }

        internal static AvsPrivateCloudAddonProperties DeserializeAvsPrivateCloudAddonProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("addonType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Arc": return AddonArcProperties.DeserializeAddonArcProperties(element, options);
                    case "HCX": return AddonHcxProperties.DeserializeAddonHcxProperties(element, options);
                    case "SRM": return AddonSrmProperties.DeserializeAddonSrmProperties(element, options);
                    case "VR": return AddonVrProperties.DeserializeAddonVrProperties(element, options);
                }
            }
            return UnknownAddonProperties.DeserializeUnknownAddonProperties(element, options);
        }

        BinaryData IPersistableModel<AvsPrivateCloudAddonProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudAddonProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudAddonProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AvsPrivateCloudAddonProperties IPersistableModel<AvsPrivateCloudAddonProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsPrivateCloudAddonProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvsPrivateCloudAddonProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsPrivateCloudAddonProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsPrivateCloudAddonProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
