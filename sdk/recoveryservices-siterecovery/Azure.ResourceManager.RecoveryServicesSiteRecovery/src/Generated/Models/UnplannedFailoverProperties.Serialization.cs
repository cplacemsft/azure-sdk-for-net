// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class UnplannedFailoverProperties : IUtf8JsonSerializable, IJsonModel<UnplannedFailoverProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnplannedFailoverProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UnplannedFailoverProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnplannedFailoverProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(FailoverDirection))
            {
                writer.WritePropertyName("failoverDirection"u8);
                writer.WriteStringValue(FailoverDirection);
            }
            if (Optional.IsDefined(SourceSiteOperations))
            {
                writer.WritePropertyName("sourceSiteOperations"u8);
                writer.WriteStringValue(SourceSiteOperations);
            }
            if (Optional.IsDefined(ProviderSpecificDetails))
            {
                writer.WritePropertyName("providerSpecificDetails"u8);
                writer.WriteObjectValue(ProviderSpecificDetails, options);
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

        UnplannedFailoverProperties IJsonModel<UnplannedFailoverProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UnplannedFailoverProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnplannedFailoverProperties(document.RootElement, options);
        }

        internal static UnplannedFailoverProperties DeserializeUnplannedFailoverProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string failoverDirection = default;
            string sourceSiteOperations = default;
            UnplannedFailoverProviderSpecificContent providerSpecificDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failoverDirection"u8))
                {
                    failoverDirection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceSiteOperations"u8))
                {
                    sourceSiteOperations = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerSpecificDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificDetails = UnplannedFailoverProviderSpecificContent.DeserializeUnplannedFailoverProviderSpecificContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnplannedFailoverProperties(failoverDirection, sourceSiteOperations, providerSpecificDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnplannedFailoverProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UnplannedFailoverProperties)} does not support writing '{options.Format}' format.");
            }
        }

        UnplannedFailoverProperties IPersistableModel<UnplannedFailoverProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UnplannedFailoverProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUnplannedFailoverProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UnplannedFailoverProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UnplannedFailoverProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
