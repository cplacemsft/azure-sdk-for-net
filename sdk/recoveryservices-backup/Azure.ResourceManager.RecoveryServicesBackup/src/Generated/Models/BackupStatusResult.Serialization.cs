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
    public partial class BackupStatusResult : IUtf8JsonSerializable, IJsonModel<BackupStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupStatusResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackupStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupStatusResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus.Value.ToString());
            }
            if (Optional.IsDefined(VaultId))
            {
                writer.WritePropertyName("vaultId"u8);
                writer.WriteStringValue(VaultId);
            }
            if (Optional.IsDefined(FabricName))
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName.Value.ToString());
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(ProtectedItemName))
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
            }
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteStringValue(ErrorCode);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName"u8);
                writer.WriteStringValue(PolicyName);
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(ProtectedItemsCount))
            {
                writer.WritePropertyName("protectedItemsCount"u8);
                writer.WriteNumberValue(ProtectedItemsCount.Value);
            }
            if (Optional.IsDefined(AcquireStorageAccountLock))
            {
                writer.WritePropertyName("acquireStorageAccountLock"u8);
                writer.WriteStringValue(AcquireStorageAccountLock.Value.ToString());
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

        BackupStatusResult IJsonModel<BackupStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupStatusResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupStatusResult(document.RootElement, options);
        }

        internal static BackupStatusResult DeserializeBackupStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BackupProtectionStatus? protectionStatus = default;
            ResourceIdentifier vaultId = default;
            BackupFabricName? fabricName = default;
            string containerName = default;
            string protectedItemName = default;
            string errorCode = default;
            string errorMessage = default;
            string policyName = default;
            string registrationStatus = default;
            int? protectedItemsCount = default;
            AcquireStorageAccountLock? acquireStorageAccountLock = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionStatus = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricName = new BackupFabricName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    errorCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyName"u8))
                {
                    policyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedItemsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("acquireStorageAccountLock"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acquireStorageAccountLock = new AcquireStorageAccountLock(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackupStatusResult(
                protectionStatus,
                vaultId,
                fabricName,
                containerName,
                protectedItemName,
                errorCode,
                errorMessage,
                policyName,
                registrationStatus,
                protectedItemsCount,
                acquireStorageAccountLock,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupStatusResult)} does not support writing '{options.Format}' format.");
            }
        }

        BackupStatusResult IPersistableModel<BackupStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBackupStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupStatusResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
