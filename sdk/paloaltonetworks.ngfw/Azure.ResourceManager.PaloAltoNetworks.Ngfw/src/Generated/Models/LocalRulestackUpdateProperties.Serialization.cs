// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    public partial class LocalRulestackUpdateProperties : IUtf8JsonSerializable, IJsonModel<LocalRulestackUpdateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LocalRulestackUpdateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LocalRulestackUpdateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalRulestackUpdateProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            if (Optional.IsDefined(PanLocation))
            {
                writer.WritePropertyName("panLocation"u8);
                writer.WriteStringValue(PanLocation.Value);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AssociatedSubscriptions))
            {
                writer.WritePropertyName("associatedSubscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in AssociatedSubscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DefaultMode))
            {
                writer.WritePropertyName("defaultMode"u8);
                writer.WriteStringValue(DefaultMode.Value.ToString());
            }
            if (Optional.IsDefined(MinAppIdVersion))
            {
                writer.WritePropertyName("minAppIdVersion"u8);
                writer.WriteStringValue(MinAppIdVersion);
            }
            if (Optional.IsDefined(SecurityServices))
            {
                writer.WritePropertyName("securityServices"u8);
                writer.WriteObjectValue(SecurityServices, options);
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

        LocalRulestackUpdateProperties IJsonModel<LocalRulestackUpdateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LocalRulestackUpdateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLocalRulestackUpdateProperties(document.RootElement, options);
        }

        internal static LocalRulestackUpdateProperties DeserializeLocalRulestackUpdateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? panETag = default;
            AzureLocation? panLocation = default;
            RulestackScopeType? scope = default;
            IList<string> associatedSubscriptions = default;
            string description = default;
            RuleCreationDefaultMode? defaultMode = default;
            string minAppIdVersion = default;
            RulestackSecurityServices securityServices = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("panEtag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panETag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("panLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    panLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = new RulestackScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("associatedSubscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    associatedSubscriptions = array;
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMode = new RuleCreationDefaultMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minAppIdVersion"u8))
                {
                    minAppIdVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityServices = RulestackSecurityServices.DeserializeRulestackSecurityServices(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LocalRulestackUpdateProperties(
                panETag,
                panLocation,
                scope,
                associatedSubscriptions ?? new ChangeTrackingList<string>(),
                description,
                defaultMode,
                minAppIdVersion,
                securityServices,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LocalRulestackUpdateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LocalRulestackUpdateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        LocalRulestackUpdateProperties IPersistableModel<LocalRulestackUpdateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LocalRulestackUpdateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLocalRulestackUpdateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LocalRulestackUpdateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LocalRulestackUpdateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
