// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchTaskInfo : IUtf8JsonSerializable, IJsonModel<BatchTaskInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchTaskInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchTaskInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchTaskInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TaskUrl))
            {
                writer.WritePropertyName("taskUrl"u8);
                writer.WriteStringValue(TaskUrl);
            }
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
            }
            if (Optional.IsDefined(SubtaskId))
            {
                writer.WritePropertyName("subtaskId"u8);
                writer.WriteNumberValue(SubtaskId.Value);
            }
            writer.WritePropertyName("taskState"u8);
            writer.WriteStringValue(TaskState.ToString());
            if (Optional.IsDefined(ExecutionInfo))
            {
                writer.WritePropertyName("executionInfo"u8);
                writer.WriteObjectValue(ExecutionInfo, options);
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

        BatchTaskInfo IJsonModel<BatchTaskInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchTaskInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchTaskInfo(document.RootElement, options);
        }

        internal static BatchTaskInfo DeserializeBatchTaskInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string taskUrl = default;
            string jobId = default;
            string taskId = default;
            int? subtaskId = default;
            BatchTaskState taskState = default;
            BatchTaskExecutionInfo executionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("taskUrl"u8))
                {
                    taskUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subtaskId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subtaskId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskState"u8))
                {
                    taskState = new BatchTaskState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionInfo = BatchTaskExecutionInfo.DeserializeBatchTaskExecutionInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchTaskInfo(
                taskUrl,
                jobId,
                taskId,
                subtaskId,
                taskState,
                executionInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchTaskInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchTaskInfo)} does not support writing '{options.Format}' format.");
            }
        }

        BatchTaskInfo IPersistableModel<BatchTaskInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchTaskInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchTaskInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchTaskInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchTaskInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchTaskInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeBatchTaskInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
