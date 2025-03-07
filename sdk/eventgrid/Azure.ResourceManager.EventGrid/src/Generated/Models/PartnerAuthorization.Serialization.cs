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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerAuthorization : IUtf8JsonSerializable, IJsonModel<PartnerAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerAuthorization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PartnerAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DefaultMaximumExpirationTimeInDays))
            {
                writer.WritePropertyName("defaultMaximumExpirationTimeInDays"u8);
                writer.WriteNumberValue(DefaultMaximumExpirationTimeInDays.Value);
            }
            if (Optional.IsCollectionDefined(AuthorizedPartnersList))
            {
                writer.WritePropertyName("authorizedPartnersList"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizedPartnersList)
                {
                    writer.WriteObjectValue(item, options);
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

        PartnerAuthorization IJsonModel<PartnerAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerAuthorization(document.RootElement, options);
        }

        internal static PartnerAuthorization DeserializePartnerAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? defaultMaximumExpirationTimeInDays = default;
            IList<EventGridPartnerContent> authorizedPartnersList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultMaximumExpirationTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMaximumExpirationTimeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authorizedPartnersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridPartnerContent> array = new List<EventGridPartnerContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridPartnerContent.DeserializeEventGridPartnerContent(item, options));
                    }
                    authorizedPartnersList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PartnerAuthorization(defaultMaximumExpirationTimeInDays, authorizedPartnersList ?? new ChangeTrackingList<EventGridPartnerContent>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultMaximumExpirationTimeInDays), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultMaximumExpirationTimeInDays: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultMaximumExpirationTimeInDays))
                {
                    builder.Append("  defaultMaximumExpirationTimeInDays: ");
                    builder.AppendLine($"{DefaultMaximumExpirationTimeInDays.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizedPartnersList), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizedPartnersList: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AuthorizedPartnersList))
                {
                    if (AuthorizedPartnersList.Any())
                    {
                        builder.Append("  authorizedPartnersList: ");
                        builder.AppendLine("[");
                        foreach (var item in AuthorizedPartnersList)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  authorizedPartnersList: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PartnerAuthorization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support writing '{options.Format}' format.");
            }
        }

        PartnerAuthorization IPersistableModel<PartnerAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePartnerAuthorization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
