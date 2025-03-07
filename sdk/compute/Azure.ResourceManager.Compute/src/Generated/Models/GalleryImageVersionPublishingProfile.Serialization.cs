// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryImageVersionPublishingProfile : IUtf8JsonSerializable, IJsonModel<GalleryImageVersionPublishingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryImageVersionPublishingProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GalleryImageVersionPublishingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        GalleryImageVersionPublishingProfile IJsonModel<GalleryImageVersionPublishingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryImageVersionPublishingProfile(document.RootElement, options);
        }

        internal static GalleryImageVersionPublishingProfile DeserializeGalleryImageVersionPublishingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TargetRegion> targetRegions = default;
            int? replicaCount = default;
            bool? excludeFromLatest = default;
            DateTimeOffset? publishedDate = default;
            DateTimeOffset? endOfLifeDate = default;
            ImageStorageAccountType? storageAccountType = default;
            GalleryReplicationMode? replicationMode = default;
            IList<GalleryTargetExtendedLocation> targetExtendedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRegion.DeserializeTargetRegion(item, options));
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
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
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationMode = new GalleryReplicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetExtendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryTargetExtendedLocation> array = new List<GalleryTargetExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryTargetExtendedLocation.DeserializeGalleryTargetExtendedLocation(item, options));
                    }
                    targetExtendedLocations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GalleryImageVersionPublishingProfile(
                targetRegions ?? new ChangeTrackingList<TargetRegion>(),
                replicaCount,
                excludeFromLatest,
                publishedDate,
                endOfLifeDate,
                storageAccountType,
                replicationMode,
                targetExtendedLocations ?? new ChangeTrackingList<GalleryTargetExtendedLocation>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GalleryImageVersionPublishingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support writing '{options.Format}' format.");
            }
        }

        GalleryImageVersionPublishingProfile IPersistableModel<GalleryImageVersionPublishingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryImageVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGalleryImageVersionPublishingProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryImageVersionPublishingProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryImageVersionPublishingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
