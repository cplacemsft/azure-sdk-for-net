// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class DevOpsProjectResource : IJsonModel<DevOpsProjectData>
    {
        void IJsonModel<DevOpsProjectData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevOpsProjectData>)Data).Write(writer, options);

        DevOpsProjectData IJsonModel<DevOpsProjectData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevOpsProjectData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevOpsProjectData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DevOpsProjectData IPersistableModel<DevOpsProjectData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevOpsProjectData>(data, options);

        string IPersistableModel<DevOpsProjectData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevOpsProjectData>)Data).GetFormatFromOptions(options);
    }
}
