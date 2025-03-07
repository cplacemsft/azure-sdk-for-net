// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class LocalRulestackResource : IJsonModel<LocalRulestackData>
    {
        void IJsonModel<LocalRulestackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LocalRulestackData>)Data).Write(writer, options);

        LocalRulestackData IJsonModel<LocalRulestackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LocalRulestackData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LocalRulestackData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LocalRulestackData IPersistableModel<LocalRulestackData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LocalRulestackData>(data, options);

        string IPersistableModel<LocalRulestackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LocalRulestackData>)Data).GetFormatFromOptions(options);
    }
}
