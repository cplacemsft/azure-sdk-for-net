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

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class SearchMetadata : IUtf8JsonSerializable, IJsonModel<SearchMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SearchMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchMetadata)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SearchId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(SearchId);
            }
            if (Optional.IsDefined(ResultType))
            {
                writer.WritePropertyName("resultType"u8);
                writer.WriteStringValue(ResultType);
            }
            if (Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
            }
            if (Optional.IsDefined(Top))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(CoreSummaries))
            {
                writer.WritePropertyName("coreSummaries"u8);
                writer.WriteStartArray();
                foreach (var item in CoreSummaries)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated.Value, "O");
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Sort))
            {
                writer.WritePropertyName("sort"u8);
                writer.WriteStartArray();
                foreach (var item in Sort)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestTime))
            {
                writer.WritePropertyName("requestTime"u8);
                writer.WriteNumberValue(RequestTime.Value);
            }
            if (Optional.IsDefined(AggregatedValueField))
            {
                writer.WritePropertyName("aggregatedValueField"u8);
                writer.WriteStringValue(AggregatedValueField);
            }
            if (Optional.IsDefined(AggregatedGroupingFields))
            {
                writer.WritePropertyName("aggregatedGroupingFields"u8);
                writer.WriteStringValue(AggregatedGroupingFields);
            }
            if (Optional.IsDefined(Sum))
            {
                writer.WritePropertyName("sum"u8);
                writer.WriteNumberValue(Sum.Value);
            }
            if (Optional.IsDefined(Max))
            {
                writer.WritePropertyName("max"u8);
                writer.WriteNumberValue(Max.Value);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteObjectValue(Schema, options);
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

        SearchMetadata IJsonModel<SearchMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchMetadata(document.RootElement, options);
        }

        internal static SearchMetadata DeserializeSearchMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string requestId = default;
            string resultType = default;
            long? total = default;
            long? top = default;
            string id = default;
            IReadOnlyList<OperationalInsightsSearchCoreSummary> coreSummaries = default;
            string status = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? lastUpdated = default;
            ETag? etag = default;
            IReadOnlyList<SearchSort> sort = default;
            long? requestTime = default;
            string aggregatedValueField = default;
            string aggregatedGroupingFields = default;
            long? sum = default;
            long? max = default;
            SearchMetadataSchema schema = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreSummaries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsSearchCoreSummary> array = new List<OperationalInsightsSearchCoreSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsSearchCoreSummary.DeserializeOperationalInsightsSearchCoreSummary(item, options));
                    }
                    coreSummaries = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SearchSort> array = new List<SearchSort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchSort.DeserializeSearchSort(item, options));
                    }
                    sort = array;
                    continue;
                }
                if (property.NameEquals("requestTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("aggregatedValueField"u8))
                {
                    aggregatedValueField = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregatedGroupingFields"u8))
                {
                    aggregatedGroupingFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("max"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    max = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = SearchMetadataSchema.DeserializeSearchMetadataSchema(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SearchMetadata(
                requestId,
                resultType,
                total,
                top,
                id,
                coreSummaries ?? new ChangeTrackingList<OperationalInsightsSearchCoreSummary>(),
                status,
                startTime,
                lastUpdated,
                etag,
                sort ?? new ChangeTrackingList<SearchSort>(),
                requestTime,
                aggregatedValueField,
                aggregatedGroupingFields,
                sum,
                max,
                schema,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SearchId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requestId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SearchId))
                {
                    builder.Append("  requestId: ");
                    if (SearchId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SearchId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SearchId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResultType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  resultType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResultType))
                {
                    builder.Append("  resultType: ");
                    if (ResultType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ResultType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ResultType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Total), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  total: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Total))
                {
                    builder.Append("  total: ");
                    builder.AppendLine($"'{Total.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Top), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  top: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Top))
                {
                    builder.Append("  top: ");
                    builder.AppendLine($"'{Top.Value.ToString()}'");
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CoreSummaries), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  coreSummaries: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CoreSummaries))
                {
                    if (CoreSummaries.Any())
                    {
                        builder.Append("  coreSummaries: ");
                        builder.AppendLine("[");
                        foreach (var item in CoreSummaries)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  coreSummaries: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    if (Status.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Status}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Status}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StartOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  startTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StartOn))
                {
                    builder.Append("  startTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(StartOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastUpdated), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastUpdated: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastUpdated))
                {
                    builder.Append("  lastUpdated: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastUpdated.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  eTag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  eTag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sort), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sort: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Sort))
                {
                    if (Sort.Any())
                    {
                        builder.Append("  sort: ");
                        builder.AppendLine("[");
                        foreach (var item in Sort)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  sort: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequestTime), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  requestTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequestTime))
                {
                    builder.Append("  requestTime: ");
                    builder.AppendLine($"'{RequestTime.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AggregatedValueField), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aggregatedValueField: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AggregatedValueField))
                {
                    builder.Append("  aggregatedValueField: ");
                    if (AggregatedValueField.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AggregatedValueField}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AggregatedValueField}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AggregatedGroupingFields), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aggregatedGroupingFields: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AggregatedGroupingFields))
                {
                    builder.Append("  aggregatedGroupingFields: ");
                    if (AggregatedGroupingFields.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AggregatedGroupingFields}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AggregatedGroupingFields}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Sum), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sum: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Sum))
                {
                    builder.Append("  sum: ");
                    builder.AppendLine($"'{Sum.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Max), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  max: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Max))
                {
                    builder.Append("  max: ");
                    builder.AppendLine($"'{Max.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Schema), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  schema: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Schema))
                {
                    builder.Append("  schema: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Schema, options, 2, false, "  schema: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SearchMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SearchMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        SearchMetadata IPersistableModel<SearchMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSearchMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
