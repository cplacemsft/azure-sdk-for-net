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
    public partial class VmWorkloadSapAseSystemWorkloadItem : IUtf8JsonSerializable, IJsonModel<VmWorkloadSapAseSystemWorkloadItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadSapAseSystemWorkloadItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmWorkloadSapAseSystemWorkloadItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapAseSystemWorkloadItem)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        VmWorkloadSapAseSystemWorkloadItem IJsonModel<VmWorkloadSapAseSystemWorkloadItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadSapAseSystemWorkloadItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSapAseSystemWorkloadItem(document.RootElement, options);
        }

        internal static VmWorkloadSapAseSystemWorkloadItem DeserializeVmWorkloadSapAseSystemWorkloadItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string parentName = default;
            string serverName = default;
            bool? isAutoProtectable = default;
            int? subinquireditemcount = default;
            int? subWorkloadItemCount = default;
            string backupManagementType = default;
            string workloadType = default;
            string workloadItemType = default;
            string friendlyName = default;
            BackupProtectionStatus? protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subWorkloadItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subWorkloadItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"u8))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmWorkloadSapAseSystemWorkloadItem(
                backupManagementType,
                workloadType,
                workloadItemType,
                friendlyName,
                protectionState,
                serializedAdditionalRawData,
                parentName,
                serverName,
                isAutoProtectable,
                subinquireditemcount,
                subWorkloadItemCount);
        }

        BinaryData IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapAseSystemWorkloadItem)} does not support writing '{options.Format}' format.");
            }
        }

        VmWorkloadSapAseSystemWorkloadItem IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVmWorkloadSapAseSystemWorkloadItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadSapAseSystemWorkloadItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadSapAseSystemWorkloadItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
