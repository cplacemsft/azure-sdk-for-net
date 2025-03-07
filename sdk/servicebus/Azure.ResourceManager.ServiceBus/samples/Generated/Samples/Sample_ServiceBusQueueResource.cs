// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceBus.Samples
{
    public partial class Sample_ServiceBusQueueResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_QueueGet()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Queues/SBQueueGet.json
            // this example is just showing the usage of "Queues_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusQueueResource created on azure
            // for more information of creating ServiceBusQueueResource, please refer to the document of ServiceBusQueueResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            string queueName = "sdk-Queues-5647";
            ResourceIdentifier serviceBusQueueResourceId = ServiceBusQueueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName);
            ServiceBusQueueResource serviceBusQueue = client.GetServiceBusQueueResource(serviceBusQueueResourceId);

            // invoke the operation
            ServiceBusQueueResource result = await serviceBusQueue.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusQueueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_QueueDelete()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Queues/SBQueueDelete.json
            // this example is just showing the usage of "Queues_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusQueueResource created on azure
            // for more information of creating ServiceBusQueueResource, please refer to the document of ServiceBusQueueResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-183";
            string queueName = "sdk-Queues-8708";
            ResourceIdentifier serviceBusQueueResourceId = ServiceBusQueueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName);
            ServiceBusQueueResource serviceBusQueue = client.GetServiceBusQueueResource(serviceBusQueueResourceId);

            // invoke the operation
            await serviceBusQueue.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_QueueCreate()
        {
            // Generated from example definition: specification/servicebus/resource-manager/Microsoft.ServiceBus/stable/2024-01-01/examples/Queues/SBQueueCreate.json
            // this example is just showing the usage of "Queues_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceBusQueueResource created on azure
            // for more information of creating ServiceBusQueueResource, please refer to the document of ServiceBusQueueResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-3174";
            string queueName = "sdk-Queues-5647";
            ResourceIdentifier serviceBusQueueResourceId = ServiceBusQueueResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, queueName);
            ServiceBusQueueResource serviceBusQueue = client.GetServiceBusQueueResource(serviceBusQueueResourceId);

            // invoke the operation
            ServiceBusQueueData data = new ServiceBusQueueData
            {
                EnablePartitioning = true,
            };
            ArmOperation<ServiceBusQueueResource> lro = await serviceBusQueue.UpdateAsync(WaitUntil.Completed, data);
            ServiceBusQueueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceBusQueueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
