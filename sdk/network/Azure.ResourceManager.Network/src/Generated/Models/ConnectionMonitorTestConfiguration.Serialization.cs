// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorTestConfiguration : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorTestConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorTestConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectionMonitorTestConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorTestConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(TestFrequencySec))
            {
                writer.WritePropertyName("testFrequencySec"u8);
                writer.WriteNumberValue(TestFrequencySec.Value);
            }
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            if (Optional.IsDefined(PreferredIPVersion))
            {
                writer.WritePropertyName("preferredIPVersion"u8);
                writer.WriteStringValue(PreferredIPVersion.Value.ToString());
            }
            if (Optional.IsDefined(HttpConfiguration))
            {
                writer.WritePropertyName("httpConfiguration"u8);
                writer.WriteObjectValue(HttpConfiguration, options);
            }
            if (Optional.IsDefined(TcpConfiguration))
            {
                writer.WritePropertyName("tcpConfiguration"u8);
                writer.WriteObjectValue(TcpConfiguration, options);
            }
            if (Optional.IsDefined(IcmpConfiguration))
            {
                writer.WritePropertyName("icmpConfiguration"u8);
                writer.WriteObjectValue(IcmpConfiguration, options);
            }
            if (Optional.IsDefined(SuccessThreshold))
            {
                writer.WritePropertyName("successThreshold"u8);
                writer.WriteObjectValue(SuccessThreshold, options);
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

        ConnectionMonitorTestConfiguration IJsonModel<ConnectionMonitorTestConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectionMonitorTestConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorTestConfiguration(document.RootElement, options);
        }

        internal static ConnectionMonitorTestConfiguration DeserializeConnectionMonitorTestConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? testFrequencySec = default;
            ConnectionMonitorTestConfigurationProtocol protocol = default;
            TestEvalPreferredIPVersion? preferredIPVersion = default;
            ConnectionMonitorHttpConfiguration httpConfiguration = default;
            ConnectionMonitorTcpConfiguration tcpConfiguration = default;
            ConnectionMonitorIcmpConfiguration icmpConfiguration = default;
            ConnectionMonitorSuccessThreshold successThreshold = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testFrequencySec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testFrequencySec = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new ConnectionMonitorTestConfigurationProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preferredIPVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredIPVersion = new TestEvalPreferredIPVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpConfiguration = ConnectionMonitorHttpConfiguration.DeserializeConnectionMonitorHttpConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tcpConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcpConfiguration = ConnectionMonitorTcpConfiguration.DeserializeConnectionMonitorTcpConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("icmpConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    icmpConfiguration = ConnectionMonitorIcmpConfiguration.DeserializeConnectionMonitorIcmpConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("successThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    successThreshold = ConnectionMonitorSuccessThreshold.DeserializeConnectionMonitorSuccessThreshold(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectionMonitorTestConfiguration(
                name,
                testFrequencySec,
                protocol,
                preferredIPVersion,
                httpConfiguration,
                tcpConfiguration,
                icmpConfiguration,
                successThreshold,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionMonitorTestConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorTestConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectionMonitorTestConfiguration IPersistableModel<ConnectionMonitorTestConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorTestConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectionMonitorTestConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectionMonitorTestConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionMonitorTestConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
