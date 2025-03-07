// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class VectorStore : IUtf8JsonSerializable, IJsonModel<VectorStore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VectorStore>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VectorStore>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStore)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("object"u8);
            writer.WriteStringValue(Object.ToString());
            writer.WritePropertyName("created_at"u8);
            writer.WriteNumberValue(CreatedAt, "U");
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("usage_bytes"u8);
            writer.WriteNumberValue(UsageBytes);
            writer.WritePropertyName("file_counts"u8);
            writer.WriteObjectValue(FileCounts, options);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsDefined(ExpiresAfter))
            {
                writer.WritePropertyName("expires_after"u8);
                writer.WriteObjectValue(ExpiresAfter, options);
            }
            if (Optional.IsDefined(ExpiresAt))
            {
                if (ExpiresAt != null)
                {
                    writer.WritePropertyName("expires_at"u8);
                    writer.WriteNumberValue(ExpiresAt.Value, "U");
                }
                else
                {
                    writer.WriteNull("expires_at");
                }
            }
            if (LastActiveAt != null)
            {
                writer.WritePropertyName("last_active_at"u8);
                writer.WriteNumberValue(LastActiveAt.Value, "U");
            }
            else
            {
                writer.WriteNull("last_active_at");
            }
            if (Metadata != null && Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            else
            {
                writer.WriteNull("metadata");
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

        VectorStore IJsonModel<VectorStore>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStore>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VectorStore)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVectorStore(document.RootElement, options);
        }

        internal static VectorStore DeserializeVectorStore(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            VectorStoreObject @object = default;
            DateTimeOffset createdAt = default;
            string name = default;
            int usageBytes = default;
            VectorStoreFileCount fileCounts = default;
            VectorStoreStatus status = default;
            VectorStoreExpirationPolicy expiresAfter = default;
            DateTimeOffset? expiresAt = default;
            DateTimeOffset? lastActiveAt = default;
            IReadOnlyDictionary<string, string> metadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new VectorStoreObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("created_at"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usage_bytes"u8))
                {
                    usageBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("file_counts"u8))
                {
                    fileCounts = VectorStoreFileCount.DeserializeVectorStoreFileCount(property.Value, options);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new VectorStoreStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expires_after"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAfter = VectorStoreExpirationPolicy.DeserializeVectorStoreExpirationPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expires_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        expiresAt = null;
                        continue;
                    }
                    expiresAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("last_active_at"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastActiveAt = null;
                        continue;
                    }
                    lastActiveAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadata = new ChangeTrackingDictionary<string, string>();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VectorStore(
                id,
                @object,
                createdAt,
                name,
                usageBytes,
                fileCounts,
                status,
                expiresAfter,
                expiresAt,
                lastActiveAt,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VectorStore>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VectorStore)} does not support writing '{options.Format}' format.");
            }
        }

        VectorStore IPersistableModel<VectorStore>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VectorStore>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVectorStore(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VectorStore)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VectorStore>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VectorStore FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeVectorStore(document.RootElement);
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
