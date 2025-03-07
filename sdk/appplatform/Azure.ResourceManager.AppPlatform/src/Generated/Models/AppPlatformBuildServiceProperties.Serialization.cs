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
    public partial class AppPlatformBuildServiceProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformBuildServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformBuildServiceProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppPlatformBuildServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildServiceProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(KPackVersion))
            {
                writer.WritePropertyName("kPackVersion"u8);
                writer.WriteStringValue(KPackVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(ResourceRequests))
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests, options);
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

        AppPlatformBuildServiceProperties IJsonModel<AppPlatformBuildServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformBuildServiceProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformBuildServiceProperties(document.RootElement, options);
        }

        internal static AppPlatformBuildServiceProperties DeserializeAppPlatformBuildServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kPackVersion = default;
            AppPlatformBuildServiceProvisioningState? provisioningState = default;
            AppPlatformBuildServiceResourceRequirements resourceRequests = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kPackVersion"u8))
                {
                    kPackVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformBuildServiceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformBuildServiceResourceRequirements.DeserializeAppPlatformBuildServiceResourceRequirements(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppPlatformBuildServiceProperties(kPackVersion, provisioningState, resourceRequests, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformBuildServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildServiceProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppPlatformBuildServiceProperties IPersistableModel<AppPlatformBuildServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformBuildServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppPlatformBuildServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformBuildServiceProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformBuildServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
