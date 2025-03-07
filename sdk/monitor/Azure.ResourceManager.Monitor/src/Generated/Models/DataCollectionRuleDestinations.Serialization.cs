// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleDestinations : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleDestinations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleDestinations>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataCollectionRuleDestinations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDestinations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDestinations)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        DataCollectionRuleDestinations IJsonModel<DataCollectionRuleDestinations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDestinations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataCollectionRuleDestinations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleDestinations(document.RootElement, options);
        }

        internal static DataCollectionRuleDestinations DeserializeDataCollectionRuleDestinations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<LogAnalyticsDestination> logAnalytics = default;
            IList<MonitoringAccountDestination> monitoringAccounts = default;
            DestinationsSpecAzureMonitorMetrics azureMonitorMetrics = default;
            IList<DataCollectionRuleEventHubDestination> eventHubs = default;
            IList<DataCollectionRuleEventHubDirectDestination> eventHubsDirect = default;
            IList<DataCollectionRuleStorageBlobDestination> storageBlobsDirect = default;
            IList<DataCollectionRuleStorageTableDestination> storageTablesDirect = default;
            IList<DataCollectionRuleStorageBlobDestination> storageAccounts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logAnalytics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogAnalyticsDestination> array = new List<LogAnalyticsDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogAnalyticsDestination.DeserializeLogAnalyticsDestination(item, options));
                    }
                    logAnalytics = array;
                    continue;
                }
                if (property.NameEquals("monitoringAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitoringAccountDestination> array = new List<MonitoringAccountDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoringAccountDestination.DeserializeMonitoringAccountDestination(item, options));
                    }
                    monitoringAccounts = array;
                    continue;
                }
                if (property.NameEquals("azureMonitorMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureMonitorMetrics = DestinationsSpecAzureMonitorMetrics.DeserializeDestinationsSpecAzureMonitorMetrics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("eventHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleEventHubDestination> array = new List<DataCollectionRuleEventHubDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleEventHubDestination.DeserializeDataCollectionRuleEventHubDestination(item, options));
                    }
                    eventHubs = array;
                    continue;
                }
                if (property.NameEquals("eventHubsDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleEventHubDirectDestination> array = new List<DataCollectionRuleEventHubDirectDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleEventHubDirectDestination.DeserializeDataCollectionRuleEventHubDirectDestination(item, options));
                    }
                    eventHubsDirect = array;
                    continue;
                }
                if (property.NameEquals("storageBlobsDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageBlobDestination> array = new List<DataCollectionRuleStorageBlobDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageBlobDestination.DeserializeDataCollectionRuleStorageBlobDestination(item, options));
                    }
                    storageBlobsDirect = array;
                    continue;
                }
                if (property.NameEquals("storageTablesDirect"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageTableDestination> array = new List<DataCollectionRuleStorageTableDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageTableDestination.DeserializeDataCollectionRuleStorageTableDestination(item, options));
                    }
                    storageTablesDirect = array;
                    continue;
                }
                if (property.NameEquals("storageAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleStorageBlobDestination> array = new List<DataCollectionRuleStorageBlobDestination>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleStorageBlobDestination.DeserializeDataCollectionRuleStorageBlobDestination(item, options));
                    }
                    storageAccounts = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataCollectionRuleDestinations(
                logAnalytics ?? new ChangeTrackingList<LogAnalyticsDestination>(),
                monitoringAccounts ?? new ChangeTrackingList<MonitoringAccountDestination>(),
                azureMonitorMetrics,
                eventHubs ?? new ChangeTrackingList<DataCollectionRuleEventHubDestination>(),
                eventHubsDirect ?? new ChangeTrackingList<DataCollectionRuleEventHubDirectDestination>(),
                storageBlobsDirect ?? new ChangeTrackingList<DataCollectionRuleStorageBlobDestination>(),
                storageTablesDirect ?? new ChangeTrackingList<DataCollectionRuleStorageTableDestination>(),
                storageAccounts ?? new ChangeTrackingList<DataCollectionRuleStorageBlobDestination>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleDestinations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDestinations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleDestinations)} does not support writing '{options.Format}' format.");
            }
        }

        DataCollectionRuleDestinations IPersistableModel<DataCollectionRuleDestinations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleDestinations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataCollectionRuleDestinations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataCollectionRuleDestinations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleDestinations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
