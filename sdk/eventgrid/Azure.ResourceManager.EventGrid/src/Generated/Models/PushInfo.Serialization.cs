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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PushInfo : IUtf8JsonSerializable, IJsonModel<PushInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PushInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PushInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PushInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(EventTimeToLive))
            {
                writer.WritePropertyName("eventTimeToLive"u8);
                writer.WriteStringValue(EventTimeToLive);
            }
            if (Optional.IsDefined(DeadLetterDestinationWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterDestinationWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterDestinationWithResourceIdentity, options);
            }
            if (Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity"u8);
                writer.WriteObjectValue(DeliveryWithResourceIdentity, options);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination, options);
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

        PushInfo IJsonModel<PushInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PushInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePushInfo(document.RootElement, options);
        }

        internal static PushInfo DeserializePushInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxDeliveryCount = default;
            string eventTimeToLive = default;
            DeadLetterWithResourceIdentity deadLetterDestinationWithResourceIdentity = default;
            DeliveryWithResourceIdentity deliveryWithResourceIdentity = default;
            EventSubscriptionDestination destination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxDeliveryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDeliveryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("eventTimeToLive"u8))
                {
                    eventTimeToLive = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterDestinationWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterDestinationWithResourceIdentity = DeadLetterWithResourceIdentity.DeserializeDeadLetterWithResourceIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deliveryWithResourceIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deliveryWithResourceIdentity = DeliveryWithResourceIdentity.DeserializeDeliveryWithResourceIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = EventSubscriptionDestination.DeserializeEventSubscriptionDestination(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PushInfo(
                maxDeliveryCount,
                eventTimeToLive,
                deadLetterDestinationWithResourceIdentity,
                deliveryWithResourceIdentity,
                destination,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxDeliveryCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxDeliveryCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxDeliveryCount))
                {
                    builder.Append("  maxDeliveryCount: ");
                    builder.AppendLine($"{MaxDeliveryCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventTimeToLive), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  eventTimeToLive: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EventTimeToLive))
                {
                    builder.Append("  eventTimeToLive: ");
                    if (EventTimeToLive.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EventTimeToLive}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EventTimeToLive}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetterDestinationWithResourceIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deadLetterDestinationWithResourceIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetterDestinationWithResourceIdentity))
                {
                    builder.Append("  deadLetterDestinationWithResourceIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeadLetterDestinationWithResourceIdentity, options, 2, false, "  deadLetterDestinationWithResourceIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeliveryWithResourceIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deliveryWithResourceIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeliveryWithResourceIdentity))
                {
                    builder.Append("  deliveryWithResourceIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DeliveryWithResourceIdentity, options, 2, false, "  deliveryWithResourceIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Destination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  destination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Destination))
                {
                    builder.Append("  destination: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Destination, options, 2, false, "  destination: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PushInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PushInfo)} does not support writing '{options.Format}' format.");
            }
        }

        PushInfo IPersistableModel<PushInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PushInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePushInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PushInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PushInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
