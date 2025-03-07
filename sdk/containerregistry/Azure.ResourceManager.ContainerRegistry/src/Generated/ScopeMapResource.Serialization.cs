// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ScopeMapResource : IJsonModel<ScopeMapData>
    {
        void IJsonModel<ScopeMapData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ScopeMapData>)Data).Write(writer, options);

        ScopeMapData IJsonModel<ScopeMapData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ScopeMapData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ScopeMapData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ScopeMapData IPersistableModel<ScopeMapData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ScopeMapData>(data, options);

        string IPersistableModel<ScopeMapData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ScopeMapData>)Data).GetFormatFromOptions(options);
    }
}
