// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class AutomationRulePropertyArrayValuesCondition : IUtf8JsonSerializable, IJsonModel<AutomationRulePropertyArrayValuesCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationRulePropertyArrayValuesCondition>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutomationRulePropertyArrayValuesCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyArrayValuesCondition)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ArrayType))
            {
                writer.WritePropertyName("arrayType"u8);
                writer.WriteStringValue(ArrayType.Value.ToString());
            }
            if (Optional.IsDefined(ArrayConditionType))
            {
                writer.WritePropertyName("arrayConditionType"u8);
                writer.WriteStringValue(ArrayConditionType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ItemConditions))
            {
                writer.WritePropertyName("itemConditions"u8);
                writer.WriteStartArray();
                foreach (var item in ItemConditions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AutomationRulePropertyArrayValuesCondition IJsonModel<AutomationRulePropertyArrayValuesCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayValuesCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationRulePropertyArrayValuesCondition)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationRulePropertyArrayValuesCondition(document.RootElement, options);
        }

        internal static AutomationRulePropertyArrayValuesCondition DeserializeAutomationRulePropertyArrayValuesCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AutomationRulePropertyArrayConditionSupportedArrayType? arrayType = default;
            AutomationRulePropertyArrayConditionSupportedArrayConditionType? arrayConditionType = default;
            IList<SecurityInsightsAutomationRuleCondition> itemConditions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("arrayType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arrayType = new AutomationRulePropertyArrayConditionSupportedArrayType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("arrayConditionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arrayConditionType = new AutomationRulePropertyArrayConditionSupportedArrayConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itemConditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityInsightsAutomationRuleCondition> array = new List<SecurityInsightsAutomationRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsAutomationRuleCondition.DeserializeSecurityInsightsAutomationRuleCondition(item, options));
                    }
                    itemConditions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutomationRulePropertyArrayValuesCondition(arrayType, arrayConditionType, itemConditions ?? new ChangeTrackingList<SecurityInsightsAutomationRuleCondition>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArrayType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  arrayType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArrayType))
                {
                    builder.Append("  arrayType: ");
                    builder.AppendLine($"'{ArrayType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArrayConditionType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  arrayConditionType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArrayConditionType))
                {
                    builder.Append("  arrayConditionType: ");
                    builder.AppendLine($"'{ArrayConditionType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ItemConditions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  itemConditions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ItemConditions))
                {
                    if (ItemConditions.Any())
                    {
                        builder.Append("  itemConditions: ");
                        builder.AppendLine("[");
                        foreach (var item in ItemConditions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  itemConditions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AutomationRulePropertyArrayValuesCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyArrayValuesCondition)} does not support writing '{options.Format}' format.");
            }
        }

        AutomationRulePropertyArrayValuesCondition IPersistableModel<AutomationRulePropertyArrayValuesCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationRulePropertyArrayValuesCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAutomationRulePropertyArrayValuesCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationRulePropertyArrayValuesCondition)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationRulePropertyArrayValuesCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
