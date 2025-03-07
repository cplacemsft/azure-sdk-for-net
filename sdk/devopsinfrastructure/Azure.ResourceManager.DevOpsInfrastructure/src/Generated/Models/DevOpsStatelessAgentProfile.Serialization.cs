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
    public partial class DevOpsStatelessAgentProfile : IUtf8JsonSerializable, IJsonModel<DevOpsStatelessAgentProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevOpsStatelessAgentProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevOpsStatelessAgentProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStatelessAgentProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsStatelessAgentProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DevOpsStatelessAgentProfile IJsonModel<DevOpsStatelessAgentProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStatelessAgentProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevOpsStatelessAgentProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevOpsStatelessAgentProfile(document.RootElement, options);
        }

        internal static DevOpsStatelessAgentProfile DeserializeDevOpsStatelessAgentProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourcePredictions resourcePredictions = default;
            ResourcePredictionsProfile resourcePredictionsProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourcePredictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourcePredictions = ResourcePredictions.DeserializeResourcePredictions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourcePredictionsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourcePredictionsProfile = ResourcePredictionsProfile.DeserializeResourcePredictionsProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevOpsStatelessAgentProfile(kind, resourcePredictions, resourcePredictionsProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevOpsStatelessAgentProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStatelessAgentProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevOpsStatelessAgentProfile)} does not support writing '{options.Format}' format.");
            }
        }

        DevOpsStatelessAgentProfile IPersistableModel<DevOpsStatelessAgentProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevOpsStatelessAgentProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevOpsStatelessAgentProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevOpsStatelessAgentProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevOpsStatelessAgentProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
