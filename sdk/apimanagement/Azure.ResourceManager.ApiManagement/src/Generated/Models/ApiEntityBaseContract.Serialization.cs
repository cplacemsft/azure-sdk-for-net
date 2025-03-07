// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiEntityBaseContract : IUtf8JsonSerializable, IJsonModel<ApiEntityBaseContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiEntityBaseContract>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiEntityBaseContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiEntityBaseContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiEntityBaseContract)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AuthenticationSettings))
            {
                writer.WritePropertyName("authenticationSettings"u8);
                writer.WriteObjectValue(AuthenticationSettings, options);
            }
            if (Optional.IsDefined(SubscriptionKeyParameterNames))
            {
                writer.WritePropertyName("subscriptionKeyParameterNames"u8);
                writer.WriteObjectValue(SubscriptionKeyParameterNames, options);
            }
            if (Optional.IsDefined(ApiType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision"u8);
                writer.WriteStringValue(ApiRevision);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent"u8);
                writer.WriteBooleanValue(IsCurrent.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsOnline))
            {
                writer.WritePropertyName("isOnline"u8);
                writer.WriteBooleanValue(IsOnline.Value);
            }
            if (Optional.IsDefined(ApiRevisionDescription))
            {
                writer.WritePropertyName("apiRevisionDescription"u8);
                writer.WriteStringValue(ApiRevisionDescription);
            }
            if (Optional.IsDefined(ApiVersionDescription))
            {
                writer.WritePropertyName("apiVersionDescription"u8);
                writer.WriteStringValue(ApiVersionDescription);
            }
            if (Optional.IsDefined(ApiVersionSetId))
            {
                writer.WritePropertyName("apiVersionSetId"u8);
                writer.WriteStringValue(ApiVersionSetId);
            }
            if (Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Optional.IsDefined(TermsOfServiceLink))
            {
                writer.WritePropertyName("termsOfServiceUrl"u8);
                writer.WriteStringValue(TermsOfServiceLink);
            }
            if (Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteObjectValue(Contact, options);
            }
            if (Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteObjectValue(License, options);
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

        ApiEntityBaseContract IJsonModel<ApiEntityBaseContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiEntityBaseContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiEntityBaseContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiEntityBaseContract(document.RootElement, options);
        }

        internal static ApiEntityBaseContract DeserializeApiEntityBaseContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            AuthenticationSettingsContract authenticationSettings = default;
            SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default;
            ApiType? type = default;
            string apiRevision = default;
            string apiVersion = default;
            bool? isCurrent = default;
            bool? isOnline = default;
            string apiRevisionDescription = default;
            string apiVersionDescription = default;
            ResourceIdentifier apiVersionSetId = default;
            bool? subscriptionRequired = default;
            string termsOfServiceUri = default;
            ApiContactInformation contact = default;
            ApiLicenseInformation license = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subscriptionKeyParameterNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiRevision"u8))
                {
                    apiRevision = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCurrent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCurrent = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOnline"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOnline = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiRevisionDescription"u8))
                {
                    apiRevisionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionDescription"u8))
                {
                    apiVersionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiVersionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiVersionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("termsOfServiceUrl"u8))
                {
                    termsOfServiceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contact"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contact = ApiContactInformation.DeserializeApiContactInformation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("license"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    license = ApiLicenseInformation.DeserializeApiLicenseInformation(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiEntityBaseContract(
                description,
                authenticationSettings,
                subscriptionKeyParameterNames,
                type,
                apiRevision,
                apiVersion,
                isCurrent,
                isOnline,
                apiRevisionDescription,
                apiVersionDescription,
                apiVersionSetId,
                subscriptionRequired,
                termsOfServiceUri,
                contact,
                license,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthenticationSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authenticationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthenticationSettings))
                {
                    builder.Append("  authenticationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AuthenticationSettings, options, 2, false, "  authenticationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubscriptionKeyParameterNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionKeyParameterNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubscriptionKeyParameterNames))
                {
                    builder.Append("  subscriptionKeyParameterNames: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SubscriptionKeyParameterNames, options, 2, false, "  subscriptionKeyParameterNames: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiType))
                {
                    builder.Append("  type: ");
                    builder.AppendLine($"'{ApiType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevision), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiRevision: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevision))
                {
                    builder.Append("  apiRevision: ");
                    if (ApiRevision.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiRevision}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiRevision}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersion))
                {
                    builder.Append("  apiVersion: ");
                    if (ApiVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsCurrent), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isCurrent: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsCurrent))
                {
                    builder.Append("  isCurrent: ");
                    var boolValue = IsCurrent.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsOnline), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isOnline: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsOnline))
                {
                    builder.Append("  isOnline: ");
                    var boolValue = IsOnline.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevisionDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiRevisionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevisionDescription))
                {
                    builder.Append("  apiRevisionDescription: ");
                    if (ApiRevisionDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiRevisionDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiRevisionDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersionDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionDescription))
                {
                    builder.Append("  apiVersionDescription: ");
                    if (ApiVersionDescription.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ApiVersionDescription}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ApiVersionDescription}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersionSetId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiVersionSetId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionSetId))
                {
                    builder.Append("  apiVersionSetId: ");
                    builder.AppendLine($"'{ApiVersionSetId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubscriptionRequired), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptionRequired: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubscriptionRequired))
                {
                    builder.Append("  subscriptionRequired: ");
                    var boolValue = IsSubscriptionRequired.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TermsOfServiceLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  termsOfServiceUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TermsOfServiceLink))
                {
                    builder.Append("  termsOfServiceUrl: ");
                    if (TermsOfServiceLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TermsOfServiceLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TermsOfServiceLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Contact), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contact: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Contact))
                {
                    builder.Append("  contact: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Contact, options, 2, false, "  contact: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(License), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  license: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(License))
                {
                    builder.Append("  license: ");
                    BicepSerializationHelpers.AppendChildObject(builder, License, options, 2, false, "  license: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiEntityBaseContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiEntityBaseContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiEntityBaseContract)} does not support writing '{options.Format}' format.");
            }
        }

        ApiEntityBaseContract IPersistableModel<ApiEntityBaseContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiEntityBaseContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiEntityBaseContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiEntityBaseContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiEntityBaseContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
