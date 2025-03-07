// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    public partial class DedicatedHsmNetworkProfile : IUtf8JsonSerializable, IJsonModel<DedicatedHsmNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DedicatedHsmNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DedicatedHsmNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHsmNetworkProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteObjectValue(Subnet, options);
            }
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        DedicatedHsmNetworkProfile IJsonModel<DedicatedHsmNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DedicatedHsmNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDedicatedHsmNetworkProfile(document.RootElement, options);
        }

        internal static DedicatedHsmNetworkProfile DeserializeDedicatedHsmNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApiEntityReference subnet = default;
            IList<DedicatedHsmNetworkInterface> networkInterfaces = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnet = ApiEntityReference.DeserializeApiEntityReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkInterfaces"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DedicatedHsmNetworkInterface> array = new List<DedicatedHsmNetworkInterface>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHsmNetworkInterface.DeserializeDedicatedHsmNetworkInterface(item, options));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DedicatedHsmNetworkProfile(subnet, networkInterfaces ?? new ChangeTrackingList<DedicatedHsmNetworkInterface>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SubnetResourceId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subnet: ");
                builder.AppendLine("{");
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Subnet))
                {
                    builder.Append("  subnet: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Subnet, options, 2, false, "  subnet: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkInterfaces), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkInterfaces: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NetworkInterfaces))
                {
                    if (NetworkInterfaces.Any())
                    {
                        builder.Append("  networkInterfaces: ");
                        builder.AppendLine("[");
                        foreach (var item in NetworkInterfaces)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  networkInterfaces: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DedicatedHsmNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DedicatedHsmNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        DedicatedHsmNetworkProfile IPersistableModel<DedicatedHsmNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DedicatedHsmNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDedicatedHsmNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DedicatedHsmNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DedicatedHsmNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
