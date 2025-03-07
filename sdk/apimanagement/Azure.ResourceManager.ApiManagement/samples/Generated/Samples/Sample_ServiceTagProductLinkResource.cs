// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceTagProductLinkResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_ApiManagementGetTagProductLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetTagProductLink.json
            // this example is just showing the usage of "TagProductLink_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagProductLinkResource created on azure
            // for more information of creating ServiceTagProductLinkResource, please refer to the document of ServiceTagProductLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string productLinkId = "link1";
            ResourceIdentifier serviceTagProductLinkResourceId = ServiceTagProductLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, productLinkId);
            ServiceTagProductLinkResource serviceTagProductLink = client.GetServiceTagProductLinkResource(serviceTagProductLinkResourceId);

            // invoke the operation
            ServiceTagProductLinkResource result = await serviceTagProductLink.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagProductLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_ApiManagementDeleteTagProductLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementDeleteTagProductLink.json
            // this example is just showing the usage of "TagProductLink_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagProductLinkResource created on azure
            // for more information of creating ServiceTagProductLinkResource, please refer to the document of ServiceTagProductLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string productLinkId = "link1";
            ResourceIdentifier serviceTagProductLinkResourceId = ServiceTagProductLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, productLinkId);
            ServiceTagProductLinkResource serviceTagProductLink = client.GetServiceTagProductLinkResource(serviceTagProductLinkResourceId);

            // invoke the operation
            await serviceTagProductLink.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_ApiManagementCreateTagProductLink()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateTagProductLink.json
            // this example is just showing the usage of "TagProductLink_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceTagProductLinkResource created on azure
            // for more information of creating ServiceTagProductLinkResource, please refer to the document of ServiceTagProductLinkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string tagId = "tag1";
            string productLinkId = "link1";
            ResourceIdentifier serviceTagProductLinkResourceId = ServiceTagProductLinkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, tagId, productLinkId);
            ServiceTagProductLinkResource serviceTagProductLink = client.GetServiceTagProductLinkResource(serviceTagProductLinkResourceId);

            // invoke the operation
            TagProductLinkContractData data = new TagProductLinkContractData
            {
                ProductId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.ApiManagement/service/apimService1/products/product1",
            };
            ArmOperation<ServiceTagProductLinkResource> lro = await serviceTagProductLink.UpdateAsync(WaitUntil.Completed, data);
            ServiceTagProductLinkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TagProductLinkContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
