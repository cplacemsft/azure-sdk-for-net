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

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    public partial class DataLakeAnalyticsVirtualNetworkRule : IUtf8JsonSerializable, IJsonModel<DataLakeAnalyticsVirtualNetworkRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataLakeAnalyticsVirtualNetworkRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataLakeAnalyticsVirtualNetworkRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsVirtualNetworkRule)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (options.Format != "W" && Optional.IsDefined(VirtualNetworkRuleState))
            {
                writer.WritePropertyName("virtualNetworkRuleState"u8);
                writer.WriteStringValue(VirtualNetworkRuleState.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        DataLakeAnalyticsVirtualNetworkRule IJsonModel<DataLakeAnalyticsVirtualNetworkRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataLakeAnalyticsVirtualNetworkRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsVirtualNetworkRule(document.RootElement, options);
        }

        internal static DataLakeAnalyticsVirtualNetworkRule DeserializeDataLakeAnalyticsVirtualNetworkRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            ResourceIdentifier subnetId = default;
            DataLakeAnalyticsVirtualNetworkRuleState? virtualNetworkRuleState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRuleState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualNetworkRuleState = property0.Value.GetString().ToDataLakeAnalyticsVirtualNetworkRuleState();
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
            return new DataLakeAnalyticsVirtualNetworkRule(
                id,
                name,
                type,
                systemData,
                subnetId,
                virtualNetworkRuleState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsVirtualNetworkRule)} does not support writing '{options.Format}' format.");
            }
        }

        DataLakeAnalyticsVirtualNetworkRule IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataLakeAnalyticsVirtualNetworkRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataLakeAnalyticsVirtualNetworkRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataLakeAnalyticsVirtualNetworkRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
