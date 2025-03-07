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

namespace Azure.ResourceManager.Search.Models
{
    public partial class SearchServiceSkuOfferingLimits : IUtf8JsonSerializable, IJsonModel<SearchServiceSkuOfferingLimits>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchServiceSkuOfferingLimits>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SearchServiceSkuOfferingLimits>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceSkuOfferingLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchServiceSkuOfferingLimits)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Indexes))
            {
                writer.WritePropertyName("indexes"u8);
                writer.WriteNumberValue(Indexes.Value);
            }
            if (Optional.IsDefined(Indexers))
            {
                writer.WritePropertyName("indexers"u8);
                writer.WriteNumberValue(Indexers.Value);
            }
            if (Optional.IsDefined(PartitionStorageInGigabytes))
            {
                writer.WritePropertyName("partitionStorageInGigabytes"u8);
                writer.WriteNumberValue(PartitionStorageInGigabytes.Value);
            }
            if (Optional.IsDefined(PartitionVectorStorageInGigabytes))
            {
                writer.WritePropertyName("partitionVectorStorageInGigabytes"u8);
                writer.WriteNumberValue(PartitionVectorStorageInGigabytes.Value);
            }
            if (Optional.IsDefined(SearchUnits))
            {
                writer.WritePropertyName("searchUnits"u8);
                writer.WriteNumberValue(SearchUnits.Value);
            }
            if (Optional.IsDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteNumberValue(Replicas.Value);
            }
            if (Optional.IsDefined(Partitions))
            {
                writer.WritePropertyName("partitions"u8);
                writer.WriteNumberValue(Partitions.Value);
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

        SearchServiceSkuOfferingLimits IJsonModel<SearchServiceSkuOfferingLimits>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceSkuOfferingLimits>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchServiceSkuOfferingLimits)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceSkuOfferingLimits(document.RootElement, options);
        }

        internal static SearchServiceSkuOfferingLimits DeserializeSearchServiceSkuOfferingLimits(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? indexes = default;
            int? indexers = default;
            float? partitionStorageInGigabytes = default;
            float? partitionVectorStorageInGigabytes = default;
            int? searchUnits = default;
            int? replicas = default;
            int? partitions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("indexers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partitionStorageInGigabytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionStorageInGigabytes = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("partitionVectorStorageInGigabytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionVectorStorageInGigabytes = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("searchUnits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchUnits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partitions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitions = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SearchServiceSkuOfferingLimits(
                indexes,
                indexers,
                partitionStorageInGigabytes,
                partitionVectorStorageInGigabytes,
                searchUnits,
                replicas,
                partitions,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Indexes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indexes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Indexes))
                {
                    builder.Append("  indexes: ");
                    builder.AppendLine($"{Indexes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Indexers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indexers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Indexers))
                {
                    builder.Append("  indexers: ");
                    builder.AppendLine($"{Indexers.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartitionStorageInGigabytes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partitionStorageInGigabytes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartitionStorageInGigabytes))
                {
                    builder.Append("  partitionStorageInGigabytes: ");
                    builder.AppendLine($"'{PartitionStorageInGigabytes.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartitionVectorStorageInGigabytes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partitionVectorStorageInGigabytes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartitionVectorStorageInGigabytes))
                {
                    builder.Append("  partitionVectorStorageInGigabytes: ");
                    builder.AppendLine($"'{PartitionVectorStorageInGigabytes.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SearchUnits), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  searchUnits: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SearchUnits))
                {
                    builder.Append("  searchUnits: ");
                    builder.AppendLine($"{SearchUnits.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Replicas), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  replicas: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Replicas))
                {
                    builder.Append("  replicas: ");
                    builder.AppendLine($"{Replicas.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Partitions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partitions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Partitions))
                {
                    builder.Append("  partitions: ");
                    builder.AppendLine($"{Partitions.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SearchServiceSkuOfferingLimits>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceSkuOfferingLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SearchServiceSkuOfferingLimits)} does not support writing '{options.Format}' format.");
            }
        }

        SearchServiceSkuOfferingLimits IPersistableModel<SearchServiceSkuOfferingLimits>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceSkuOfferingLimits>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSearchServiceSkuOfferingLimits(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchServiceSkuOfferingLimits)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchServiceSkuOfferingLimits>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
