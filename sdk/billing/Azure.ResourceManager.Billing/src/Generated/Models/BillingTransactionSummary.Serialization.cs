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
    public partial class BillingTransactionSummary : IUtf8JsonSerializable, IJsonModel<BillingTransactionSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingTransactionSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BillingTransactionSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingTransactionSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingTransactionSummary)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(AzureCreditApplied))
            {
                writer.WritePropertyName("azureCreditApplied"u8);
                writer.WriteNumberValue(AzureCreditApplied.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingCurrency))
            {
                writer.WritePropertyName("billingCurrency"u8);
                writer.WriteStringValue(BillingCurrency);
            }
            if (options.Format != "W" && Optional.IsDefined(ConsumptionCommitmentDecremented))
            {
                writer.WritePropertyName("consumptionCommitmentDecremented"u8);
                writer.WriteNumberValue(ConsumptionCommitmentDecremented.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(SubTotal))
            {
                writer.WritePropertyName("subTotal"u8);
                writer.WriteNumberValue(SubTotal.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Tax))
            {
                writer.WritePropertyName("tax"u8);
                writer.WriteNumberValue(Tax.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
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

        BillingTransactionSummary IJsonModel<BillingTransactionSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingTransactionSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BillingTransactionSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingTransactionSummary(document.RootElement, options);
        }

        internal static BillingTransactionSummary DeserializeBillingTransactionSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? azureCreditApplied = default;
            string billingCurrency = default;
            float? consumptionCommitmentDecremented = default;
            float? subTotal = default;
            float? tax = default;
            float? total = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureCreditApplied"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureCreditApplied = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("billingCurrency"u8))
                {
                    billingCurrency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumptionCommitmentDecremented"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consumptionCommitmentDecremented = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("subTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subTotal = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tax"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tax = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BillingTransactionSummary(
                azureCreditApplied,
                billingCurrency,
                consumptionCommitmentDecremented,
                subTotal,
                tax,
                total,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AzureCreditApplied), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  azureCreditApplied: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AzureCreditApplied))
                {
                    builder.Append("  azureCreditApplied: ");
                    builder.AppendLine($"'{AzureCreditApplied.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingCurrency), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingCurrency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingCurrency))
                {
                    builder.Append("  billingCurrency: ");
                    if (BillingCurrency.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingCurrency}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingCurrency}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsumptionCommitmentDecremented), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consumptionCommitmentDecremented: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsumptionCommitmentDecremented))
                {
                    builder.Append("  consumptionCommitmentDecremented: ");
                    builder.AppendLine($"'{ConsumptionCommitmentDecremented.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubTotal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subTotal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubTotal))
                {
                    builder.Append("  subTotal: ");
                    builder.AppendLine($"'{SubTotal.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tax), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tax: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Tax))
                {
                    builder.Append("  tax: ");
                    builder.AppendLine($"'{Tax.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Total), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  total: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Total))
                {
                    builder.Append("  total: ");
                    builder.AppendLine($"'{Total.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BillingTransactionSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingTransactionSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BillingTransactionSummary)} does not support writing '{options.Format}' format.");
            }
        }

        BillingTransactionSummary IPersistableModel<BillingTransactionSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BillingTransactionSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBillingTransactionSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BillingTransactionSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BillingTransactionSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
