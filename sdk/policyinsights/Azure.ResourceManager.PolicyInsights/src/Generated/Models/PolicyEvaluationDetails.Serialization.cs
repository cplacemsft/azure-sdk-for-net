// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyEvaluationDetails : IUtf8JsonSerializable, IJsonModel<PolicyEvaluationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyEvaluationDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PolicyEvaluationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(EvaluatedExpressions))
            {
                writer.WritePropertyName("evaluatedExpressions"u8);
                writer.WriteStartArray();
                foreach (var item in EvaluatedExpressions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IfNotExistsDetails))
            {
                writer.WritePropertyName("ifNotExistsDetails"u8);
                writer.WriteObjectValue(IfNotExistsDetails, options);
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

        PolicyEvaluationDetails IJsonModel<PolicyEvaluationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyEvaluationDetails(document.RootElement, options);
        }

        internal static PolicyEvaluationDetails DeserializePolicyEvaluationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ExpressionEvaluationDetails> evaluatedExpressions = default;
            IfNotExistsEvaluationDetails ifNotExistsDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evaluatedExpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressionEvaluationDetails> array = new List<ExpressionEvaluationDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressionEvaluationDetails.DeserializeExpressionEvaluationDetails(item, options));
                    }
                    evaluatedExpressions = array;
                    continue;
                }
                if (property.NameEquals("ifNotExistsDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ifNotExistsDetails = IfNotExistsEvaluationDetails.DeserializeIfNotExistsEvaluationDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PolicyEvaluationDetails(evaluatedExpressions ?? new ChangeTrackingList<ExpressionEvaluationDetails>(), ifNotExistsDetails, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyEvaluationDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyEvaluationDetails IPersistableModel<PolicyEvaluationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyEvaluationDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePolicyEvaluationDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyEvaluationDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyEvaluationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
