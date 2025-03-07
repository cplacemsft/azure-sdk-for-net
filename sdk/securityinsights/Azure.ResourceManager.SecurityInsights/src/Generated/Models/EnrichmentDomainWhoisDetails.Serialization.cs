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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class EnrichmentDomainWhoisDetails : IUtf8JsonSerializable, IJsonModel<EnrichmentDomainWhoisDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EnrichmentDomainWhoisDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EnrichmentDomainWhoisDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnrichmentDomainWhoisDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Registrar))
            {
                writer.WritePropertyName("registrar"u8);
                writer.WriteObjectValue(Registrar, options);
            }
            if (Optional.IsDefined(Contacts))
            {
                writer.WritePropertyName("contacts"u8);
                writer.WriteObjectValue(Contacts, options);
            }
            if (Optional.IsCollectionDefined(NameServers))
            {
                writer.WritePropertyName("nameServers"u8);
                writer.WriteStartArray();
                foreach (var item in NameServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Statuses))
            {
                writer.WritePropertyName("statuses"u8);
                writer.WriteStartArray();
                foreach (var item in Statuses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        EnrichmentDomainWhoisDetails IJsonModel<EnrichmentDomainWhoisDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EnrichmentDomainWhoisDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEnrichmentDomainWhoisDetails(document.RootElement, options);
        }

        internal static EnrichmentDomainWhoisDetails DeserializeEnrichmentDomainWhoisDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EnrichmentDomainWhoisRegistrarDetails registrar = default;
            EnrichmentDomainWhoisContacts contacts = default;
            IReadOnlyList<string> nameServers = default;
            IReadOnlyList<string> statuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("registrar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registrar = EnrichmentDomainWhoisRegistrarDetails.DeserializeEnrichmentDomainWhoisRegistrarDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("contacts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contacts = EnrichmentDomainWhoisContacts.DeserializeEnrichmentDomainWhoisContacts(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nameServers"u8))
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
                    nameServers = array;
                    continue;
                }
                if (property.NameEquals("statuses"u8))
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
                    statuses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EnrichmentDomainWhoisDetails(registrar, contacts, nameServers ?? new ChangeTrackingList<string>(), statuses ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Registrar), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  registrar: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Registrar))
                {
                    builder.Append("  registrar: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Registrar, options, 2, false, "  registrar: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Contacts), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  contacts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Contacts))
                {
                    builder.Append("  contacts: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Contacts, options, 2, false, "  contacts: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NameServers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nameServers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NameServers))
                {
                    if (NameServers.Any())
                    {
                        builder.Append("  nameServers: ");
                        builder.AppendLine("[");
                        foreach (var item in NameServers)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Statuses), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  statuses: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Statuses))
                {
                    if (Statuses.Any())
                    {
                        builder.Append("  statuses: ");
                        builder.AppendLine("[");
                        foreach (var item in Statuses)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EnrichmentDomainWhoisDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EnrichmentDomainWhoisDetails)} does not support writing '{options.Format}' format.");
            }
        }

        EnrichmentDomainWhoisDetails IPersistableModel<EnrichmentDomainWhoisDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EnrichmentDomainWhoisDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEnrichmentDomainWhoisDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EnrichmentDomainWhoisDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EnrichmentDomainWhoisDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
