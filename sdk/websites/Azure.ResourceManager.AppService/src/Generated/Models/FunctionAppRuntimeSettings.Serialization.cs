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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppRuntimeSettings : IUtf8JsonSerializable, IJsonModel<FunctionAppRuntimeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionAppRuntimeSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FunctionAppRuntimeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(IsRemoteDebuggingSupported))
            {
                writer.WritePropertyName("remoteDebuggingSupported"u8);
                writer.WriteBooleanValue(IsRemoteDebuggingSupported.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(AppInsightsSettings))
            {
                writer.WritePropertyName("appInsightsSettings"u8);
                writer.WriteObjectValue(AppInsightsSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(GitHubActionSettings))
            {
                writer.WritePropertyName("gitHubActionSettings"u8);
                writer.WriteObjectValue(GitHubActionSettings, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AppSettingsDictionary))
            {
                writer.WritePropertyName("appSettingsDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in AppSettingsDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(SiteConfigPropertiesDictionary))
            {
                writer.WritePropertyName("siteConfigPropertiesDictionary"u8);
                writer.WriteObjectValue(SiteConfigPropertiesDictionary, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(SupportedFunctionsExtensionVersions))
            {
                writer.WritePropertyName("supportedFunctionsExtensionVersions"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedFunctionsExtensionVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDeprecated))
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsHidden))
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsAutoUpdate))
            {
                writer.WritePropertyName("isAutoUpdate"u8);
                writer.WriteBooleanValue(IsAutoUpdate.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsEarlyAccess))
            {
                writer.WritePropertyName("isEarlyAccess"u8);
                writer.WriteBooleanValue(IsEarlyAccess.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
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

        FunctionAppRuntimeSettings IJsonModel<FunctionAppRuntimeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
        }

        internal static FunctionAppRuntimeSettings DeserializeFunctionAppRuntimeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string runtimeVersion = default;
            bool? remoteDebuggingSupported = default;
            AppInsightsWebAppStackSettings appInsightsSettings = default;
            GitHubActionWebAppStackSettings gitHubActionSettings = default;
            IReadOnlyDictionary<string, string> appSettingsDictionary = default;
            SiteConfigPropertiesDictionary siteConfigPropertiesDictionary = default;
            IReadOnlyList<string> supportedFunctionsExtensionVersions = default;
            bool? isPreview = default;
            bool? isDeprecated = default;
            bool? isHidden = default;
            DateTimeOffset? endOfLifeDate = default;
            bool? isAutoUpdate = default;
            bool? isEarlyAccess = default;
            bool? isDefault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteDebuggingSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteDebuggingSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appInsightsSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appInsightsSettings = AppInsightsWebAppStackSettings.DeserializeAppInsightsWebAppStackSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("gitHubActionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHubActionSettings = GitHubActionWebAppStackSettings.DeserializeGitHubActionWebAppStackSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteConfigPropertiesDictionary = SiteConfigPropertiesDictionary.DeserializeSiteConfigPropertiesDictionary(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedFunctionsExtensionVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedFunctionsExtensionVersions = array;
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isAutoUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEarlyAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEarlyAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FunctionAppRuntimeSettings(
                runtimeVersion,
                remoteDebuggingSupported,
                appInsightsSettings,
                gitHubActionSettings,
                appSettingsDictionary ?? new ChangeTrackingDictionary<string, string>(),
                siteConfigPropertiesDictionary,
                supportedFunctionsExtensionVersions ?? new ChangeTrackingList<string>(),
                isPreview,
                isDeprecated,
                isHidden,
                endOfLifeDate,
                isAutoUpdate,
                isEarlyAccess,
                isDefault,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuntimeVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runtimeVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RuntimeVersion))
                {
                    builder.Append("  runtimeVersion: ");
                    if (RuntimeVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RuntimeVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RuntimeVersion}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsRemoteDebuggingSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  remoteDebuggingSupported: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsRemoteDebuggingSupported))
                {
                    builder.Append("  remoteDebuggingSupported: ");
                    var boolValue = IsRemoteDebuggingSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppInsightsSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appInsightsSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppInsightsSettings))
                {
                    builder.Append("  appInsightsSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AppInsightsSettings, options, 2, false, "  appInsightsSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GitHubActionSettings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gitHubActionSettings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GitHubActionSettings))
                {
                    builder.Append("  gitHubActionSettings: ");
                    BicepSerializationHelpers.AppendChildObject(builder, GitHubActionSettings, options, 2, false, "  gitHubActionSettings: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppSettingsDictionary), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  appSettingsDictionary: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AppSettingsDictionary))
                {
                    if (AppSettingsDictionary.Any())
                    {
                        builder.Append("  appSettingsDictionary: ");
                        builder.AppendLine("{");
                        foreach (var item in AppSettingsDictionary)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SiteConfigPropertiesDictionary), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  siteConfigPropertiesDictionary: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SiteConfigPropertiesDictionary))
                {
                    builder.Append("  siteConfigPropertiesDictionary: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SiteConfigPropertiesDictionary, options, 2, false, "  siteConfigPropertiesDictionary: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportedFunctionsExtensionVersions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportedFunctionsExtensionVersions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportedFunctionsExtensionVersions))
                {
                    if (SupportedFunctionsExtensionVersions.Any())
                    {
                        builder.Append("  supportedFunctionsExtensionVersions: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportedFunctionsExtensionVersions)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPreview), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isPreview: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPreview))
                {
                    builder.Append("  isPreview: ");
                    var boolValue = IsPreview.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDeprecated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isDeprecated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDeprecated))
                {
                    builder.Append("  isDeprecated: ");
                    var boolValue = IsDeprecated.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsHidden), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isHidden: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsHidden))
                {
                    builder.Append("  isHidden: ");
                    var boolValue = IsHidden.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOfLifeOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  endOfLifeDate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndOfLifeOn))
                {
                    builder.Append("  endOfLifeDate: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EndOfLifeOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsAutoUpdate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isAutoUpdate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsAutoUpdate))
                {
                    builder.Append("  isAutoUpdate: ");
                    var boolValue = IsAutoUpdate.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEarlyAccess), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isEarlyAccess: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEarlyAccess))
                {
                    builder.Append("  isEarlyAccess: ");
                    var boolValue = IsEarlyAccess.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDefault), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isDefault: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDefault))
                {
                    builder.Append("  isDefault: ");
                    var boolValue = IsDefault.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FunctionAppRuntimeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support writing '{options.Format}' format.");
            }
        }

        FunctionAppRuntimeSettings IPersistableModel<FunctionAppRuntimeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionAppRuntimeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFunctionAppRuntimeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionAppRuntimeSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionAppRuntimeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
