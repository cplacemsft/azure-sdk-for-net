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
    internal class ApplicationGatewayBackendHealthOnDemandOperationSource : IOperationSource<ApplicationGatewayBackendHealthOnDemand>
    {
        ApplicationGatewayBackendHealthOnDemand IOperationSource<ApplicationGatewayBackendHealthOnDemand>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return ApplicationGatewayBackendHealthOnDemand.DeserializeApplicationGatewayBackendHealthOnDemand(document.RootElement);
        }

        async ValueTask<ApplicationGatewayBackendHealthOnDemand> IOperationSource<ApplicationGatewayBackendHealthOnDemand>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return ApplicationGatewayBackendHealthOnDemand.DeserializeApplicationGatewayBackendHealthOnDemand(document.RootElement);
        }
    }
}
