// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OperationalInsights
{
    public partial class OperationalInsightsLinkedServiceResource : IJsonModel<OperationalInsightsLinkedServiceData>
    {
        void IJsonModel<OperationalInsightsLinkedServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<OperationalInsightsLinkedServiceData>)Data).Write(writer, options);

        OperationalInsightsLinkedServiceData IJsonModel<OperationalInsightsLinkedServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<OperationalInsightsLinkedServiceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<OperationalInsightsLinkedServiceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        OperationalInsightsLinkedServiceData IPersistableModel<OperationalInsightsLinkedServiceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<OperationalInsightsLinkedServiceData>(data, options);

        string IPersistableModel<OperationalInsightsLinkedServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<OperationalInsightsLinkedServiceData>)Data).GetFormatFromOptions(options);
    }
}
