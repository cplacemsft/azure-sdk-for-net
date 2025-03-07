// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Weather.Models
{
    internal partial class GeoJsonFeatureCollection
    {
        internal static GeoJsonFeatureCollection DeserializeGeoJsonFeatureCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<GeoJsonFeature> features = default;
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("features"u8))
                {
                    List<GeoJsonFeature> array = new List<GeoJsonFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonFeature.DeserializeGeoJsonFeature(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonFeatureCollection(type, features);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new GeoJsonFeatureCollection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeGeoJsonFeatureCollection(document.RootElement);
        }
    }
}
