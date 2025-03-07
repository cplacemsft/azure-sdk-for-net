// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    internal partial class AnalysisServers : IUtf8JsonSerializable, IJsonModel<AnalysisServers>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalysisServers>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalysisServers>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisServers)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in AnalysisResources)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        AnalysisServers IJsonModel<AnalysisServers>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServers>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalysisServers)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalysisServers(document.RootElement, options);
        }

        internal static AnalysisServers DeserializeAnalysisServers(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AnalysisServerData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AnalysisServerData> array = new List<AnalysisServerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalysisServerData.DeserializeAnalysisServerData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AnalysisServers(value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnalysisServers>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnalysisServers)} does not support writing '{options.Format}' format.");
            }
        }

        AnalysisServers IPersistableModel<AnalysisServers>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalysisServers>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAnalysisServers(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalysisServers)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalysisServers>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
