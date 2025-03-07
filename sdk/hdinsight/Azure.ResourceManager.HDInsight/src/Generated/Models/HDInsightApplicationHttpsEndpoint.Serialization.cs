// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightApplicationHttpsEndpoint : IUtf8JsonSerializable, IJsonModel<HDInsightApplicationHttpsEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightApplicationHttpsEndpoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightApplicationHttpsEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationHttpsEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AccessModes))
            {
                writer.WritePropertyName("accessModes"u8);
                writer.WriteStartArray();
                foreach (var item in AccessModes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(EndpointLocation))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(EndpointLocation);
            }
            if (Optional.IsDefined(DestinationPort))
            {
                writer.WritePropertyName("destinationPort"u8);
                writer.WriteNumberValue(DestinationPort.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublicPort))
            {
                writer.WritePropertyName("publicPort"u8);
                writer.WriteNumberValue(PublicPort.Value);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(SubDomainSuffix))
            {
                writer.WritePropertyName("subDomainSuffix"u8);
                writer.WriteStringValue(SubDomainSuffix);
            }
            if (Optional.IsDefined(DisableGatewayAuth))
            {
                writer.WritePropertyName("disableGatewayAuth"u8);
                writer.WriteBooleanValue(DisableGatewayAuth.Value);
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

        HDInsightApplicationHttpsEndpoint IJsonModel<HDInsightApplicationHttpsEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationHttpsEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightApplicationHttpsEndpoint(document.RootElement, options);
        }

        internal static HDInsightApplicationHttpsEndpoint DeserializeHDInsightApplicationHttpsEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> accessModes = default;
            string location = default;
            int? destinationPort = default;
            int? publicPort = default;
            IPAddress privateIPAddress = default;
            string subDomainSuffix = default;
            bool? disableGatewayAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessModes"u8))
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
                    accessModes = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("publicPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subDomainSuffix"u8))
                {
                    subDomainSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableGatewayAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableGatewayAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightApplicationHttpsEndpoint(
                accessModes ?? new ChangeTrackingList<string>(),
                location,
                destinationPort,
                publicPort,
                privateIPAddress,
                subDomainSuffix,
                disableGatewayAuth,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightApplicationHttpsEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationHttpsEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightApplicationHttpsEndpoint IPersistableModel<HDInsightApplicationHttpsEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationHttpsEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightApplicationHttpsEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightApplicationHttpsEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightApplicationHttpsEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
