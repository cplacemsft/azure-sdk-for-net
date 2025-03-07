// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetInnerError : IUtf8JsonSerializable, IJsonModel<ComputeFleetInnerError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetInnerError>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetInnerError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetInnerError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetInnerError)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ExceptionType))
            {
                writer.WritePropertyName("exceptionType"u8);
                writer.WriteStringValue(ExceptionType);
            }
            if (Optional.IsDefined(ErrorDetail))
            {
                writer.WritePropertyName("errorDetail"u8);
                writer.WriteStringValue(ErrorDetail);
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

        ComputeFleetInnerError IJsonModel<ComputeFleetInnerError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetInnerError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetInnerError)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetInnerError(document.RootElement, options);
        }

        internal static ComputeFleetInnerError DeserializeComputeFleetInnerError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string exceptionType = default;
            string errorDetail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exceptionType"u8))
                {
                    exceptionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetail"u8))
                {
                    errorDetail = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetInnerError(exceptionType, errorDetail, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetInnerError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetInnerError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetInnerError)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetInnerError IPersistableModel<ComputeFleetInnerError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetInnerError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeComputeFleetInnerError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetInnerError)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetInnerError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
