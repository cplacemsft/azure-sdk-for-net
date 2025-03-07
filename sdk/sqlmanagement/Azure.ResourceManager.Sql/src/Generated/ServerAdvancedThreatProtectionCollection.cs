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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ServerAdvancedThreatProtectionResource"/> and their operations.
    /// Each <see cref="ServerAdvancedThreatProtectionResource"/> in the collection will belong to the same instance of <see cref="SqlServerResource"/>.
    /// To get a <see cref="ServerAdvancedThreatProtectionCollection"/> instance call the GetServerAdvancedThreatProtections method from an instance of <see cref="SqlServerResource"/>.
    /// </summary>
    public partial class ServerAdvancedThreatProtectionCollection : ArmCollection, IEnumerable<ServerAdvancedThreatProtectionResource>, IAsyncEnumerable<ServerAdvancedThreatProtectionResource>
    {
        private readonly ClientDiagnostics _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics;
        private readonly ServerAdvancedThreatProtectionSettingsRestOperations _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerAdvancedThreatProtectionCollection"/> class for mocking. </summary>
        protected ServerAdvancedThreatProtectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerAdvancedThreatProtectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServerAdvancedThreatProtectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ServerAdvancedThreatProtectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServerAdvancedThreatProtectionResource.ResourceType, out string serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsApiVersion);
            _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient = new ServerAdvancedThreatProtectionSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsApiVersion);
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
        /// Creates or updates an Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The server Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServerAdvancedThreatProtectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ServerAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ServerAdvancedThreatProtectionResource>(new ServerAdvancedThreatProtectionOperationSource(Client), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="data"> The server Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServerAdvancedThreatProtectionResource> CreateOrUpdate(WaitUntil waitUntil, AdvancedThreatProtectionName advancedThreatProtectionName, ServerAdvancedThreatProtectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data, cancellationToken);
                var operation = new SqlArmOperation<ServerAdvancedThreatProtectionResource>(new ServerAdvancedThreatProtectionOperationSource(Client), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a server's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServerAdvancedThreatProtectionResource>> GetAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server's Advanced Threat Protection state.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServerAdvancedThreatProtectionResource> Get(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.Get");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of the server's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServerAdvancedThreatProtectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServerAdvancedThreatProtectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ServerAdvancedThreatProtectionResource(Client, ServerAdvancedThreatProtectionData.DeserializeServerAdvancedThreatProtectionData(e)), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ServerAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of the server's Advanced Threat Protection states.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_ListByServer</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServerAdvancedThreatProtectionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServerAdvancedThreatProtectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ServerAdvancedThreatProtectionResource(Client, ServerAdvancedThreatProtectionData.DeserializeServerAdvancedThreatProtectionData(e)), _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics, Pipeline, "ServerAdvancedThreatProtectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ServerAdvancedThreatProtectionResource>> GetIfExistsAsync(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ServerAdvancedThreatProtectionResource>(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advancedThreatProtectionSettings/{advancedThreatProtectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerAdvancedThreatProtectionSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ServerAdvancedThreatProtectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="advancedThreatProtectionName"> The name of the Advanced Threat Protection state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ServerAdvancedThreatProtectionResource> GetIfExists(AdvancedThreatProtectionName advancedThreatProtectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsClientDiagnostics.CreateScope("ServerAdvancedThreatProtectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serverAdvancedThreatProtectionServerAdvancedThreatProtectionSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, advancedThreatProtectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ServerAdvancedThreatProtectionResource>(response.GetRawResponse());
                return Response.FromValue(new ServerAdvancedThreatProtectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServerAdvancedThreatProtectionResource> IEnumerable<ServerAdvancedThreatProtectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServerAdvancedThreatProtectionResource> IAsyncEnumerable<ServerAdvancedThreatProtectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
