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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerRegistryArchiveResource"/> and their operations.
    /// Each <see cref="ContainerRegistryArchiveResource"/> in the collection will belong to the same instance of <see cref="ContainerRegistryResource"/>.
    /// To get a <see cref="ContainerRegistryArchiveCollection"/> instance call the GetContainerRegistryArchives method from an instance of <see cref="ContainerRegistryResource"/>.
    /// </summary>
    public partial class ContainerRegistryArchiveCollection : ArmCollection, IEnumerable<ContainerRegistryArchiveResource>, IAsyncEnumerable<ContainerRegistryArchiveResource>
    {
        private readonly ClientDiagnostics _containerRegistryArchiveArchivesClientDiagnostics;
        private readonly ArchivesRestOperations _containerRegistryArchiveArchivesRestClient;
        private readonly string _packageType;

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryArchiveCollection"/> class for mocking. </summary>
        protected ContainerRegistryArchiveCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerRegistryArchiveCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="packageType"> The type of the package resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="packageType"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="packageType"/> is an empty string, and was expected to be non-empty. </exception>
        internal ContainerRegistryArchiveCollection(ArmClient client, ResourceIdentifier id, string packageType) : base(client, id)
        {
            _packageType = packageType;
            _containerRegistryArchiveArchivesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryArchiveResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerRegistryArchiveResource.ResourceType, out string containerRegistryArchiveArchivesApiVersion);
            _containerRegistryArchiveArchivesRestClient = new ArchivesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerRegistryArchiveArchivesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a archive for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="data"> The parameters for creating a archive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerRegistryArchiveResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string archiveName, ContainerRegistryArchiveData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerRegistryArchiveArchivesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryArchiveResource>(new ContainerRegistryArchiveOperationSource(Client), _containerRegistryArchiveArchivesClientDiagnostics, Pipeline, _containerRegistryArchiveArchivesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a archive for a container registry with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="data"> The parameters for creating a archive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerRegistryArchiveResource> CreateOrUpdate(WaitUntil waitUntil, string archiveName, ContainerRegistryArchiveData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerRegistryArchiveArchivesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ContainerRegistryArchiveResource>(new ContainerRegistryArchiveOperationSource(Client), _containerRegistryArchiveArchivesClientDiagnostics, Pipeline, _containerRegistryArchiveArchivesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the properties of the archive.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual async Task<Response<ContainerRegistryArchiveResource>> GetAsync(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerRegistryArchiveArchivesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryArchiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the archive.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual Response<ContainerRegistryArchiveResource> Get(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.Get");
            scope.Start();
            try
            {
                var response = _containerRegistryArchiveArchivesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryArchiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all archives for the specified container registry and package type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryArchiveResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryArchiveResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryArchiveArchivesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryArchiveArchivesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryArchiveResource(Client, ContainerRegistryArchiveData.DeserializeContainerRegistryArchiveData(e)), _containerRegistryArchiveArchivesClientDiagnostics, Pipeline, "ContainerRegistryArchiveCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all archives for the specified container registry and package type.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryArchiveResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryArchiveResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerRegistryArchiveArchivesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerRegistryArchiveArchivesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryArchiveResource(Client, ContainerRegistryArchiveData.DeserializeContainerRegistryArchiveData(e)), _containerRegistryArchiveArchivesClientDiagnostics, Pipeline, "ContainerRegistryArchiveCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerRegistryArchiveArchivesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual Response<bool> Exists(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerRegistryArchiveArchivesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerRegistryArchiveResource>> GetIfExistsAsync(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerRegistryArchiveArchivesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryArchiveResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryArchiveResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/packages/{packageType}/archives/{archiveName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Archives_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerRegistryArchiveResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="archiveName"> The name of the archive resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="archiveName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="archiveName"/> is null. </exception>
        public virtual NullableResponse<ContainerRegistryArchiveResource> GetIfExists(string archiveName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(archiveName, nameof(archiveName));

            using var scope = _containerRegistryArchiveArchivesClientDiagnostics.CreateScope("ContainerRegistryArchiveCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerRegistryArchiveArchivesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, _packageType, archiveName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerRegistryArchiveResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerRegistryArchiveResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerRegistryArchiveResource> IEnumerable<ContainerRegistryArchiveResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerRegistryArchiveResource> IAsyncEnumerable<ContainerRegistryArchiveResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
