// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterUpdateGatewaySettingsContent : IUtf8JsonSerializable, IJsonModel<HDInsightClusterUpdateGatewaySettingsContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightClusterUpdateGatewaySettingsContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightClusterUpdateGatewaySettingsContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterUpdateGatewaySettingsContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsCredentialEnabled))
            {
                writer.WritePropertyName("restAuthCredential.isEnabled"u8);
                writer.WriteBooleanValue(IsCredentialEnabled.Value);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("restAuthCredential.username"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("restAuthCredential.password"u8);
                writer.WriteStringValue(Password);
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

        HDInsightClusterUpdateGatewaySettingsContent IJsonModel<HDInsightClusterUpdateGatewaySettingsContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightClusterUpdateGatewaySettingsContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterUpdateGatewaySettingsContent(document.RootElement, options);
        }

        internal static HDInsightClusterUpdateGatewaySettingsContent DeserializeHDInsightClusterUpdateGatewaySettingsContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? restAuthCredentialIsEnabled = default;
            string restAuthCredentialUsername = default;
            string restAuthCredentialPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restAuthCredential.isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restAuthCredentialIsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restAuthCredential.username"u8))
                {
                    restAuthCredentialUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restAuthCredential.password"u8))
                {
                    restAuthCredentialPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightClusterUpdateGatewaySettingsContent(restAuthCredentialIsEnabled, restAuthCredentialUsername, restAuthCredentialPassword, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterUpdateGatewaySettingsContent)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightClusterUpdateGatewaySettingsContent IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightClusterUpdateGatewaySettingsContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightClusterUpdateGatewaySettingsContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightClusterUpdateGatewaySettingsContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
