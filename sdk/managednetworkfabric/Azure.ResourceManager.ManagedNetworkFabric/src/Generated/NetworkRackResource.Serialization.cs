// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkRackResource : IJsonModel<NetworkRackData>
    {
        void IJsonModel<NetworkRackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkRackData>)Data).Write(writer, options);

        NetworkRackData IJsonModel<NetworkRackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkRackData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkRackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        NetworkRackData IPersistableModel<NetworkRackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkRackData>(data, options);

        string IPersistableModel<NetworkRackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkRackData>)Data).GetFormatFromOptions(options);
    }
}
