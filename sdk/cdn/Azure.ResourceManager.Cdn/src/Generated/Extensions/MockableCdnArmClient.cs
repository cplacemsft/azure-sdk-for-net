// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Cdn.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableCdnArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableCdnArmClient"/> class for mocking. </summary>
        protected MockableCdnArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCdnArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCdnArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableCdnArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorCustomDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorCustomDomainResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorCustomDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorCustomDomainResource"/> object. </returns>
        public virtual FrontDoorCustomDomainResource GetFrontDoorCustomDomainResource(ResourceIdentifier id)
        {
            FrontDoorCustomDomainResource.ValidateResourceId(id);
            return new FrontDoorCustomDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorEndpointResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorEndpointResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorEndpointResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorEndpointResource"/> object. </returns>
        public virtual FrontDoorEndpointResource GetFrontDoorEndpointResource(ResourceIdentifier id)
        {
            FrontDoorEndpointResource.ValidateResourceId(id);
            return new FrontDoorEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorOriginGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorOriginGroupResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorOriginGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorOriginGroupResource"/> object. </returns>
        public virtual FrontDoorOriginGroupResource GetFrontDoorOriginGroupResource(ResourceIdentifier id)
        {
            FrontDoorOriginGroupResource.ValidateResourceId(id);
            return new FrontDoorOriginGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorOriginResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorOriginResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorOriginResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorOriginResource"/> object. </returns>
        public virtual FrontDoorOriginResource GetFrontDoorOriginResource(ResourceIdentifier id)
        {
            FrontDoorOriginResource.ValidateResourceId(id);
            return new FrontDoorOriginResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorRouteResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorRouteResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorRouteResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorRouteResource"/> object. </returns>
        public virtual FrontDoorRouteResource GetFrontDoorRouteResource(ResourceIdentifier id)
        {
            FrontDoorRouteResource.ValidateResourceId(id);
            return new FrontDoorRouteResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorRuleSetResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorRuleSetResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorRuleSetResource"/> object. </returns>
        public virtual FrontDoorRuleSetResource GetFrontDoorRuleSetResource(ResourceIdentifier id)
        {
            FrontDoorRuleSetResource.ValidateResourceId(id);
            return new FrontDoorRuleSetResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorRuleResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorRuleResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorRuleResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorRuleResource"/> object. </returns>
        public virtual FrontDoorRuleResource GetFrontDoorRuleResource(ResourceIdentifier id)
        {
            FrontDoorRuleResource.ValidateResourceId(id);
            return new FrontDoorRuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorSecurityPolicyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorSecurityPolicyResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorSecurityPolicyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorSecurityPolicyResource"/> object. </returns>
        public virtual FrontDoorSecurityPolicyResource GetFrontDoorSecurityPolicyResource(ResourceIdentifier id)
        {
            FrontDoorSecurityPolicyResource.ValidateResourceId(id);
            return new FrontDoorSecurityPolicyResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FrontDoorSecretResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FrontDoorSecretResource.CreateResourceIdentifier" /> to create a <see cref="FrontDoorSecretResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FrontDoorSecretResource"/> object. </returns>
        public virtual FrontDoorSecretResource GetFrontDoorSecretResource(ResourceIdentifier id)
        {
            FrontDoorSecretResource.ValidateResourceId(id);
            return new FrontDoorSecretResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ProfileResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProfileResource.CreateResourceIdentifier" /> to create a <see cref="ProfileResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProfileResource"/> object. </returns>
        public virtual ProfileResource GetProfileResource(ResourceIdentifier id)
        {
            ProfileResource.ValidateResourceId(id);
            return new ProfileResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CdnEndpointResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CdnEndpointResource.CreateResourceIdentifier" /> to create a <see cref="CdnEndpointResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnEndpointResource"/> object. </returns>
        public virtual CdnEndpointResource GetCdnEndpointResource(ResourceIdentifier id)
        {
            CdnEndpointResource.ValidateResourceId(id);
            return new CdnEndpointResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CdnOriginResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CdnOriginResource.CreateResourceIdentifier" /> to create a <see cref="CdnOriginResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnOriginResource"/> object. </returns>
        public virtual CdnOriginResource GetCdnOriginResource(ResourceIdentifier id)
        {
            CdnOriginResource.ValidateResourceId(id);
            return new CdnOriginResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CdnOriginGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CdnOriginGroupResource.CreateResourceIdentifier" /> to create a <see cref="CdnOriginGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnOriginGroupResource"/> object. </returns>
        public virtual CdnOriginGroupResource GetCdnOriginGroupResource(ResourceIdentifier id)
        {
            CdnOriginGroupResource.ValidateResourceId(id);
            return new CdnOriginGroupResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CdnCustomDomainResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CdnCustomDomainResource.CreateResourceIdentifier" /> to create a <see cref="CdnCustomDomainResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnCustomDomainResource"/> object. </returns>
        public virtual CdnCustomDomainResource GetCdnCustomDomainResource(ResourceIdentifier id)
        {
            CdnCustomDomainResource.ValidateResourceId(id);
            return new CdnCustomDomainResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="CdnWebApplicationFirewallPolicyResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="CdnWebApplicationFirewallPolicyResource.CreateResourceIdentifier" /> to create a <see cref="CdnWebApplicationFirewallPolicyResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="CdnWebApplicationFirewallPolicyResource"/> object. </returns>
        public virtual CdnWebApplicationFirewallPolicyResource GetCdnWebApplicationFirewallPolicyResource(ResourceIdentifier id)
        {
            CdnWebApplicationFirewallPolicyResource.ValidateResourceId(id);
            return new CdnWebApplicationFirewallPolicyResource(Client, id);
        }
    }
}
