// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeNode : IUtf8JsonSerializable, IJsonModel<SynapseManagedIntegrationRuntimeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedIntegrationRuntimeNode>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseManagedIntegrationRuntimeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(NodeId))
            {
                writer.WritePropertyName("nodeId"u8);
                writer.WriteStringValue(NodeId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
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

        SynapseManagedIntegrationRuntimeNode IJsonModel<SynapseManagedIntegrationRuntimeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeNode(document.RootElement, options);
        }

        internal static SynapseManagedIntegrationRuntimeNode DeserializeSynapseManagedIntegrationRuntimeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nodeId = default;
            SynapseManagedIntegrationRuntimeNodeStatus? status = default;
            IReadOnlyList<SynapseManagedIntegrationRuntimeError> errors = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SynapseManagedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseManagedIntegrationRuntimeError> array = new List<SynapseManagedIntegrationRuntimeError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseManagedIntegrationRuntimeError.DeserializeSynapseManagedIntegrationRuntimeError(item, options));
                    }
                    errors = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeNode(nodeId, status, errors ?? new ChangeTrackingList<SynapseManagedIntegrationRuntimeError>(), additionalProperties);
        }

        BinaryData IPersistableModel<SynapseManagedIntegrationRuntimeNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseManagedIntegrationRuntimeNode IPersistableModel<SynapseManagedIntegrationRuntimeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSynapseManagedIntegrationRuntimeNode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeNode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseManagedIntegrationRuntimeNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
