// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class SavingsPlanModelListResult : IUtf8JsonSerializable, IJsonModel<SavingsPlanModelListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanModelListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SavingsPlanModelListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanModelListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanModelListResult)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalProperties)
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

        SavingsPlanModelListResult IJsonModel<SavingsPlanModelListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanModelListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SavingsPlanModelListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanModelListResult(document.RootElement, options);
        }

        internal static SavingsPlanModelListResult DeserializeSavingsPlanModelListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<BillingBenefitsSavingsPlanData> value = default;
            string nextLink = default;
            IReadOnlyList<SavingsPlanSummary> additionalProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingBenefitsSavingsPlanData> array = new List<BillingBenefitsSavingsPlanData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingBenefitsSavingsPlanData.DeserializeBillingBenefitsSavingsPlanData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SavingsPlanSummary> array = new List<SavingsPlanSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SavingsPlanSummary.DeserializeSavingsPlanSummary(item, options));
                    }
                    additionalProperties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SavingsPlanModelListResult(value ?? new ChangeTrackingList<BillingBenefitsSavingsPlanData>(), nextLink, additionalProperties ?? new ChangeTrackingList<SavingsPlanSummary>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanModelListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanModelListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanModelListResult)} does not support writing '{options.Format}' format.");
            }
        }

        SavingsPlanModelListResult IPersistableModel<SavingsPlanModelListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SavingsPlanModelListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSavingsPlanModelListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SavingsPlanModelListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SavingsPlanModelListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
