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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class AvailabilityZoneMappings : IUtf8JsonSerializable, IJsonModel<AvailabilityZoneMappings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailabilityZoneMappings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvailabilityZoneMappings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityZoneMappings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(LogicalZone))
            {
                writer.WritePropertyName("logicalZone"u8);
                writer.WriteStringValue(LogicalZone);
            }
            if (options.Format != "W" && Optional.IsDefined(PhysicalZone))
            {
                writer.WritePropertyName("physicalZone"u8);
                writer.WriteStringValue(PhysicalZone);
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

        AvailabilityZoneMappings IJsonModel<AvailabilityZoneMappings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityZoneMappings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityZoneMappings(document.RootElement, options);
        }

        internal static AvailabilityZoneMappings DeserializeAvailabilityZoneMappings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string logicalZone = default;
            string physicalZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logicalZone"u8))
                {
                    logicalZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalZone"u8))
                {
                    physicalZone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvailabilityZoneMappings(logicalZone, physicalZone, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LogicalZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  logicalZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LogicalZone))
                {
                    builder.Append("  logicalZone: ");
                    if (LogicalZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LogicalZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LogicalZone}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PhysicalZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  physicalZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PhysicalZone))
                {
                    builder.Append("  physicalZone: ");
                    if (PhysicalZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PhysicalZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PhysicalZone}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AvailabilityZoneMappings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityZoneMappings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support writing '{options.Format}' format.");
            }
        }

        AvailabilityZoneMappings IPersistableModel<AvailabilityZoneMappings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailabilityZoneMappings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAvailabilityZoneMappings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailabilityZoneMappings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailabilityZoneMappings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
