// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.MixedReality.Common;

namespace Azure.MixedReality.ObjectAnchors.Conversion.Models
{
    internal partial class ErrorDetail
    {
        internal static ErrorDetail DeserializeErrorDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<ErrorDetail> details = default;
            InnerError innererror = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ErrorDetail> array = new List<ErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeErrorDetail(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innererror"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innererror = InnerError.DeserializeInnerError(property.Value);
                    continue;
                }
            }
            return new ErrorDetail(code, message, target, details ?? new ChangeTrackingList<ErrorDetail>(), innererror);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ErrorDetail FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeErrorDetail(document.RootElement);
        }
    }
}
