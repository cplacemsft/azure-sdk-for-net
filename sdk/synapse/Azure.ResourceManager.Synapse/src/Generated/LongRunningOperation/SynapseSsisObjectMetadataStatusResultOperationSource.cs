// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseSsisObjectMetadataStatusResultOperationSource : IOperationSource<SynapseSsisObjectMetadataStatusResult>
    {
        SynapseSsisObjectMetadataStatusResult IOperationSource<SynapseSsisObjectMetadataStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return SynapseSsisObjectMetadataStatusResult.DeserializeSynapseSsisObjectMetadataStatusResult(document.RootElement);
        }

        async ValueTask<SynapseSsisObjectMetadataStatusResult> IOperationSource<SynapseSsisObjectMetadataStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return SynapseSsisObjectMetadataStatusResult.DeserializeSynapseSsisObjectMetadataStatusResult(document.RootElement);
        }
    }
}
