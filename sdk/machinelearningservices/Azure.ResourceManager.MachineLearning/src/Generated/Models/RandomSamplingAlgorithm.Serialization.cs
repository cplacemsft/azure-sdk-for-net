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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class RandomSamplingAlgorithm : IUtf8JsonSerializable, IJsonModel<RandomSamplingAlgorithm>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RandomSamplingAlgorithm>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RandomSamplingAlgorithm>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RandomSamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RandomSamplingAlgorithm)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Seed))
            {
                if (Seed != null)
                {
                    writer.WritePropertyName("seed"u8);
                    writer.WriteNumberValue(Seed.Value);
                }
                else
                {
                    writer.WriteNull("seed");
                }
            }
            if (Optional.IsDefined(Rule))
            {
                writer.WritePropertyName("rule"u8);
                writer.WriteStringValue(Rule.Value.ToString());
            }
        }

        RandomSamplingAlgorithm IJsonModel<RandomSamplingAlgorithm>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RandomSamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RandomSamplingAlgorithm)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRandomSamplingAlgorithm(document.RootElement, options);
        }

        internal static RandomSamplingAlgorithm DeserializeRandomSamplingAlgorithm(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? seed = default;
            RandomSamplingAlgorithmRule? rule = default;
            SamplingAlgorithmType samplingAlgorithmType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("seed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        seed = null;
                        continue;
                    }
                    seed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rule = new RandomSamplingAlgorithmRule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("samplingAlgorithmType"u8))
                {
                    samplingAlgorithmType = new SamplingAlgorithmType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RandomSamplingAlgorithm(samplingAlgorithmType, serializedAdditionalRawData, seed, rule);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Seed), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  seed: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Seed))
                {
                    builder.Append("  seed: ");
                    builder.AppendLine($"{Seed.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rule), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  rule: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Rule))
                {
                    builder.Append("  rule: ");
                    builder.AppendLine($"'{Rule.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SamplingAlgorithmType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  samplingAlgorithmType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  samplingAlgorithmType: ");
                builder.AppendLine($"'{SamplingAlgorithmType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RandomSamplingAlgorithm>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RandomSamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RandomSamplingAlgorithm)} does not support writing '{options.Format}' format.");
            }
        }

        RandomSamplingAlgorithm IPersistableModel<RandomSamplingAlgorithm>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RandomSamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRandomSamplingAlgorithm(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RandomSamplingAlgorithm)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RandomSamplingAlgorithm>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
