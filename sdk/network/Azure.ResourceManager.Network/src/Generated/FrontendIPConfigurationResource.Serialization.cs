// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class FrontendIPConfigurationResource : IJsonModel<FrontendIPConfigurationData>
    {
        void IJsonModel<FrontendIPConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontendIPConfigurationData>)Data).Write(writer, options);

        FrontendIPConfigurationData IJsonModel<FrontendIPConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontendIPConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FrontendIPConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FrontendIPConfigurationData IPersistableModel<FrontendIPConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontendIPConfigurationData>(data, options);

        string IPersistableModel<FrontendIPConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontendIPConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
