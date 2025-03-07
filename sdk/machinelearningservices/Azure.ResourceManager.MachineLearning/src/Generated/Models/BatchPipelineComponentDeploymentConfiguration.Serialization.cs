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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class BatchPipelineComponentDeploymentConfiguration : IUtf8JsonSerializable, IJsonModel<BatchPipelineComponentDeploymentConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPipelineComponentDeploymentConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPipelineComponentDeploymentConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPipelineComponentDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPipelineComponentDeploymentConfiguration)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ComponentId))
            {
                if (ComponentId != null)
                {
                    writer.WritePropertyName("componentId"u8);
                    writer.WriteObjectValue(ComponentId, options);
                }
                else
                {
                    writer.WriteNull("componentId");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Settings))
            {
                if (Settings != null)
                {
                    writer.WritePropertyName("settings"u8);
                    writer.WriteStartObject();
                    foreach (var item in Settings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("settings");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
                {
                    writer.WritePropertyName("tags"u8);
                    writer.WriteStartObject();
                    foreach (var item in Tags)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("tags");
                }
            }
        }

        BatchPipelineComponentDeploymentConfiguration IJsonModel<BatchPipelineComponentDeploymentConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPipelineComponentDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPipelineComponentDeploymentConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPipelineComponentDeploymentConfiguration(document.RootElement, options);
        }

        internal static BatchPipelineComponentDeploymentConfiguration DeserializeBatchPipelineComponentDeploymentConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningIdAssetReference componentId = default;
            string description = default;
            IDictionary<string, string> settings = default;
            IDictionary<string, string> tags = default;
            BatchDeploymentConfigurationType deploymentConfigurationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("componentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        componentId = null;
                        continue;
                    }
                    componentId = MachineLearningIdAssetReference.DeserializeMachineLearningIdAssetReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        settings = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    settings = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("deploymentConfigurationType"u8))
                {
                    deploymentConfigurationType = new BatchDeploymentConfigurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPipelineComponentDeploymentConfiguration(
                deploymentConfigurationType,
                serializedAdditionalRawData,
                componentId,
                description,
                settings ?? new ChangeTrackingDictionary<string, string>(),
                tags ?? new ChangeTrackingDictionary<string, string>());
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComponentId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  componentId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ComponentId))
                {
                    builder.Append("  componentId: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ComponentId, options, 2, false, "  componentId: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("  description: ");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Settings), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  settings: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Settings))
                {
                    if (Settings.Any())
                    {
                        builder.Append("  settings: ");
                        builder.AppendLine("{");
                        foreach (var item in Settings)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentConfigurationType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  deploymentConfigurationType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  deploymentConfigurationType: ");
                builder.AppendLine($"'{DeploymentConfigurationType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BatchPipelineComponentDeploymentConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPipelineComponentDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BatchPipelineComponentDeploymentConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPipelineComponentDeploymentConfiguration IPersistableModel<BatchPipelineComponentDeploymentConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPipelineComponentDeploymentConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBatchPipelineComponentDeploymentConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPipelineComponentDeploymentConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPipelineComponentDeploymentConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
