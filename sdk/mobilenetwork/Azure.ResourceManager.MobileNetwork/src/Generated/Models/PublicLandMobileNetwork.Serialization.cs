// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class PublicLandMobileNetwork : IUtf8JsonSerializable, IJsonModel<PublicLandMobileNetwork>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PublicLandMobileNetwork>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PublicLandMobileNetwork>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicLandMobileNetwork)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(HomeNetworkPublicKeys))
            {
                writer.WritePropertyName("homeNetworkPublicKeys"u8);
                writer.WriteObjectValue(HomeNetworkPublicKeys, options);
            }
        }

        PublicLandMobileNetwork IJsonModel<PublicLandMobileNetwork>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetwork>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PublicLandMobileNetwork)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePublicLandMobileNetwork(document.RootElement, options);
        }

        internal static PublicLandMobileNetwork DeserializePublicLandMobileNetwork(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PublicLandMobileNetworkHomeNetworkPublicKeys homeNetworkPublicKeys = default;
            string mcc = default;
            string mnc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("homeNetworkPublicKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    homeNetworkPublicKeys = PublicLandMobileNetworkHomeNetworkPublicKeys.DeserializePublicLandMobileNetworkHomeNetworkPublicKeys(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mcc"u8))
                {
                    mcc = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mnc"u8))
                {
                    mnc = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PublicLandMobileNetwork(mcc, mnc, serializedAdditionalRawData, homeNetworkPublicKeys);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HomeNetworkPublicKeys), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  homeNetworkPublicKeys: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HomeNetworkPublicKeys))
                {
                    builder.Append("  homeNetworkPublicKeys: ");
                    BicepSerializationHelpers.AppendChildObject(builder, HomeNetworkPublicKeys, options, 2, false, "  homeNetworkPublicKeys: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Mcc), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mcc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Mcc))
                {
                    builder.Append("  mcc: ");
                    if (Mcc.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Mcc}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Mcc}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Mnc), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mnc: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Mnc))
                {
                    builder.Append("  mnc: ");
                    if (Mnc.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Mnc}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Mnc}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PublicLandMobileNetwork>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PublicLandMobileNetwork)} does not support writing '{options.Format}' format.");
            }
        }

        PublicLandMobileNetwork IPersistableModel<PublicLandMobileNetwork>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PublicLandMobileNetwork>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePublicLandMobileNetwork(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PublicLandMobileNetwork)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PublicLandMobileNetwork>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
