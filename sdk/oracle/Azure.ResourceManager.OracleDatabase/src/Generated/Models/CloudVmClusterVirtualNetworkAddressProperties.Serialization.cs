// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class CloudVmClusterVirtualNetworkAddressProperties : IUtf8JsonSerializable, IJsonModel<CloudVmClusterVirtualNetworkAddressProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudVmClusterVirtualNetworkAddressProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudVmClusterVirtualNetworkAddressProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudVmClusterVirtualNetworkAddressProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(VmOcid))
            {
                writer.WritePropertyName("vmOcid"u8);
                writer.WriteStringValue(VmOcid);
            }
            if (options.Format != "W" && Optional.IsDefined(Ocid))
            {
                writer.WritePropertyName("ocid"u8);
                writer.WriteStringValue(Ocid);
            }
            if (options.Format != "W" && Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LifecycleState))
            {
                writer.WritePropertyName("lifecycleState"u8);
                writer.WriteStringValue(LifecycleState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssignedOn))
            {
                writer.WritePropertyName("timeAssigned"u8);
                writer.WriteStringValue(AssignedOn.Value, "O");
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

        CloudVmClusterVirtualNetworkAddressProperties IJsonModel<CloudVmClusterVirtualNetworkAddressProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudVmClusterVirtualNetworkAddressProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudVmClusterVirtualNetworkAddressProperties(document.RootElement, options);
        }

        internal static CloudVmClusterVirtualNetworkAddressProperties DeserializeCloudVmClusterVirtualNetworkAddressProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipAddress = default;
            ResourceIdentifier vmOcid = default;
            ResourceIdentifier ocid = default;
            string domain = default;
            string lifecycleDetails = default;
            OracleDatabaseProvisioningState? provisioningState = default;
            VirtualNetworkAddressLifecycleState? lifecycleState = default;
            DateTimeOffset? timeAssigned = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmOcid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmOcid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ocid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ocid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new OracleDatabaseProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lifecycleState = new VirtualNetworkAddressLifecycleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeAssigned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAssigned = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudVmClusterVirtualNetworkAddressProperties(
                ipAddress,
                vmOcid,
                ocid,
                domain,
                lifecycleDetails,
                provisioningState,
                lifecycleState,
                timeAssigned,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudVmClusterVirtualNetworkAddressProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CloudVmClusterVirtualNetworkAddressProperties IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCloudVmClusterVirtualNetworkAddressProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudVmClusterVirtualNetworkAddressProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudVmClusterVirtualNetworkAddressProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
