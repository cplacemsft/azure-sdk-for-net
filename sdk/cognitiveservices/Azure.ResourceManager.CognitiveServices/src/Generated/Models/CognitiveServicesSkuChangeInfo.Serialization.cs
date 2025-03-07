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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesSkuChangeInfo : IUtf8JsonSerializable, IJsonModel<CognitiveServicesSkuChangeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CognitiveServicesSkuChangeInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CognitiveServicesSkuChangeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesSkuChangeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesSkuChangeInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CountOfDowngrades))
            {
                writer.WritePropertyName("countOfDowngrades"u8);
                writer.WriteNumberValue(CountOfDowngrades.Value);
            }
            if (Optional.IsDefined(CountOfUpgradesAfterDowngrades))
            {
                writer.WritePropertyName("countOfUpgradesAfterDowngrades"u8);
                writer.WriteNumberValue(CountOfUpgradesAfterDowngrades.Value);
            }
            if (Optional.IsDefined(LastChangedOn))
            {
                writer.WritePropertyName("lastChangeDate"u8);
                writer.WriteStringValue(LastChangedOn.Value, "O");
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

        CognitiveServicesSkuChangeInfo IJsonModel<CognitiveServicesSkuChangeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesSkuChangeInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesSkuChangeInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesSkuChangeInfo(document.RootElement, options);
        }

        internal static CognitiveServicesSkuChangeInfo DeserializeCognitiveServicesSkuChangeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? countOfDowngrades = default;
            float? countOfUpgradesAfterDowngrades = default;
            DateTimeOffset? lastChangeDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countOfDowngrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    countOfDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("countOfUpgradesAfterDowngrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    countOfUpgradesAfterDowngrades = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CognitiveServicesSkuChangeInfo(countOfDowngrades, countOfUpgradesAfterDowngrades, lastChangeDate, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CountOfDowngrades), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  countOfDowngrades: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CountOfDowngrades))
                {
                    builder.Append("  countOfDowngrades: ");
                    builder.AppendLine($"'{CountOfDowngrades.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CountOfUpgradesAfterDowngrades), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  countOfUpgradesAfterDowngrades: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CountOfUpgradesAfterDowngrades))
                {
                    builder.Append("  countOfUpgradesAfterDowngrades: ");
                    builder.AppendLine($"'{CountOfUpgradesAfterDowngrades.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastChangedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastChangeDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastChangedOn))
                {
                    builder.Append("  lastChangeDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastChangedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<CognitiveServicesSkuChangeInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesSkuChangeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesSkuChangeInfo)} does not support writing '{options.Format}' format.");
            }
        }

        CognitiveServicesSkuChangeInfo IPersistableModel<CognitiveServicesSkuChangeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesSkuChangeInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCognitiveServicesSkuChangeInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesSkuChangeInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CognitiveServicesSkuChangeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
