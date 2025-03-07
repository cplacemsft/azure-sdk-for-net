// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    internal partial class AdditionalFeaturesServerConfigurations : IUtf8JsonSerializable, IJsonModel<AdditionalFeaturesServerConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdditionalFeaturesServerConfigurations>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AdditionalFeaturesServerConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalFeaturesServerConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalFeaturesServerConfigurations)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsRServicesEnabled))
            {
                writer.WritePropertyName("isRServicesEnabled"u8);
                writer.WriteBooleanValue(IsRServicesEnabled.Value);
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

        AdditionalFeaturesServerConfigurations IJsonModel<AdditionalFeaturesServerConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalFeaturesServerConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AdditionalFeaturesServerConfigurations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdditionalFeaturesServerConfigurations(document.RootElement, options);
        }

        internal static AdditionalFeaturesServerConfigurations DeserializeAdditionalFeaturesServerConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isRServicesEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isRServicesEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRServicesEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AdditionalFeaturesServerConfigurations(isRServicesEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdditionalFeaturesServerConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalFeaturesServerConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AdditionalFeaturesServerConfigurations)} does not support writing '{options.Format}' format.");
            }
        }

        AdditionalFeaturesServerConfigurations IPersistableModel<AdditionalFeaturesServerConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AdditionalFeaturesServerConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAdditionalFeaturesServerConfigurations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AdditionalFeaturesServerConfigurations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AdditionalFeaturesServerConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
