// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class PipelineElapsedTimeMetricPolicy : IUtf8JsonSerializable, IJsonModel<PipelineElapsedTimeMetricPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineElapsedTimeMetricPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PipelineElapsedTimeMetricPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineElapsedTimeMetricPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineElapsedTimeMetricPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Duration);
#else
                using (JsonDocument document = JsonDocument.Parse(Duration, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        PipelineElapsedTimeMetricPolicy IJsonModel<PipelineElapsedTimeMetricPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineElapsedTimeMetricPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineElapsedTimeMetricPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineElapsedTimeMetricPolicy(document.RootElement, options);
        }

        internal static PipelineElapsedTimeMetricPolicy DeserializePipelineElapsedTimeMetricPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData duration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PipelineElapsedTimeMetricPolicy(duration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PipelineElapsedTimeMetricPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineElapsedTimeMetricPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PipelineElapsedTimeMetricPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineElapsedTimeMetricPolicy IPersistableModel<PipelineElapsedTimeMetricPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineElapsedTimeMetricPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePipelineElapsedTimeMetricPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineElapsedTimeMetricPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineElapsedTimeMetricPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
