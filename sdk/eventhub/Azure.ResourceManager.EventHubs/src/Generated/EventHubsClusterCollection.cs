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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary>
    /// A class representing a collection of <see cref="EventHubsClusterResource"/> and their operations.
    /// Each <see cref="EventHubsClusterResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="EventHubsClusterCollection"/> instance call the GetEventHubsClusters method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class EventHubsClusterCollection : ArmCollection, IEnumerable<EventHubsClusterResource>, IAsyncEnumerable<EventHubsClusterResource>
    {
        private readonly ClientDiagnostics _eventHubsClusterClustersClientDiagnostics;
        private readonly ClustersRestOperations _eventHubsClusterClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubsClusterCollection"/> class for mocking. </summary>
        protected EventHubsClusterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubsClusterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventHubsClusterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventHubsClusterClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsClusterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventHubsClusterResource.ResourceType, out string eventHubsClusterClustersApiVersion);
            _eventHubsClusterClustersRestClient = new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventHubsClusterClustersApiVersion);
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
        /// Creates or updates an instance of an Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="data"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventHubsClusterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string clusterName, EventHubsClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubsClusterClustersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubsArmOperation<EventHubsClusterResource>(new EventHubsClusterOperationSource(Client), _eventHubsClusterClustersClientDiagnostics, Pipeline, _eventHubsClusterClustersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an instance of an Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="data"> Parameters for creating a eventhub cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventHubsClusterResource> CreateOrUpdate(WaitUntil waitUntil, string clusterName, EventHubsClusterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubsClusterClustersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data, cancellationToken);
                var operation = new EventHubsArmOperation<EventHubsClusterResource>(new EventHubsClusterOperationSource(Client), _eventHubsClusterClustersClientDiagnostics, Pipeline, _eventHubsClusterClustersRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, clusterName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<EventHubsClusterResource>> GetAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the resource description of the specified Event Hubs Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<EventHubsClusterResource> Get(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubsClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsClusterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsClusterClustersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsClusterClustersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsClusterResource(Client, EventHubsClusterData.DeserializeEventHubsClusterData(e)), _eventHubsClusterClustersClientDiagnostics, Pipeline, "EventHubsClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsClusterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventHubsClusterClustersRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventHubsClusterClustersRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsClusterResource(Client, EventHubsClusterData.DeserializeEventHubsClusterData(e)), _eventHubsClusterClustersClientDiagnostics, Pipeline, "EventHubsClusterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventHubsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual Response<bool> Exists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventHubsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual async Task<NullableResponse<EventHubsClusterResource>> GetIfExistsAsync(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubsClusterClustersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsClusterResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsClusterResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventHub/clusters/{clusterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="EventHubsClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterName"> The name of the Event Hubs Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        public virtual NullableResponse<EventHubsClusterResource> GetIfExists(string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var scope = _eventHubsClusterClustersClientDiagnostics.CreateScope("EventHubsClusterCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubsClusterClustersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, clusterName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<EventHubsClusterResource>(response.GetRawResponse());
                return Response.FromValue(new EventHubsClusterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventHubsClusterResource> IEnumerable<EventHubsClusterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubsClusterResource> IAsyncEnumerable<EventHubsClusterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
