// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayFirewallExclusion : IUtf8JsonSerializable, IJsonModel<ApplicationGatewayFirewallExclusion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationGatewayFirewallExclusion>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationGatewayFirewallExclusion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallExclusion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayFirewallExclusion)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("matchVariable"u8);
            writer.WriteStringValue(MatchVariable);
            writer.WritePropertyName("selectorMatchOperator"u8);
            writer.WriteStringValue(SelectorMatchOperator);
            writer.WritePropertyName("selector"u8);
            writer.WriteStringValue(Selector);
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

        ApplicationGatewayFirewallExclusion IJsonModel<ApplicationGatewayFirewallExclusion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallExclusion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationGatewayFirewallExclusion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayFirewallExclusion(document.RootElement, options);
        }

        internal static ApplicationGatewayFirewallExclusion DeserializeApplicationGatewayFirewallExclusion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string matchVariable = default;
            string selectorMatchOperator = default;
            string selector = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchVariable"u8))
                {
                    matchVariable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectorMatchOperator"u8))
                {
                    selectorMatchOperator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selector"u8))
                {
                    selector = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApplicationGatewayFirewallExclusion(matchVariable, selectorMatchOperator, selector, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationGatewayFirewallExclusion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallExclusion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayFirewallExclusion)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationGatewayFirewallExclusion IPersistableModel<ApplicationGatewayFirewallExclusion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationGatewayFirewallExclusion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationGatewayFirewallExclusion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationGatewayFirewallExclusion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationGatewayFirewallExclusion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
