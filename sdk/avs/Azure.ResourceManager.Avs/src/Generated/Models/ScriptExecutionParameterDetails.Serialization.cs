// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    [PersistableModelProxy(typeof(UnknownScriptExecutionParameter))]
    public partial class ScriptExecutionParameterDetails : IUtf8JsonSerializable, IJsonModel<ScriptExecutionParameterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScriptExecutionParameterDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ScriptExecutionParameterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptExecutionParameterDetails)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ParameterType.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ScriptExecutionParameterDetails IJsonModel<ScriptExecutionParameterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScriptExecutionParameterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScriptExecutionParameterDetails(document.RootElement, options);
        }

        internal static ScriptExecutionParameterDetails DeserializeScriptExecutionParameterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Credential": return PSCredentialExecutionParameterDetails.DeserializePSCredentialExecutionParameterDetails(element, options);
                    case "SecureValue": return ScriptSecureStringExecutionParameterDetails.DeserializeScriptSecureStringExecutionParameterDetails(element, options);
                    case "Value": return ScriptStringExecutionParameterDetails.DeserializeScriptStringExecutionParameterDetails(element, options);
                }
            }
            return UnknownScriptExecutionParameter.DeserializeUnknownScriptExecutionParameter(element, options);
        }

        BinaryData IPersistableModel<ScriptExecutionParameterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScriptExecutionParameterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ScriptExecutionParameterDetails IPersistableModel<ScriptExecutionParameterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScriptExecutionParameterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeScriptExecutionParameterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScriptExecutionParameterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScriptExecutionParameterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
