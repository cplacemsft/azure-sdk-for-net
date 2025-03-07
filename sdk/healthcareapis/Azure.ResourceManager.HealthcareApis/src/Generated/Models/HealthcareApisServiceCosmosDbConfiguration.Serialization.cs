// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceCosmosDbConfiguration : IUtf8JsonSerializable, IJsonModel<HealthcareApisServiceCosmosDbConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisServiceCosmosDbConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HealthcareApisServiceCosmosDbConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceCosmosDbConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OfferThroughput))
            {
                writer.WritePropertyName("offerThroughput"u8);
                writer.WriteNumberValue(OfferThroughput.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(CrossTenantCmkApplicationId))
            {
                writer.WritePropertyName("crossTenantCmkApplicationId"u8);
                writer.WriteStringValue(CrossTenantCmkApplicationId.Value);
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

        HealthcareApisServiceCosmosDbConfiguration IJsonModel<HealthcareApisServiceCosmosDbConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceCosmosDbConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceCosmosDbConfiguration(document.RootElement, options);
        }

        internal static HealthcareApisServiceCosmosDbConfiguration DeserializeHealthcareApisServiceCosmosDbConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? offerThroughput = default;
            Uri keyVaultKeyUri = default;
            Guid? crossTenantCmkApplicationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    offerThroughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("crossTenantCmkApplicationId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    crossTenantCmkApplicationId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HealthcareApisServiceCosmosDbConfiguration(offerThroughput, keyVaultKeyUri, crossTenantCmkApplicationId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceCosmosDbConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        HealthcareApisServiceCosmosDbConfiguration IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHealthcareApisServiceCosmosDbConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceCosmosDbConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisServiceCosmosDbConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
