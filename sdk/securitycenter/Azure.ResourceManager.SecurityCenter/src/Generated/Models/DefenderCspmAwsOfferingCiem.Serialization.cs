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
    public partial class DefenderCspmAwsOfferingCiem : IUtf8JsonSerializable, IJsonModel<DefenderCspmAwsOfferingCiem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderCspmAwsOfferingCiem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderCspmAwsOfferingCiem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CiemDiscovery))
            {
                writer.WritePropertyName("ciemDiscovery"u8);
                writer.WriteObjectValue(CiemDiscovery, options);
            }
            if (Optional.IsDefined(CiemOidc))
            {
                writer.WritePropertyName("ciemOidc"u8);
                writer.WriteObjectValue(CiemOidc, options);
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

        DefenderCspmAwsOfferingCiem IJsonModel<DefenderCspmAwsOfferingCiem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderCspmAwsOfferingCiem(document.RootElement, options);
        }

        internal static DefenderCspmAwsOfferingCiem DeserializeDefenderCspmAwsOfferingCiem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DefenderCspmAwsOfferingCiemDiscovery ciemDiscovery = default;
            DefenderCspmAwsOfferingCiemOidc ciemOidc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ciemDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemDiscovery = DefenderCspmAwsOfferingCiemDiscovery.DeserializeDefenderCspmAwsOfferingCiemDiscovery(property.Value, options);
                    continue;
                }
                if (property.NameEquals("ciemOidc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ciemOidc = DefenderCspmAwsOfferingCiemOidc.DeserializeDefenderCspmAwsOfferingCiemOidc(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderCspmAwsOfferingCiem(ciemDiscovery, ciemOidc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderCspmAwsOfferingCiem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderCspmAwsOfferingCiem IPersistableModel<DefenderCspmAwsOfferingCiem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderCspmAwsOfferingCiem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDefenderCspmAwsOfferingCiem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderCspmAwsOfferingCiem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderCspmAwsOfferingCiem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
