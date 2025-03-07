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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="FailoverGroupResource"/> and their operations.
    /// Each <see cref="FailoverGroupResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="FailoverGroupCollection"/> instance call the GetFailoverGroups method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class FailoverGroupCollection : ArmCollection, IEnumerable<FailoverGroupResource>, IAsyncEnumerable<FailoverGroupResource>
    {
        private readonly ClientDiagnostics _failoverGroupClientDiagnostics;
        private readonly FailoverGroupsRestOperations _failoverGroupRestClient;

        /// <summary> Initializes a new instance of the <see cref="FailoverGroupCollection"/> class for mocking. </summary>
        protected FailoverGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FailoverGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FailoverGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _failoverGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", FailoverGroupResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FailoverGroupResource.ResourceType, out string failoverGroupApiVersion);
            _failoverGroupRestClient = new FailoverGroupsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, failoverGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="data"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FailoverGroupResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string failoverGroupName, FailoverGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<FailoverGroupResource>(new FailoverGroupOperationSource(Client), _failoverGroupClientDiagnostics, Pipeline, _failoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="data"> The failover group parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FailoverGroupResource> CreateOrUpdate(WaitUntil waitUntil, string failoverGroupName, FailoverGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, data, cancellationToken);
                var operation = new SqlArmOperation<FailoverGroupResource>(new FailoverGroupOperationSource(Client), _failoverGroupClientDiagnostics, Pipeline, _failoverGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<Response<FailoverGroupResource>> GetAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a failover group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<FailoverGroupResource> Get(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the failover groups in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FailoverGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FailoverGroupResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _failoverGroupRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _failoverGroupRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FailoverGroupResource(Client, FailoverGroupData.DeserializeFailoverGroupData(e)), _failoverGroupClientDiagnostics, Pipeline, "FailoverGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the failover groups in a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FailoverGroupResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FailoverGroupResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _failoverGroupRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _failoverGroupRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FailoverGroupResource(Client, FailoverGroupData.DeserializeFailoverGroupData(e)), _failoverGroupClientDiagnostics, Pipeline, "FailoverGroupCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual async Task<NullableResponse<FailoverGroupResource>> GetIfExistsAsync(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _failoverGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FailoverGroupResource>(response.GetRawResponse());
                return Response.FromValue(new FailoverGroupResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/failoverGroups/{failoverGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FailoverGroups_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FailoverGroupResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="failoverGroupName"> The name of the failover group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="failoverGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="failoverGroupName"/> is null. </exception>
        public virtual NullableResponse<FailoverGroupResource> GetIfExists(string failoverGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(failoverGroupName, nameof(failoverGroupName));

            using var scope = _failoverGroupClientDiagnostics.CreateScope("FailoverGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _failoverGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, failoverGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FailoverGroupResource>(response.GetRawResponse());
                return Response.FromValue(new FailoverGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FailoverGroupResource> IEnumerable<FailoverGroupResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FailoverGroupResource> IAsyncEnumerable<FailoverGroupResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
