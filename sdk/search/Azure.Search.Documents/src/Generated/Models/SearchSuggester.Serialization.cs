// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchSuggester : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("searchMode"u8);
            writer.WriteStringValue(SearchMode);
            writer.WritePropertyName("sourceFields"u8);
            writer.WriteStartArray();
            foreach (var item in SourceFields)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SearchSuggester DeserializeSearchSuggester(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string searchMode = default;
            IList<string> sourceFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"u8))
                {
                    searchMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceFields"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceFields = array;
                    continue;
                }
            }
            return new SearchSuggester(name, searchMode, sourceFields);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchSuggester FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSearchSuggester(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
