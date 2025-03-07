// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Models
{
    public partial class ConnectedClusterStorageClassProperties : IUtf8JsonSerializable, IJsonModel<ConnectedClusterStorageClassProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectedClusterStorageClassProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectedClusterStorageClassProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterStorageClassProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterStorageClassProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(AllowVolumeExpansion))
            {
                writer.WritePropertyName("allowVolumeExpansion"u8);
                writer.WriteStringValue(AllowVolumeExpansion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MountOptions))
            {
                writer.WritePropertyName("mountOptions"u8);
                writer.WriteStartArray();
                foreach (var item in MountOptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Provisioner))
            {
                writer.WritePropertyName("provisioner"u8);
                writer.WriteStringValue(Provisioner);
            }
            if (Optional.IsDefined(VolumeBindingMode))
            {
                writer.WritePropertyName("volumeBindingMode"u8);
                writer.WriteStringValue(VolumeBindingMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AccessModes))
            {
                writer.WritePropertyName("accessModes"u8);
                writer.WriteStartArray();
                foreach (var item in AccessModes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DataResilience))
            {
                writer.WritePropertyName("dataResilience"u8);
                writer.WriteStringValue(DataResilience.Value.ToString());
            }
            if (Optional.IsDefined(FailoverSpeed))
            {
                writer.WritePropertyName("failoverSpeed"u8);
                writer.WriteStringValue(FailoverSpeed.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Limitations))
            {
                writer.WritePropertyName("limitations"u8);
                writer.WriteStartArray();
                foreach (var item in Limitations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Performance))
            {
                writer.WritePropertyName("performance"u8);
                writer.WriteStringValue(Performance.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteObjectValue(TypeProperties, options);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        ConnectedClusterStorageClassProperties IJsonModel<ConnectedClusterStorageClassProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterStorageClassProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectedClusterStorageClassProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectedClusterStorageClassProperties(document.RootElement, options);
        }

        internal static ConnectedClusterStorageClassProperties DeserializeConnectedClusterStorageClassProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VolumeExpansion? allowVolumeExpansion = default;
            IList<string> mountOptions = default;
            string provisioner = default;
            VolumeBindingMode? volumeBindingMode = default;
            IList<StorageClassAccessMode> accessModes = default;
            DataResilienceTier? dataResilience = default;
            FailoverTier? failoverSpeed = default;
            IList<string> limitations = default;
            PerformanceTier? performance = default;
            long? priority = default;
            StorageClassTypeProperties typeProperties = default;
            ContainerOrchestratorProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowVolumeExpansion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowVolumeExpansion = new VolumeExpansion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mountOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    mountOptions = array;
                    continue;
                }
                if (property.NameEquals("provisioner"u8))
                {
                    provisioner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("volumeBindingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    volumeBindingMode = new VolumeBindingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessModes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageClassAccessMode> array = new List<StorageClassAccessMode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new StorageClassAccessMode(item.GetString()));
                    }
                    accessModes = array;
                    continue;
                }
                if (property.NameEquals("dataResilience"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataResilience = new DataResilienceTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverSpeed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverSpeed = new FailoverTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("limitations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    limitations = array;
                    continue;
                }
                if (property.NameEquals("performance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performance = new PerformanceTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    typeProperties = StorageClassTypeProperties.DeserializeStorageClassTypeProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ContainerOrchestratorProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectedClusterStorageClassProperties(
                allowVolumeExpansion,
                mountOptions ?? new ChangeTrackingList<string>(),
                provisioner,
                volumeBindingMode,
                accessModes ?? new ChangeTrackingList<StorageClassAccessMode>(),
                dataResilience,
                failoverSpeed,
                limitations ?? new ChangeTrackingList<string>(),
                performance,
                priority,
                typeProperties,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectedClusterStorageClassProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterStorageClassProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterStorageClassProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectedClusterStorageClassProperties IPersistableModel<ConnectedClusterStorageClassProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectedClusterStorageClassProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectedClusterStorageClassProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectedClusterStorageClassProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectedClusterStorageClassProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
