// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageMover.Models
{
    public partial class UploadLimitWeeklyRecurrence : IUtf8JsonSerializable, IJsonModel<UploadLimitWeeklyRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UploadLimitWeeklyRecurrence>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UploadLimitWeeklyRecurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadLimitWeeklyRecurrence)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("limitInMbps"u8);
            writer.WriteNumberValue(LimitInMbps);
        }

        UploadLimitWeeklyRecurrence IJsonModel<UploadLimitWeeklyRecurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UploadLimitWeeklyRecurrence)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUploadLimitWeeklyRecurrence(document.RootElement, options);
        }

        internal static UploadLimitWeeklyRecurrence DeserializeUploadLimitWeeklyRecurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int limitInMbps = default;
            IList<ScheduleDayOfWeek> days = default;
            ScheduleTime startTime = default;
            ScheduleTime endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("limitInMbps"u8))
                {
                    limitInMbps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("days"u8))
                {
                    List<ScheduleDayOfWeek> array = new List<ScheduleDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToScheduleDayOfWeek());
                    }
                    days = array;
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = ScheduleTime.DeserializeScheduleTime(property.Value, options);
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = ScheduleTime.DeserializeScheduleTime(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UploadLimitWeeklyRecurrence(startTime, endTime, serializedAdditionalRawData, days, limitInMbps);
        }

        BinaryData IPersistableModel<UploadLimitWeeklyRecurrence>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UploadLimitWeeklyRecurrence)} does not support writing '{options.Format}' format.");
            }
        }

        UploadLimitWeeklyRecurrence IPersistableModel<UploadLimitWeeklyRecurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UploadLimitWeeklyRecurrence>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUploadLimitWeeklyRecurrence(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UploadLimitWeeklyRecurrence)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UploadLimitWeeklyRecurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
