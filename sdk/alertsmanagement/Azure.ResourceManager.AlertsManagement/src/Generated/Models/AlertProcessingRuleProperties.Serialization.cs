// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AlertProcessingRuleProperties : IUtf8JsonSerializable, IJsonModel<AlertProcessingRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AlertProcessingRuleProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AlertProcessingRuleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("scopes"u8);
            writer.WriteStartArray();
            foreach (var item in Scopes)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions"u8);
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule, options);
            }
            writer.WritePropertyName("actions"u8);
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        AlertProcessingRuleProperties IJsonModel<AlertProcessingRuleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AlertProcessingRuleProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAlertProcessingRuleProperties(document.RootElement, options);
        }

        internal static AlertProcessingRuleProperties DeserializeAlertProcessingRuleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> scopes = default;
            IList<AlertProcessingRuleCondition> conditions = default;
            AlertProcessingRuleSchedule schedule = default;
            IList<AlertProcessingRuleAction> actions = default;
            string description = default;
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scopes"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scopes = array;
                    continue;
                }
                if (property.NameEquals("conditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlertProcessingRuleCondition> array = new List<AlertProcessingRuleCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingRuleCondition.DeserializeAlertProcessingRuleCondition(item, options));
                    }
                    conditions = array;
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedule = AlertProcessingRuleSchedule.DeserializeAlertProcessingRuleSchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    List<AlertProcessingRuleAction> array = new List<AlertProcessingRuleAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AlertProcessingRuleAction.DeserializeAlertProcessingRuleAction(item, options));
                    }
                    actions = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AlertProcessingRuleProperties(
                scopes,
                conditions ?? new ChangeTrackingList<AlertProcessingRuleCondition>(),
                schedule,
                actions,
                description,
                enabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AlertProcessingRuleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AlertProcessingRuleProperties IPersistableModel<AlertProcessingRuleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AlertProcessingRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAlertProcessingRuleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AlertProcessingRuleProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AlertProcessingRuleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
