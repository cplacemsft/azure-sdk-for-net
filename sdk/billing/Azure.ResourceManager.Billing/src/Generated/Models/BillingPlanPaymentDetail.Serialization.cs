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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingPlanPaymentDetail : IUtf8JsonSerializable, IJsonModel<BillingPlanPaymentDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingPlanPaymentDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingPlanPaymentDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPlanPaymentDetail)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DueOn))
            {
                writer.WritePropertyName("dueDate"u8);
                writer.WriteStringValue(DueOn.Value, "D");
            }
            if (Optional.IsDefined(PaymentCompletedOn))
            {
                writer.WritePropertyName("paymentDate"u8);
                writer.WriteStringValue(PaymentCompletedOn.Value, "D");
            }
            if (Optional.IsDefined(PricingCurrencyTotal))
            {
                writer.WritePropertyName("pricingCurrencyTotal"u8);
                writer.WriteObjectValue(PricingCurrencyTotal, options);
            }
            if (Optional.IsDefined(BillingCurrencyTotal))
            {
                writer.WritePropertyName("billingCurrencyTotal"u8);
                writer.WriteObjectValue(BillingCurrencyTotal, options);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExtendedStatusInfo))
            {
                writer.WritePropertyName("extendedStatusInfo"u8);
                writer.WriteObjectValue(ExtendedStatusInfo, options);
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

        BillingPlanPaymentDetail IJsonModel<BillingPlanPaymentDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingPlanPaymentDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingPlanPaymentDetail(document.RootElement, options);
        }

        internal static BillingPlanPaymentDetail DeserializeBillingPlanPaymentDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? dueDate = default;
            DateTimeOffset? paymentDate = default;
            BillingPrice pricingCurrencyTotal = default;
            BillingPrice billingCurrencyTotal = default;
            BillingPaymentStatus? status = default;
            ExtendedStatusInfo extendedStatusInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dueDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dueDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("paymentDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    paymentDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("pricingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pricingCurrencyTotal = BillingPrice.DeserializeBillingPrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingCurrencyTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotal = BillingPrice.DeserializeBillingPrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new BillingPaymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("extendedStatusInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedStatusInfo = ExtendedStatusInfo.DeserializeExtendedStatusInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingPlanPaymentDetail(
                dueDate,
                paymentDate,
                pricingCurrencyTotal,
                billingCurrencyTotal,
                status,
                extendedStatusInfo,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DueOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dueDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DueOn))
                {
                    builder.Append("  dueDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(DueOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PaymentCompletedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  paymentDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PaymentCompletedOn))
                {
                    builder.Append("  paymentDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(PaymentCompletedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PricingCurrencyTotal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  pricingCurrencyTotal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PricingCurrencyTotal))
                {
                    builder.Append("  pricingCurrencyTotal: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PricingCurrencyTotal, options, 2, false, "  pricingCurrencyTotal: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingCurrencyTotal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingCurrencyTotal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingCurrencyTotal))
                {
                    builder.Append("  billingCurrencyTotal: ");
                    BicepSerializationHelpers.AppendChildObject(builder, BillingCurrencyTotal, options, 2, false, "  billingCurrencyTotal: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    builder.AppendLine($"'{Status.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExtendedStatusInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  extendedStatusInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExtendedStatusInfo))
                {
                    builder.Append("  extendedStatusInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ExtendedStatusInfo, options, 2, false, "  extendedStatusInfo: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingPlanPaymentDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingPlanPaymentDetail)} does not support writing '{options.Format}' format.");
            }
        }

        BillingPlanPaymentDetail IPersistableModel<BillingPlanPaymentDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingPlanPaymentDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingPlanPaymentDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingPlanPaymentDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingPlanPaymentDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
