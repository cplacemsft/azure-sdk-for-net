// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxDeploymentPropertiesNginxAppProtect : IUtf8JsonSerializable, IJsonModel<NginxDeploymentPropertiesNginxAppProtect>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxDeploymentPropertiesNginxAppProtect>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NginxDeploymentPropertiesNginxAppProtect>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxDeploymentPropertiesNginxAppProtect)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("webApplicationFirewallSettings"u8);
            writer.WriteObjectValue(WebApplicationFirewallSettings, options);
            if (options.Format != "W" && Optional.IsDefined(WebApplicationFirewallStatus))
            {
                writer.WritePropertyName("webApplicationFirewallStatus"u8);
                writer.WriteObjectValue(WebApplicationFirewallStatus, options);
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

        NginxDeploymentPropertiesNginxAppProtect IJsonModel<NginxDeploymentPropertiesNginxAppProtect>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxDeploymentPropertiesNginxAppProtect)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxDeploymentPropertiesNginxAppProtect(document.RootElement, options);
        }

        internal static NginxDeploymentPropertiesNginxAppProtect DeserializeNginxDeploymentPropertiesNginxAppProtect(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebApplicationFirewallSettings webApplicationFirewallSettings = default;
            WebApplicationFirewallStatus webApplicationFirewallStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webApplicationFirewallSettings"u8))
                {
                    webApplicationFirewallSettings = WebApplicationFirewallSettings.DeserializeWebApplicationFirewallSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("webApplicationFirewallStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webApplicationFirewallStatus = WebApplicationFirewallStatus.DeserializeWebApplicationFirewallStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NginxDeploymentPropertiesNginxAppProtect(webApplicationFirewallSettings, webApplicationFirewallStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxDeploymentPropertiesNginxAppProtect)} does not support writing '{options.Format}' format.");
            }
        }

        NginxDeploymentPropertiesNginxAppProtect IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNginxDeploymentPropertiesNginxAppProtect(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxDeploymentPropertiesNginxAppProtect)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxDeploymentPropertiesNginxAppProtect>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
