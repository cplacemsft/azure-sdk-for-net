// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointRehydrationInfo : IUtf8JsonSerializable, IJsonModel<RecoveryPointRehydrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointRehydrationInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RecoveryPointRehydrationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(RehydrationRetentionDuration))
            {
                writer.WritePropertyName("rehydrationRetentionDuration"u8);
                writer.WriteStringValue(RehydrationRetentionDuration.Value, "P");
            }
            if (Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority.Value.ToString());
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

        RecoveryPointRehydrationInfo IJsonModel<RecoveryPointRehydrationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointRehydrationInfo(document.RootElement, options);
        }

        internal static RecoveryPointRehydrationInfo DeserializeRecoveryPointRehydrationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan? rehydrationRetentionDuration = default;
            RehydrationPriority? rehydrationPriority = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationPriority = new RehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RecoveryPointRehydrationInfo(rehydrationRetentionDuration, rehydrationPriority, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointRehydrationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support writing '{options.Format}' format.");
            }
        }

        RecoveryPointRehydrationInfo IPersistableModel<RecoveryPointRehydrationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryPointRehydrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRecoveryPointRehydrationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryPointRehydrationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
