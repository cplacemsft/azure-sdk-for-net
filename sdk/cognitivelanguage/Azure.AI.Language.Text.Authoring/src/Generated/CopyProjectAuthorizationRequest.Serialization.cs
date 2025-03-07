// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    internal partial class CopyProjectAuthorizationRequest : IUtf8JsonSerializable, IJsonModel<CopyProjectAuthorizationRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyProjectAuthorizationRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CopyProjectAuthorizationRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyProjectAuthorizationRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyProjectAuthorizationRequest)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("projectKind"u8);
            writer.WriteStringValue(ProjectKind.ToString());
            if (Optional.IsDefined(StorageInputContainerName))
            {
                writer.WritePropertyName("storageInputContainerName"u8);
                writer.WriteStringValue(StorageInputContainerName);
            }
            if (Optional.IsDefined(AllowOverwrite))
            {
                writer.WritePropertyName("allowOverwrite"u8);
                writer.WriteBooleanValue(AllowOverwrite.Value);
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

        CopyProjectAuthorizationRequest IJsonModel<CopyProjectAuthorizationRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyProjectAuthorizationRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyProjectAuthorizationRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyProjectAuthorizationRequest(document.RootElement, options);
        }

        internal static CopyProjectAuthorizationRequest DeserializeCopyProjectAuthorizationRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextAuthoringProjectKind projectKind = default;
            string storageInputContainerName = default;
            bool? allowOverwrite = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new TextAuthoringProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageInputContainerName"u8))
                {
                    storageInputContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowOverwrite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowOverwrite = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CopyProjectAuthorizationRequest(projectKind, storageInputContainerName, allowOverwrite, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CopyProjectAuthorizationRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyProjectAuthorizationRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyProjectAuthorizationRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CopyProjectAuthorizationRequest IPersistableModel<CopyProjectAuthorizationRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyProjectAuthorizationRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCopyProjectAuthorizationRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyProjectAuthorizationRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyProjectAuthorizationRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CopyProjectAuthorizationRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCopyProjectAuthorizationRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
