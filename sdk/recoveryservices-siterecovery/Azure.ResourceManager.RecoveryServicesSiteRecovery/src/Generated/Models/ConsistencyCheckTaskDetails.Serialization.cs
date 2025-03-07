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
    public partial class ConsistencyCheckTaskDetails : IUtf8JsonSerializable, IJsonModel<ConsistencyCheckTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsistencyCheckTaskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConsistencyCheckTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(VmDetails))
            {
                writer.WritePropertyName("vmDetails"u8);
                writer.WriteStartArray();
                foreach (var item in VmDetails)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        ConsistencyCheckTaskDetails IJsonModel<ConsistencyCheckTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsistencyCheckTaskDetails(document.RootElement, options);
        }

        internal static ConsistencyCheckTaskDetails DeserializeConsistencyCheckTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<InconsistentVmDetails> vmDetails = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InconsistentVmDetails> array = new List<InconsistentVmDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InconsistentVmDetails.DeserializeInconsistentVmDetails(item, options));
                    }
                    vmDetails = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConsistencyCheckTaskDetails(instanceType, serializedAdditionalRawData, vmDetails ?? new ChangeTrackingList<InconsistentVmDetails>());
        }

        BinaryData IPersistableModel<ConsistencyCheckTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ConsistencyCheckTaskDetails IPersistableModel<ConsistencyCheckTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsistencyCheckTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConsistencyCheckTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsistencyCheckTaskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsistencyCheckTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
