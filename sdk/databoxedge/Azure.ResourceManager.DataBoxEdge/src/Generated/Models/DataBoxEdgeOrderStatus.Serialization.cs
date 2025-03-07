// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class DataBoxEdgeOrderStatus : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeOrderStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeOrderStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeOrderStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeOrderStatus)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (options.Format != "W" && Optional.IsDefined(UpdateOn))
            {
                writer.WritePropertyName("updateDateTime"u8);
                writer.WriteStringValue(UpdateOn.Value, "O");
            }
            if (Optional.IsDefined(Comments))
            {
                writer.WritePropertyName("comments"u8);
                writer.WriteStringValue(Comments);
            }
            if (options.Format != "W" && Optional.IsDefined(TrackingInformation))
            {
                writer.WritePropertyName("trackingInformation"u8);
                writer.WriteObjectValue(TrackingInformation, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalOrderDetails))
            {
                writer.WritePropertyName("additionalOrderDetails"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalOrderDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        DataBoxEdgeOrderStatus IJsonModel<DataBoxEdgeOrderStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeOrderStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeOrderStatus(document.RootElement, options);
        }

        internal static DataBoxEdgeOrderStatus DeserializeDataBoxEdgeOrderStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeOrderState status = default;
            DateTimeOffset? updateDateTime = default;
            string comments = default;
            DataBoxEdgeTrackingInfo trackingInformation = default;
            IReadOnlyDictionary<string, string> additionalOrderDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = new DataBoxEdgeOrderState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("comments"u8))
                {
                    comments = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trackingInformation = DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("additionalOrderDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    additionalOrderDetails = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxEdgeOrderStatus(
                status,
                updateDateTime,
                comments,
                trackingInformation,
                additionalOrderDetails ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeOrderStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeOrderStatus)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeOrderStatus IPersistableModel<DataBoxEdgeOrderStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeOrderStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataBoxEdgeOrderStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeOrderStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeOrderStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
