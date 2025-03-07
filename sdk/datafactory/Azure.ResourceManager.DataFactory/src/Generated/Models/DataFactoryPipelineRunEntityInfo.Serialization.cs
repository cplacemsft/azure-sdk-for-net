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
    public partial class DataFactoryPipelineRunEntityInfo : IUtf8JsonSerializable, IJsonModel<DataFactoryPipelineRunEntityInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryPipelineRunEntityInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataFactoryPipelineRunEntityInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunEntityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPipelineRunEntityInfo)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(InvokedByType))
            {
                writer.WritePropertyName("invokedByType"u8);
                writer.WriteStringValue(InvokedByType);
            }
            if (options.Format != "W" && Optional.IsDefined(PipelineName))
            {
                writer.WritePropertyName("pipelineName"u8);
                writer.WriteStringValue(PipelineName);
            }
            if (options.Format != "W" && Optional.IsDefined(PipelineRunId))
            {
                writer.WritePropertyName("pipelineRunId"u8);
                writer.WriteStringValue(PipelineRunId.Value);
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

        DataFactoryPipelineRunEntityInfo IJsonModel<DataFactoryPipelineRunEntityInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunEntityInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPipelineRunEntityInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryPipelineRunEntityInfo(document.RootElement, options);
        }

        internal static DataFactoryPipelineRunEntityInfo DeserializeDataFactoryPipelineRunEntityInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string id = default;
            string invokedByType = default;
            string pipelineName = default;
            Guid? pipelineRunId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invokedByType"u8))
                {
                    invokedByType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineRunId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataFactoryPipelineRunEntityInfo(
                name,
                id,
                invokedByType,
                pipelineName,
                pipelineRunId,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFactoryPipelineRunEntityInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunEntityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPipelineRunEntityInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DataFactoryPipelineRunEntityInfo IPersistableModel<DataFactoryPipelineRunEntityInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPipelineRunEntityInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataFactoryPipelineRunEntityInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPipelineRunEntityInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryPipelineRunEntityInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
