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
    public partial class RequestMetadata : IUtf8JsonSerializable, IJsonModel<RequestMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RequestMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestMetadata)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("relativePath"u8);
            writer.WriteStringValue(RelativePath);
            writer.WritePropertyName("httpMethod"u8);
            writer.WriteStringValue(HttpMethod.ToString());
            writer.WritePropertyName("serializedBody"u8);
            writer.WriteStringValue(SerializedBody);
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        RequestMetadata IJsonModel<RequestMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestMetadata(document.RootElement, options);
        }

        internal static RequestMetadata DeserializeRequestMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string relativePath = default;
            HttpMethod httpMethod = default;
            string serializedBody = default;
            string apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    httpMethod = new HttpMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serializedBody"u8))
                {
                    serializedBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RequestMetadata(relativePath, httpMethod, serializedBody, apiVersion, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequestMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        RequestMetadata IPersistableModel<RequestMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRequestMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequestMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
