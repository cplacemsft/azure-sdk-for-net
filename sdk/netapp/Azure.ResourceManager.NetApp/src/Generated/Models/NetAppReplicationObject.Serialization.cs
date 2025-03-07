// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppReplicationObject : IUtf8JsonSerializable, IJsonModel<NetAppReplicationObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppReplicationObject>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetAppReplicationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppReplicationObject)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ReplicationId))
            {
                writer.WritePropertyName("replicationId"u8);
                writer.WriteStringValue(ReplicationId);
            }
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("endpointType"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationSchedule))
            {
                writer.WritePropertyName("replicationSchedule"u8);
                writer.WriteStringValue(ReplicationSchedule.Value.ToString());
            }
            if (Optional.IsDefined(RemoteVolumeResourceId))
            {
                writer.WritePropertyName("remoteVolumeResourceId"u8);
                writer.WriteStringValue(RemoteVolumeResourceId);
            }
            if (Optional.IsDefined(RemotePath))
            {
                writer.WritePropertyName("remotePath"u8);
                writer.WriteObjectValue(RemotePath, options);
            }
            if (Optional.IsDefined(RemoteVolumeRegion))
            {
                writer.WritePropertyName("remoteVolumeRegion"u8);
                writer.WriteStringValue(RemoteVolumeRegion);
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

        NetAppReplicationObject IJsonModel<NetAppReplicationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppReplicationObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppReplicationObject(document.RootElement, options);
        }

        internal static NetAppReplicationObject DeserializeNetAppReplicationObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string replicationId = default;
            NetAppEndpointType? endpointType = default;
            NetAppReplicationSchedule? replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            RemotePath remotePath = default;
            string remoteVolumeRegion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationId"u8))
                {
                    replicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointType = new NetAppEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationSchedule = new NetAppReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteVolumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remotePath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remotePath = RemotePath.DeserializeRemotePath(property.Value, options);
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"u8))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetAppReplicationObject(
                replicationId,
                endpointType,
                replicationSchedule,
                remoteVolumeResourceId,
                remotePath,
                remoteVolumeRegion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppReplicationObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppReplicationObject)} does not support writing '{options.Format}' format.");
            }
        }

        NetAppReplicationObject IPersistableModel<NetAppReplicationObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppReplicationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNetAppReplicationObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppReplicationObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppReplicationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
