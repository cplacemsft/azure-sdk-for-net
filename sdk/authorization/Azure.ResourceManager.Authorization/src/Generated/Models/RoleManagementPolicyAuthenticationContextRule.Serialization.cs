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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleManagementPolicyAuthenticationContextRule : IUtf8JsonSerializable, IJsonModel<RoleManagementPolicyAuthenticationContextRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleManagementPolicyAuthenticationContextRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RoleManagementPolicyAuthenticationContextRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAuthenticationContextRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyAuthenticationContextRule)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(ClaimValue))
            {
                writer.WritePropertyName("claimValue"u8);
                writer.WriteStringValue(ClaimValue);
            }
        }

        RoleManagementPolicyAuthenticationContextRule IJsonModel<RoleManagementPolicyAuthenticationContextRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAuthenticationContextRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoleManagementPolicyAuthenticationContextRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleManagementPolicyAuthenticationContextRule(document.RootElement, options);
        }

        internal static RoleManagementPolicyAuthenticationContextRule DeserializeRoleManagementPolicyAuthenticationContextRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isEnabled = default;
            string claimValue = default;
            string id = default;
            RoleManagementPolicyRuleType ruleType = default;
            RoleManagementPolicyRuleTarget target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("claimValue"u8))
                {
                    claimValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"u8))
                {
                    ruleType = new RoleManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = RoleManagementPolicyRuleTarget.DeserializeRoleManagementPolicyRuleTarget(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RoleManagementPolicyAuthenticationContextRule(
                id,
                ruleType,
                target,
                serializedAdditionalRawData,
                isEnabled,
                claimValue);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  isEnabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClaimValue), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  claimValue: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClaimValue))
                {
                    builder.Append("  claimValue: ");
                    if (ClaimValue.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClaimValue}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClaimValue}'");
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
                    if (Id.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Id}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Id}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ruleType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  ruleType: ");
                builder.AppendLine($"'{RuleType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Target), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  target: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Target))
                {
                    builder.Append("  target: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Target, options, 2, false, "  target: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RoleManagementPolicyAuthenticationContextRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAuthenticationContextRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyAuthenticationContextRule)} does not support writing '{options.Format}' format.");
            }
        }

        RoleManagementPolicyAuthenticationContextRule IPersistableModel<RoleManagementPolicyAuthenticationContextRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoleManagementPolicyAuthenticationContextRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRoleManagementPolicyAuthenticationContextRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoleManagementPolicyAuthenticationContextRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoleManagementPolicyAuthenticationContextRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
