// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    public partial class AcsClusterProperties : IUtf8JsonSerializable, IJsonModel<AcsClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsClusterProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsClusterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsClusterProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(ClusterFqdn))
            {
                writer.WritePropertyName("clusterFqdn"u8);
                writer.WriteStringValue(ClusterFqdn);
            }
            writer.WritePropertyName("orchestratorType"u8);
            writer.WriteStringValue(OrchestratorType.ToString());
            if (Optional.IsDefined(OrchestratorProperties))
            {
                writer.WritePropertyName("orchestratorProperties"u8);
                writer.WriteObjectValue(OrchestratorProperties, options);
            }
            if (Optional.IsCollectionDefined(SystemServices))
            {
                writer.WritePropertyName("systemServices"u8);
                writer.WriteStartArray();
                foreach (var item in SystemServices)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MasterCount))
            {
                writer.WritePropertyName("masterCount"u8);
                writer.WriteNumberValue(MasterCount.Value);
            }
            if (Optional.IsDefined(AgentCount))
            {
                writer.WritePropertyName("agentCount"u8);
                writer.WriteNumberValue(AgentCount.Value);
            }
            if (Optional.IsDefined(AgentVmSize))
            {
                writer.WritePropertyName("agentVmSize"u8);
                writer.WriteStringValue(AgentVmSize.Value.ToString());
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

        AcsClusterProperties IJsonModel<AcsClusterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsClusterProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsClusterProperties(document.RootElement, options);
        }

        internal static AcsClusterProperties DeserializeAcsClusterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clusterFqdn = default;
            OrchestratorType orchestratorType = default;
            KubernetesClusterProperties orchestratorProperties = default;
            IList<SystemService> systemServices = default;
            int? masterCount = default;
            int? agentCount = default;
            AgentVmSizeType? agentVmSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterFqdn"u8))
                {
                    clusterFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("orchestratorType"u8))
                {
                    orchestratorType = new OrchestratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orchestratorProperties = KubernetesClusterProperties.DeserializeKubernetesClusterProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("systemServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SystemService> array = new List<SystemService>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SystemService.DeserializeSystemService(item, options));
                    }
                    systemServices = array;
                    continue;
                }
                if (property.NameEquals("masterCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    masterCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agentVmSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentVmSize = new AgentVmSizeType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsClusterProperties(
                clusterFqdn,
                orchestratorType,
                orchestratorProperties,
                systemServices ?? new ChangeTrackingList<SystemService>(),
                masterCount,
                agentCount,
                agentVmSize,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcsClusterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsClusterProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AcsClusterProperties IPersistableModel<AcsClusterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAcsClusterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsClusterProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsClusterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
