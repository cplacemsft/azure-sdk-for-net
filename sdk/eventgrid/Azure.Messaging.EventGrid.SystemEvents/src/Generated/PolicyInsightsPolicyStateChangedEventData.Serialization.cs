// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class PolicyInsightsPolicyStateChangedEventData : IUtf8JsonSerializable, IJsonModel<PolicyInsightsPolicyStateChangedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyInsightsPolicyStateChangedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PolicyInsightsPolicyStateChangedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            writer.WritePropertyName("policyAssignmentId"u8);
            writer.WriteStringValue(PolicyAssignmentId);
            writer.WritePropertyName("policyDefinitionId"u8);
            writer.WriteStringValue(PolicyDefinitionId);
            writer.WritePropertyName("policyDefinitionReferenceId"u8);
            writer.WriteStringValue(PolicyDefinitionReferenceId);
            writer.WritePropertyName("complianceState"u8);
            writer.WriteStringValue(ComplianceState);
            writer.WritePropertyName("subscriptionId"u8);
            writer.WriteStringValue(SubscriptionId);
            writer.WritePropertyName("complianceReasonCode"u8);
            writer.WriteStringValue(ComplianceReasonCode);
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

        PolicyInsightsPolicyStateChangedEventData IJsonModel<PolicyInsightsPolicyStateChangedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement, options);
        }

        internal static PolicyInsightsPolicyStateChangedEventData DeserializePolicyInsightsPolicyStateChangedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            string policyAssignmentId = default;
            string policyDefinitionId = default;
            string policyDefinitionReferenceId = default;
            string complianceState = default;
            string subscriptionId = default;
            string complianceReasonCode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    policyAssignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    policyDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceReasonCode"u8))
                {
                    complianceReasonCode = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PolicyInsightsPolicyStateChangedEventData(
                timestamp,
                policyAssignmentId,
                policyDefinitionId,
                policyDefinitionReferenceId,
                complianceState,
                subscriptionId,
                complianceReasonCode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        PolicyInsightsPolicyStateChangedEventData IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyInsightsPolicyStateChangedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyInsightsPolicyStateChangedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyInsightsPolicyStateChangedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PolicyInsightsPolicyStateChangedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePolicyInsightsPolicyStateChangedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
