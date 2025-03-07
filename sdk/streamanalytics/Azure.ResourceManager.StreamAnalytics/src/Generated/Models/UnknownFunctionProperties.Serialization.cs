// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    internal partial class UnknownFunctionProperties : IUtf8JsonSerializable, IJsonModel<StreamingJobFunctionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamingJobFunctionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamingJobFunctionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        StreamingJobFunctionProperties IJsonModel<StreamingJobFunctionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobFunctionProperties(document.RootElement, options);
        }

        internal static UnknownFunctionProperties DeserializeUnknownFunctionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            ETag? etag = default;
            IList<StreamingJobFunctionInput> inputs = default;
            StreamingJobFunctionOutput output = default;
            StreamingJobFunctionBinding binding = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StreamingJobFunctionInput> array = new List<StreamingJobFunctionInput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StreamingJobFunctionInput.DeserializeStreamingJobFunctionInput(item, options));
                            }
                            inputs = array;
                            continue;
                        }
                        if (property0.NameEquals("output"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            output = StreamingJobFunctionOutput.DeserializeStreamingJobFunctionOutput(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("binding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            binding = StreamingJobFunctionBinding.DeserializeStreamingJobFunctionBinding(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownFunctionProperties(
                type,
                etag,
                inputs ?? new ChangeTrackingList<StreamingJobFunctionInput>(),
                output,
                binding,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StreamingJobFunctionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingJobFunctionProperties IPersistableModel<StreamingJobFunctionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamingJobFunctionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStreamingJobFunctionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingJobFunctionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingJobFunctionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
