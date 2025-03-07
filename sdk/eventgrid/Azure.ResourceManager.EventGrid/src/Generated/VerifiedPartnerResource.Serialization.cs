// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class VerifiedPartnerResource : IJsonModel<VerifiedPartnerData>
    {
        void IJsonModel<VerifiedPartnerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VerifiedPartnerData>)Data).Write(writer, options);

        VerifiedPartnerData IJsonModel<VerifiedPartnerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VerifiedPartnerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VerifiedPartnerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VerifiedPartnerData IPersistableModel<VerifiedPartnerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VerifiedPartnerData>(data, options);

        string IPersistableModel<VerifiedPartnerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VerifiedPartnerData>)Data).GetFormatFromOptions(options);
    }
}
