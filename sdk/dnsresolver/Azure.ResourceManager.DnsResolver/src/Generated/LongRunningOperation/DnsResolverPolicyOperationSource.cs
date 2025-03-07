// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsResolverPolicyOperationSource : IOperationSource<DnsResolverPolicyResource>
    {
        private readonly ArmClient _client;

        internal DnsResolverPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsResolverPolicyResource IOperationSource<DnsResolverPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverPolicyData>(response.Content);
            return new DnsResolverPolicyResource(_client, data);
        }

        async ValueTask<DnsResolverPolicyResource> IOperationSource<DnsResolverPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DnsResolverPolicyData>(response.Content);
            return await Task.FromResult(new DnsResolverPolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
