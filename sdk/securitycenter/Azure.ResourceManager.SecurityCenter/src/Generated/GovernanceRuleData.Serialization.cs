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
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class GovernanceRuleData : IUtf8JsonSerializable, IJsonModel<GovernanceRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GovernanceRuleData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GovernanceRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceRuleData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationTimeframe))
            {
                writer.WritePropertyName("remediationTimeframe"u8);
                writer.WriteStringValue(RemediationTimeframe);
            }
            if (Optional.IsDefined(IsGracePeriod))
            {
                writer.WritePropertyName("isGracePeriod"u8);
                writer.WriteBooleanValue(IsGracePeriod.Value);
            }
            if (Optional.IsDefined(RulePriority))
            {
                writer.WritePropertyName("rulePriority"u8);
                writer.WriteNumberValue(RulePriority.Value);
            }
            if (Optional.IsDefined(IsDisabled))
            {
                writer.WritePropertyName("isDisabled"u8);
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            if (Optional.IsDefined(RuleType))
            {
                writer.WritePropertyName("ruleType"u8);
                writer.WriteStringValue(RuleType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceType))
            {
                writer.WritePropertyName("sourceResourceType"u8);
                writer.WriteStringValue(SourceResourceType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExcludedScopes))
            {
                writer.WritePropertyName("excludedScopes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConditionSets))
            {
                writer.WritePropertyName("conditionSets"u8);
                writer.WriteStartArray();
                foreach (var item in ConditionSets)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IncludeMemberScopes))
            {
                writer.WritePropertyName("includeMemberScopes"u8);
                writer.WriteBooleanValue(IncludeMemberScopes.Value);
            }
            if (Optional.IsDefined(OwnerSource))
            {
                writer.WritePropertyName("ownerSource"u8);
                writer.WriteObjectValue(OwnerSource, options);
            }
            if (Optional.IsDefined(GovernanceEmailNotification))
            {
                writer.WritePropertyName("governanceEmailNotification"u8);
                writer.WriteObjectValue(GovernanceEmailNotification, options);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue(Metadata, options);
            }
            writer.WriteEndObject();
        }

        GovernanceRuleData IJsonModel<GovernanceRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceRuleData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceRuleData(document.RootElement, options);
        }

        internal static GovernanceRuleData DeserializeGovernanceRuleData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Guid? tenantId = default;
            string displayName = default;
            string description = default;
            string remediationTimeframe = default;
            bool? isGracePeriod = default;
            int? rulePriority = default;
            bool? isDisabled = default;
            GovernanceRuleType? ruleType = default;
            GovernanceRuleSourceResourceType? sourceResourceType = default;
            IList<string> excludedScopes = default;
            IList<BinaryData> conditionSets = default;
            bool? includeMemberScopes = default;
            GovernanceRuleOwnerSource ownerSource = default;
            GovernanceRuleEmailNotification governanceEmailNotification = default;
            GovernanceRuleMetadata metadata = default;
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationTimeframe"u8))
                        {
                            remediationTimeframe = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isGracePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isGracePeriod = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("rulePriority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rulePriority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isDisabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ruleType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ruleType = new GovernanceRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceResourceType = new GovernanceRuleSourceResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("excludedScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            excludedScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("conditionSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BinaryData> array = new List<BinaryData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(BinaryData.FromString(item.GetRawText()));
                                }
                            }
                            conditionSets = array;
                            continue;
                        }
                        if (property0.NameEquals("includeMemberScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            includeMemberScopes = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ownerSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ownerSource = GovernanceRuleOwnerSource.DeserializeGovernanceRuleOwnerSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("governanceEmailNotification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            governanceEmailNotification = GovernanceRuleEmailNotification.DeserializeGovernanceRuleEmailNotification(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = GovernanceRuleMetadata.DeserializeGovernanceRuleMetadata(property0.Value, options);
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
            return new GovernanceRuleData(
                id,
                name,
                type,
                systemData,
                tenantId,
                displayName,
                description,
                remediationTimeframe,
                isGracePeriod,
                rulePriority,
                isDisabled,
                ruleType,
                sourceResourceType,
                excludedScopes ?? new ChangeTrackingList<string>(),
                conditionSets ?? new ChangeTrackingList<BinaryData>(),
                includeMemberScopes,
                ownerSource,
                governanceEmailNotification,
                metadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GovernanceRuleData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GovernanceRuleData)} does not support writing '{options.Format}' format.");
            }
        }

        GovernanceRuleData IPersistableModel<GovernanceRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGovernanceRuleData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GovernanceRuleData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GovernanceRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
