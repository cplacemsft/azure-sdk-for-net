// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.PhoneNumbers
{
    public partial class PhoneNumberOffering
    {
        internal static PhoneNumberOffering DeserializePhoneNumberOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PhoneNumberType? phoneNumberType = default;
            PhoneNumberAssignmentType? assignmentType = default;
            PhoneNumberCapabilities availableCapabilities = default;
            PhoneNumberCost cost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phoneNumberType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phoneNumberType = new PhoneNumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assignmentType = new PhoneNumberAssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("availableCapabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableCapabilities = PhoneNumberCapabilities.DeserializePhoneNumberCapabilities(property.Value);
                    continue;
                }
                if (property.NameEquals("cost"u8))
                {
                    cost = PhoneNumberCost.DeserializePhoneNumberCost(property.Value);
                    continue;
                }
            }
            return new PhoneNumberOffering(phoneNumberType, assignmentType, availableCapabilities, cost);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PhoneNumberOffering FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePhoneNumberOffering(document.RootElement);
        }
    }
}
