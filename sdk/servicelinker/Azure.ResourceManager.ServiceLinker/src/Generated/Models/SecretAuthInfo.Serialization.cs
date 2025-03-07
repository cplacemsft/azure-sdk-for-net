// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class SecretAuthInfo : IUtf8JsonSerializable, IJsonModel<SecretAuthInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecretAuthInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecretAuthInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecretAuthInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Name))
            {
                if (Name != null)
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
                else
                {
                    writer.WriteNull("name");
                }
            }
            if (Optional.IsDefined(SecretInfo))
            {
                if (SecretInfo != null)
                {
                    writer.WritePropertyName("secretInfo"u8);
                    writer.WriteObjectValue(SecretInfo, options);
                }
                else
                {
                    writer.WriteNull("secretInfo");
                }
            }
        }

        SecretAuthInfo IJsonModel<SecretAuthInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretAuthInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecretAuthInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecretAuthInfo(document.RootElement, options);
        }

        internal static SecretAuthInfo DeserializeSecretAuthInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            SecretBaseInfo secretInfo = default;
            LinkerAuthType authType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        name = null;
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        secretInfo = null;
                        continue;
                    }
                    secretInfo = SecretBaseInfo.DeserializeSecretBaseInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new LinkerAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecretAuthInfo(authType, serializedAdditionalRawData, name, secretInfo);
        }

        BinaryData IPersistableModel<SecretAuthInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecretAuthInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SecretAuthInfo IPersistableModel<SecretAuthInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecretAuthInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecretAuthInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecretAuthInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecretAuthInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
