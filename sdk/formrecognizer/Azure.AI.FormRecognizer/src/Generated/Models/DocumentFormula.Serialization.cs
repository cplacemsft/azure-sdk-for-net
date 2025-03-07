// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentFormula
    {
        internal static DocumentFormula DeserializeDocumentFormula(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DocumentFormulaKind kind = default;
            string value = default;
            IReadOnlyList<float> polygon = default;
            DocumentSpan span = default;
            float confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DocumentFormulaKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("polygon"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<float> array = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetSingle());
                    }
                    polygon = array;
                    continue;
                }
                if (property.NameEquals("span"u8))
                {
                    span = DocumentSpan.DeserializeDocumentSpan(property.Value);
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return new DocumentFormula(kind, value, polygon ?? new ChangeTrackingList<float>(), span, confidence);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentFormula FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentFormula(document.RootElement);
        }
    }
}
