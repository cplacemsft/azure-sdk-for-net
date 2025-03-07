// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.CostManagement
{
    public partial class TenantsCostManagementViewsResource : IJsonModel<CostManagementViewData>
    {
        void IJsonModel<CostManagementViewData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<CostManagementViewData>)Data).Write(writer, options);

        CostManagementViewData IJsonModel<CostManagementViewData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<CostManagementViewData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<CostManagementViewData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        CostManagementViewData IPersistableModel<CostManagementViewData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<CostManagementViewData>(data, options);

        string IPersistableModel<CostManagementViewData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<CostManagementViewData>)Data).GetFormatFromOptions(options);
    }
}
