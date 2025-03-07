// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    [PersistableModelProxy(typeof(UnknownRuleDataSource))]
    public partial class RuleDataSource : IUtf8JsonSerializable, IJsonModel<RuleDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleDataSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RuleDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleDataSource)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId"u8);
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
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

        RuleDataSource IJsonModel<RuleDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleDataSource(document.RootElement, options);
        }

        internal static RuleDataSource DeserializeRuleDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource": return RuleManagementEventDataSource.DeserializeRuleManagementEventDataSource(element, options);
                    case "Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource": return RuleMetricDataSource.DeserializeRuleMetricDataSource(element, options);
                }
            }
            return UnknownRuleDataSource.DeserializeUnknownRuleDataSource(element, options);
        }

        BinaryData IPersistableModel<RuleDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RuleDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        RuleDataSource IPersistableModel<RuleDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRuleDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
