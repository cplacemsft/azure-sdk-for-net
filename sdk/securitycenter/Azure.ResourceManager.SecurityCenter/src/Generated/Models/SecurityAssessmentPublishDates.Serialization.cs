// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentPublishDates : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentPublishDates>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentPublishDates>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAssessmentPublishDates>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPublishDates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentPublishDates)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(GA))
            {
                writer.WritePropertyName("GA"u8);
                writer.WriteStringValue(GA);
            }
            writer.WritePropertyName("public"u8);
            writer.WriteStringValue(Public);
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

        SecurityAssessmentPublishDates IJsonModel<SecurityAssessmentPublishDates>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPublishDates>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentPublishDates)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentPublishDates(document.RootElement, options);
        }

        internal static SecurityAssessmentPublishDates DeserializeSecurityAssessmentPublishDates(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ga = default;
            string @public = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("GA"u8))
                {
                    ga = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("public"u8))
                {
                    @public = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityAssessmentPublishDates(ga, @public, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentPublishDates>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPublishDates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentPublishDates)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAssessmentPublishDates IPersistableModel<SecurityAssessmentPublishDates>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPublishDates>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityAssessmentPublishDates(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentPublishDates)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentPublishDates>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
