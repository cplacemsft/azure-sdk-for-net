// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class KubernetesDaemonSet : IUtf8JsonSerializable, IJsonModel<KubernetesDaemonSet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesDaemonSet>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesDaemonSet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesDaemonSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesDaemonSet)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(DesiredNumberOfPods))
            {
                writer.WritePropertyName("desired"u8);
                writer.WriteNumberValue(DesiredNumberOfPods.Value);
            }
            if (Optional.IsDefined(CurrentNumberOfPods))
            {
                writer.WritePropertyName("current"u8);
                writer.WriteNumberValue(CurrentNumberOfPods.Value);
            }
            if (Optional.IsDefined(ReadyNumberOfPods))
            {
                writer.WritePropertyName("ready"u8);
                writer.WriteNumberValue(ReadyNumberOfPods.Value);
            }
            if (Optional.IsDefined(UpToDateNumberOfPods))
            {
                writer.WritePropertyName("upToDate"u8);
                writer.WriteNumberValue(UpToDateNumberOfPods.Value);
            }
            if (Optional.IsDefined(AvailableNumberOfPods))
            {
                writer.WritePropertyName("available"u8);
                writer.WriteNumberValue(AvailableNumberOfPods.Value);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
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

        KubernetesDaemonSet IJsonModel<KubernetesDaemonSet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesDaemonSet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesDaemonSet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesDaemonSet(document.RootElement, options);
        }

        internal static KubernetesDaemonSet DeserializeKubernetesDaemonSet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @namespace = default;
            int? desired = default;
            int? current = default;
            int? ready = default;
            int? upToDate = default;
            int? available = default;
            DateTimeOffset? creationTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("desired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    desired = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("current"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    current = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ready"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ready = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("upToDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upToDate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    available = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesDaemonSet(
                name,
                @namespace,
                desired,
                current,
                ready,
                upToDate,
                available,
                creationTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesDaemonSet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesDaemonSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesDaemonSet)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesDaemonSet IPersistableModel<KubernetesDaemonSet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesDaemonSet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKubernetesDaemonSet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesDaemonSet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesDaemonSet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
