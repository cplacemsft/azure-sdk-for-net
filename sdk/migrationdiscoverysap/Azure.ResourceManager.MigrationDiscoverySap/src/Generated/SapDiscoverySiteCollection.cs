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

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    /// <summary>
    /// A class representing a collection of <see cref="SapDiscoverySiteResource"/> and their operations.
    /// Each <see cref="SapDiscoverySiteResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="SapDiscoverySiteCollection"/> instance call the GetSapDiscoverySites method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class SapDiscoverySiteCollection : ArmCollection, IEnumerable<SapDiscoverySiteResource>, IAsyncEnumerable<SapDiscoverySiteResource>
    {
        private readonly ClientDiagnostics _sapDiscoverySiteClientDiagnostics;
        private readonly SapDiscoverySitesRestOperations _sapDiscoverySiteRestClient;

        /// <summary> Initializes a new instance of the <see cref="SapDiscoverySiteCollection"/> class for mocking. </summary>
        protected SapDiscoverySiteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SapDiscoverySiteCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SapDiscoverySiteCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sapDiscoverySiteClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MigrationDiscoverySap", SapDiscoverySiteResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SapDiscoverySiteResource.ResourceType, out string sapDiscoverySiteApiVersion);
            _sapDiscoverySiteRestClient = new SapDiscoverySitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sapDiscoverySiteApiVersion);
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
        /// Creates a discovery site resource for SAP Migration. This resource will be used to run system discovery and assessment with Azure Migrate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SapDiscoverySiteResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sapDiscoverySiteName, SapDiscoverySiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sapDiscoverySiteRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MigrationDiscoverySapArmOperation<SapDiscoverySiteResource>(new SapDiscoverySiteOperationSource(Client), _sapDiscoverySiteClientDiagnostics, Pipeline, _sapDiscoverySiteRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a discovery site resource for SAP Migration. This resource will be used to run system discovery and assessment with Azure Migrate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SapDiscoverySiteResource> CreateOrUpdate(WaitUntil waitUntil, string sapDiscoverySiteName, SapDiscoverySiteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sapDiscoverySiteRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, data, cancellationToken);
                var operation = new MigrationDiscoverySapArmOperation<SapDiscoverySiteResource>(new SapDiscoverySiteOperationSource(Client), _sapDiscoverySiteClientDiagnostics, Pipeline, _sapDiscoverySiteRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a SAP Migration discovery site resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual async Task<Response<SapDiscoverySiteResource>> GetAsync(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.Get");
            scope.Start();
            try
            {
                var response = await _sapDiscoverySiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDiscoverySiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a SAP Migration discovery site resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual Response<SapDiscoverySiteResource> Get(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.Get");
            scope.Start();
            try
            {
                var response = _sapDiscoverySiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SapDiscoverySiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all SAP Migration discovery site resources in a Resource Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SapDiscoverySiteResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SapDiscoverySiteResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDiscoverySiteRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDiscoverySiteRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SapDiscoverySiteResource(Client, SapDiscoverySiteData.DeserializeSapDiscoverySiteData(e)), _sapDiscoverySiteClientDiagnostics, Pipeline, "SapDiscoverySiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all SAP Migration discovery site resources in a Resource Group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SapDiscoverySiteResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SapDiscoverySiteResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sapDiscoverySiteRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sapDiscoverySiteRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SapDiscoverySiteResource(Client, SapDiscoverySiteData.DeserializeSapDiscoverySiteData(e)), _sapDiscoverySiteClientDiagnostics, Pipeline, "SapDiscoverySiteCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sapDiscoverySiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual Response<bool> Exists(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.Exists");
            scope.Start();
            try
            {
                var response = _sapDiscoverySiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual async Task<NullableResponse<SapDiscoverySiteResource>> GetIfExistsAsync(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sapDiscoverySiteRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SapDiscoverySiteResource>(response.GetRawResponse());
                return Response.FromValue(new SapDiscoverySiteResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Workloads/sapDiscoverySites/{sapDiscoverySiteName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SapDiscoverySites_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SapDiscoverySiteResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sapDiscoverySiteName"> The name of the discovery site resource for SAP Migration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sapDiscoverySiteName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sapDiscoverySiteName"/> is null. </exception>
        public virtual NullableResponse<SapDiscoverySiteResource> GetIfExists(string sapDiscoverySiteName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sapDiscoverySiteName, nameof(sapDiscoverySiteName));

            using var scope = _sapDiscoverySiteClientDiagnostics.CreateScope("SapDiscoverySiteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sapDiscoverySiteRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sapDiscoverySiteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SapDiscoverySiteResource>(response.GetRawResponse());
                return Response.FromValue(new SapDiscoverySiteResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SapDiscoverySiteResource> IEnumerable<SapDiscoverySiteResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SapDiscoverySiteResource> IAsyncEnumerable<SapDiscoverySiteResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
