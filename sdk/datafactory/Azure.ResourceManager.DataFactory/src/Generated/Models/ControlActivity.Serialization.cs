// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ControlActivity : IUtf8JsonSerializable, IJsonModel<ControlActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControlActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ControlActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControlActivity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            foreach (var item in AdditionalProperties)
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

        ControlActivity IJsonModel<ControlActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControlActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControlActivity(document.RootElement, options);
        }

        internal static ControlActivity DeserializeControlActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AppendVariable": return AppendVariableActivity.DeserializeAppendVariableActivity(element, options);
                    case "ExecutePipeline": return ExecutePipelineActivity.DeserializeExecutePipelineActivity(element, options);
                    case "Fail": return FailActivity.DeserializeFailActivity(element, options);
                    case "Filter": return FilterActivity.DeserializeFilterActivity(element, options);
                    case "ForEach": return ForEachActivity.DeserializeForEachActivity(element, options);
                    case "IfCondition": return IfConditionActivity.DeserializeIfConditionActivity(element, options);
                    case "SetVariable": return SetVariableActivity.DeserializeSetVariableActivity(element, options);
                    case "Switch": return SwitchActivity.DeserializeSwitchActivity(element, options);
                    case "Until": return UntilActivity.DeserializeUntilActivity(element, options);
                    case "Validation": return ValidationActivity.DeserializeValidationActivity(element, options);
                    case "Wait": return WaitActivity.DeserializeWaitActivity(element, options);
                    case "WebHook": return WebHookActivity.DeserializeWebHookActivity(element, options);
                }
            }
            string name = default;
            string type = "Container";
            string description = default;
            PipelineActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<PipelineActivityDependency> dependsOn = default;
            IList<PipelineActivityUserProperty> userProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ControlActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<PipelineActivityDependency>(),
                userProperties ?? new ChangeTrackingList<PipelineActivityUserProperty>(),
                additionalProperties);
        }

        BinaryData IPersistableModel<ControlActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ControlActivity)} does not support writing '{options.Format}' format.");
            }
        }

        ControlActivity IPersistableModel<ControlActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControlActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeControlActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ControlActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ControlActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
