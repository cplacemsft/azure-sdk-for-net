// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    internal class BillingDocumentDownloadResultOperationSource : IOperationSource<BillingDocumentDownloadResult>
    {
        BillingDocumentDownloadResult IOperationSource<BillingDocumentDownloadResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
            return BillingDocumentDownloadResult.DeserializeBillingDocumentDownloadResult(document.RootElement);
        }

        async ValueTask<BillingDocumentDownloadResult> IOperationSource<BillingDocumentDownloadResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
            return BillingDocumentDownloadResult.DeserializeBillingDocumentDownloadResult(document.RootElement);
        }
    }
}
