// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class TextAuthoringAssignedProjectDeploymentsMetadata : IUtf8JsonSerializable, IJsonModel<TextAuthoringAssignedProjectDeploymentsMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TextAuthoringAssignedProjectDeploymentsMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TextAuthoringAssignedProjectDeploymentsMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringAssignedProjectDeploymentsMetadata)} does not support writing '{format}' format.");
            }

            if (options.Format != "W")
            {
                writer.WritePropertyName("projectName"u8);
                writer.WriteStringValue(ProjectName);
            }
            writer.WritePropertyName("deploymentsMetadata"u8);
            writer.WriteStartArray();
            foreach (var item in DeploymentsMetadata)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        TextAuthoringAssignedProjectDeploymentsMetadata IJsonModel<TextAuthoringAssignedProjectDeploymentsMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TextAuthoringAssignedProjectDeploymentsMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTextAuthoringAssignedProjectDeploymentsMetadata(document.RootElement, options);
        }

        internal static TextAuthoringAssignedProjectDeploymentsMetadata DeserializeTextAuthoringAssignedProjectDeploymentsMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string projectName = default;
            IReadOnlyList<TextAuthoringAssignedProjectDeploymentMetadata> deploymentsMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentsMetadata"u8))
                {
                    List<TextAuthoringAssignedProjectDeploymentMetadata> array = new List<TextAuthoringAssignedProjectDeploymentMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAuthoringAssignedProjectDeploymentMetadata.DeserializeTextAuthoringAssignedProjectDeploymentMetadata(item, options));
                    }
                    deploymentsMetadata = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TextAuthoringAssignedProjectDeploymentsMetadata(projectName, deploymentsMetadata, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringAssignedProjectDeploymentsMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        TextAuthoringAssignedProjectDeploymentsMetadata IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTextAuthoringAssignedProjectDeploymentsMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TextAuthoringAssignedProjectDeploymentsMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TextAuthoringAssignedProjectDeploymentsMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TextAuthoringAssignedProjectDeploymentsMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeTextAuthoringAssignedProjectDeploymentsMetadata(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
