// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabVmData : IUtf8JsonSerializable, IJsonModel<DevTestLabVmData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabVmData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabVmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(OwnerObjectId))
            {
                writer.WritePropertyName("ownerObjectId"u8);
                writer.WriteStringValue(OwnerObjectId);
            }
            if (Optional.IsDefined(OwnerUserPrincipalName))
            {
                writer.WritePropertyName("ownerUserPrincipalName"u8);
                writer.WriteStringValue(OwnerUserPrincipalName);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByUserId))
            {
                writer.WritePropertyName("createdByUserId"u8);
                writer.WriteStringValue(CreatedByUserId);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByUser))
            {
                writer.WritePropertyName("createdByUser"u8);
                writer.WriteStringValue(CreatedByUser);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(ComputeId))
            {
                writer.WritePropertyName("computeId"u8);
                writer.WriteStringValue(ComputeId);
            }
            if (Optional.IsDefined(CustomImageId))
            {
                writer.WritePropertyName("customImageId"u8);
                writer.WriteStringValue(CustomImageId);
            }
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SshKey))
            {
                writer.WritePropertyName("sshKey"u8);
                writer.WriteStringValue(SshKey);
            }
            if (Optional.IsDefined(IsAuthenticationWithSshKey))
            {
                writer.WritePropertyName("isAuthenticationWithSshKey"u8);
                writer.WriteBooleanValue(IsAuthenticationWithSshKey.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Fqdn))
            {
                writer.WritePropertyName("fqdn"u8);
                writer.WriteStringValue(Fqdn);
            }
            if (Optional.IsDefined(LabSubnetName))
            {
                writer.WritePropertyName("labSubnetName"u8);
                writer.WriteStringValue(LabSubnetName);
            }
            if (Optional.IsDefined(LabVirtualNetworkId))
            {
                writer.WritePropertyName("labVirtualNetworkId"u8);
                writer.WriteStringValue(LabVirtualNetworkId);
            }
            if (Optional.IsDefined(DisallowPublicIPAddress))
            {
                writer.WritePropertyName("disallowPublicIpAddress"u8);
                writer.WriteBooleanValue(DisallowPublicIPAddress.Value);
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ArtifactDeploymentStatus))
            {
                writer.WritePropertyName("artifactDeploymentStatus"u8);
                writer.WriteObjectValue(ArtifactDeploymentStatus, options);
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                writer.WriteObjectValue(GalleryImageReference, options);
            }
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (options.Format != "W" && Optional.IsDefined(ComputeVm))
            {
                writer.WritePropertyName("computeVm"u8);
                writer.WriteObjectValue(ComputeVm, options);
            }
            if (Optional.IsDefined(NetworkInterface))
            {
                writer.WritePropertyName("networkInterface"u8);
                writer.WriteObjectValue(NetworkInterface, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ApplicableSchedule))
            {
                writer.WritePropertyName("applicableSchedule"u8);
                writer.WriteObjectValue(ApplicableSchedule, options);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AllowClaim))
            {
                writer.WritePropertyName("allowClaim"u8);
                writer.WriteBooleanValue(AllowClaim.Value);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType);
            }
            if (options.Format != "W" && Optional.IsDefined(VmCreationSource))
            {
                writer.WritePropertyName("virtualMachineCreationSource"u8);
                writer.WriteStringValue(VmCreationSource.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(DataDiskParameters))
            {
                writer.WritePropertyName("dataDiskParameters"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleParameters))
            {
                writer.WritePropertyName("scheduleParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(LastKnownPowerState))
            {
                writer.WritePropertyName("lastKnownPowerState"u8);
                writer.WriteStringValue(LastKnownPowerState);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(UniqueIdentifier))
            {
                writer.WritePropertyName("uniqueIdentifier"u8);
                writer.WriteStringValue(UniqueIdentifier.Value);
            }
            writer.WriteEndObject();
        }

        DevTestLabVmData IJsonModel<DevTestLabVmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabVmData(document.RootElement, options);
        }

        internal static DevTestLabVmData DeserializeDevTestLabVmData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string notes = default;
            string ownerObjectId = default;
            string ownerUserPrincipalName = default;
            string createdByUserId = default;
            string createdByUser = default;
            DateTimeOffset? createdDate = default;
            ResourceIdentifier computeId = default;
            string customImageId = default;
            string osType = default;
            string size = default;
            string userName = default;
            string password = default;
            string sshKey = default;
            bool? isAuthenticationWithSshKey = default;
            string fqdn = default;
            string labSubnetName = default;
            ResourceIdentifier labVirtualNetworkId = default;
            bool? disallowPublicIPAddress = default;
            IList<DevTestLabArtifactInstallInfo> artifacts = default;
            DevTestLabArtifactDeploymentStatus artifactDeploymentStatus = default;
            DevTestLabGalleryImageReference galleryImageReference = default;
            string planId = default;
            ComputeVmProperties computeVm = default;
            DevTestLabNetworkInterface networkInterface = default;
            DevTestLabApplicableSchedule applicableSchedule = default;
            DateTimeOffset? expirationDate = default;
            bool? allowClaim = default;
            string storageType = default;
            DevTestLabVmCreationSource? vmCreationSource = default;
            ResourceIdentifier environmentId = default;
            IList<DevTestLabDataDiskProperties> dataDiskParameters = default;
            IList<DevTestLabScheduleCreationParameter> scheduleParameters = default;
            string lastKnownPowerState = default;
            string provisioningState = default;
            Guid? uniqueIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerObjectId"u8))
                        {
                            ownerObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerUserPrincipalName"u8))
                        {
                            ownerUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByUserId"u8))
                        {
                            createdByUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByUser"u8))
                        {
                            createdByUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("computeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("customImageId"u8))
                        {
                            customImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshKey"u8))
                        {
                            sshKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAuthenticationWithSshKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAuthenticationWithSshKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"u8))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labSubnetName"u8))
                        {
                            labSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labVirtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labVirtualNetworkId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disallowPublicIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowPublicIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabArtifactInstallInfo> array = new List<DevTestLabArtifactInstallInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabArtifactInstallInfo.DeserializeDevTestLabArtifactInstallInfo(item, options));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("artifactDeploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            artifactDeploymentStatus = DevTestLabArtifactDeploymentStatus.DeserializeDevTestLabArtifactDeploymentStatus(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("galleryImageReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            galleryImageReference = DevTestLabGalleryImageReference.DeserializeDevTestLabGalleryImageReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("planId"u8))
                        {
                            planId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computeVm"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeVm = ComputeVmProperties.DeserializeComputeVmProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterface = DevTestLabNetworkInterface.DeserializeDevTestLabNetworkInterface(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("applicableSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicableSchedule = DevTestLabApplicableSchedule.DeserializeDevTestLabApplicableSchedule(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allowClaim"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowClaim = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageType"u8))
                        {
                            storageType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineCreationSource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vmCreationSource = new DevTestLabVmCreationSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("environmentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            environmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataDiskParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskProperties> array = new List<DevTestLabDataDiskProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskProperties.DeserializeDevTestLabDataDiskProperties(item, options));
                            }
                            dataDiskParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduleParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabScheduleCreationParameter> array = new List<DevTestLabScheduleCreationParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabScheduleCreationParameter.DeserializeDevTestLabScheduleCreationParameter(item, options));
                            }
                            scheduleParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("lastKnownPowerState"u8))
                        {
                            lastKnownPowerState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabVmData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                notes,
                ownerObjectId,
                ownerUserPrincipalName,
                createdByUserId,
                createdByUser,
                createdDate,
                computeId,
                customImageId,
                osType,
                size,
                userName,
                password,
                sshKey,
                isAuthenticationWithSshKey,
                fqdn,
                labSubnetName,
                labVirtualNetworkId,
                disallowPublicIPAddress,
                artifacts ?? new ChangeTrackingList<DevTestLabArtifactInstallInfo>(),
                artifactDeploymentStatus,
                galleryImageReference,
                planId,
                computeVm,
                networkInterface,
                applicableSchedule,
                expirationDate,
                allowClaim,
                storageType,
                vmCreationSource,
                environmentId,
                dataDiskParameters ?? new ChangeTrackingList<DevTestLabDataDiskProperties>(),
                scheduleParameters ?? new ChangeTrackingList<DevTestLabScheduleCreationParameter>(),
                lastKnownPowerState,
                provisioningState,
                uniqueIdentifier,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabVmData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabVmData IPersistableModel<DevTestLabVmData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabVmData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabVmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
