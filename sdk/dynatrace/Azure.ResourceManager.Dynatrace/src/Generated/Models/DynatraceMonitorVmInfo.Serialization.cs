// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorVmInfo : IUtf8JsonSerializable, IJsonModel<DynatraceMonitorVmInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceMonitorVmInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DynatraceMonitorVmInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorVmInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(MonitoringType))
            {
                writer.WritePropertyName("monitoringType"u8);
                writer.WriteStringValue(MonitoringType.Value.ToString());
            }
            if (Optional.IsDefined(AutoUpdateSetting))
            {
                writer.WritePropertyName("autoUpdateSetting"u8);
                writer.WriteStringValue(AutoUpdateSetting.Value.ToString());
            }
            if (Optional.IsDefined(UpdateStatus))
            {
                writer.WritePropertyName("updateStatus"u8);
                writer.WriteStringValue(UpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AvailabilityState))
            {
                writer.WritePropertyName("availabilityState"u8);
                writer.WriteStringValue(AvailabilityState.Value.ToString());
            }
            if (Optional.IsDefined(LogModule))
            {
                writer.WritePropertyName("logModule"u8);
                writer.WriteStringValue(LogModule.Value.ToString());
            }
            if (Optional.IsDefined(HostGroup))
            {
                writer.WritePropertyName("hostGroup"u8);
                writer.WriteStringValue(HostGroup);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
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

        DynatraceMonitorVmInfo IJsonModel<DynatraceMonitorVmInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorVmInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorVmInfo(document.RootElement, options);
        }

        internal static DynatraceMonitorVmInfo DeserializeDynatraceMonitorVmInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            string version = default;
            DynatraceOneAgentMonitoringType? monitoringType = default;
            DynatraceOneAgentAutoUpdateSetting? autoUpdateSetting = default;
            DynatraceOneAgentUpdateStatus? updateStatus = default;
            DynatraceOneAgentAvailabilityState? availabilityState = default;
            DynatraceLogModuleState? logModule = default;
            string hostGroup = default;
            string hostName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitoringType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringType = new DynatraceOneAgentMonitoringType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("autoUpdateSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpdateSetting = new DynatraceOneAgentAutoUpdateSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateStatus = new DynatraceOneAgentUpdateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availabilityState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availabilityState = new DynatraceOneAgentAvailabilityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("logModule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logModule = new DynatraceLogModuleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostGroup"u8))
                {
                    hostGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DynatraceMonitorVmInfo(
                resourceId,
                version,
                monitoringType,
                autoUpdateSetting,
                updateStatus,
                availabilityState,
                logModule,
                hostGroup,
                hostName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceMonitorVmInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorVmInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DynatraceMonitorVmInfo IPersistableModel<DynatraceMonitorVmInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorVmInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDynatraceMonitorVmInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorVmInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceMonitorVmInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
