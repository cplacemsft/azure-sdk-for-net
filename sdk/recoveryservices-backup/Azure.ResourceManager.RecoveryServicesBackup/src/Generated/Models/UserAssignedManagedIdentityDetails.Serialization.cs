// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class UserAssignedManagedIdentityDetails : IUtf8JsonSerializable, IJsonModel<UserAssignedManagedIdentityDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserAssignedManagedIdentityDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserAssignedManagedIdentityDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedManagedIdentityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAssignedManagedIdentityDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IdentityArmId))
            {
                writer.WritePropertyName("identityArmId"u8);
                writer.WriteStringValue(IdentityArmId);
            }
            if (Optional.IsDefined(IdentityName))
            {
                writer.WritePropertyName("identityName"u8);
                writer.WriteStringValue(IdentityName);
            }
            if (Optional.IsDefined(UserAssignedIdentityProperties))
            {
                writer.WritePropertyName("userAssignedIdentityProperties"u8);
                JsonSerializer.Serialize(writer, UserAssignedIdentityProperties);
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

        UserAssignedManagedIdentityDetails IJsonModel<UserAssignedManagedIdentityDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedManagedIdentityDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserAssignedManagedIdentityDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAssignedManagedIdentityDetails(document.RootElement, options);
        }

        internal static UserAssignedManagedIdentityDetails DeserializeUserAssignedManagedIdentityDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string identityArmId = default;
            string identityName = default;
            UserAssignedIdentity userAssignedIdentityProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identityArmId"u8))
                {
                    identityArmId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityName"u8))
                {
                    identityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentityProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssignedIdentityProperties = JsonSerializer.Deserialize<UserAssignedIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserAssignedManagedIdentityDetails(identityArmId, identityName, userAssignedIdentityProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserAssignedManagedIdentityDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedManagedIdentityDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserAssignedManagedIdentityDetails)} does not support writing '{options.Format}' format.");
            }
        }

        UserAssignedManagedIdentityDetails IPersistableModel<UserAssignedManagedIdentityDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserAssignedManagedIdentityDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUserAssignedManagedIdentityDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserAssignedManagedIdentityDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserAssignedManagedIdentityDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
