// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class RecordingStorageInfo
    {
        internal static RecordingStorageInfo DeserializeRecordingStorageInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RecordingChunkStorageInfo> recordingChunks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingChunks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecordingChunkStorageInfo> array = new List<RecordingChunkStorageInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecordingChunkStorageInfo.DeserializeRecordingChunkStorageInfo(item));
                    }
                    recordingChunks = array;
                    continue;
                }
            }
            return new RecordingStorageInfo(recordingChunks ?? new ChangeTrackingList<RecordingChunkStorageInfo>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RecordingStorageInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRecordingStorageInfo(document.RootElement);
        }
    }
}
