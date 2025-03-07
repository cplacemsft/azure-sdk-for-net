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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class IstioComponents : IUtf8JsonSerializable, IJsonModel<IstioComponents>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IstioComponents>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IstioComponents>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioComponents)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(IngressGateways))
            {
                writer.WritePropertyName("ingressGateways"u8);
                writer.WriteStartArray();
                foreach (var item in IngressGateways)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EgressGateways))
            {
                writer.WritePropertyName("egressGateways"u8);
                writer.WriteStartArray();
                foreach (var item in EgressGateways)
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

        IstioComponents IJsonModel<IstioComponents>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IstioComponents)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIstioComponents(document.RootElement, options);
        }

        internal static IstioComponents DeserializeIstioComponents(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<IstioIngressGateway> ingressGateways = default;
            IList<IstioEgressGateway> egressGateways = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingressGateways"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IstioIngressGateway> array = new List<IstioIngressGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IstioIngressGateway.DeserializeIstioIngressGateway(item, options));
                    }
                    ingressGateways = array;
                    continue;
                }
                if (property.NameEquals("egressGateways"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IstioEgressGateway> array = new List<IstioEgressGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IstioEgressGateway.DeserializeIstioEgressGateway(item, options));
                    }
                    egressGateways = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IstioComponents(ingressGateways ?? new ChangeTrackingList<IstioIngressGateway>(), egressGateways ?? new ChangeTrackingList<IstioEgressGateway>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IngressGateways), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ingressGateways: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(IngressGateways))
                {
                    if (IngressGateways.Any())
                    {
                        builder.Append("  ingressGateways: ");
                        builder.AppendLine("[");
                        foreach (var item in IngressGateways)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  ingressGateways: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EgressGateways), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  egressGateways: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EgressGateways))
                {
                    if (EgressGateways.Any())
                    {
                        builder.Append("  egressGateways: ");
                        builder.AppendLine("[");
                        foreach (var item in EgressGateways)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  egressGateways: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<IstioComponents>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IstioComponents)} does not support writing '{options.Format}' format.");
            }
        }

        IstioComponents IPersistableModel<IstioComponents>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IstioComponents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIstioComponents(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IstioComponents)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IstioComponents>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
