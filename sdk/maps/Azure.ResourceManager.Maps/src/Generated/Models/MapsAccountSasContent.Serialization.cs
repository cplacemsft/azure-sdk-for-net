// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountSasContent : IUtf8JsonSerializable, IJsonModel<MapsAccountSasContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsAccountSasContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MapsAccountSasContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountSasContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountSasContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("signingKey"u8);
            writer.WriteStringValue(SigningKey.ToString());
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("maxRatePerSecond"u8);
            writer.WriteNumberValue(MaxRatePerSecond);
            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start);
            writer.WritePropertyName("expiry"u8);
            writer.WriteStringValue(Expiry);
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

        MapsAccountSasContent IJsonModel<MapsAccountSasContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountSasContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountSasContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsAccountSasContent(document.RootElement, options);
        }

        internal static MapsAccountSasContent DeserializeMapsAccountSasContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MapsSigningKey signingKey = default;
            string principalId = default;
            IList<string> regions = default;
            int maxRatePerSecond = default;
            string start = default;
            string expiry = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("signingKey"u8))
                {
                    signingKey = new MapsSigningKey(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regions"u8))
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
                    regions = array;
                    continue;
                }
                if (property.NameEquals("maxRatePerSecond"u8))
                {
                    maxRatePerSecond = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    expiry = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MapsAccountSasContent(
                signingKey,
                principalId,
                regions ?? new ChangeTrackingList<string>(),
                maxRatePerSecond,
                start,
                expiry,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsAccountSasContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountSasContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapsAccountSasContent)} does not support writing '{options.Format}' format.");
            }
        }

        MapsAccountSasContent IPersistableModel<MapsAccountSasContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountSasContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMapsAccountSasContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapsAccountSasContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapsAccountSasContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
