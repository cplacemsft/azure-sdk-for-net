// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MetricTrigger : IUtf8JsonSerializable, IJsonModel<MetricTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricTrigger>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MetricTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricTrigger)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(MetricName);
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WritePropertyName("metricResourceUri"u8);
            writer.WriteStringValue(MetricResourceId);
            if (Optional.IsDefined(MetricResourceLocation))
            {
                writer.WritePropertyName("metricResourceLocation"u8);
                writer.WriteStringValue(MetricResourceLocation.Value);
            }
            writer.WritePropertyName("timeGrain"u8);
            writer.WriteStringValue(TimeGrain, "P");
            writer.WritePropertyName("statistic"u8);
            writer.WriteStringValue(Statistic.ToSerialString());
            writer.WritePropertyName("timeWindow"u8);
            writer.WriteStringValue(TimeWindow, "P");
            writer.WritePropertyName("timeAggregation"u8);
            writer.WriteStringValue(TimeAggregation.ToSerialString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToSerialString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            if (Optional.IsCollectionDefined(Dimensions))
            {
                if (Dimensions != null)
                {
                    writer.WritePropertyName("dimensions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Dimensions)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("dimensions");
                }
            }
            if (Optional.IsDefined(IsDividedPerInstance))
            {
                writer.WritePropertyName("dividePerInstance"u8);
                writer.WriteBooleanValue(IsDividedPerInstance.Value);
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

        MetricTrigger IJsonModel<MetricTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricTrigger)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricTrigger(document.RootElement, options);
        }

        internal static MetricTrigger DeserializeMetricTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metricName = default;
            string metricNamespace = default;
            ResourceIdentifier metricResourceUri = default;
            AzureLocation? metricResourceLocation = default;
            TimeSpan timeGrain = default;
            MetricStatisticType statistic = default;
            TimeSpan timeWindow = default;
            MetricTriggerTimeAggregationType timeAggregation = default;
            MetricTriggerComparisonOperation @operator = default;
            double threshold = default;
            IList<AutoscaleRuleMetricDimension> dimensions = default;
            bool? dividePerInstance = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricResourceUri"u8))
                {
                    metricResourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricResourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metricResourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeGrain"u8))
                {
                    timeGrain = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("statistic"u8))
                {
                    statistic = property.Value.GetString().ToMetricStatisticType();
                    continue;
                }
                if (property.NameEquals("timeWindow"u8))
                {
                    timeWindow = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    timeAggregation = property.Value.GetString().ToMetricTriggerTimeAggregationType();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = property.Value.GetString().ToMetricTriggerComparisonOperation();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("dimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dimensions = null;
                        continue;
                    }
                    List<AutoscaleRuleMetricDimension> array = new List<AutoscaleRuleMetricDimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoscaleRuleMetricDimension.DeserializeAutoscaleRuleMetricDimension(item, options));
                    }
                    dimensions = array;
                    continue;
                }
                if (property.NameEquals("dividePerInstance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dividePerInstance = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MetricTrigger(
                metricName,
                metricNamespace,
                metricResourceUri,
                metricResourceLocation,
                timeGrain,
                statistic,
                timeWindow,
                timeAggregation,
                @operator,
                threshold,
                dimensions ?? new ChangeTrackingList<AutoscaleRuleMetricDimension>(),
                dividePerInstance,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MetricTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricTrigger)} does not support writing '{options.Format}' format.");
            }
        }

        MetricTrigger IPersistableModel<MetricTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMetricTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricTrigger)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
