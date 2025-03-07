// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RedisEnterprise
{
    public partial class RedisEnterpriseDatabaseResource : IJsonModel<RedisEnterpriseDatabaseData>
    {
        void IJsonModel<RedisEnterpriseDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RedisEnterpriseDatabaseData>)Data).Write(writer, options);

        RedisEnterpriseDatabaseData IJsonModel<RedisEnterpriseDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RedisEnterpriseDatabaseData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RedisEnterpriseDatabaseData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RedisEnterpriseDatabaseData IPersistableModel<RedisEnterpriseDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RedisEnterpriseDatabaseData>(data, options);

        string IPersistableModel<RedisEnterpriseDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RedisEnterpriseDatabaseData>)Data).GetFormatFromOptions(options);
    }
}
