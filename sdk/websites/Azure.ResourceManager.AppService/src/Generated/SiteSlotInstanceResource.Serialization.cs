// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSlotInstanceResource : IJsonModel<WebSiteInstanceStatusData>
    {
        void IJsonModel<WebSiteInstanceStatusData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WebSiteInstanceStatusData>)Data).Write(writer, options);

        WebSiteInstanceStatusData IJsonModel<WebSiteInstanceStatusData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WebSiteInstanceStatusData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WebSiteInstanceStatusData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        WebSiteInstanceStatusData IPersistableModel<WebSiteInstanceStatusData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WebSiteInstanceStatusData>(data, options);

        string IPersistableModel<WebSiteInstanceStatusData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WebSiteInstanceStatusData>)Data).GetFormatFromOptions(options);
    }
}
