// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkGroupStaticMemberResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StaticMembersGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerStaticMemberGet.json
            // this example is just showing the usage of "StaticMembers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupStaticMemberResource created on azure
            // for more information of creating NetworkGroupStaticMemberResource, please refer to the document of NetworkGroupStaticMemberResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            string staticMemberName = "testStaticMember";
            ResourceIdentifier networkGroupStaticMemberResourceId = NetworkGroupStaticMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName, staticMemberName);
            NetworkGroupStaticMemberResource networkGroupStaticMember = client.GetNetworkGroupStaticMemberResource(networkGroupStaticMemberResourceId);

            // invoke the operation
            NetworkGroupStaticMemberResource result = await networkGroupStaticMember.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupStaticMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_StaticMembersDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerStaticMemberDelete.json
            // this example is just showing the usage of "StaticMembers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupStaticMemberResource created on azure
            // for more information of creating NetworkGroupStaticMemberResource, please refer to the document of NetworkGroupStaticMemberResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SampleRG";
            string networkManagerName = "TestNM";
            string networkGroupName = "testNetworkGroup";
            string staticMemberName = "testStaticMember";
            ResourceIdentifier networkGroupStaticMemberResourceId = NetworkGroupStaticMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName, staticMemberName);
            NetworkGroupStaticMemberResource networkGroupStaticMember = client.GetNetworkGroupStaticMemberResource(networkGroupStaticMemberResourceId);

            // invoke the operation
            await networkGroupStaticMember.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_StaticMemberPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerStaticMemberPut.json
            // this example is just showing the usage of "StaticMembers_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupStaticMemberResource created on azure
            // for more information of creating NetworkGroupStaticMemberResource, please refer to the document of NetworkGroupStaticMemberResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            string staticMemberName = "testStaticMember";
            ResourceIdentifier networkGroupStaticMemberResourceId = NetworkGroupStaticMemberResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName, staticMemberName);
            NetworkGroupStaticMemberResource networkGroupStaticMember = client.GetNetworkGroupStaticMemberResource(networkGroupStaticMemberResourceId);

            // invoke the operation
            NetworkGroupStaticMemberData data = new NetworkGroupStaticMemberData
            {
                ResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroup/rg1/providers/Microsoft.Network/virtualnetworks/vnet1"),
            };
            ArmOperation<NetworkGroupStaticMemberResource> lro = await networkGroupStaticMember.UpdateAsync(WaitUntil.Completed, data);
            NetworkGroupStaticMemberResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupStaticMemberData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
