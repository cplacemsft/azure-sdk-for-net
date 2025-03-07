// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkSecurityPerimeterLinkData : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterLinkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterLinkData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterLinkData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(AutoApprovedRemotePerimeterResourceId))
            {
                writer.WritePropertyName("autoApprovedRemotePerimeterResourceId"u8);
                writer.WriteStringValue(AutoApprovedRemotePerimeterResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(RemotePerimeterGuid))
            {
                writer.WritePropertyName("remotePerimeterGuid"u8);
                writer.WriteStringValue(RemotePerimeterGuid.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RemotePerimeterLocation))
            {
                writer.WritePropertyName("remotePerimeterLocation"u8);
                writer.WriteStringValue(RemotePerimeterLocation);
            }
            if (Optional.IsCollectionDefined(LocalInboundProfiles))
            {
                writer.WritePropertyName("localInboundProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in LocalInboundProfiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(LocalOutboundProfiles))
            {
                writer.WritePropertyName("localOutboundProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in LocalOutboundProfiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RemoteInboundProfiles))
            {
                writer.WritePropertyName("remoteInboundProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in RemoteInboundProfiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RemoteOutboundProfiles))
            {
                writer.WritePropertyName("remoteOutboundProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in RemoteOutboundProfiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WriteEndObject();
        }

        NetworkSecurityPerimeterLinkData IJsonModel<NetworkSecurityPerimeterLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterLinkData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterLinkData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterLinkData(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterLinkData DeserializeNetworkSecurityPerimeterLinkData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            NetworkSecurityPerimeterLinkProvisioningState? provisioningState = default;
            string autoApprovedRemotePerimeterResourceId = default;
            Guid? remotePerimeterGuid = default;
            string remotePerimeterLocation = default;
            IList<string> localInboundProfiles = default;
            IReadOnlyList<string> localOutboundProfiles = default;
            IList<string> remoteInboundProfiles = default;
            IReadOnlyList<string> remoteOutboundProfiles = default;
            string description = default;
            NetworkSecurityPerimeterLinkStatus? status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkSecurityPerimeterLinkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoApprovedRemotePerimeterResourceId"u8))
                        {
                            autoApprovedRemotePerimeterResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remotePerimeterGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remotePerimeterGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("remotePerimeterLocation"u8))
                        {
                            remotePerimeterLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("localInboundProfiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            localInboundProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("localOutboundProfiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            localOutboundProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("remoteInboundProfiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            remoteInboundProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("remoteOutboundProfiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            remoteOutboundProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new NetworkSecurityPerimeterLinkStatus(property0.Value.GetString());
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
            return new NetworkSecurityPerimeterLinkData(
                id,
                name,
                type,
                systemData,
                provisioningState,
                autoApprovedRemotePerimeterResourceId,
                remotePerimeterGuid,
                remotePerimeterLocation,
                localInboundProfiles ?? new ChangeTrackingList<string>(),
                localOutboundProfiles ?? new ChangeTrackingList<string>(),
                remoteInboundProfiles ?? new ChangeTrackingList<string>(),
                remoteOutboundProfiles ?? new ChangeTrackingList<string>(),
                description,
                status,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterLinkData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterLinkData)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterLinkData IPersistableModel<NetworkSecurityPerimeterLinkData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterLinkData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetworkSecurityPerimeterLinkData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterLinkData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
