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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticDetectorResponse : IUtf8JsonSerializable, IJsonModel<DiagnosticDetectorResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticDetectorResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DiagnosticDetectorResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(IssueDetected))
            {
                writer.WritePropertyName("issueDetected"u8);
                writer.WriteBooleanValue(IssueDetected.Value);
            }
            if (Optional.IsDefined(DetectorDefinition))
            {
                writer.WritePropertyName("detectorDefinition"u8);
                writer.WriteObjectValue(DetectorDefinition, options);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AbnormalTimePeriods))
            {
                writer.WritePropertyName("abnormalTimePeriods"u8);
                writer.WriteStartArray();
                foreach (var item in AbnormalTimePeriods)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0, options);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ResponseMetaData))
            {
                writer.WritePropertyName("responseMetaData"u8);
                writer.WriteObjectValue(ResponseMetaData, options);
            }
            writer.WriteEndObject();
        }

        DiagnosticDetectorResponse IJsonModel<DiagnosticDetectorResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticDetectorResponse(document.RootElement, options);
        }

        internal static DiagnosticDetectorResponse DeserializeDiagnosticDetectorResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            bool? issueDetected = default;
            DetectorDefinition detectorDefinition = default;
            IList<DiagnosticMetricSet> metrics = default;
            IList<DetectorAbnormalTimePeriod> abnormalTimePeriods = default;
            IList<IList<AppServiceNameValuePair>> data = default;
            DetectorMetadata responseMetaData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("issueDetected"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            issueDetected = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("detectorDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            detectorDefinition = DetectorDefinition.DeserializeDetectorDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DiagnosticMetricSet> array = new List<DiagnosticMetricSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DiagnosticMetricSet.DeserializeDiagnosticMetricSet(item, options));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("abnormalTimePeriods"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DetectorAbnormalTimePeriod> array = new List<DetectorAbnormalTimePeriod>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DetectorAbnormalTimePeriod.DeserializeDetectorAbnormalTimePeriod(item, options));
                            }
                            abnormalTimePeriods = array;
                            continue;
                        }
                        if (property0.NameEquals("data"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                                    foreach (var item0 in item.EnumerateArray())
                                    {
                                        array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0, options));
                                    }
                                    array.Add(array0);
                                }
                            }
                            data = array;
                            continue;
                        }
                        if (property0.NameEquals("responseMetaData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            responseMetaData = DetectorMetadata.DeserializeDetectorMetadata(property0.Value, options);
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
            return new DiagnosticDetectorResponse(
                id,
                name,
                type,
                systemData,
                startTime,
                endTime,
                issueDetected,
                detectorDefinition,
                metrics ?? new ChangeTrackingList<DiagnosticMetricSet>(),
                abnormalTimePeriods ?? new ChangeTrackingList<DetectorAbnormalTimePeriod>(),
                data ?? new ChangeTrackingList<IList<AppServiceNameValuePair>>(),
                responseMetaData,
                kind,
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
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartOn))
                {
                    builder.Append("    startTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EndOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    endTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EndOn))
                {
                    builder.Append("    endTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(EndOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IssueDetected), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    issueDetected: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IssueDetected))
                {
                    builder.Append("    issueDetected: ");
                    var boolValue = IssueDetected.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DetectorDefinition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    detectorDefinition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DetectorDefinition))
                {
                    builder.Append("    detectorDefinition: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DetectorDefinition, options, 4, false, "    detectorDefinition: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Metrics), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    metrics: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Metrics))
                {
                    if (Metrics.Any())
                    {
                        builder.Append("    metrics: ");
                        builder.AppendLine("[");
                        foreach (var item in Metrics)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    metrics: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AbnormalTimePeriods), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    abnormalTimePeriods: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AbnormalTimePeriods))
                {
                    if (AbnormalTimePeriods.Any())
                    {
                        builder.Append("    abnormalTimePeriods: ");
                        builder.AppendLine("[");
                        foreach (var item in AbnormalTimePeriods)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    abnormalTimePeriods: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Data), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    data: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Data))
                {
                    if (Data.Any())
                    {
                        builder.Append("    data: ");
                        builder.AppendLine("[");
                        foreach (var item in Data)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item)
                            {
                                BicepSerializationHelpers.AppendChildObject(builder, item0, options, 6, true, "    data: ");
                            }
                            builder.AppendLine("    ]");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DataSource", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    responseMetaData: ");
                builder.AppendLine("{");
                builder.AppendLine("      responseMetaData: {");
                builder.Append("        dataSource: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(ResponseMetaData))
                {
                    builder.Append("    responseMetaData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ResponseMetaData, options, 4, false, "    responseMetaData: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DiagnosticDetectorResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support writing '{options.Format}' format.");
            }
        }

        DiagnosticDetectorResponse IPersistableModel<DiagnosticDetectorResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnosticDetectorResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDiagnosticDetectorResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnosticDetectorResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnosticDetectorResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
