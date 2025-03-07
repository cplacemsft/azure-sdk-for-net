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
    public partial class DataFactoryDataFlowDebugInfo : IUtf8JsonSerializable, IJsonModel<DataFactoryDataFlowDebugInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryDataFlowDebugInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryDataFlowDebugInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties, options);
        }

        DataFactoryDataFlowDebugInfo IJsonModel<DataFactoryDataFlowDebugInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryDataFlowDebugInfo(document.RootElement, options);
        }

        internal static DataFactoryDataFlowDebugInfo DeserializeDataFactoryDataFlowDebugInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryDataFlowProperties properties = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = DataFactoryDataFlowProperties.DeserializeDataFactoryDataFlowProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryDataFlowDebugInfo(name, serializedAdditionalRawData, properties);
        }

        BinaryData IPersistableModel<DataFactoryDataFlowDebugInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryDataFlowDebugInfo IPersistableModel<DataFactoryDataFlowDebugInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryDataFlowDebugInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataFactoryDataFlowDebugInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryDataFlowDebugInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryDataFlowDebugInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
