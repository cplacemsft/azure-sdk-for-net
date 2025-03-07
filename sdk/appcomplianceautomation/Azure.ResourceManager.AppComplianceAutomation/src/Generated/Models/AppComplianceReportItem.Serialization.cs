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
    public partial class AppComplianceReportItem : IUtf8JsonSerializable, IJsonModel<AppComplianceReportItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppComplianceReportItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AppComplianceReportItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportItem)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CategoryName))
            {
                writer.WritePropertyName("categoryName"u8);
                writer.WriteStringValue(CategoryName);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlFamilyName))
            {
                writer.WritePropertyName("controlFamilyName"u8);
                writer.WriteStringValue(ControlFamilyName);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlId))
            {
                writer.WritePropertyName("controlId"u8);
                writer.WriteStringValue(ControlId);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlName))
            {
                writer.WritePropertyName("controlName"u8);
                writer.WriteStringValue(ControlName);
            }
            if (options.Format != "W" && Optional.IsDefined(ControlStatus))
            {
                writer.WritePropertyName("controlStatus"u8);
                writer.WriteStringValue(ControlStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResponsibilityTitle))
            {
                writer.WritePropertyName("responsibilityTitle"u8);
                writer.WriteStringValue(ResponsibilityTitle);
            }
            if (options.Format != "W" && Optional.IsDefined(ResponsibilityDescription))
            {
                writer.WritePropertyName("responsibilityDescription"u8);
                writer.WriteStringValue(ResponsibilityDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceOrigin))
            {
                writer.WritePropertyName("resourceOrigin"u8);
                writer.WriteStringValue(ResourceOrigin.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceStatus))
            {
                writer.WritePropertyName("resourceStatus"u8);
                writer.WriteStringValue(ResourceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceStatusChangedOn))
            {
                writer.WritePropertyName("resourceStatusChangeDate"u8);
                writer.WriteStringValue(ResourceStatusChangedOn.Value, "O");
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

        AppComplianceReportItem IJsonModel<AppComplianceReportItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppComplianceReportItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppComplianceReportItem(document.RootElement, options);
        }

        internal static AppComplianceReportItem DeserializeAppComplianceReportItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string categoryName = default;
            string controlFamilyName = default;
            string controlId = default;
            string controlName = default;
            AppComplianceControlStatus? controlStatus = default;
            string responsibilityTitle = default;
            string responsibilityDescription = default;
            ResourceIdentifier resourceId = default;
            ResourceType? resourceType = default;
            ReportResourceOrigin? resourceOrigin = default;
            ReportResourceStatus? resourceStatus = default;
            DateTimeOffset? resourceStatusChangeDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categoryName"u8))
                {
                    categoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlFamilyName"u8))
                {
                    controlFamilyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlId"u8))
                {
                    controlId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlName"u8))
                {
                    controlName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlStatus = new AppComplianceControlStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("responsibilityTitle"u8))
                {
                    responsibilityTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responsibilityDescription"u8))
                {
                    responsibilityDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceOrigin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceOrigin = new ReportResourceOrigin(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStatus = new ReportResourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceStatusChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStatusChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AppComplianceReportItem(
                categoryName,
                controlFamilyName,
                controlId,
                controlName,
                controlStatus,
                responsibilityTitle,
                responsibilityDescription,
                resourceId,
                resourceType,
                resourceOrigin,
                resourceStatus,
                resourceStatusChangeDate,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppComplianceReportItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportItem)} does not support writing '{options.Format}' format.");
            }
        }

        AppComplianceReportItem IPersistableModel<AppComplianceReportItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppComplianceReportItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAppComplianceReportItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppComplianceReportItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppComplianceReportItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
