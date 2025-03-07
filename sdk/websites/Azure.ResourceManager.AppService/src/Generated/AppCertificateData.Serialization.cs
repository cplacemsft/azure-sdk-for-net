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
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppCertificateData : IUtf8JsonSerializable, IJsonModel<AppCertificateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppCertificateData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificateData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(SubjectName))
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (Optional.IsCollectionDefined(HostNames))
            {
                writer.WritePropertyName("hostNames"u8);
                writer.WriteStartArray();
                foreach (var item in HostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PfxBlob))
            {
                writer.WritePropertyName("pfxBlob"u8);
                writer.WriteBase64StringValue(PfxBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(SiteName))
            {
                writer.WritePropertyName("siteName"u8);
                writer.WriteStringValue(SiteName);
            }
            if (options.Format != "W" && Optional.IsDefined(SelfLink))
            {
                writer.WritePropertyName("selfLink"u8);
                writer.WriteStringValue(SelfLink);
            }
            if (options.Format != "W" && Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && Optional.IsDefined(IssueOn))
            {
                writer.WritePropertyName("issueDate"u8);
                writer.WriteStringValue(IssueOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ThumbprintString))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(ThumbprintString);
            }
            if (options.Format != "W" && Optional.IsDefined(IsValid))
            {
                writer.WritePropertyName("valid"u8);
                writer.WriteBooleanValue(IsValid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CerBlob))
            {
                writer.WritePropertyName("cerBlob"u8);
                writer.WriteBase64StringValue(CerBlob, "D");
            }
            if (options.Format != "W" && Optional.IsDefined(PublicKeyHash))
            {
                writer.WritePropertyName("publicKeyHash"u8);
                writer.WriteStringValue(PublicKeyHash);
            }
            if (options.Format != "W" && Optional.IsDefined(HostingEnvironmentProfile))
            {
                writer.WritePropertyName("hostingEnvironmentProfile"u8);
                writer.WriteObjectValue(HostingEnvironmentProfile, options);
            }
            if (Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (Optional.IsDefined(KeyVaultSecretName))
            {
                writer.WritePropertyName("keyVaultSecretName"u8);
                writer.WriteStringValue(KeyVaultSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultSecretStatus))
            {
                writer.WritePropertyName("keyVaultSecretStatus"u8);
                writer.WriteStringValue(KeyVaultSecretStatus.Value.ToSerialString());
            }
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(CanonicalName))
            {
                writer.WritePropertyName("canonicalName"u8);
                writer.WriteStringValue(CanonicalName);
            }
            if (Optional.IsDefined(DomainValidationMethod))
            {
                writer.WritePropertyName("domainValidationMethod"u8);
                writer.WriteStringValue(DomainValidationMethod);
            }
            writer.WriteEndObject();
        }

        AppCertificateData IJsonModel<AppCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppCertificateData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppCertificateData(document.RootElement, options);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Password), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    password: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Password))
                {
                    builder.Append("    password: ");
                    if (Password.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Password}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Password}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FriendlyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    friendlyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FriendlyName))
                {
                    builder.Append("    friendlyName: ");
                    if (FriendlyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FriendlyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FriendlyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubjectName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subjectName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubjectName))
                {
                    builder.Append("    subjectName: ");
                    if (SubjectName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SubjectName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SubjectName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hostNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(HostNames))
                {
                    if (HostNames.Any())
                    {
                        builder.Append("    hostNames: ");
                        builder.AppendLine("[");
                        foreach (var item in HostNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PfxBlob), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    pfxBlob: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PfxBlob))
                {
                    builder.Append("    pfxBlob: ");
                    builder.AppendLine($"'{PfxBlob.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SiteName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    siteName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SiteName))
                {
                    builder.Append("    siteName: ");
                    if (SiteName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SiteName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SiteName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SelfLink), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    selfLink: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SelfLink))
                {
                    builder.Append("    selfLink: ");
                    if (SelfLink.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SelfLink}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SelfLink}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Issuer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    issuer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Issuer))
                {
                    builder.Append("    issuer: ");
                    if (Issuer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Issuer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Issuer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IssueOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    issueDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IssueOn))
                {
                    builder.Append("    issueDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(IssueOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpireOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    expirationDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpireOn))
                {
                    builder.Append("    expirationDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ExpireOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThumbprintString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    thumbprint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThumbprintString))
                {
                    builder.Append("    thumbprint: ");
                    if (ThumbprintString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ThumbprintString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ThumbprintString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsValid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    valid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsValid))
                {
                    builder.Append("    valid: ");
                    var boolValue = IsValid.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CerBlob), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    cerBlob: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CerBlob))
                {
                    builder.Append("    cerBlob: ");
                    builder.AppendLine($"'{CerBlob.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PublicKeyHash), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    publicKeyHash: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PublicKeyHash))
                {
                    builder.Append("    publicKeyHash: ");
                    if (PublicKeyHash.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PublicKeyHash}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PublicKeyHash}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostingEnvironmentProfile), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hostingEnvironmentProfile: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostingEnvironmentProfile))
                {
                    builder.Append("    hostingEnvironmentProfile: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HostingEnvironmentProfile, options, 4, false, "    hostingEnvironmentProfile: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    keyVaultId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultId))
                {
                    builder.Append("    keyVaultId: ");
                    builder.AppendLine($"'{KeyVaultId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultSecretName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    keyVaultSecretName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultSecretName))
                {
                    builder.Append("    keyVaultSecretName: ");
                    if (KeyVaultSecretName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KeyVaultSecretName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KeyVaultSecretName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultSecretStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    keyVaultSecretStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultSecretStatus))
                {
                    builder.Append("    keyVaultSecretStatus: ");
                    builder.AppendLine($"'{KeyVaultSecretStatus.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServerFarmId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    serverFarmId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServerFarmId))
                {
                    builder.Append("    serverFarmId: ");
                    builder.AppendLine($"'{ServerFarmId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CanonicalName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    canonicalName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CanonicalName))
                {
                    builder.Append("    canonicalName: ");
                    if (CanonicalName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{CanonicalName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{CanonicalName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainValidationMethod), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    domainValidationMethod: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainValidationMethod))
                {
                    builder.Append("    domainValidationMethod: ");
                    if (DomainValidationMethod.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DomainValidationMethod}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DomainValidationMethod}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AppCertificateData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AppCertificateData)} does not support writing '{options.Format}' format.");
            }
        }

        AppCertificateData IPersistableModel<AppCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppCertificateData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppCertificateData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppCertificateData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
