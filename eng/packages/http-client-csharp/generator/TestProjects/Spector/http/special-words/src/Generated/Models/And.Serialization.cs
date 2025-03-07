// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace SpecialWords._Models
{
    public partial class And : IJsonModel<And>
    {
        void IJsonModel<And>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        And IJsonModel<And>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual And JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<And>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        And IPersistableModel<And>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual And PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<And>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="and"> The <see cref="And"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(And @and) => throw null;

        public static explicit operator And(Response result) => throw null;
    }
}
