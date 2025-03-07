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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesServicePrincipal : IUtf8JsonSerializable, IJsonModel<KubernetesServicePrincipal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesServicePrincipal>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesServicePrincipal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesServicePrincipal)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ClientId))
            {
                if (ClientId != null)
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
                }
                else
                {
                    writer.WriteNull("clientId");
                }
            }
            if (Optional.IsDefined(TenantId))
            {
                if (TenantId != null)
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
                else
                {
                    writer.WriteNull("tenantId");
                }
            }
            if (Optional.IsDefined(ClientSecret))
            {
                if (ClientSecret != null)
                {
                    writer.WritePropertyName("clientSecret"u8);
                    writer.WriteStringValue(ClientSecret);
                }
                else
                {
                    writer.WriteNull("clientSecret");
                }
            }
            if (Optional.IsDefined(ClientCertificate))
            {
                if (ClientCertificate != null)
                {
                    writer.WritePropertyName("clientCertificate"u8);
                    writer.WriteStringValue(ClientCertificate);
                }
                else
                {
                    writer.WriteNull("clientCertificate");
                }
            }
            if (Optional.IsDefined(ClientCertificatePassword))
            {
                if (ClientCertificatePassword != null)
                {
                    writer.WritePropertyName("clientCertificatePassword"u8);
                    writer.WriteStringValue(ClientCertificatePassword);
                }
                else
                {
                    writer.WriteNull("clientCertificatePassword");
                }
            }
            if (Optional.IsDefined(ClientCertificateSendChain))
            {
                writer.WritePropertyName("clientCertificateSendChain"u8);
                writer.WriteBooleanValue(ClientCertificateSendChain.Value);
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

        KubernetesServicePrincipal IJsonModel<KubernetesServicePrincipal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesServicePrincipal)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesServicePrincipal(document.RootElement, options);
        }

        internal static KubernetesServicePrincipal DeserializeKubernetesServicePrincipal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? clientId = default;
            Guid? tenantId = default;
            string clientSecret = default;
            string clientCertificate = default;
            string clientCertificatePassword = default;
            bool? clientCertificateSendChain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientId = null;
                        continue;
                    }
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tenantId = null;
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientSecret = null;
                        continue;
                    }
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificate = null;
                        continue;
                    }
                    clientCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificatePassword"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clientCertificatePassword = null;
                        continue;
                    }
                    clientCertificatePassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientCertificateSendChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientCertificateSendChain = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesServicePrincipal(
                clientId,
                tenantId,
                clientSecret,
                clientCertificate,
                clientCertificatePassword,
                clientCertificateSendChain,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientId))
                {
                    builder.Append("  clientId: ");
                    builder.AppendLine($"'{ClientId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TenantId))
                {
                    builder.Append("  tenantId: ");
                    builder.AppendLine($"'{TenantId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecret), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecret))
                {
                    builder.Append("  clientSecret: ");
                    if (ClientSecret.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecret}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecret}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientCertificate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientCertificate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientCertificate))
                {
                    builder.Append("  clientCertificate: ");
                    if (ClientCertificate.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientCertificate}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientCertificate}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientCertificatePassword), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientCertificatePassword: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientCertificatePassword))
                {
                    builder.Append("  clientCertificatePassword: ");
                    if (ClientCertificatePassword.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientCertificatePassword}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientCertificatePassword}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientCertificateSendChain), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientCertificateSendChain: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientCertificateSendChain))
                {
                    builder.Append("  clientCertificateSendChain: ");
                    var boolValue = ClientCertificateSendChain.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<KubernetesServicePrincipal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesServicePrincipal)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesServicePrincipal IPersistableModel<KubernetesServicePrincipal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesServicePrincipal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKubernetesServicePrincipal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesServicePrincipal)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesServicePrincipal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
