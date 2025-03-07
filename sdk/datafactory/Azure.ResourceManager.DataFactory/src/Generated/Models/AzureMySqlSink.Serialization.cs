// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureMySqlSink : IUtf8JsonSerializable, IJsonModel<AzureMySqlSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMySqlSink>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureMySqlSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMySqlSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMySqlSink)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(PreCopyScript))
            {
                writer.WritePropertyName("preCopyScript"u8);
                JsonSerializer.Serialize(writer, PreCopyScript);
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

        AzureMySqlSink IJsonModel<AzureMySqlSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMySqlSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMySqlSink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMySqlSink(document.RootElement, options);
        }

        internal static AzureMySqlSink DeserializeAzureMySqlSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> preCopyScript = default;
            string type = default;
            DataFactoryElement<int> writeBatchSize = default;
            DataFactoryElement<string> writeBatchTimeout = default;
            DataFactoryElement<int> sinkRetryCount = default;
            DataFactoryElement<string> sinkRetryWait = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preCopyScript"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preCopyScript = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureMySqlSink(
                type,
                writeBatchSize,
                writeBatchTimeout,
                sinkRetryCount,
                sinkRetryWait,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                preCopyScript);
        }

        BinaryData IPersistableModel<AzureMySqlSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMySqlSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureMySqlSink)} does not support writing '{options.Format}' format.");
            }
        }

        AzureMySqlSink IPersistableModel<AzureMySqlSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMySqlSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureMySqlSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMySqlSink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMySqlSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
