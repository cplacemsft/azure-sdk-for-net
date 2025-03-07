// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseDataWarehouseUserActivityResource : IJsonModel<SynapseDataWarehouseUserActivityData>
    {
        void IJsonModel<SynapseDataWarehouseUserActivityData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDataWarehouseUserActivityData>)Data).Write(writer, options);

        SynapseDataWarehouseUserActivityData IJsonModel<SynapseDataWarehouseUserActivityData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseDataWarehouseUserActivityData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseDataWarehouseUserActivityData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseDataWarehouseUserActivityData IPersistableModel<SynapseDataWarehouseUserActivityData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseDataWarehouseUserActivityData>(data, options);

        string IPersistableModel<SynapseDataWarehouseUserActivityData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseDataWarehouseUserActivityData>)Data).GetFormatFromOptions(options);
    }
}
