// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class PartitionInstanceCountScalingMechanism : IUtf8JsonSerializable, IJsonModel<PartitionInstanceCountScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartitionInstanceCountScalingMechanism>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PartitionInstanceCountScalingMechanism>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("minInstanceCount"u8);
            writer.WriteNumberValue(MinInstanceCount);
            writer.WritePropertyName("maxInstanceCount"u8);
            writer.WriteNumberValue(MaxInstanceCount);
            writer.WritePropertyName("scaleIncrement"u8);
            writer.WriteNumberValue(ScaleIncrement);
        }

        PartitionInstanceCountScalingMechanism IJsonModel<PartitionInstanceCountScalingMechanism>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartitionInstanceCountScalingMechanism(document.RootElement, options);
        }

        internal static PartitionInstanceCountScalingMechanism DeserializePartitionInstanceCountScalingMechanism(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minInstanceCount = default;
            int maxInstanceCount = default;
            int scaleIncrement = default;
            ServiceScalingMechanismKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minInstanceCount"u8))
                {
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"u8))
                {
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleIncrement"u8))
                {
                    scaleIncrement = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingMechanismKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PartitionInstanceCountScalingMechanism(kind, serializedAdditionalRawData, minInstanceCount, maxInstanceCount, scaleIncrement);
        }

        BinaryData IPersistableModel<PartitionInstanceCountScalingMechanism>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support writing '{options.Format}' format.");
            }
        }

        PartitionInstanceCountScalingMechanism IPersistableModel<PartitionInstanceCountScalingMechanism>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePartitionInstanceCountScalingMechanism(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartitionInstanceCountScalingMechanism>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
