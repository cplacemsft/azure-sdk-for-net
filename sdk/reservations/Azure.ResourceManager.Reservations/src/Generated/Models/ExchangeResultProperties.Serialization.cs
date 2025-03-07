// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ExchangeResultProperties : IUtf8JsonSerializable, IJsonModel<ExchangeResultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExchangeResultProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExchangeResultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId.Value);
            }
            if (Optional.IsDefined(NetPayable))
            {
                writer.WritePropertyName("netPayable"u8);
                writer.WriteObjectValue(NetPayable, options);
            }
            if (Optional.IsDefined(RefundsTotal))
            {
                writer.WritePropertyName("refundsTotal"u8);
                writer.WriteObjectValue(RefundsTotal, options);
            }
            if (Optional.IsDefined(PurchasesTotal))
            {
                writer.WritePropertyName("purchasesTotal"u8);
                writer.WriteObjectValue(PurchasesTotal, options);
            }
            if (Optional.IsCollectionDefined(ReservationsToPurchase))
            {
                writer.WritePropertyName("reservationsToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToPurchase)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SavingsPlansToPurchase))
            {
                writer.WritePropertyName("savingsPlansToPurchase"u8);
                writer.WriteStartArray();
                foreach (var item in SavingsPlansToPurchase)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReservationsToExchange))
            {
                writer.WritePropertyName("reservationsToExchange"u8);
                writer.WriteStartArray();
                foreach (var item in ReservationsToExchange)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyResult))
            {
                writer.WritePropertyName("policyResult"u8);
                writer.WriteObjectValue(PolicyResult, options);
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

        ExchangeResultProperties IJsonModel<ExchangeResultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExchangeResultProperties(document.RootElement, options);
        }

        internal static ExchangeResultProperties DeserializeExchangeResultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? sessionId = default;
            PurchasePrice netPayable = default;
            PurchasePrice refundsTotal = default;
            PurchasePrice purchasesTotal = default;
            IReadOnlyList<ReservationToPurchaseExchange> reservationsToPurchase = default;
            IReadOnlyList<SavingsPlanToPurchaseExchange> savingsPlansToPurchase = default;
            IReadOnlyList<ReservationToReturnForExchange> reservationsToExchange = default;
            ExchangePolicyErrors policyResult = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("netPayable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    netPayable = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("refundsTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refundsTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("purchasesTotal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchasesTotal = PurchasePrice.DeserializePurchasePrice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reservationsToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToPurchaseExchange> array = new List<ReservationToPurchaseExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToPurchaseExchange.DeserializeReservationToPurchaseExchange(item, options));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("savingsPlansToPurchase"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanToPurchaseExchange> array = new List<SavingsPlanToPurchaseExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanToPurchaseExchange.DeserializeSavingsPlanToPurchaseExchange(item, options));
                    }
                    savingsPlansToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationToReturnForExchange> array = new List<ReservationToReturnForExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToReturnForExchange.DeserializeReservationToReturnForExchange(item, options));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (property.NameEquals("policyResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyResult = ExchangePolicyErrors.DeserializeExchangePolicyErrors(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExchangeResultProperties(
                sessionId,
                netPayable,
                refundsTotal,
                purchasesTotal,
                reservationsToPurchase ?? new ChangeTrackingList<ReservationToPurchaseExchange>(),
                savingsPlansToPurchase ?? new ChangeTrackingList<SavingsPlanToPurchaseExchange>(),
                reservationsToExchange ?? new ChangeTrackingList<ReservationToReturnForExchange>(),
                policyResult,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExchangeResultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ExchangeResultProperties IPersistableModel<ExchangeResultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExchangeResultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExchangeResultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExchangeResultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExchangeResultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
