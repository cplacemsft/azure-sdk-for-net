// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubHubProperties : IUtf8JsonSerializable, IJsonModel<WebPubSubHubProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebPubSubHubProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebPubSubHubProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubHubProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(EventHandlers))
            {
                writer.WritePropertyName("eventHandlers"u8);
                writer.WriteStartArray();
                foreach (var item in EventHandlers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AnonymousConnectPolicy))
            {
                writer.WritePropertyName("anonymousConnectPolicy"u8);
                writer.WriteStringValue(AnonymousConnectPolicy);
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

        WebPubSubHubProperties IJsonModel<WebPubSubHubProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubHubProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubHubProperties(document.RootElement, options);
        }

        internal static WebPubSubHubProperties DeserializeWebPubSubHubProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<WebPubSubEventHandler> eventHandlers = default;
            string anonymousConnectPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHandlers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubEventHandler> array = new List<WebPubSubEventHandler>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebPubSubEventHandler.DeserializeWebPubSubEventHandler(item, options));
                    }
                    eventHandlers = array;
                    continue;
                }
                if (property.NameEquals("anonymousConnectPolicy"u8))
                {
                    anonymousConnectPolicy = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebPubSubHubProperties(eventHandlers ?? new ChangeTrackingList<WebPubSubEventHandler>(), anonymousConnectPolicy, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventHandlers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  eventHandlers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EventHandlers))
                {
                    if (EventHandlers.Any())
                    {
                        builder.Append("  eventHandlers: ");
                        builder.AppendLine("[");
                        foreach (var item in EventHandlers)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  eventHandlers: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnonymousConnectPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  anonymousConnectPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AnonymousConnectPolicy))
                {
                    builder.Append("  anonymousConnectPolicy: ");
                    if (AnonymousConnectPolicy.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AnonymousConnectPolicy}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AnonymousConnectPolicy}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebPubSubHubProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubHubProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support writing '{options.Format}' format.");
            }
        }

        WebPubSubHubProperties IPersistableModel<WebPubSubHubProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubHubProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeWebPubSubHubProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebPubSubHubProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebPubSubHubProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
