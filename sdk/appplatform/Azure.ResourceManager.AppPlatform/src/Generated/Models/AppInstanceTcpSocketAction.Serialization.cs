// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppInstanceTcpSocketAction : IUtf8JsonSerializable, IJsonModel<AppInstanceTcpSocketAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppInstanceTcpSocketAction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppInstanceTcpSocketAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceTcpSocketAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInstanceTcpSocketAction)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        AppInstanceTcpSocketAction IJsonModel<AppInstanceTcpSocketAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceTcpSocketAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppInstanceTcpSocketAction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppInstanceTcpSocketAction(document.RootElement, options);
        }

        internal static AppInstanceTcpSocketAction DeserializeAppInstanceTcpSocketAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProbeActionType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ProbeActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppInstanceTcpSocketAction(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppInstanceTcpSocketAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceTcpSocketAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppInstanceTcpSocketAction)} does not support writing '{options.Format}' format.");
            }
        }

        AppInstanceTcpSocketAction IPersistableModel<AppInstanceTcpSocketAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppInstanceTcpSocketAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppInstanceTcpSocketAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppInstanceTcpSocketAction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppInstanceTcpSocketAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
