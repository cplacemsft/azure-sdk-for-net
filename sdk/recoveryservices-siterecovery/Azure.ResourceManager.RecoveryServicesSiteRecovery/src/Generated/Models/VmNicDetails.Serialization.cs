// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VmNicDetails : IUtf8JsonSerializable, IJsonModel<VmNicDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmNicDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VmNicDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmNicDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NicId))
            {
                writer.WritePropertyName("nicId"u8);
                writer.WriteStringValue(NicId);
            }
            if (Optional.IsDefined(ReplicaNicId))
            {
                writer.WritePropertyName("replicaNicId"u8);
                writer.WriteStringValue(ReplicaNicId);
            }
            if (Optional.IsDefined(SourceNicArmId))
            {
                writer.WritePropertyName("sourceNicArmId"u8);
                writer.WriteStringValue(SourceNicArmId);
            }
            if (Optional.IsDefined(VmNetworkName))
            {
                writer.WritePropertyName("vMNetworkName"u8);
                writer.WriteStringValue(VmNetworkName);
            }
            if (Optional.IsDefined(RecoveryVmNetworkId))
            {
                writer.WritePropertyName("recoveryVMNetworkId"u8);
                writer.WriteStringValue(RecoveryVmNetworkId);
            }
            if (Optional.IsCollectionDefined(IPConfigs))
            {
                writer.WritePropertyName("ipConfigs"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigs)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SelectionType))
            {
                writer.WritePropertyName("selectionType"u8);
                writer.WriteStringValue(SelectionType);
            }
            if (Optional.IsDefined(RecoveryNetworkSecurityGroupId))
            {
                writer.WritePropertyName("recoveryNetworkSecurityGroupId"u8);
                writer.WriteStringValue(RecoveryNetworkSecurityGroupId);
            }
            if (Optional.IsDefined(IsAcceleratedNetworkingOnRecoveryEnabled))
            {
                writer.WritePropertyName("enableAcceleratedNetworkingOnRecovery"u8);
                writer.WriteBooleanValue(IsAcceleratedNetworkingOnRecoveryEnabled.Value);
            }
            if (Optional.IsDefined(TfoVmNetworkId))
            {
                writer.WritePropertyName("tfoVMNetworkId"u8);
                writer.WriteStringValue(TfoVmNetworkId);
            }
            if (Optional.IsDefined(TfoNetworkSecurityGroupId))
            {
                writer.WritePropertyName("tfoNetworkSecurityGroupId"u8);
                writer.WriteStringValue(TfoNetworkSecurityGroupId);
            }
            if (Optional.IsDefined(IsAcceleratedNetworkingOnTfoEnabled))
            {
                writer.WritePropertyName("enableAcceleratedNetworkingOnTfo"u8);
                writer.WriteBooleanValue(IsAcceleratedNetworkingOnTfoEnabled.Value);
            }
            if (Optional.IsDefined(RecoveryNicName))
            {
                writer.WritePropertyName("recoveryNicName"u8);
                writer.WriteStringValue(RecoveryNicName);
            }
            if (Optional.IsDefined(RecoveryNicResourceGroupName))
            {
                writer.WritePropertyName("recoveryNicResourceGroupName"u8);
                writer.WriteStringValue(RecoveryNicResourceGroupName);
            }
            if (Optional.IsDefined(IsReuseExistingNicAllowed))
            {
                writer.WritePropertyName("reuseExistingNic"u8);
                writer.WriteBooleanValue(IsReuseExistingNicAllowed.Value);
            }
            if (Optional.IsDefined(TfoRecoveryNicName))
            {
                writer.WritePropertyName("tfoRecoveryNicName"u8);
                writer.WriteStringValue(TfoRecoveryNicName);
            }
            if (Optional.IsDefined(TfoRecoveryNicResourceGroupName))
            {
                writer.WritePropertyName("tfoRecoveryNicResourceGroupName"u8);
                writer.WriteStringValue(TfoRecoveryNicResourceGroupName);
            }
            if (Optional.IsDefined(IsTfoReuseExistingNicAllowed))
            {
                writer.WritePropertyName("tfoReuseExistingNic"u8);
                writer.WriteBooleanValue(IsTfoReuseExistingNicAllowed.Value);
            }
            if (Optional.IsDefined(TargetNicName))
            {
                writer.WritePropertyName("targetNicName"u8);
                writer.WriteStringValue(TargetNicName);
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

        VmNicDetails IJsonModel<VmNicDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmNicDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmNicDetails(document.RootElement, options);
        }

        internal static VmNicDetails DeserializeVmNicDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nicId = default;
            string replicaNicId = default;
            ResourceIdentifier sourceNicArmId = default;
            string vmNetworkName = default;
            ResourceIdentifier recoveryVmNetworkId = default;
            IReadOnlyList<HyperVIPConfigDetails> ipConfigs = default;
            string selectionType = default;
            string recoveryNetworkSecurityGroupId = default;
            bool? enableAcceleratedNetworkingOnRecovery = default;
            ResourceIdentifier tfoVmNetworkId = default;
            string tfoNetworkSecurityGroupId = default;
            bool? enableAcceleratedNetworkingOnTfo = default;
            string recoveryNicName = default;
            string recoveryNicResourceGroupName = default;
            bool? reuseExistingNic = default;
            string tfoRecoveryNicName = default;
            string tfoRecoveryNicResourceGroupName = default;
            bool? tfoReuseExistingNic = default;
            string targetNicName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nicId"u8))
                {
                    nicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaNicId"u8))
                {
                    replicaNicId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceNicArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceNicArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vMNetworkName"u8))
                {
                    vmNetworkName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryVMNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryVmNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipConfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HyperVIPConfigDetails> array = new List<HyperVIPConfigDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HyperVIPConfigDetails.DeserializeHyperVIPConfigDetails(item, options));
                    }
                    ipConfigs = array;
                    continue;
                }
                if (property.NameEquals("selectionType"u8))
                {
                    selectionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNetworkSecurityGroupId"u8))
                {
                    recoveryNetworkSecurityGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworkingOnRecovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAcceleratedNetworkingOnRecovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tfoVMNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoVmNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tfoNetworkSecurityGroupId"u8))
                {
                    tfoNetworkSecurityGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworkingOnTfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAcceleratedNetworkingOnTfo = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoveryNicName"u8))
                {
                    recoveryNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryNicResourceGroupName"u8))
                {
                    recoveryNicResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reuseExistingNic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reuseExistingNic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tfoRecoveryNicName"u8))
                {
                    tfoRecoveryNicName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoRecoveryNicResourceGroupName"u8))
                {
                    tfoRecoveryNicResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tfoReuseExistingNic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tfoReuseExistingNic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("targetNicName"u8))
                {
                    targetNicName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmNicDetails(
                nicId,
                replicaNicId,
                sourceNicArmId,
                vmNetworkName,
                recoveryVmNetworkId,
                ipConfigs ?? new ChangeTrackingList<HyperVIPConfigDetails>(),
                selectionType,
                recoveryNetworkSecurityGroupId,
                enableAcceleratedNetworkingOnRecovery,
                tfoVmNetworkId,
                tfoNetworkSecurityGroupId,
                enableAcceleratedNetworkingOnTfo,
                recoveryNicName,
                recoveryNicResourceGroupName,
                reuseExistingNic,
                tfoRecoveryNicName,
                tfoRecoveryNicResourceGroupName,
                tfoReuseExistingNic,
                targetNicName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmNicDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmNicDetails)} does not support writing '{options.Format}' format.");
            }
        }

        VmNicDetails IPersistableModel<VmNicDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmNicDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVmNicDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmNicDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmNicDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
