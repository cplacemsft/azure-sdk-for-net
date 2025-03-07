// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MapsGeofenceEnteredEventData : IUtf8JsonSerializable, IJsonModel<MapsGeofenceEnteredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsGeofenceEnteredEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MapsGeofenceEnteredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEnteredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEnteredEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        MapsGeofenceEnteredEventData IJsonModel<MapsGeofenceEnteredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEnteredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsGeofenceEnteredEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsGeofenceEnteredEventData(document.RootElement, options);
        }

        internal static MapsGeofenceEnteredEventData DeserializeMapsGeofenceEnteredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> expiredGeofenceGeometryId = default;
            IReadOnlyList<MapsGeofenceGeometry> geometries = default;
            IReadOnlyList<string> invalidPeriodGeofenceGeometryId = default;
            bool? isEventPublished = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiredGeofenceGeometryId"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    expiredGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("geometries"u8))
                {
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item, options));
                    }
                    geometries = array;
                    continue;
                }
                if (property.NameEquals("invalidPeriodGeofenceGeometryId"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidPeriodGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("isEventPublished"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEventPublished = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MapsGeofenceEnteredEventData(expiredGeofenceGeometryId, geometries, invalidPeriodGeofenceGeometryId, isEventPublished, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsGeofenceEnteredEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEnteredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapsGeofenceEnteredEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MapsGeofenceEnteredEventData IPersistableModel<MapsGeofenceEnteredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsGeofenceEnteredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMapsGeofenceEnteredEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapsGeofenceEnteredEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapsGeofenceEnteredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MapsGeofenceEnteredEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMapsGeofenceEnteredEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
