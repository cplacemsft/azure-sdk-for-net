// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetVmGalleryApplication : IUtf8JsonSerializable, IJsonModel<ComputeFleetVmGalleryApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetVmGalleryApplication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetVmGalleryApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetVmGalleryApplication)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStringValue(Tags);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            writer.WritePropertyName("packageReferenceId"u8);
            writer.WriteStringValue(PackageReferenceId);
            if (Optional.IsDefined(ConfigurationReference))
            {
                writer.WritePropertyName("configurationReference"u8);
                writer.WriteStringValue(ConfigurationReference);
            }
            if (Optional.IsDefined(IsTreatFailureAsDeploymentFailureEnabled))
            {
                writer.WritePropertyName("treatFailureAsDeploymentFailure"u8);
                writer.WriteBooleanValue(IsTreatFailureAsDeploymentFailureEnabled.Value);
            }
            if (Optional.IsDefined(IsAutomaticUpgradeEnabled))
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(IsAutomaticUpgradeEnabled.Value);
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

        ComputeFleetVmGalleryApplication IJsonModel<ComputeFleetVmGalleryApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetVmGalleryApplication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetVmGalleryApplication(document.RootElement, options);
        }

        internal static ComputeFleetVmGalleryApplication DeserializeComputeFleetVmGalleryApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tags = default;
            int? order = default;
            ResourceIdentifier packageReferenceId = default;
            string configurationReference = default;
            bool? treatFailureAsDeploymentFailure = default;
            bool? enableAutomaticUpgrade = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    tags = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("packageReferenceId"u8))
                {
                    packageReferenceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationReference"u8))
                {
                    configurationReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("treatFailureAsDeploymentFailure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    treatFailureAsDeploymentFailure = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableAutomaticUpgrade"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutomaticUpgrade = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetVmGalleryApplication(
                tags,
                order,
                packageReferenceId,
                configurationReference,
                treatFailureAsDeploymentFailure,
                enableAutomaticUpgrade,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetVmGalleryApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetVmGalleryApplication)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetVmGalleryApplication IPersistableModel<ComputeFleetVmGalleryApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmGalleryApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeComputeFleetVmGalleryApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetVmGalleryApplication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetVmGalleryApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
