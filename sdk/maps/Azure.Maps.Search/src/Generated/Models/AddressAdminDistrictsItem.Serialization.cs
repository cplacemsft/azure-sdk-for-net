// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class AddressAdminDistrictsItem
    {
        internal static AddressAdminDistrictsItem DeserializeAddressAdminDistrictsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string shortName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shortName"u8))
                {
                    shortName = property.Value.GetString();
                    continue;
                }
            }
            return new AddressAdminDistrictsItem(name, shortName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AddressAdminDistrictsItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAddressAdminDistrictsItem(document.RootElement);
        }
    }
}
