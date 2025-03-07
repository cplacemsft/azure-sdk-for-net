// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticExternalUserContent : IUtf8JsonSerializable, IJsonModel<ElasticExternalUserContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ElasticExternalUserContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ElasticExternalUserContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticExternalUserContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticExternalUserContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(FullName))
            {
                writer.WritePropertyName("fullName"u8);
                writer.WriteStringValue(FullName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(EmailId))
            {
                writer.WritePropertyName("emailId"u8);
                writer.WriteStringValue(EmailId);
            }
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartArray();
                foreach (var item in Roles)
                {
                    writer.WriteStringValue(item);
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

        ElasticExternalUserContent IJsonModel<ElasticExternalUserContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticExternalUserContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ElasticExternalUserContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticExternalUserContent(document.RootElement, options);
        }

        internal static ElasticExternalUserContent DeserializeElasticExternalUserContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userName = default;
            string fullName = default;
            string password = default;
            string emailId = default;
            IList<string> roles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullName"u8))
                {
                    fullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("emailId"u8))
                {
                    emailId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roles"u8))
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
                    roles = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ElasticExternalUserContent(
                userName,
                fullName,
                password,
                emailId,
                roles ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ElasticExternalUserContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticExternalUserContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ElasticExternalUserContent)} does not support writing '{options.Format}' format.");
            }
        }

        ElasticExternalUserContent IPersistableModel<ElasticExternalUserContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ElasticExternalUserContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeElasticExternalUserContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ElasticExternalUserContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ElasticExternalUserContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
