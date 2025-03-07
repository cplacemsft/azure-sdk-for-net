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
    public partial class AwsOrganizationalDataMaster : IUtf8JsonSerializable, IJsonModel<AwsOrganizationalDataMaster>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AwsOrganizationalDataMaster>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AwsOrganizationalDataMaster>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(StacksetName))
            {
                writer.WritePropertyName("stacksetName"u8);
                writer.WriteStringValue(StacksetName);
            }
            if (Optional.IsCollectionDefined(ExcludedAccountIds))
            {
                writer.WritePropertyName("excludedAccountIds"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedAccountIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
        }

        AwsOrganizationalDataMaster IJsonModel<AwsOrganizationalDataMaster>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAwsOrganizationalDataMaster(document.RootElement, options);
        }

        internal static AwsOrganizationalDataMaster DeserializeAwsOrganizationalDataMaster(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string stacksetName = default;
            IList<string> excludedAccountIds = default;
            OrganizationMembershipType organizationMembershipType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stacksetName"u8))
                {
                    stacksetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedAccountIds"u8))
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
                    excludedAccountIds = array;
                    continue;
                }
                if (property.NameEquals("organizationMembershipType"u8))
                {
                    organizationMembershipType = new OrganizationMembershipType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AwsOrganizationalDataMaster(organizationMembershipType, serializedAdditionalRawData, stacksetName, excludedAccountIds ?? new ChangeTrackingList<string>());
        }

        BinaryData IPersistableModel<AwsOrganizationalDataMaster>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support writing '{options.Format}' format.");
            }
        }

        AwsOrganizationalDataMaster IPersistableModel<AwsOrganizationalDataMaster>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AwsOrganizationalDataMaster>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAwsOrganizationalDataMaster(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AwsOrganizationalDataMaster)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AwsOrganizationalDataMaster>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
