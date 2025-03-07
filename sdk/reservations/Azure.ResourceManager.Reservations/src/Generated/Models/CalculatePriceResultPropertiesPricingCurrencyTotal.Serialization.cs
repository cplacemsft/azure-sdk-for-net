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
    public partial class CalculatePriceResultPropertiesPricingCurrencyTotal : IUtf8JsonSerializable, IJsonModel<CalculatePriceResultPropertiesPricingCurrencyTotal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CalculatePriceResultPropertiesPricingCurrencyTotal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesPricingCurrencyTotal)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CurrencyCode))
            {
                writer.WritePropertyName("currencyCode"u8);
                writer.WriteStringValue(CurrencyCode);
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
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

        CalculatePriceResultPropertiesPricingCurrencyTotal IJsonModel<CalculatePriceResultPropertiesPricingCurrencyTotal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesPricingCurrencyTotal)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(document.RootElement, options);
        }

        internal static CalculatePriceResultPropertiesPricingCurrencyTotal DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string currencyCode = default;
            float? amount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currencyCode"u8))
                {
                    currencyCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CalculatePriceResultPropertiesPricingCurrencyTotal(currencyCode, amount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesPricingCurrencyTotal)} does not support writing '{options.Format}' format.");
            }
        }

        CalculatePriceResultPropertiesPricingCurrencyTotal IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCalculatePriceResultPropertiesPricingCurrencyTotal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CalculatePriceResultPropertiesPricingCurrencyTotal)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CalculatePriceResultPropertiesPricingCurrencyTotal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
