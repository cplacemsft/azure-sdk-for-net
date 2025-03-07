// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesEligibleAuthorization : IUtf8JsonSerializable, IJsonModel<ManagedServicesEligibleAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesEligibleAuthorization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedServicesEligibleAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesEligibleAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesEligibleAuthorization)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            if (Optional.IsDefined(PrincipalIdDisplayName))
            {
                writer.WritePropertyName("principalIdDisplayName"u8);
                writer.WriteStringValue(PrincipalIdDisplayName);
            }
            writer.WritePropertyName("roleDefinitionId"u8);
            writer.WriteStringValue(RoleDefinitionId);
            if (Optional.IsDefined(JustInTimeAccessPolicy))
            {
                writer.WritePropertyName("justInTimeAccessPolicy"u8);
                writer.WriteObjectValue(JustInTimeAccessPolicy, options);
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

        ManagedServicesEligibleAuthorization IJsonModel<ManagedServicesEligibleAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesEligibleAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesEligibleAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesEligibleAuthorization(document.RootElement, options);
        }

        internal static ManagedServicesEligibleAuthorization DeserializeManagedServicesEligibleAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            string principalIdDisplayName = default;
            string roleDefinitionId = default;
            ManagedServicesJustInTimeAccessPolicy justInTimeAccessPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("principalIdDisplayName"u8))
                {
                    principalIdDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("justInTimeAccessPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    justInTimeAccessPolicy = ManagedServicesJustInTimeAccessPolicy.DeserializeManagedServicesJustInTimeAccessPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedServicesEligibleAuthorization(principalId, principalIdDisplayName, roleDefinitionId, justInTimeAccessPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServicesEligibleAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesEligibleAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesEligibleAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedServicesEligibleAuthorization IPersistableModel<ManagedServicesEligibleAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesEligibleAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedServicesEligibleAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesEligibleAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicesEligibleAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
