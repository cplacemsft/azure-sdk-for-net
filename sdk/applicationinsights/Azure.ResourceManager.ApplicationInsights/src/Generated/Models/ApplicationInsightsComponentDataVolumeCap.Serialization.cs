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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentDataVolumeCap : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentDataVolumeCap>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentDataVolumeCap>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Cap))
            {
                writer.WritePropertyName("Cap"u8);
                writer.WriteNumberValue(Cap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResetTime))
            {
                writer.WritePropertyName("ResetTime"u8);
                writer.WriteNumberValue(ResetTime.Value);
            }
            if (Optional.IsDefined(WarningThreshold))
            {
                writer.WritePropertyName("WarningThreshold"u8);
                writer.WriteNumberValue(WarningThreshold.Value);
            }
            if (Optional.IsDefined(IsStopSendNotificationWhenHitThreshold))
            {
                writer.WritePropertyName("StopSendNotificationWhenHitThreshold"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitThreshold.Value);
            }
            if (Optional.IsDefined(IsStopSendNotificationWhenHitCap))
            {
                writer.WritePropertyName("StopSendNotificationWhenHitCap"u8);
                writer.WriteBooleanValue(IsStopSendNotificationWhenHitCap.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(MaxHistoryCap))
            {
                writer.WritePropertyName("MaxHistoryCap"u8);
                writer.WriteNumberValue(MaxHistoryCap.Value);
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

        ApplicationInsightsComponentDataVolumeCap IJsonModel<ApplicationInsightsComponentDataVolumeCap>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentDataVolumeCap DeserializeApplicationInsightsComponentDataVolumeCap(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? cap = default;
            int? resetTime = default;
            int? warningThreshold = default;
            bool? stopSendNotificationWhenHitThreshold = default;
            bool? stopSendNotificationWhenHitCap = default;
            float? maxHistoryCap = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Cap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cap = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("ResetTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resetTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("WarningThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningThreshold = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitThreshold = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("StopSendNotificationWhenHitCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stopSendNotificationWhenHitCap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("MaxHistoryCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxHistoryCap = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationInsightsComponentDataVolumeCap(
                cap,
                resetTime,
                warningThreshold,
                stopSendNotificationWhenHitThreshold,
                stopSendNotificationWhenHitCap,
                maxHistoryCap,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Cap), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  Cap: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Cap))
                {
                    builder.Append("  Cap: ");
                    builder.AppendLine($"'{Cap.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResetTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ResetTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResetTime))
                {
                    builder.Append("  ResetTime: ");
                    builder.AppendLine($"{ResetTime.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WarningThreshold), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  WarningThreshold: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WarningThreshold))
                {
                    builder.Append("  WarningThreshold: ");
                    builder.AppendLine($"{WarningThreshold.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStopSendNotificationWhenHitThreshold), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  StopSendNotificationWhenHitThreshold: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStopSendNotificationWhenHitThreshold))
                {
                    builder.Append("  StopSendNotificationWhenHitThreshold: ");
                    var boolValue = IsStopSendNotificationWhenHitThreshold.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStopSendNotificationWhenHitCap), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  StopSendNotificationWhenHitCap: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStopSendNotificationWhenHitCap))
                {
                    builder.Append("  StopSendNotificationWhenHitCap: ");
                    var boolValue = IsStopSendNotificationWhenHitCap.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxHistoryCap), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  MaxHistoryCap: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxHistoryCap))
                {
                    builder.Append("  MaxHistoryCap: ");
                    builder.AppendLine($"'{MaxHistoryCap.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsComponentDataVolumeCap IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsComponentDataVolumeCap>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationInsightsComponentDataVolumeCap(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsComponentDataVolumeCap)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsComponentDataVolumeCap>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
