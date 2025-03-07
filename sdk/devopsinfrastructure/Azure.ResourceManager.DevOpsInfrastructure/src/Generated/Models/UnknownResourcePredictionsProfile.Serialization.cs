// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevOpsInfrastructure.Models
{
    internal partial class UnknownResourcePredictionsProfile : IUtf8JsonSerializable, IJsonModel<ResourcePredictionsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourcePredictionsProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourcePredictionsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcePredictionsProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ResourcePredictionsProfile IJsonModel<ResourcePredictionsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourcePredictionsProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourcePredictionsProfile(document.RootElement, options);
        }

        internal static UnknownResourcePredictionsProfile DeserializeUnknownResourcePredictionsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourcePredictionsProfileType kind = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ResourcePredictionsProfileType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownResourcePredictionsProfile(kind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourcePredictionsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourcePredictionsProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ResourcePredictionsProfile IPersistableModel<ResourcePredictionsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourcePredictionsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourcePredictionsProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourcePredictionsProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourcePredictionsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
