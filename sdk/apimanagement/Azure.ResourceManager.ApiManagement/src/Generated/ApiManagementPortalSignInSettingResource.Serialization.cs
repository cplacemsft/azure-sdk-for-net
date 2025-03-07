// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementPortalSignInSettingResource : IJsonModel<ApiManagementPortalSignInSettingData>
    {
        void IJsonModel<ApiManagementPortalSignInSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementPortalSignInSettingData>)Data).Write(writer, options);

        ApiManagementPortalSignInSettingData IJsonModel<ApiManagementPortalSignInSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementPortalSignInSettingData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementPortalSignInSettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiManagementPortalSignInSettingData IPersistableModel<ApiManagementPortalSignInSettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementPortalSignInSettingData>(data, options);

        string IPersistableModel<ApiManagementPortalSignInSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementPortalSignInSettingData>)Data).GetFormatFromOptions(options);
    }
}
