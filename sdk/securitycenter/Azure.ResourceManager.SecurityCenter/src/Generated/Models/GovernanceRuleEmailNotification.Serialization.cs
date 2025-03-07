// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GovernanceRuleEmailNotification : IUtf8JsonSerializable, IJsonModel<GovernanceRuleEmailNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GovernanceRuleEmailNotification>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GovernanceRuleEmailNotification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleEmailNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceRuleEmailNotification)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsManagerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableManagerEmailNotification"u8);
                writer.WriteBooleanValue(IsManagerEmailNotificationDisabled.Value);
            }
            if (Optional.IsDefined(IsOwnerEmailNotificationDisabled))
            {
                writer.WritePropertyName("disableOwnerEmailNotification"u8);
                writer.WriteBooleanValue(IsOwnerEmailNotificationDisabled.Value);
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

        GovernanceRuleEmailNotification IJsonModel<GovernanceRuleEmailNotification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleEmailNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceRuleEmailNotification)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceRuleEmailNotification(document.RootElement, options);
        }

        internal static GovernanceRuleEmailNotification DeserializeGovernanceRuleEmailNotification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? disableManagerEmailNotification = default;
            bool? disableOwnerEmailNotification = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disableManagerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableManagerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableOwnerEmailNotification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableOwnerEmailNotification = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GovernanceRuleEmailNotification(disableManagerEmailNotification, disableOwnerEmailNotification, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GovernanceRuleEmailNotification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleEmailNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GovernanceRuleEmailNotification)} does not support writing '{options.Format}' format.");
            }
        }

        GovernanceRuleEmailNotification IPersistableModel<GovernanceRuleEmailNotification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceRuleEmailNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeGovernanceRuleEmailNotification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GovernanceRuleEmailNotification)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GovernanceRuleEmailNotification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
