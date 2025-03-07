// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Models
{
    public partial class QueryResultDocumentSubscores
    {
        internal static QueryResultDocumentSubscores DeserializeQueryResultDocumentSubscores(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TextResult text = default;
            IReadOnlyList<IDictionary<string, SingleVectorFieldResult>> vectors = default;
            double? documentBoost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    text = TextResult.DeserializeTextResult(property.Value);
                    continue;
                }
                if (property.NameEquals("vectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IDictionary<string, SingleVectorFieldResult>> array = new List<IDictionary<string, SingleVectorFieldResult>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, SingleVectorFieldResult> dictionary = new Dictionary<string, SingleVectorFieldResult>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                dictionary.Add(property0.Name, SingleVectorFieldResult.DeserializeSingleVectorFieldResult(property0.Value));
                            }
                            array.Add(dictionary);
                        }
                    }
                    vectors = array;
                    continue;
                }
                if (property.NameEquals("documentBoost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    documentBoost = property.Value.GetDouble();
                    continue;
                }
            }
            return new QueryResultDocumentSubscores(text, vectors ?? new ChangeTrackingList<IDictionary<string, SingleVectorFieldResult>>(), documentBoost);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static QueryResultDocumentSubscores FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeQueryResultDocumentSubscores(document.RootElement);
        }
    }
}
