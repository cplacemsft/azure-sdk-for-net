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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    [PersistableModelProxy(typeof(UnknownClusterAvailableUpgradeProperties))]
    public partial class ClusterAvailableUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterAvailableUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterAvailableUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterAvailableUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
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

        ClusterAvailableUpgradeProperties IJsonModel<ClusterAvailableUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAvailableUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterAvailableUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterAvailableUpgradeProperties DeserializeClusterAvailableUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("upgradeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKSPatchUpgrade": return ClusterAvailableUpgradeAksPatchUpgradeProperties.DeserializeClusterAvailableUpgradeAksPatchUpgradeProperties(element, options);
                    case "ClusterAvailableInPlaceUpgradeProperties": return ClusterAvailableInPlaceUpgradeProperties.DeserializeClusterAvailableInPlaceUpgradeProperties(element, options);
                    case "HotfixUpgrade": return ClusterAvailableUpgradeHotfixUpgradeProperties.DeserializeClusterAvailableUpgradeHotfixUpgradeProperties(element, options);
                    case "PatchVersionUpgrade": return ClusterAvailableUpgradePatchVersionUpgradeProperties.DeserializeClusterAvailableUpgradePatchVersionUpgradeProperties(element, options);
                }
            }
            return UnknownClusterAvailableUpgradeProperties.DeserializeUnknownClusterAvailableUpgradeProperties(element, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpgradeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  upgradeType: ");
                builder.AppendLine($"'{UpgradeType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterAvailableUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterAvailableUpgradeProperties IPersistableModel<ClusterAvailableUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAvailableUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterAvailableUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterAvailableUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterAvailableUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
