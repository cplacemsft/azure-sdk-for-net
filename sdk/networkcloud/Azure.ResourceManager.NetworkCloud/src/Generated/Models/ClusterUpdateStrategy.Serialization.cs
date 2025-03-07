// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class ClusterUpdateStrategy : IUtf8JsonSerializable, IJsonModel<ClusterUpdateStrategy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterUpdateStrategy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterUpdateStrategy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpdateStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpdateStrategy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MaxUnavailable))
            {
                writer.WritePropertyName("maxUnavailable"u8);
                writer.WriteNumberValue(MaxUnavailable.Value);
            }
            writer.WritePropertyName("strategyType"u8);
            writer.WriteStringValue(StrategyType.ToString());
            writer.WritePropertyName("thresholdType"u8);
            writer.WriteStringValue(ThresholdType.ToString());
            writer.WritePropertyName("thresholdValue"u8);
            writer.WriteNumberValue(ThresholdValue);
            if (Optional.IsDefined(WaitTimeMinutes))
            {
                writer.WritePropertyName("waitTimeMinutes"u8);
                writer.WriteNumberValue(WaitTimeMinutes.Value);
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

        ClusterUpdateStrategy IJsonModel<ClusterUpdateStrategy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpdateStrategy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterUpdateStrategy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterUpdateStrategy(document.RootElement, options);
        }

        internal static ClusterUpdateStrategy DeserializeClusterUpdateStrategy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? maxUnavailable = default;
            ClusterUpdateStrategyType strategyType = default;
            ValidationThresholdType thresholdType = default;
            long thresholdValue = default;
            long? waitTimeMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxUnavailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxUnavailable = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("strategyType"u8))
                {
                    strategyType = new ClusterUpdateStrategyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("thresholdType"u8))
                {
                    thresholdType = new ValidationThresholdType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("thresholdValue"u8))
                {
                    thresholdValue = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("waitTimeMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    waitTimeMinutes = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterUpdateStrategy(
                maxUnavailable,
                strategyType,
                thresholdType,
                thresholdValue,
                waitTimeMinutes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterUpdateStrategy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpdateStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterUpdateStrategy)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterUpdateStrategy IPersistableModel<ClusterUpdateStrategy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterUpdateStrategy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeClusterUpdateStrategy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterUpdateStrategy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterUpdateStrategy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
