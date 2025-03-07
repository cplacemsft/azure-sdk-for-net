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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedIdentityCredential : IUtf8JsonSerializable, IJsonModel<ManagedIdentityCredential>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedIdentityCredential>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedIdentityCredential>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ManagedIdentityType))
            {
                if (ManagedIdentityType != null)
                {
                    writer.WritePropertyName("managedIdentityType"u8);
                    writer.WriteStringValue(ManagedIdentityType);
                }
                else
                {
                    writer.WriteNull("managedIdentityType");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityResourceId))
            {
                if (UserManagedIdentityResourceId != null)
                {
                    writer.WritePropertyName("userManagedIdentityResourceId"u8);
                    writer.WriteStringValue(UserManagedIdentityResourceId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityResourceId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityClientId))
            {
                if (UserManagedIdentityClientId != null)
                {
                    writer.WritePropertyName("userManagedIdentityClientId"u8);
                    writer.WriteStringValue(UserManagedIdentityClientId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityClientId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityPrincipalId))
            {
                if (UserManagedIdentityPrincipalId != null)
                {
                    writer.WritePropertyName("userManagedIdentityPrincipalId"u8);
                    writer.WriteStringValue(UserManagedIdentityPrincipalId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityPrincipalId");
                }
            }
            if (Optional.IsDefined(UserManagedIdentityTenantId))
            {
                if (UserManagedIdentityTenantId != null)
                {
                    writer.WritePropertyName("userManagedIdentityTenantId"u8);
                    writer.WriteStringValue(UserManagedIdentityTenantId);
                }
                else
                {
                    writer.WriteNull("userManagedIdentityTenantId");
                }
            }
        }

        ManagedIdentityCredential IJsonModel<ManagedIdentityCredential>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedIdentityCredential(document.RootElement, options);
        }

        internal static ManagedIdentityCredential DeserializeManagedIdentityCredential(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string managedIdentityType = default;
            string userManagedIdentityResourceId = default;
            string userManagedIdentityClientId = default;
            string userManagedIdentityPrincipalId = default;
            string userManagedIdentityTenantId = default;
            DataReferenceCredentialType credentialType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedIdentityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managedIdentityType = null;
                        continue;
                    }
                    managedIdentityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityResourceId = null;
                        continue;
                    }
                    userManagedIdentityResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityClientId = null;
                        continue;
                    }
                    userManagedIdentityClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityPrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityPrincipalId = null;
                        continue;
                    }
                    userManagedIdentityPrincipalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userManagedIdentityTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        userManagedIdentityTenantId = null;
                        continue;
                    }
                    userManagedIdentityTenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new DataReferenceCredentialType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedIdentityCredential(
                credentialType,
                serializedAdditionalRawData,
                managedIdentityType,
                userManagedIdentityResourceId,
                userManagedIdentityClientId,
                userManagedIdentityPrincipalId,
                userManagedIdentityTenantId);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ManagedIdentityType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managedIdentityType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ManagedIdentityType))
                {
                    builder.Append("  managedIdentityType: ");
                    if (ManagedIdentityType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ManagedIdentityType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ManagedIdentityType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserManagedIdentityResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userManagedIdentityResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserManagedIdentityResourceId))
                {
                    builder.Append("  userManagedIdentityResourceId: ");
                    if (UserManagedIdentityResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserManagedIdentityResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserManagedIdentityResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserManagedIdentityClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userManagedIdentityClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserManagedIdentityClientId))
                {
                    builder.Append("  userManagedIdentityClientId: ");
                    if (UserManagedIdentityClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserManagedIdentityClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserManagedIdentityClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserManagedIdentityPrincipalId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userManagedIdentityPrincipalId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserManagedIdentityPrincipalId))
                {
                    builder.Append("  userManagedIdentityPrincipalId: ");
                    if (UserManagedIdentityPrincipalId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserManagedIdentityPrincipalId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserManagedIdentityPrincipalId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserManagedIdentityTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userManagedIdentityTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UserManagedIdentityTenantId))
                {
                    builder.Append("  userManagedIdentityTenantId: ");
                    if (UserManagedIdentityTenantId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UserManagedIdentityTenantId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UserManagedIdentityTenantId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CredentialType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  credentialType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  credentialType: ");
                builder.AppendLine($"'{CredentialType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedIdentityCredential>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedIdentityCredential IPersistableModel<ManagedIdentityCredential>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedIdentityCredential>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedIdentityCredential(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedIdentityCredential)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedIdentityCredential>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
