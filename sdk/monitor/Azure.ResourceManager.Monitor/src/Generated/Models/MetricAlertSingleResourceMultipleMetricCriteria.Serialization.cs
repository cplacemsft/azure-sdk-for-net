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
    public partial class MetricAlertSingleResourceMultipleMetricCriteria : IUtf8JsonSerializable, IJsonModel<MetricAlertSingleResourceMultipleMetricCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricAlertSingleResourceMultipleMetricCriteria>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MetricAlertSingleResourceMultipleMetricCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertSingleResourceMultipleMetricCriteria)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(AllOf))
            {
                writer.WritePropertyName("allOf"u8);
                writer.WriteStartArray();
                foreach (var item in AllOf)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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

        MetricAlertSingleResourceMultipleMetricCriteria IJsonModel<MetricAlertSingleResourceMultipleMetricCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MetricAlertSingleResourceMultipleMetricCriteria)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricAlertSingleResourceMultipleMetricCriteria(document.RootElement, options);
        }

        internal static MetricAlertSingleResourceMultipleMetricCriteria DeserializeMetricAlertSingleResourceMultipleMetricCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MetricCriteria> allOf = default;
            MonitorOdataType odataType = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allOf"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetricCriteria> array = new List<MetricCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricCriteria.DeserializeMetricCriteria(item, options));
                    }
                    allOf = array;
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = new MonitorOdataType(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MetricAlertSingleResourceMultipleMetricCriteria(odataType, additionalProperties, allOf ?? new ChangeTrackingList<MetricCriteria>());
        }

        BinaryData IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MetricAlertSingleResourceMultipleMetricCriteria)} does not support writing '{options.Format}' format.");
            }
        }

        MetricAlertSingleResourceMultipleMetricCriteria IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMetricAlertSingleResourceMultipleMetricCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MetricAlertSingleResourceMultipleMetricCriteria)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MetricAlertSingleResourceMultipleMetricCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
