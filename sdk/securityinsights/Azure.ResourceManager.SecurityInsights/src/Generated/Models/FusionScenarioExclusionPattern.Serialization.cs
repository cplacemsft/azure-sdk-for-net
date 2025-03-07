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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class FusionScenarioExclusionPattern : IUtf8JsonSerializable, IJsonModel<FusionScenarioExclusionPattern>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FusionScenarioExclusionPattern>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FusionScenarioExclusionPattern>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionScenarioExclusionPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionScenarioExclusionPattern)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("exclusionPattern"u8);
            writer.WriteStringValue(ExclusionPattern);
            writer.WritePropertyName("dateAddedInUTC"u8);
            writer.WriteStringValue(DateAddedInUTC);
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

        FusionScenarioExclusionPattern IJsonModel<FusionScenarioExclusionPattern>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionScenarioExclusionPattern>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionScenarioExclusionPattern)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFusionScenarioExclusionPattern(document.RootElement, options);
        }

        internal static FusionScenarioExclusionPattern DeserializeFusionScenarioExclusionPattern(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string exclusionPattern = default;
            string dateAddedInUTC = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exclusionPattern"u8))
                {
                    exclusionPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dateAddedInUTC"u8))
                {
                    dateAddedInUTC = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FusionScenarioExclusionPattern(exclusionPattern, dateAddedInUTC, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExclusionPattern), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  exclusionPattern: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExclusionPattern))
                {
                    builder.Append("  exclusionPattern: ");
                    if (ExclusionPattern.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ExclusionPattern}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ExclusionPattern}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DateAddedInUTC), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dateAddedInUTC: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DateAddedInUTC))
                {
                    builder.Append("  dateAddedInUTC: ");
                    if (DateAddedInUTC.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DateAddedInUTC}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DateAddedInUTC}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FusionScenarioExclusionPattern>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionScenarioExclusionPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FusionScenarioExclusionPattern)} does not support writing '{options.Format}' format.");
            }
        }

        FusionScenarioExclusionPattern IPersistableModel<FusionScenarioExclusionPattern>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionScenarioExclusionPattern>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFusionScenarioExclusionPattern(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FusionScenarioExclusionPattern)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FusionScenarioExclusionPattern>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
