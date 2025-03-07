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
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class ApplicationInsightsWebTestData : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsWebTestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsWebTestData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApplicationInsightsWebTestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsWebTestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsWebTestData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToSerialString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SyntheticMonitorId))
            {
                writer.WritePropertyName("SyntheticMonitorId"u8);
                writer.WriteStringValue(SyntheticMonitorId);
            }
            if (Optional.IsDefined(WebTestName))
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(WebTestName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("Description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("Enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(FrequencyInSeconds))
            {
                writer.WritePropertyName("Frequency"u8);
                writer.WriteNumberValue(FrequencyInSeconds.Value);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("Timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(WebTestKind))
            {
                writer.WritePropertyName("Kind"u8);
                writer.WriteStringValue(WebTestKind.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsRetryEnabled))
            {
                writer.WritePropertyName("RetryEnabled"u8);
                writer.WriteBooleanValue(IsRetryEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("Locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("Configuration"u8);
                writer.WriteObjectValue(Configuration, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Request))
            {
                writer.WritePropertyName("Request"u8);
                writer.WriteObjectValue(Request, options);
            }
            if (Optional.IsDefined(ValidationRules))
            {
                writer.WritePropertyName("ValidationRules"u8);
                writer.WriteObjectValue(ValidationRules, options);
            }
            writer.WriteEndObject();
        }

        ApplicationInsightsWebTestData IJsonModel<ApplicationInsightsWebTestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsWebTestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsWebTestData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsWebTestData(document.RootElement, options);
        }

        internal static ApplicationInsightsWebTestData DeserializeApplicationInsightsWebTestData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WebTestKind? kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string syntheticMonitorId = default;
            string name0 = default;
            string description = default;
            bool? enabled = default;
            int? frequency = default;
            int? timeout = default;
            WebTestKind? kind0 = default;
            bool? retryEnabled = default;
            IList<WebTestGeolocation> locations = default;
            WebTestConfiguration configuration = default;
            string provisioningState = default;
            WebTestRequest request = default;
            WebTestValidationRules validationRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = property.Value.GetString().ToWebTestKind();
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("SyntheticMonitorId"u8))
                        {
                            syntheticMonitorId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("Frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("Timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("Kind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kind0 = property0.Value.GetString().ToWebTestKind();
                            continue;
                        }
                        if (property0.NameEquals("RetryEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retryEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("Locations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebTestGeolocation> array = new List<WebTestGeolocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebTestGeolocation.DeserializeWebTestGeolocation(item, options));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configuration = WebTestConfiguration.DeserializeWebTestConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Request"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            request = WebTestRequest.DeserializeWebTestRequest(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ValidationRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationRules = WebTestValidationRules.DeserializeWebTestValidationRules(property0.Value, options);
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
            return new ApplicationInsightsWebTestData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                kind,
                syntheticMonitorId,
                name0,
                description,
                enabled,
                frequency,
                timeout,
                kind0,
                retryEnabled,
                locations ?? new ChangeTrackingList<WebTestGeolocation>(),
                configuration,
                provisioningState,
                request,
                validationRules,
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
                    builder.AppendLine($"'{Kind.Value.ToSerialString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyntheticMonitorId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    SyntheticMonitorId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyntheticMonitorId))
                {
                    builder.Append("    SyntheticMonitorId: ");
                    if (SyntheticMonitorId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SyntheticMonitorId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SyntheticMonitorId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebTestName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebTestName))
                {
                    builder.Append("    Name: ");
                    if (WebTestName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WebTestName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WebTestName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    Description: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("    Enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FrequencyInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Frequency: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FrequencyInSeconds))
                {
                    builder.Append("    Frequency: ");
                    builder.AppendLine($"{FrequencyInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Timeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("    Timeout: ");
                    builder.AppendLine($"{TimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebTestKind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WebTestKind))
                {
                    builder.Append("    Kind: ");
                    builder.AppendLine($"'{WebTestKind.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsRetryEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    RetryEnabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsRetryEnabled))
                {
                    builder.Append("    RetryEnabled: ");
                    var boolValue = IsRetryEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Locations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Locations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Locations))
                {
                    if (Locations.Any())
                    {
                        builder.Append("    Locations: ");
                        builder.AppendLine("[");
                        foreach (var item in Locations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    Locations: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("WebTest", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Configuration: ");
                builder.AppendLine("{");
                builder.AppendLine("      Configuration: {");
                builder.Append("        WebTest: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Configuration))
                {
                    builder.Append("    Configuration: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Configuration, options, 4, false, "    Configuration: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    if (ProvisioningState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProvisioningState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProvisioningState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Request), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    Request: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Request))
                {
                    builder.Append("    Request: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Request, options, 4, false, "    Request: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValidationRules), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    ValidationRules: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ValidationRules))
                {
                    builder.Append("    ValidationRules: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ValidationRules, options, 4, false, "    ValidationRules: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApplicationInsightsWebTestData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsWebTestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsWebTestData)} does not support writing '{options.Format}' format.");
            }
        }

        ApplicationInsightsWebTestData IPersistableModel<ApplicationInsightsWebTestData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationInsightsWebTestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApplicationInsightsWebTestData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApplicationInsightsWebTestData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationInsightsWebTestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
