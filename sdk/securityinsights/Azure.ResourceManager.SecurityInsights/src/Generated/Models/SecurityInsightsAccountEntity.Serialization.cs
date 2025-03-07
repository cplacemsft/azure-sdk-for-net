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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAccountEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAccountEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAccountEntity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityInsightsAccountEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAccountEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(AadTenantId))
            {
                writer.WritePropertyName("aadTenantId"u8);
                writer.WriteStringValue(AadTenantId);
            }
            if (options.Format != "W" && Optional.IsDefined(AadUserId))
            {
                writer.WritePropertyName("aadUserId"u8);
                writer.WriteStringValue(AadUserId);
            }
            if (options.Format != "W" && Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(HostEntityId))
            {
                writer.WritePropertyName("hostEntityId"u8);
                writer.WriteStringValue(HostEntityId);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDomainJoined))
            {
                writer.WritePropertyName("isDomainJoined"u8);
                writer.WriteBooleanValue(IsDomainJoined.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(NtDomain))
            {
                writer.WritePropertyName("ntDomain"u8);
                writer.WriteStringValue(NtDomain);
            }
            if (options.Format != "W" && Optional.IsDefined(ObjectGuid))
            {
                writer.WritePropertyName("objectGuid"u8);
                writer.WriteStringValue(ObjectGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Puid))
            {
                writer.WritePropertyName("puid"u8);
                writer.WriteStringValue(Puid);
            }
            if (options.Format != "W" && Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid"u8);
                writer.WriteStringValue(Sid);
            }
            if (options.Format != "W" && Optional.IsDefined(UpnSuffix))
            {
                writer.WritePropertyName("upnSuffix"u8);
                writer.WriteStringValue(UpnSuffix);
            }
            if (options.Format != "W" && Optional.IsDefined(DnsDomain))
            {
                writer.WritePropertyName("dnsDomain"u8);
                writer.WriteStringValue(DnsDomain);
            }
            writer.WriteEndObject();
        }

        SecurityInsightsAccountEntity IJsonModel<SecurityInsightsAccountEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAccountEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAccountEntity(document.RootElement, options);
        }

        internal static SecurityInsightsAccountEntity DeserializeSecurityInsightsAccountEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyDictionary<string, BinaryData> additionalData = default;
            string friendlyName = default;
            string aadTenantId = default;
            string aadUserId = default;
            string accountName = default;
            string displayName = default;
            string hostEntityId = default;
            bool? isDomainJoined = default;
            string ntDomain = default;
            Guid? objectGuid = default;
            string puid = default;
            string sid = default;
            string upnSuffix = default;
            string dnsDomain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            aadTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadUserId"u8))
                        {
                            aadUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDomainJoined"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDomainJoined = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ntDomain"u8))
                        {
                            ntDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("objectGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            objectGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("puid"u8))
                        {
                            puid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            sid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("upnSuffix"u8))
                        {
                            upnSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsDomain"u8))
                        {
                            dnsDomain = property0.Value.GetString();
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
            return new SecurityInsightsAccountEntity(
                id,
                name,
                type,
                systemData,
                kind,
                serializedAdditionalRawData,
                additionalData ?? new ChangeTrackingDictionary<string, BinaryData>(),
                friendlyName,
                aadTenantId,
                aadUserId,
                accountName,
                displayName,
                hostEntityId,
                isDomainJoined,
                ntDomain,
                objectGuid,
                puid,
                sid,
                upnSuffix,
                dnsDomain);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  kind: ");
                builder.AppendLine($"'{Kind.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdditionalData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    additionalData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AdditionalData))
                {
                    if (AdditionalData.Any())
                    {
                        builder.Append("    additionalData: ");
                        builder.AppendLine("{");
                        foreach (var item in AdditionalData)
                        {
                            builder.Append($"        '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"'{item.Value.ToString()}'");
                        }
                        builder.AppendLine("    }");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadTenantId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadTenantId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadTenantId))
                {
                    builder.Append("    aadTenantId: ");
                    if (AadTenantId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AadTenantId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AadTenantId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AadUserId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    aadUserId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AadUserId))
                {
                    builder.Append("    aadUserId: ");
                    if (AadUserId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AadUserId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AadUserId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    accountName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountName))
                {
                    builder.Append("    accountName: ");
                    if (AccountName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccountName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccountName}'");
                    }
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HostEntityId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    hostEntityId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HostEntityId))
                {
                    builder.Append("    hostEntityId: ");
                    if (HostEntityId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HostEntityId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HostEntityId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDomainJoined), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isDomainJoined: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDomainJoined))
                {
                    builder.Append("    isDomainJoined: ");
                    var boolValue = IsDomainJoined.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NtDomain), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ntDomain: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NtDomain))
                {
                    builder.Append("    ntDomain: ");
                    if (NtDomain.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{NtDomain}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{NtDomain}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ObjectGuid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    objectGuid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ObjectGuid))
                {
                    builder.Append("    objectGuid: ");
                    builder.AppendLine($"'{ObjectGuid.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Puid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    puid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Puid))
                {
                    builder.Append("    puid: ");
                    if (Puid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Puid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Puid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    sid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sid))
                {
                    builder.Append("    sid: ");
                    if (Sid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Sid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Sid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpnSuffix), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    upnSuffix: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpnSuffix))
                {
                    builder.Append("    upnSuffix: ");
                    if (UpnSuffix.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{UpnSuffix}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{UpnSuffix}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsDomain), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    dnsDomain: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsDomain))
                {
                    builder.Append("    dnsDomain: ");
                    if (DnsDomain.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DnsDomain}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DnsDomain}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SecurityInsightsAccountEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAccountEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityInsightsAccountEntity IPersistableModel<SecurityInsightsAccountEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAccountEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSecurityInsightsAccountEntity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAccountEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
