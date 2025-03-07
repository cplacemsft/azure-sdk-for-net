// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ProductApiData : IUtf8JsonSerializable, IJsonModel<ProductApiData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductApiData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProductApiData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductApiData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductApiData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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
            if (Optional.IsDefined(SourceApiId))
            {
                writer.WritePropertyName("sourceApiId"u8);
                writer.WriteStringValue(SourceApiId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(ServiceLink))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceLink);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiVersionSet))
            {
                writer.WritePropertyName("apiVersionSet"u8);
                writer.WriteObjectValue(ApiVersionSet, options);
            }
            writer.WriteEndObject();
        }

        ProductApiData IJsonModel<ProductApiData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductApiData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductApiData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductApiData(document.RootElement, options);
        }

        internal static ProductApiData DeserializeProductApiData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string description = default;
            AuthenticationSettingsContract authenticationSettings = default;
            SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames = default;
            ApiType? type0 = default;
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
            ResourceIdentifier sourceApiId = default;
            string displayName = default;
            string serviceUri = default;
            string path = default;
            IList<ApiOperationInvokableProtocol> protocols = default;
            ApiVersionSetContractDetails apiVersionSet = default;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("subscriptionKeyParameterNames"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new ApiType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiRevision"u8))
                        {
                            apiRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersion"u8))
                        {
                            apiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCurrent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCurrent = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isOnline"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isOnline = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiRevisionDescription"u8))
                        {
                            apiRevisionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionDescription"u8))
                        {
                            apiVersionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionSetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subscriptionRequired"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("termsOfServiceUrl"u8))
                        {
                            termsOfServiceUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contact = ApiContactInformation.DeserializeApiContactInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("license"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            license = ApiLicenseInformation.DeserializeApiLicenseInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sourceApiId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceApiId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"u8))
                        {
                            serviceUri = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApiOperationInvokableProtocol> array = new List<ApiOperationInvokableProtocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApiOperationInvokableProtocol(item.GetString()));
                            }
                            protocols = array;
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiVersionSet = ApiVersionSetContractDetails.DeserializeApiVersionSetContractDetails(property0.Value, options);
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
            return new ProductApiData(
                id,
                name,
                type,
                systemData,
                description,
                authenticationSettings,
                subscriptionKeyParameterNames,
                type0,
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
                sourceApiId,
                displayName,
                serviceUri,
                path,
                protocols ?? new ChangeTrackingList<ApiOperationInvokableProtocol>(),
                apiVersionSet,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
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
                builder.Append("    authenticationSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthenticationSettings))
                {
                    builder.Append("    authenticationSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AuthenticationSettings, options, 4, false, "    authenticationSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubscriptionKeyParameterNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subscriptionKeyParameterNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubscriptionKeyParameterNames))
                {
                    builder.Append("    subscriptionKeyParameterNames: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SubscriptionKeyParameterNames, options, 4, false, "    subscriptionKeyParameterNames: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiType))
                {
                    builder.Append("    type: ");
                    builder.AppendLine($"'{ApiType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevision), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    apiRevision: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevision))
                {
                    builder.Append("    apiRevision: ");
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
                builder.Append("    apiVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersion))
                {
                    builder.Append("    apiVersion: ");
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
                builder.Append("    isCurrent: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsCurrent))
                {
                    builder.Append("    isCurrent: ");
                    var boolValue = IsCurrent.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsOnline), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isOnline: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsOnline))
                {
                    builder.Append("    isOnline: ");
                    var boolValue = IsOnline.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiRevisionDescription), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    apiRevisionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiRevisionDescription))
                {
                    builder.Append("    apiRevisionDescription: ");
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
                builder.Append("    apiVersionDescription: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionDescription))
                {
                    builder.Append("    apiVersionDescription: ");
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
                builder.Append("    apiVersionSetId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionSetId))
                {
                    builder.Append("    apiVersionSetId: ");
                    builder.AppendLine($"'{ApiVersionSetId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSubscriptionRequired), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subscriptionRequired: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSubscriptionRequired))
                {
                    builder.Append("    subscriptionRequired: ");
                    var boolValue = IsSubscriptionRequired.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TermsOfServiceLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    termsOfServiceUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TermsOfServiceLink))
                {
                    builder.Append("    termsOfServiceUrl: ");
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
                builder.Append("    contact: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Contact))
                {
                    builder.Append("    contact: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Contact, options, 4, false, "    contact: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(License), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    license: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(License))
                {
                    builder.Append("    license: ");
                    BicepSerializationHelpers.AppendChildObject(builder, License, options, 4, false, "    license: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourceApiId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sourceApiId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SourceApiId))
                {
                    builder.Append("    sourceApiId: ");
                    builder.AppendLine($"'{SourceApiId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    serviceUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceLink))
                {
                    builder.Append("    serviceUrl: ");
                    if (ServiceLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServiceLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServiceLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Path))
                {
                    builder.Append("    path: ");
                    if (Path.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Path}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Path}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Protocols), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    protocols: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Protocols))
                {
                    if (Protocols.Any())
                    {
                        builder.Append("    protocols: ");
                        builder.AppendLine("[");
                        foreach (var item in Protocols)
                        {
                            builder.AppendLine($"      '{item.ToString()}'");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiVersionSet), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    apiVersionSet: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiVersionSet))
                {
                    builder.Append("    apiVersionSet: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ApiVersionSet, options, 4, false, "    apiVersionSet: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ProductApiData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductApiData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ProductApiData)} does not support writing '{options.Format}' format.");
            }
        }

        ProductApiData IPersistableModel<ProductApiData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductApiData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeProductApiData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductApiData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductApiData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
