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
    public partial class WorkloadSapHanaPointInTimeRecoveryPoint : IUtf8JsonSerializable, IJsonModel<WorkloadSapHanaPointInTimeRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadSapHanaPointInTimeRecoveryPoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WorkloadSapHanaPointInTimeRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSapHanaPointInTimeRecoveryPoint)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        WorkloadSapHanaPointInTimeRecoveryPoint IJsonModel<WorkloadSapHanaPointInTimeRecoveryPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadSapHanaPointInTimeRecoveryPoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(document.RootElement, options);
        }

        internal static WorkloadSapHanaPointInTimeRecoveryPoint DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<PointInTimeRange> timeRanges = default;
            DateTimeOffset? recoveryPointTimeInUTC = default;
            RestorePointType? type = default;
            IList<RecoveryPointTierInformationV2> recoveryPointTierDetails = default;
            IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo = default;
            RecoveryPointProperties recoveryPointProperties = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PointInTimeRange> array = new List<PointInTimeRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PointInTimeRange.DeserializePointInTimeRange(item, options));
                    }
                    timeRanges = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item, options));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value, options));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WorkloadSapHanaPointInTimeRecoveryPoint(
                objectType,
                serializedAdditionalRawData,
                recoveryPointTimeInUTC,
                type,
                recoveryPointTierDetails ?? new ChangeTrackingList<RecoveryPointTierInformationV2>(),
                recoveryPointMoveReadinessInfo ?? new ChangeTrackingDictionary<string, RecoveryPointMoveReadinessInfo>(),
                recoveryPointProperties,
                timeRanges ?? new ChangeTrackingList<PointInTimeRange>());
        }

        BinaryData IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadSapHanaPointInTimeRecoveryPoint)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadSapHanaPointInTimeRecoveryPoint IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadSapHanaPointInTimeRecoveryPoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadSapHanaPointInTimeRecoveryPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
