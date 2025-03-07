// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    public partial class ShareSubscriptionData : IUtf8JsonSerializable, IJsonModel<ShareSubscriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareSubscriptionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ShareSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            writer.WritePropertyName("invitationId"u8);
            writer.WriteStringValue(InvitationId);
            if (options.Format != "W" && Optional.IsDefined(ProviderEmail))
            {
                writer.WritePropertyName("providerEmail"u8);
                writer.WriteStringValue(ProviderEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderName))
            {
                writer.WritePropertyName("providerName"u8);
                writer.WriteStringValue(ProviderName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProviderTenantName))
            {
                writer.WritePropertyName("providerTenantName"u8);
                writer.WriteStringValue(ProviderTenantName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ShareDescription))
            {
                writer.WritePropertyName("shareDescription"u8);
                writer.WriteStringValue(ShareDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(ShareKind))
            {
                writer.WritePropertyName("shareKind"u8);
                writer.WriteStringValue(ShareKind.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ShareName))
            {
                writer.WritePropertyName("shareName"u8);
                writer.WriteStringValue(ShareName);
            }
            if (options.Format != "W" && Optional.IsDefined(ShareSubscriptionStatus))
            {
                writer.WritePropertyName("shareSubscriptionStatus"u8);
                writer.WriteStringValue(ShareSubscriptionStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ShareTerms))
            {
                writer.WritePropertyName("shareTerms"u8);
                writer.WriteStringValue(ShareTerms);
            }
            writer.WritePropertyName("sourceShareLocation"u8);
            writer.WriteStringValue(SourceShareLocation);
            if (options.Format != "W" && Optional.IsDefined(UserEmail))
            {
                writer.WritePropertyName("userEmail"u8);
                writer.WriteStringValue(UserEmail);
            }
            if (options.Format != "W" && Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            writer.WriteEndObject();
        }

        ShareSubscriptionData IJsonModel<ShareSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareSubscriptionData(document.RootElement, options);
        }

        internal static ShareSubscriptionData DeserializeShareSubscriptionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DateTimeOffset? createdAt = default;
            DateTimeOffset? expirationDate = default;
            Guid invitationId = default;
            string providerEmail = default;
            string providerName = default;
            string providerTenantName = default;
            DataShareProvisioningState? provisioningState = default;
            string shareDescription = default;
            DataShareKind? shareKind = default;
            string shareName = default;
            ShareSubscriptionStatus? shareSubscriptionStatus = default;
            string shareTerms = default;
            AzureLocation sourceShareLocation = default;
            string userEmail = default;
            string userName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("invitationId"u8))
                        {
                            invitationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("providerEmail"u8))
                        {
                            providerEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerName"u8))
                        {
                            providerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("providerTenantName"u8))
                        {
                            providerTenantName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DataShareProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shareDescription"u8))
                        {
                            shareDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shareKind = new DataShareKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shareName"u8))
                        {
                            shareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("shareSubscriptionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shareSubscriptionStatus = new ShareSubscriptionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("shareTerms"u8))
                        {
                            shareTerms = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceShareLocation"u8))
                        {
                            sourceShareLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userEmail"u8))
                        {
                            userEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ShareSubscriptionData(
                id,
                name,
                type,
                systemData,
                createdAt,
                expirationDate,
                invitationId,
                providerEmail,
                providerName,
                providerTenantName,
                provisioningState,
                shareDescription,
                shareKind,
                shareName,
                shareSubscriptionStatus,
                shareTerms,
                sourceShareLocation,
                userEmail,
                userName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareSubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionData)} does not support writing '{options.Format}' format.");
            }
        }

        ShareSubscriptionData IPersistableModel<ShareSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeShareSubscriptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShareSubscriptionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
