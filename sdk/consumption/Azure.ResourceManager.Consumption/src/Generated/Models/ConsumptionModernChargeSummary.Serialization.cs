// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionModernChargeSummary : IUtf8JsonSerializable, IJsonModel<ConsumptionModernChargeSummary>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionModernChargeSummary>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsumptionModernChargeSummary>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernChargeSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernChargeSummary)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BillingPeriodId))
            {
                writer.WritePropertyName("billingPeriodId"u8);
                writer.WriteStringValue(BillingPeriodId);
            }
            if (options.Format != "W" && Optional.IsDefined(UsageStart))
            {
                writer.WritePropertyName("usageStart"u8);
                writer.WriteStringValue(UsageStart);
            }
            if (options.Format != "W" && Optional.IsDefined(UsageEnd))
            {
                writer.WritePropertyName("usageEnd"u8);
                writer.WriteStringValue(UsageEnd);
            }
            if (options.Format != "W" && Optional.IsDefined(AzureCharges))
            {
                writer.WritePropertyName("azureCharges"u8);
                writer.WriteObjectValue(AzureCharges, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ChargesBilledSeparately))
            {
                writer.WritePropertyName("chargesBilledSeparately"u8);
                writer.WriteObjectValue(ChargesBilledSeparately, options);
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceCharges))
            {
                writer.WritePropertyName("marketplaceCharges"u8);
                writer.WriteObjectValue(MarketplaceCharges, options);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingAccountId))
            {
                writer.WritePropertyName("billingAccountId"u8);
                writer.WriteStringValue(BillingAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionId))
            {
                writer.WritePropertyName("invoiceSectionId"u8);
                writer.WriteStringValue(InvoiceSectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId"u8);
                writer.WriteStringValue(CustomerId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsInvoiced))
            {
                writer.WritePropertyName("isInvoiced"u8);
                writer.WriteBooleanValue(IsInvoiced.Value);
            }
            writer.WriteEndObject();
        }

        ConsumptionModernChargeSummary IJsonModel<ConsumptionModernChargeSummary>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernChargeSummary>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionModernChargeSummary)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionModernChargeSummary(document.RootElement, options);
        }

        internal static ConsumptionModernChargeSummary DeserializeConsumptionModernChargeSummary(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChargeSummaryKind kind = default;
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string billingPeriodId = default;
            string usageStart = default;
            string usageEnd = default;
            ConsumptionAmount azureCharges = default;
            ConsumptionAmount chargesBilledSeparately = default;
            ConsumptionAmount marketplaceCharges = default;
            string billingAccountId = default;
            string billingProfileId = default;
            string invoiceSectionId = default;
            string customerId = default;
            bool? isInvoiced = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ChargeSummaryKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("billingPeriodId"u8))
                        {
                            billingPeriodId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageStart"u8))
                        {
                            usageStart = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("usageEnd"u8))
                        {
                            usageEnd = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azureCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureCharges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("chargesBilledSeparately"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            chargesBilledSeparately = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("marketplaceCharges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            marketplaceCharges = ConsumptionAmount.DeserializeConsumptionAmount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("billingAccountId"u8))
                        {
                            billingAccountId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingProfileId"u8))
                        {
                            billingProfileId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoiceSectionId"u8))
                        {
                            invoiceSectionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customerId"u8))
                        {
                            customerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isInvoiced"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isInvoiced = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsumptionModernChargeSummary(
                id,
                name,
                type,
                systemData,
                kind,
                etag,
                serializedAdditionalRawData,
                billingPeriodId,
                usageStart,
                usageEnd,
                azureCharges,
                chargesBilledSeparately,
                marketplaceCharges,
                billingAccountId,
                billingProfileId,
                invoiceSectionId,
                customerId,
                isInvoiced);
        }

        BinaryData IPersistableModel<ConsumptionModernChargeSummary>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernChargeSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernChargeSummary)} does not support writing '{options.Format}' format.");
            }
        }

        ConsumptionModernChargeSummary IPersistableModel<ConsumptionModernChargeSummary>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionModernChargeSummary>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConsumptionModernChargeSummary(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionModernChargeSummary)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionModernChargeSummary>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
