// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.TrafficManager
{
    public partial class TrafficManagerProfileResource : IJsonModel<TrafficManagerProfileData>
    {
        void IJsonModel<TrafficManagerProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TrafficManagerProfileData>)Data).Write(writer, options);

        TrafficManagerProfileData IJsonModel<TrafficManagerProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TrafficManagerProfileData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TrafficManagerProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        TrafficManagerProfileData IPersistableModel<TrafficManagerProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TrafficManagerProfileData>(data, options);

        string IPersistableModel<TrafficManagerProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TrafficManagerProfileData>)Data).GetFormatFromOptions(options);
    }
}
