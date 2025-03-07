// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceApiOperationResource : IJsonModel<ApiOperationData>
    {
        void IJsonModel<ApiOperationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiOperationData>)Data).Write(writer, options);

        ApiOperationData IJsonModel<ApiOperationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiOperationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiOperationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiOperationData IPersistableModel<ApiOperationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiOperationData>(data, options);

        string IPersistableModel<ApiOperationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiOperationData>)Data).GetFormatFromOptions(options);
    }
}
