// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink : IUtf8JsonSerializable, IJsonModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink IJsonModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(document.RootElement, options);
        }

        internal static EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink)} does not support writing '{options.Format}' format.");
            }
        }

        EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
