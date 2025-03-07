// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ExpressRouteLinkResource : IJsonModel<ExpressRouteLinkData>
    {
        void IJsonModel<ExpressRouteLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteLinkData>)Data).Write(writer, options);

        ExpressRouteLinkData IJsonModel<ExpressRouteLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ExpressRouteLinkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ExpressRouteLinkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ExpressRouteLinkData IPersistableModel<ExpressRouteLinkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ExpressRouteLinkData>(data, options);

        string IPersistableModel<ExpressRouteLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ExpressRouteLinkData>)Data).GetFormatFromOptions(options);
    }
}
