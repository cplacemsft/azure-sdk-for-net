// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoUpdateContent : IUtf8JsonSerializable, IJsonModel<SourceCodeRepoUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceCodeRepoUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SourceCodeRepoUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoUpdateContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SourceControlType))
            {
                writer.WritePropertyName("sourceControlType"u8);
                writer.WriteStringValue(SourceControlType.Value.ToString());
            }
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(SourceControlAuthProperties))
            {
                writer.WritePropertyName("sourceControlAuthProperties"u8);
                writer.WriteObjectValue(SourceControlAuthProperties, options);
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

        SourceCodeRepoUpdateContent IJsonModel<SourceCodeRepoUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceCodeRepoUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceCodeRepoUpdateContent(document.RootElement, options);
        }

        internal static SourceCodeRepoUpdateContent DeserializeSourceCodeRepoUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceControlType? sourceControlType = default;
            Uri repositoryUrl = default;
            string branch = default;
            SourceCodeRepoAuthInfoUpdateContent sourceControlAuthProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceControlType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceControlType = new SourceControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branch"u8))
                {
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceControlAuthProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceControlAuthProperties = SourceCodeRepoAuthInfoUpdateContent.DeserializeSourceCodeRepoAuthInfoUpdateContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SourceCodeRepoUpdateContent(sourceControlType, repositoryUrl, branch, sourceControlAuthProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceCodeRepoUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        SourceCodeRepoUpdateContent IPersistableModel<SourceCodeRepoUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceCodeRepoUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSourceCodeRepoUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceCodeRepoUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceCodeRepoUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
