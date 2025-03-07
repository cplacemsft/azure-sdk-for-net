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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceFeatures : IUtf8JsonSerializable, IJsonModel<OperationalInsightsWorkspaceFeatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationalInsightsWorkspaceFeatures>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OperationalInsightsWorkspaceFeatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceFeatures)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsDataExportEnabled))
            {
                if (IsDataExportEnabled != null)
                {
                    writer.WritePropertyName("enableDataExport"u8);
                    writer.WriteBooleanValue(IsDataExportEnabled.Value);
                }
                else
                {
                    writer.WriteNull("enableDataExport");
                }
            }
            if (Optional.IsDefined(ImmediatePurgeDataOn30Days))
            {
                if (ImmediatePurgeDataOn30Days != null)
                {
                    writer.WritePropertyName("immediatePurgeDataOn30Days"u8);
                    writer.WriteBooleanValue(ImmediatePurgeDataOn30Days.Value);
                }
                else
                {
                    writer.WriteNull("immediatePurgeDataOn30Days");
                }
            }
            if (Optional.IsDefined(IsLogAccessUsingOnlyResourcePermissionsEnabled))
            {
                if (IsLogAccessUsingOnlyResourcePermissionsEnabled != null)
                {
                    writer.WritePropertyName("enableLogAccessUsingOnlyResourcePermissions"u8);
                    writer.WriteBooleanValue(IsLogAccessUsingOnlyResourcePermissionsEnabled.Value);
                }
                else
                {
                    writer.WriteNull("enableLogAccessUsingOnlyResourcePermissions");
                }
            }
            if (Optional.IsDefined(ClusterResourceId))
            {
                if (ClusterResourceId != null)
                {
                    writer.WritePropertyName("clusterResourceId"u8);
                    writer.WriteStringValue(ClusterResourceId);
                }
                else
                {
                    writer.WriteNull("clusterResourceId");
                }
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                if (IsLocalAuthDisabled != null)
                {
                    writer.WritePropertyName("disableLocalAuth"u8);
                    writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
                }
                else
                {
                    writer.WriteNull("disableLocalAuth");
                }
            }
            foreach (var item in AdditionalProperties)
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

        OperationalInsightsWorkspaceFeatures IJsonModel<OperationalInsightsWorkspaceFeatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceFeatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceFeatures)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationalInsightsWorkspaceFeatures(document.RootElement, options);
        }

        internal static OperationalInsightsWorkspaceFeatures DeserializeOperationalInsightsWorkspaceFeatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enableDataExport = default;
            bool? immediatePurgeDataOn30Days = default;
            bool? enableLogAccessUsingOnlyResourcePermissions = default;
            ResourceIdentifier clusterResourceId = default;
            bool? disableLocalAuth = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableDataExport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableDataExport = null;
                        continue;
                    }
                    enableDataExport = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("immediatePurgeDataOn30Days"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        immediatePurgeDataOn30Days = null;
                        continue;
                    }
                    immediatePurgeDataOn30Days = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableLogAccessUsingOnlyResourcePermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableLogAccessUsingOnlyResourcePermissions = null;
                        continue;
                    }
                    enableLogAccessUsingOnlyResourcePermissions = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clusterResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        clusterResourceId = null;
                        continue;
                    }
                    clusterResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        disableLocalAuth = null;
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new OperationalInsightsWorkspaceFeatures(
                enableDataExport,
                immediatePurgeDataOn30Days,
                enableLogAccessUsingOnlyResourcePermissions,
                clusterResourceId,
                disableLocalAuth,
                additionalProperties);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsDataExportEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableDataExport: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsDataExportEnabled))
                {
                    builder.Append("  enableDataExport: ");
                    var boolValue = IsDataExportEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImmediatePurgeDataOn30Days), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  immediatePurgeDataOn30Days: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ImmediatePurgeDataOn30Days))
                {
                    builder.Append("  immediatePurgeDataOn30Days: ");
                    var boolValue = ImmediatePurgeDataOn30Days.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsLogAccessUsingOnlyResourcePermissionsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enableLogAccessUsingOnlyResourcePermissions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsLogAccessUsingOnlyResourcePermissionsEnabled))
                {
                    builder.Append("  enableLogAccessUsingOnlyResourcePermissions: ");
                    var boolValue = IsLogAccessUsingOnlyResourcePermissionsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClusterResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clusterResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClusterResourceId))
                {
                    builder.Append("  clusterResourceId: ");
                    builder.AppendLine($"'{ClusterResourceId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsLocalAuthDisabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  disableLocalAuth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsLocalAuthDisabled))
                {
                    builder.Append("  disableLocalAuth: ");
                    var boolValue = IsLocalAuthDisabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OperationalInsightsWorkspaceFeatures>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceFeatures)} does not support writing '{options.Format}' format.");
            }
        }

        OperationalInsightsWorkspaceFeatures IPersistableModel<OperationalInsightsWorkspaceFeatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationalInsightsWorkspaceFeatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOperationalInsightsWorkspaceFeatures(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationalInsightsWorkspaceFeatures)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationalInsightsWorkspaceFeatures>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
