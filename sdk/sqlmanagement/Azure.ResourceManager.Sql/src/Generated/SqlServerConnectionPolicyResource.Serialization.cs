// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerConnectionPolicyResource : IJsonModel<SqlServerConnectionPolicyData>
    {
        void IJsonModel<SqlServerConnectionPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerConnectionPolicyData>)Data).Write(writer, options);

        SqlServerConnectionPolicyData IJsonModel<SqlServerConnectionPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SqlServerConnectionPolicyData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SqlServerConnectionPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SqlServerConnectionPolicyData IPersistableModel<SqlServerConnectionPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SqlServerConnectionPolicyData>(data, options);

        string IPersistableModel<SqlServerConnectionPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SqlServerConnectionPolicyData>)Data).GetFormatFromOptions(options);
    }
}
