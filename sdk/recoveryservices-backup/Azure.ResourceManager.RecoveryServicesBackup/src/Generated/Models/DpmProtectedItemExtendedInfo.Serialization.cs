// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class DpmProtectedItemExtendedInfo : IUtf8JsonSerializable, IJsonModel<DpmProtectedItemExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DpmProtectedItemExtendedInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DpmProtectedItemExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DpmProtectedItemExtendedInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ProtectableObjectLoadPath))
            {
                writer.WritePropertyName("protectableObjectLoadPath"u8);
                writer.WriteStartObject();
                foreach (var item in ProtectableObjectLoadPath)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsProtected))
            {
                writer.WritePropertyName("protected"u8);
                writer.WriteBooleanValue(IsProtected.Value);
            }
            if (Optional.IsDefined(IsPresentOnCloud))
            {
                writer.WritePropertyName("isPresentOnCloud"u8);
                writer.WriteBooleanValue(IsPresentOnCloud.Value);
            }
            if (Optional.IsDefined(LastBackupStatus))
            {
                writer.WritePropertyName("lastBackupStatus"u8);
                writer.WriteStringValue(LastBackupStatus);
            }
            if (Optional.IsDefined(LastRefreshedOn))
            {
                writer.WritePropertyName("lastRefreshedAt"u8);
                writer.WriteStringValue(LastRefreshedOn.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoverOn))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(OnPremiseOldestRecoverOn))
            {
                writer.WritePropertyName("onPremiseOldestRecoveryPoint"u8);
                writer.WriteStringValue(OnPremiseOldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(OnPremiseLatestRecoverOn))
            {
                writer.WritePropertyName("onPremiseLatestRecoveryPoint"u8);
                writer.WriteStringValue(OnPremiseLatestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(OnPremiseRecoveryPointCount))
            {
                writer.WritePropertyName("onPremiseRecoveryPointCount"u8);
                writer.WriteNumberValue(OnPremiseRecoveryPointCount.Value);
            }
            if (Optional.IsDefined(IsCollocated))
            {
                writer.WritePropertyName("isCollocated"u8);
                writer.WriteBooleanValue(IsCollocated.Value);
            }
            if (Optional.IsDefined(ProtectionGroupName))
            {
                writer.WritePropertyName("protectionGroupName"u8);
                writer.WriteStringValue(ProtectionGroupName);
            }
            if (Optional.IsDefined(DiskStorageUsedInBytes))
            {
                writer.WritePropertyName("diskStorageUsedInBytes"u8);
                writer.WriteStringValue(DiskStorageUsedInBytes);
            }
            if (Optional.IsDefined(TotalDiskStorageSizeInBytes))
            {
                writer.WritePropertyName("totalDiskStorageSizeInBytes"u8);
                writer.WriteStringValue(TotalDiskStorageSizeInBytes);
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

        DpmProtectedItemExtendedInfo IJsonModel<DpmProtectedItemExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DpmProtectedItemExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDpmProtectedItemExtendedInfo(document.RootElement, options);
        }

        internal static DpmProtectedItemExtendedInfo DeserializeDpmProtectedItemExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> protectableObjectLoadPath = default;
            bool? @protected = default;
            bool? isPresentOnCloud = default;
            string lastBackupStatus = default;
            DateTimeOffset? lastRefreshedAt = default;
            DateTimeOffset? oldestRecoveryPoint = default;
            int? recoveryPointCount = default;
            DateTimeOffset? onPremiseOldestRecoveryPoint = default;
            DateTimeOffset? onPremiseLatestRecoveryPoint = default;
            int? onPremiseRecoveryPointCount = default;
            bool? isCollocated = default;
            string protectionGroupName = default;
            string diskStorageUsedInBytes = default;
            string totalDiskStorageSizeInBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectableObjectLoadPath"u8))
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
                    protectableObjectLoadPath = dictionary;
                    continue;
                }
                if (property.NameEquals("protected"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @protected = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPresentOnCloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPresentOnCloud = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastBackupStatus"u8))
                {
                    lastBackupStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRefreshedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRefreshedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("onPremiseOldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onPremiseOldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("onPremiseLatestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onPremiseLatestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("onPremiseRecoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onPremiseRecoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isCollocated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCollocated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectionGroupName"u8))
                {
                    protectionGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskStorageUsedInBytes"u8))
                {
                    diskStorageUsedInBytes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("totalDiskStorageSizeInBytes"u8))
                {
                    totalDiskStorageSizeInBytes = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DpmProtectedItemExtendedInfo(
                protectableObjectLoadPath ?? new ChangeTrackingDictionary<string, string>(),
                @protected,
                isPresentOnCloud,
                lastBackupStatus,
                lastRefreshedAt,
                oldestRecoveryPoint,
                recoveryPointCount,
                onPremiseOldestRecoveryPoint,
                onPremiseLatestRecoveryPoint,
                onPremiseRecoveryPointCount,
                isCollocated,
                protectionGroupName,
                diskStorageUsedInBytes,
                totalDiskStorageSizeInBytes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DpmProtectedItemExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DpmProtectedItemExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DpmProtectedItemExtendedInfo IPersistableModel<DpmProtectedItemExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DpmProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDpmProtectedItemExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DpmProtectedItemExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DpmProtectedItemExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
