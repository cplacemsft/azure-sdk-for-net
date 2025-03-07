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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseClusterPatch : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseClusterPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedisEnterpriseClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseClusterPatch)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                writer.WriteStringValue(HighAvailability.Value.ToString());
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RedundancyMode))
            {
                writer.WritePropertyName("redundancyMode"u8);
                writer.WriteStringValue(RedundancyMode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion"u8);
                writer.WriteStringValue(RedisVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        RedisEnterpriseClusterPatch IJsonModel<RedisEnterpriseClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseClusterPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseClusterPatch(document.RootElement, options);
        }

        internal static RedisEnterpriseClusterPatch DeserializeRedisEnterpriseClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RedisEnterpriseSku sku = default;
            ManagedServiceIdentity identity = default;
            IDictionary<string, string> tags = default;
            RedisEnterpriseHighAvailability? highAvailability = default;
            RedisEnterpriseTlsVersion? minimumTlsVersion = default;
            ClusterPropertiesEncryption encryption = default;
            string hostName = default;
            RedisEnterpriseProvisioningStatus? provisioningState = default;
            RedisEnterpriseRedundancyMode? redundancyMode = default;
            RedisEnterpriseClusterResourceState? resourceState = default;
            string redisVersion = default;
            IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData> privateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = RedisEnterpriseSku.DeserializeRedisEnterpriseSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("highAvailability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailability = new RedisEnterpriseHighAvailability(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new RedisEnterpriseTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = ClusterPropertiesEncryption.DeserializeClusterPropertiesEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new RedisEnterpriseProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("redundancyMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redundancyMode = new RedisEnterpriseRedundancyMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new RedisEnterpriseClusterResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"u8))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RedisEnterprisePrivateEndpointConnectionData> array = new List<RedisEnterprisePrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisEnterprisePrivateEndpointConnectionData.DeserializeRedisEnterprisePrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
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
            return new RedisEnterpriseClusterPatch(
                sku,
                identity,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                highAvailability,
                minimumTlsVersion,
                encryption,
                hostName,
                provisioningState,
                redundancyMode,
                resourceState,
                redisVersion,
                privateEndpointConnections ?? new ChangeTrackingList<RedisEnterprisePrivateEndpointConnectionData>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisEnterpriseClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseClusterPatch)} does not support writing '{options.Format}' format.");
            }
        }

        RedisEnterpriseClusterPatch IPersistableModel<RedisEnterpriseClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRedisEnterpriseClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseClusterPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
