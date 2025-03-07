// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AddressValidationResult : IUtf8JsonSerializable, IJsonModel<AddressValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddressValidationResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AddressValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationResult)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ValidationStatus))
            {
                writer.WritePropertyName("validationStatus"u8);
                writer.WriteStringValue(ValidationStatus.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AlternateAddresses))
            {
                writer.WritePropertyName("alternateAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateAddresses)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        AddressValidationResult IJsonModel<AddressValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AddressValidationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddressValidationResult(document.RootElement, options);
        }

        internal static AddressValidationResult DeserializeAddressValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AddressValidationStatus? validationStatus = default;
            IReadOnlyList<DataBoxShippingAddress> alternateAddresses = default;
            DataBoxValidationInputDiscriminator validationType = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationStatus = property.Value.GetString().ToAddressValidationStatus();
                    continue;
                }
                if (property.NameEquals("alternateAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxShippingAddress> array = new List<DataBoxShippingAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxShippingAddress.DeserializeDataBoxShippingAddress(item, options));
                    }
                    alternateAddresses = array;
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AddressValidationResult(validationType, error, serializedAdditionalRawData, validationStatus, alternateAddresses ?? new ChangeTrackingList<DataBoxShippingAddress>());
        }

        BinaryData IPersistableModel<AddressValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AddressValidationResult)} does not support writing '{options.Format}' format.");
            }
        }

        AddressValidationResult IPersistableModel<AddressValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AddressValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAddressValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AddressValidationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AddressValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
