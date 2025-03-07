// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DatasetListResponseConverter))]
    internal partial class DatasetListResponse
    {
        internal static DatasetListResponse DeserializeDatasetListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DatasetResource> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DatasetResource> array = new List<DatasetResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetResource.DeserializeDatasetResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DatasetListResponse(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DatasetListResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDatasetListResponse(document.RootElement);
        }

        internal partial class DatasetListResponseConverter : JsonConverter<DatasetListResponse>
        {
            public override void Write(Utf8JsonWriter writer, DatasetListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override DatasetListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetListResponse(document.RootElement);
            }
        }
    }
}
