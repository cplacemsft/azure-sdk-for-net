// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleRecurrence : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleRecurrence>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightAutoScaleRecurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsCollectionDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteStartArray();
                foreach (var item in Schedule)
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

        HDInsightAutoScaleRecurrence IJsonModel<HDInsightAutoScaleRecurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleRecurrence(document.RootElement, options);
        }

        internal static HDInsightAutoScaleRecurrence DeserializeHDInsightAutoScaleRecurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string timeZone = default;
            IList<HDInsightAutoScaleSchedule> schedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightAutoScaleSchedule> array = new List<HDInsightAutoScaleSchedule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightAutoScaleSchedule.DeserializeHDInsightAutoScaleSchedule(item, options));
                    }
                    schedule = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightAutoScaleRecurrence(timeZone, schedule ?? new ChangeTrackingList<HDInsightAutoScaleSchedule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleRecurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAutoScaleRecurrence IPersistableModel<HDInsightAutoScaleRecurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightAutoScaleRecurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAutoScaleRecurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
