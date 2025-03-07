// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class MediaStreamingUpdate
    {
        internal static MediaStreamingUpdate DeserializeMediaStreamingUpdate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contentType = default;
            MediaStreamingStatus? mediaStreamingStatus = default;
            MediaStreamingStatusDetails? mediaStreamingStatusDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaStreamingStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingStatus = new MediaStreamingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mediaStreamingStatusDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mediaStreamingStatusDetails = new MediaStreamingStatusDetails(property.Value.GetString());
                    continue;
                }
            }
            return new MediaStreamingUpdate(contentType, mediaStreamingStatus, mediaStreamingStatusDetails);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MediaStreamingUpdate FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMediaStreamingUpdate(document.RootElement);
        }
    }
}
