// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSupportedRuntimeVersion : IUtf8JsonSerializable, IJsonModel<AppPlatformSupportedRuntimeVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformSupportedRuntimeVersion>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformSupportedRuntimeVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSupportedRuntimeVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSupportedRuntimeVersion)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value.Value.ToString());
            }
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteStringValue(Platform.Value.ToString());
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        AppPlatformSupportedRuntimeVersion IJsonModel<AppPlatformSupportedRuntimeVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSupportedRuntimeVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSupportedRuntimeVersion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformSupportedRuntimeVersion(document.RootElement, options);
        }

        internal static AppPlatformSupportedRuntimeVersion DeserializeAppPlatformSupportedRuntimeVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AppPlatformSupportedRuntimeValue? value = default;
            AppPlatformSupportedRuntimePlatform? platform = default;
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = new AppPlatformSupportedRuntimeValue(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platform = new AppPlatformSupportedRuntimePlatform(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformSupportedRuntimeVersion(value, platform, version, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformSupportedRuntimeVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSupportedRuntimeVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSupportedRuntimeVersion)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformSupportedRuntimeVersion IPersistableModel<AppPlatformSupportedRuntimeVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSupportedRuntimeVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformSupportedRuntimeVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSupportedRuntimeVersion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformSupportedRuntimeVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
