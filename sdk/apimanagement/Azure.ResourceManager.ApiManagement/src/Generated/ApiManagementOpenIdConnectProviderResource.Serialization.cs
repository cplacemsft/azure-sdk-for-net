// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementOpenIdConnectProviderResource : IJsonModel<ApiManagementOpenIdConnectProviderData>
    {
        void IJsonModel<ApiManagementOpenIdConnectProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementOpenIdConnectProviderData>)Data).Write(writer, options);

        ApiManagementOpenIdConnectProviderData IJsonModel<ApiManagementOpenIdConnectProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementOpenIdConnectProviderData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementOpenIdConnectProviderData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiManagementOpenIdConnectProviderData IPersistableModel<ApiManagementOpenIdConnectProviderData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementOpenIdConnectProviderData>(data, options);

        string IPersistableModel<ApiManagementOpenIdConnectProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementOpenIdConnectProviderData>)Data).GetFormatFromOptions(options);
    }
}
