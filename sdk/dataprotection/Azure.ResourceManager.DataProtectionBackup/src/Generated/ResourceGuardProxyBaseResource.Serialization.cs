// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataProtectionBackup
{
    public partial class ResourceGuardProxyBaseResource : IJsonModel<ResourceGuardProxyBaseResourceData>
    {
        void IJsonModel<ResourceGuardProxyBaseResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ResourceGuardProxyBaseResourceData>)Data).Write(writer, options);

        ResourceGuardProxyBaseResourceData IJsonModel<ResourceGuardProxyBaseResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ResourceGuardProxyBaseResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ResourceGuardProxyBaseResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ResourceGuardProxyBaseResourceData IPersistableModel<ResourceGuardProxyBaseResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ResourceGuardProxyBaseResourceData>(data, options);

        string IPersistableModel<ResourceGuardProxyBaseResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ResourceGuardProxyBaseResourceData>)Data).GetFormatFromOptions(options);
    }
}
