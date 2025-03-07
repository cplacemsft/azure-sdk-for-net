// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Nginx.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableNginxSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _nginxDeploymentDeploymentsClientDiagnostics;
        private DeploymentsRestOperations _nginxDeploymentDeploymentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableNginxSubscriptionResource"/> class for mocking. </summary>
        protected MockableNginxSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableNginxSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableNginxSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics NginxDeploymentDeploymentsClientDiagnostics => _nginxDeploymentDeploymentsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Nginx", NginxDeploymentResource.ResourceType.Namespace, Diagnostics);
        private DeploymentsRestOperations NginxDeploymentDeploymentsRestClient => _nginxDeploymentDeploymentsRestClient ??= new DeploymentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(NginxDeploymentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List the NGINX deployments resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Nginx.NginxPlus/nginxDeployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NginxDeploymentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NginxDeploymentResource> GetNginxDeploymentsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NginxDeploymentDeploymentsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NginxDeploymentDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NginxDeploymentResource(Client, NginxDeploymentData.DeserializeNginxDeploymentData(e)), NginxDeploymentDeploymentsClientDiagnostics, Pipeline, "MockableNginxSubscriptionResource.GetNginxDeployments", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List the NGINX deployments resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Nginx.NginxPlus/nginxDeployments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Deployments_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="NginxDeploymentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NginxDeploymentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NginxDeploymentResource> GetNginxDeployments(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => NginxDeploymentDeploymentsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => NginxDeploymentDeploymentsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NginxDeploymentResource(Client, NginxDeploymentData.DeserializeNginxDeploymentData(e)), NginxDeploymentDeploymentsClientDiagnostics, Pipeline, "MockableNginxSubscriptionResource.GetNginxDeployments", "value", "nextLink", cancellationToken);
        }
    }
}
