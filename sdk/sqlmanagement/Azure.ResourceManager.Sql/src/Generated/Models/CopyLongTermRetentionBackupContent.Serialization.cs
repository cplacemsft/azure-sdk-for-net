// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class CopyLongTermRetentionBackupContent : IUtf8JsonSerializable, IJsonModel<CopyLongTermRetentionBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CopyLongTermRetentionBackupContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CopyLongTermRetentionBackupContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyLongTermRetentionBackupContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TargetSubscriptionId))
            {
                writer.WritePropertyName("targetSubscriptionId"u8);
                writer.WriteStringValue(TargetSubscriptionId);
            }
            if (Optional.IsDefined(TargetResourceGroup))
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroup);
            }
            if (Optional.IsDefined(TargetServerResourceId))
            {
                writer.WritePropertyName("targetServerResourceId"u8);
                writer.WriteStringValue(TargetServerResourceId);
            }
            if (Optional.IsDefined(TargetServerFullyQualifiedDomainName))
            {
                writer.WritePropertyName("targetServerFullyQualifiedDomainName"u8);
                writer.WriteStringValue(TargetServerFullyQualifiedDomainName);
            }
            if (Optional.IsDefined(TargetDatabaseName))
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (Optional.IsDefined(TargetBackupStorageRedundancy))
            {
                writer.WritePropertyName("targetBackupStorageRedundancy"u8);
                writer.WriteStringValue(TargetBackupStorageRedundancy.Value.ToString());
            }
            writer.WriteEndObject();
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

        CopyLongTermRetentionBackupContent IJsonModel<CopyLongTermRetentionBackupContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CopyLongTermRetentionBackupContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCopyLongTermRetentionBackupContent(document.RootElement, options);
        }

        internal static CopyLongTermRetentionBackupContent DeserializeCopyLongTermRetentionBackupContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetSubscriptionId = default;
            string targetResourceGroup = default;
            ResourceIdentifier targetServerResourceId = default;
            string targetServerFullyQualifiedDomainName = default;
            string targetDatabaseName = default;
            SqlBackupStorageRedundancy? targetBackupStorageRedundancy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetSubscriptionId"u8))
                        {
                            targetSubscriptionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceGroup"u8))
                        {
                            targetResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetServerFullyQualifiedDomainName"u8))
                        {
                            targetServerFullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetDatabaseName"u8))
                        {
                            targetDatabaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetBackupStorageRedundancy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetBackupStorageRedundancy = new SqlBackupStorageRedundancy(property0.Value.GetString());
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
            return new CopyLongTermRetentionBackupContent(
                targetSubscriptionId,
                targetResourceGroup,
                targetServerResourceId,
                targetServerFullyQualifiedDomainName,
                targetDatabaseName,
                targetBackupStorageRedundancy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CopyLongTermRetentionBackupContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CopyLongTermRetentionBackupContent)} does not support writing '{options.Format}' format.");
            }
        }

        CopyLongTermRetentionBackupContent IPersistableModel<CopyLongTermRetentionBackupContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CopyLongTermRetentionBackupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCopyLongTermRetentionBackupContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CopyLongTermRetentionBackupContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CopyLongTermRetentionBackupContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
