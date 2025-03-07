// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CommunityGalleryMetadata : IUtf8JsonSerializable, IJsonModel<CommunityGalleryMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommunityGalleryMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PublisherUri))
            {
                writer.WritePropertyName("publisherUri"u8);
                writer.WriteStringValue(PublisherUri.AbsoluteUri);
            }
            writer.WritePropertyName("publisherContact"u8);
            writer.WriteStringValue(PublisherContact);
            if (Optional.IsDefined(Eula))
            {
                writer.WritePropertyName("eula"u8);
                writer.WriteStringValue(Eula);
            }
            writer.WritePropertyName("publicNames"u8);
            writer.WriteStartArray();
            foreach (var item in PublicNames)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(PrivacyStatementUri))
            {
                writer.WritePropertyName("privacyStatementUri"u8);
                writer.WriteStringValue(PrivacyStatementUri.AbsoluteUri);
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

        CommunityGalleryMetadata IJsonModel<CommunityGalleryMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryMetadata(document.RootElement, options);
        }

        internal static CommunityGalleryMetadata DeserializeCommunityGalleryMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri publisherUri = default;
            string publisherContact = default;
            string eula = default;
            IReadOnlyList<string> publicNames = default;
            Uri privacyStatementUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisherUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publisherContact"u8))
                {
                    publisherContact = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eula"u8))
                {
                    eula = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNames"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    publicNames = array;
                    continue;
                }
                if (property.NameEquals("privacyStatementUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privacyStatementUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommunityGalleryMetadata(
                publisherUri,
                publisherContact,
                eula,
                publicNames,
                privacyStatementUri,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CommunityGalleryMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        CommunityGalleryMetadata IPersistableModel<CommunityGalleryMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCommunityGalleryMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
