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
    internal partial class DataSourcesSpecDataImports : IUtf8JsonSerializable, IJsonModel<DataSourcesSpecDataImports>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataSourcesSpecDataImports>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataSourcesSpecDataImports>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpecDataImports>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourcesSpecDataImports)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DataSourcesSpecDataImports IJsonModel<DataSourcesSpecDataImports>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpecDataImports>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourcesSpecDataImports)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourcesSpecDataImports(document.RootElement, options);
        }

        internal static DataSourcesSpecDataImports DeserializeDataSourcesSpecDataImports(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataImportSourcesEventHub eventHub = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHub = DataImportSourcesEventHub.DeserializeDataImportSourcesEventHub(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataSourcesSpecDataImports(eventHub, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataSourcesSpecDataImports>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpecDataImports>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataSourcesSpecDataImports)} does not support writing '{options.Format}' format.");
            }
        }

        DataSourcesSpecDataImports IPersistableModel<DataSourcesSpecDataImports>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourcesSpecDataImports>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataSourcesSpecDataImports(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataSourcesSpecDataImports)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataSourcesSpecDataImports>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
