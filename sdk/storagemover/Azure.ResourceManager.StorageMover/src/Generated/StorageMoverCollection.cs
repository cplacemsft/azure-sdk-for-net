// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageMoverResource"/> and their operations.
    /// Each <see cref="StorageMoverResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="StorageMoverCollection"/> instance call the GetStorageMovers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class StorageMoverCollection : ArmCollection, IEnumerable<StorageMoverResource>, IAsyncEnumerable<StorageMoverResource>
    {
        private readonly ClientDiagnostics _storageMoverClientDiagnostics;
        private readonly StorageMoversRestOperations _storageMoverRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageMoverCollection"/> class for mocking. </summary>
        protected StorageMoverCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageMoverCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageMoverCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageMoverClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StorageMover", StorageMoverResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageMoverResource.ResourceType, out string storageMoverApiVersion);
            _storageMoverRestClient = new StorageMoversRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageMoverApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a top-level Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="data"> The <see cref="StorageMoverData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageMoverResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageMoverName, StorageMoverData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageMoverRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, data, cancellationToken).ConfigureAwait(false);
                var uri = _storageMoverRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageMoverArmOperation<StorageMoverResource>(Response.FromValue(new StorageMoverResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a top-level Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="data"> The <see cref="StorageMoverData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageMoverResource> CreateOrUpdate(WaitUntil waitUntil, string storageMoverName, StorageMoverData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageMoverRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, data, cancellationToken);
                var uri = _storageMoverRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StorageMoverArmOperation<StorageMoverResource>(Response.FromValue(new StorageMoverResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual async Task<Response<StorageMoverResource>> GetAsync(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageMoverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual Response<StorageMoverResource> Get(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.Get");
            scope.Start();
            try
            {
                var response = _storageMoverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageMoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all Storage Movers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageMoverResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageMoverResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageMoverResource(Client, StorageMoverData.DeserializeStorageMoverData(e)), _storageMoverClientDiagnostics, Pipeline, "StorageMoverCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all Storage Movers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageMoverResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageMoverResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageMoverRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageMoverRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageMoverResource(Client, StorageMoverData.DeserializeStorageMoverData(e)), _storageMoverClientDiagnostics, Pipeline, "StorageMoverCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageMoverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageMoverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageMoverResource>> GetIfExistsAsync(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageMoverRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageMoverResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        public virtual NullableResponse<StorageMoverResource> GetIfExists(string storageMoverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageMoverName, nameof(storageMoverName));

            using var scope = _storageMoverClientDiagnostics.CreateScope("StorageMoverCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageMoverRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageMoverName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageMoverResource>(response.GetRawResponse());
                return Response.FromValue(new StorageMoverResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageMoverResource> IEnumerable<StorageMoverResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageMoverResource> IAsyncEnumerable<StorageMoverResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
