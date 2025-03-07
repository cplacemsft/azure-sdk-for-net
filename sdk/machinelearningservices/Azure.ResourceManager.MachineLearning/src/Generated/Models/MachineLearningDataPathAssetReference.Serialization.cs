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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDataPathAssetReference : IUtf8JsonSerializable, IJsonModel<MachineLearningDataPathAssetReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningDataPathAssetReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningDataPathAssetReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            if (Optional.IsDefined(DatastoreId))
            {
                if (DatastoreId != null)
                {
                    writer.WritePropertyName("datastoreId"u8);
                    writer.WriteStringValue(DatastoreId);
                }
                else
                {
                    writer.WriteNull("datastoreId");
                }
            }
        }

        MachineLearningDataPathAssetReference IJsonModel<MachineLearningDataPathAssetReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningDataPathAssetReference(document.RootElement, options);
        }

        internal static MachineLearningDataPathAssetReference DeserializeMachineLearningDataPathAssetReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            string datastoreId = default;
            ReferenceType referenceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datastoreId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        datastoreId = null;
                        continue;
                    }
                    datastoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceType"u8))
                {
                    referenceType = new ReferenceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningDataPathAssetReference(referenceType, serializedAdditionalRawData, path, datastoreId);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Path), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  path: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Path))
                {
                    builder.Append("  path: ");
                    if (Path.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Path}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Path}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatastoreId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  datastoreId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatastoreId))
                {
                    builder.Append("  datastoreId: ");
                    if (DatastoreId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatastoreId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatastoreId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReferenceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  referenceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  referenceType: ");
                builder.AppendLine($"'{ReferenceType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningDataPathAssetReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningDataPathAssetReference IPersistableModel<MachineLearningDataPathAssetReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningDataPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningDataPathAssetReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningDataPathAssetReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningDataPathAssetReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
