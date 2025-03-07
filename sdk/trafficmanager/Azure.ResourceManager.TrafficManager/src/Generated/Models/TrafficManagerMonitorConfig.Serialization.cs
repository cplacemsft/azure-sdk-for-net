// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerMonitorConfig : IUtf8JsonSerializable, IJsonModel<TrafficManagerMonitorConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerMonitorConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TrafficManagerMonitorConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerMonitorConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProfileMonitorStatus))
            {
                writer.WritePropertyName("profileMonitorStatus"u8);
                writer.WriteStringValue(ProfileMonitorStatus.Value.ToString());
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(ToleratedNumberOfFailures))
            {
                writer.WritePropertyName("toleratedNumberOfFailures"u8);
                writer.WriteNumberValue(ToleratedNumberOfFailures.Value);
            }
            if (Optional.IsCollectionDefined(CustomHeaders))
            {
                writer.WritePropertyName("customHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in CustomHeaders)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExpectedStatusCodeRanges))
            {
                writer.WritePropertyName("expectedStatusCodeRanges"u8);
                writer.WriteStartArray();
                foreach (var item in ExpectedStatusCodeRanges)
                {
                    writer.WriteObjectValue(item, options);
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

        TrafficManagerMonitorConfig IJsonModel<TrafficManagerMonitorConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerMonitorConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerMonitorConfig(document.RootElement, options);
        }

        internal static TrafficManagerMonitorConfig DeserializeTrafficManagerMonitorConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrafficManagerProfileMonitorStatus? profileMonitorStatus = default;
            TrafficManagerMonitorProtocol? protocol = default;
            long? port = default;
            string path = default;
            long? intervalInSeconds = default;
            long? timeoutInSeconds = default;
            long? toleratedNumberOfFailures = default;
            IList<TrafficManagerMonitorConfigCustomHeaderInfo> customHeaders = default;
            IList<ExpectedStatusCodeRangeInfo> expectedStatusCodeRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profileMonitorStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profileMonitorStatus = new TrafficManagerProfileMonitorStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new TrafficManagerMonitorProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("toleratedNumberOfFailures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toleratedNumberOfFailures = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("customHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrafficManagerMonitorConfigCustomHeaderInfo> array = new List<TrafficManagerMonitorConfigCustomHeaderInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrafficManagerMonitorConfigCustomHeaderInfo.DeserializeTrafficManagerMonitorConfigCustomHeaderInfo(item, options));
                    }
                    customHeaders = array;
                    continue;
                }
                if (property.NameEquals("expectedStatusCodeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpectedStatusCodeRangeInfo> array = new List<ExpectedStatusCodeRangeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpectedStatusCodeRangeInfo.DeserializeExpectedStatusCodeRangeInfo(item, options));
                    }
                    expectedStatusCodeRanges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TrafficManagerMonitorConfig(
                profileMonitorStatus,
                protocol,
                port,
                path,
                intervalInSeconds,
                timeoutInSeconds,
                toleratedNumberOfFailures,
                customHeaders ?? new ChangeTrackingList<TrafficManagerMonitorConfigCustomHeaderInfo>(),
                expectedStatusCodeRanges ?? new ChangeTrackingList<ExpectedStatusCodeRangeInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficManagerMonitorConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerMonitorConfig)} does not support writing '{options.Format}' format.");
            }
        }

        TrafficManagerMonitorConfig IPersistableModel<TrafficManagerMonitorConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTrafficManagerMonitorConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerMonitorConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerMonitorConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
