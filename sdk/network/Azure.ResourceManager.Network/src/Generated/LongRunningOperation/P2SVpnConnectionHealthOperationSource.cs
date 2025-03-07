// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class P2SVpnConnectionHealthOperationSource : IOperationSource<P2SVpnConnectionHealth>
    {
        P2SVpnConnectionHealth IOperationSource<P2SVpnConnectionHealth>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return P2SVpnConnectionHealth.DeserializeP2SVpnConnectionHealth(document.RootElement);
        }

        async ValueTask<P2SVpnConnectionHealth> IOperationSource<P2SVpnConnectionHealth>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return P2SVpnConnectionHealth.DeserializeP2SVpnConnectionHealth(document.RootElement);
        }
    }
}
