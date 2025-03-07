// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class ExecutionStatistics : IUtf8JsonSerializable, IJsonModel<ExecutionStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecutionStatistics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExecutionStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ExecutionCount))
            {
                writer.WritePropertyName("executionCount"u8);
                writer.WriteNumberValue(ExecutionCount.Value);
            }
            if (Optional.IsDefined(CpuTimeMs))
            {
                writer.WritePropertyName("cpuTimeMs"u8);
                writer.WriteNumberValue(CpuTimeMs.Value);
            }
            if (Optional.IsDefined(ElapsedTimeMs))
            {
                writer.WritePropertyName("elapsedTimeMs"u8);
                writer.WriteNumberValue(ElapsedTimeMs.Value);
            }
            if (Optional.IsCollectionDefined(WaitStats))
            {
                writer.WritePropertyName("waitStats"u8);
                writer.WriteStartObject();
                foreach (var item in WaitStats)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(HasErrors))
            {
                writer.WritePropertyName("hasErrors"u8);
                writer.WriteBooleanValue(HasErrors.Value);
            }
            if (Optional.IsCollectionDefined(SqlErrors))
            {
                writer.WritePropertyName("sqlErrors"u8);
                writer.WriteStartArray();
                foreach (var item in SqlErrors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ExecutionStatistics IJsonModel<ExecutionStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecutionStatistics(document.RootElement, options);
        }

        internal static ExecutionStatistics DeserializeExecutionStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? executionCount = default;
            float? cpuTimeMs = default;
            float? elapsedTimeMs = default;
            IReadOnlyDictionary<string, WaitStatistics> waitStats = default;
            bool? hasErrors = default;
            IReadOnlyList<string> sqlErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("executionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    executionCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cpuTimeMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuTimeMs = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("elapsedTimeMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elapsedTimeMs = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("waitStats"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WaitStatistics> dictionary = new Dictionary<string, WaitStatistics>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, WaitStatistics.DeserializeWaitStatistics(property0.Value, options));
                    }
                    waitStats = dictionary;
                    continue;
                }
                if (property.NameEquals("hasErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasErrors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sqlErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sqlErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExecutionStatistics(
                executionCount,
                cpuTimeMs,
                elapsedTimeMs,
                waitStats ?? new ChangeTrackingDictionary<string, WaitStatistics>(),
                hasErrors,
                sqlErrors ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExecutionStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        ExecutionStatistics IPersistableModel<ExecutionStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExecutionStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecutionStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecutionStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
