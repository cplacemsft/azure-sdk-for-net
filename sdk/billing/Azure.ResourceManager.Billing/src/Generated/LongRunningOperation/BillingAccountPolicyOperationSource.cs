// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Billing
{
    internal class BillingAccountPolicyOperationSource : IOperationSource<BillingAccountPolicyResource>
    {
        private readonly ArmClient _client;

        internal BillingAccountPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingAccountPolicyResource IOperationSource<BillingAccountPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingAccountPolicyData>(response.Content);
            return new BillingAccountPolicyResource(_client, data);
        }

        async ValueTask<BillingAccountPolicyResource> IOperationSource<BillingAccountPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<BillingAccountPolicyData>(response.Content);
            return await Task.FromResult(new BillingAccountPolicyResource(_client, data)).ConfigureAwait(false);
        }
    }
}
