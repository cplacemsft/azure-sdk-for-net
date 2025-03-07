// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class AppComplianceReportScopingConfigurationProperties : IUtf8JsonSerializable, IJsonModel<AppComplianceReportScopingConfigurationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppComplianceReportScopingConfigurationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppComplianceReportScopingConfigurationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportScopingConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportScopingConfigurationProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Answers))
            {
                writer.WritePropertyName("answers"u8);
                writer.WriteStartArray();
                foreach (var item in Answers)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AppComplianceReportScopingConfigurationProperties IJsonModel<AppComplianceReportScopingConfigurationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportScopingConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportScopingConfigurationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppComplianceReportScopingConfigurationProperties(document.RootElement, options);
        }

        internal static AppComplianceReportScopingConfigurationProperties DeserializeAppComplianceReportScopingConfigurationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ScopingAnswer> answers = default;
            AppComplianceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("answers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScopingAnswer> array = new List<ScopingAnswer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScopingAnswer.DeserializeScopingAnswer(item, options));
                    }
                    answers = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppComplianceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppComplianceReportScopingConfigurationProperties(answers ?? new ChangeTrackingList<ScopingAnswer>(), provisioningState, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppComplianceReportScopingConfigurationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportScopingConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportScopingConfigurationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        AppComplianceReportScopingConfigurationProperties IPersistableModel<AppComplianceReportScopingConfigurationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportScopingConfigurationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppComplianceReportScopingConfigurationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportScopingConfigurationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppComplianceReportScopingConfigurationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
