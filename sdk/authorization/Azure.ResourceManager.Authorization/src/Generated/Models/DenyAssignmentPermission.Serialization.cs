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

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class DenyAssignmentPermission : IUtf8JsonSerializable, IJsonModel<DenyAssignmentPermission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DenyAssignmentPermission>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DenyAssignmentPermission>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DenyAssignmentPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DenyAssignmentPermission)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotActions))
            {
                writer.WritePropertyName("notActions"u8);
                writer.WriteStartArray();
                foreach (var item in NotActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DataActions))
            {
                writer.WritePropertyName("dataActions"u8);
                writer.WriteStartArray();
                foreach (var item in DataActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotDataActions))
            {
                writer.WritePropertyName("notDataActions"u8);
                writer.WriteStartArray();
                foreach (var item in NotDataActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(ConditionVersion))
            {
                writer.WritePropertyName("conditionVersion"u8);
                writer.WriteStringValue(ConditionVersion);
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

        DenyAssignmentPermission IJsonModel<DenyAssignmentPermission>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DenyAssignmentPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DenyAssignmentPermission)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDenyAssignmentPermission(document.RootElement, options);
        }

        internal static DenyAssignmentPermission DeserializeDenyAssignmentPermission(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> actions = default;
            IReadOnlyList<string> notActions = default;
            IReadOnlyList<string> dataActions = default;
            IReadOnlyList<string> notDataActions = default;
            string condition = default;
            string conditionVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actions"u8))
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
                    actions = array;
                    continue;
                }
                if (property.NameEquals("notActions"u8))
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
                    notActions = array;
                    continue;
                }
                if (property.NameEquals("dataActions"u8))
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
                    dataActions = array;
                    continue;
                }
                if (property.NameEquals("notDataActions"u8))
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
                    notDataActions = array;
                    continue;
                }
                if (property.NameEquals("condition"u8))
                {
                    condition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("conditionVersion"u8))
                {
                    conditionVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DenyAssignmentPermission(
                actions ?? new ChangeTrackingList<string>(),
                notActions ?? new ChangeTrackingList<string>(),
                dataActions ?? new ChangeTrackingList<string>(),
                notDataActions ?? new ChangeTrackingList<string>(),
                condition,
                conditionVersion,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Actions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Actions))
                {
                    if (Actions.Any())
                    {
                        builder.Append("  actions: ");
                        builder.AppendLine("[");
                        foreach (var item in Actions)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotActions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notActions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NotActions))
                {
                    if (NotActions.Any())
                    {
                        builder.Append("  notActions: ");
                        builder.AppendLine("[");
                        foreach (var item in NotActions)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataActions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataActions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DataActions))
                {
                    if (DataActions.Any())
                    {
                        builder.Append("  dataActions: ");
                        builder.AppendLine("[");
                        foreach (var item in DataActions)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NotDataActions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  notDataActions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NotDataActions))
                {
                    if (NotDataActions.Any())
                    {
                        builder.Append("  notDataActions: ");
                        builder.AppendLine("[");
                        foreach (var item in NotDataActions)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Condition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  condition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Condition))
                {
                    builder.Append("  condition: ");
                    if (Condition.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Condition}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Condition}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConditionVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conditionVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConditionVersion))
                {
                    builder.Append("  conditionVersion: ");
                    if (ConditionVersion.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConditionVersion}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConditionVersion}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DenyAssignmentPermission>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DenyAssignmentPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DenyAssignmentPermission)} does not support writing '{options.Format}' format.");
            }
        }

        DenyAssignmentPermission IPersistableModel<DenyAssignmentPermission>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DenyAssignmentPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDenyAssignmentPermission(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DenyAssignmentPermission)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DenyAssignmentPermission>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
