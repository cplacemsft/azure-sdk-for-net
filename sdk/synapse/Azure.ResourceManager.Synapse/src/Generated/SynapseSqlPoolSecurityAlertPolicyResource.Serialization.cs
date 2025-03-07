// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseSqlPoolSecurityAlertPolicyResource : IJsonModel<SynapseSqlPoolSecurityAlertPolicyData>
    {
        void IJsonModel<SynapseSqlPoolSecurityAlertPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SynapseSqlPoolSecurityAlertPolicyData>)Data).Write(writer, options);

        SynapseSqlPoolSecurityAlertPolicyData IJsonModel<SynapseSqlPoolSecurityAlertPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SynapseSqlPoolSecurityAlertPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SynapseSqlPoolSecurityAlertPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SynapseSqlPoolSecurityAlertPolicyData IPersistableModel<SynapseSqlPoolSecurityAlertPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SynapseSqlPoolSecurityAlertPolicyData>(data, options);

        string IPersistableModel<SynapseSqlPoolSecurityAlertPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SynapseSqlPoolSecurityAlertPolicyData>)Data).GetFormatFromOptions(options);
    }
}
