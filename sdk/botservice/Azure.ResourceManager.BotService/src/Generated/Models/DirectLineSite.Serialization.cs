// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class DirectLineSite : IUtf8JsonSerializable, IJsonModel<DirectLineSite>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DirectLineSite>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DirectLineSite>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineSite)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DirectLineSite IJsonModel<DirectLineSite>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DirectLineSite)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDirectLineSite(document.RootElement, options);
        }

        internal static DirectLineSite DeserializeDirectLineSite(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? tenantId = default;
            string siteId = default;
            string siteName = default;
            string key = default;
            string key2 = default;
            bool isEnabled = default;
            bool? isTokenEnabled = default;
            bool? isEndpointParametersEnabled = default;
            bool? isDetailedLoggingEnabled = default;
            bool? isBlockUserUploadEnabled = default;
            bool? isNoStorageEnabled = default;
            ETag? etag = default;
            string appId = default;
            bool? isV1Enabled = default;
            bool? isV3Enabled = default;
            bool? isSecureSiteEnabled = default;
            IList<string> trustedOrigins = default;
            bool? isWebChatSpeechEnabled = default;
            bool? isWebchatPreviewEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("siteId"u8))
                {
                    siteId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isTokenEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isTokenEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEndpointParametersEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEndpointParametersEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDetailedLoggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDetailedLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isBlockUserUploadEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isBlockUserUploadEnabled = null;
                        continue;
                    }
                    isBlockUserUploadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNoStorageEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNoStorageEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isV1Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV1Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isV3Enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isV3Enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isSecureSiteEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSecureSiteEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trustedOrigins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    trustedOrigins = array;
                    continue;
                }
                if (property.NameEquals("isWebChatSpeechEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebChatSpeechEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isWebchatPreviewEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isWebchatPreviewEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DirectLineSite(
                tenantId,
                siteId,
                siteName,
                key,
                key2,
                isEnabled,
                isTokenEnabled,
                isEndpointParametersEnabled,
                isDetailedLoggingEnabled,
                isBlockUserUploadEnabled,
                isNoStorageEnabled,
                etag,
                appId,
                isV1Enabled,
                isV3Enabled,
                isSecureSiteEnabled,
                trustedOrigins ?? new ChangeTrackingList<string>(),
                isWebChatSpeechEnabled,
                isWebchatPreviewEnabled,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DirectLineSite>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DirectLineSite)} does not support writing '{options.Format}' format.");
            }
        }

        DirectLineSite IPersistableModel<DirectLineSite>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DirectLineSite>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDirectLineSite(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DirectLineSite)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DirectLineSite>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
