// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Samples
{
    public partial class Sample_ServiceFabricManagedServiceCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAServiceWithMaximumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServicePutOperation_example_max.json
            // this example is just showing the usage of "Services_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation
            string serviceName = "myService";
            ServiceFabricManagedServiceData data = new ServiceFabricManagedServiceData(new AzureLocation("eastus"))
            {
                Properties = new StatelessServiceProperties("myServiceType", new SingletonPartitionScheme(), 5)
                {
                    MinInstanceCount = 3,
                    MinInstancePercentage = 30,
                    ServicePackageActivationMode = ManagedServicePackageActivationMode.SharedProcess,
                    ServiceDnsName = "myservicednsname.myApp",
                    PlacementConstraints = "NodeType==frontend",
                    CorrelationScheme = { new ManagedServiceCorrelation(ManagedServiceCorrelationScheme.AlignedAffinity, "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/resRg/providers/Microsoft.ServiceFabric/managedclusters/myCluster/applications/myApp/services/myService1") },
                    ServiceLoadMetrics = {new ManagedServiceLoadMetric("metric1")
{
Weight = ManagedServiceLoadMetricWeight.Low,
DefaultLoad = 3,
}},
                    ServicePlacementPolicies = { new ServicePlacementNonPartiallyPlaceServicePolicy() },
                    DefaultMoveCost = ServiceFabricManagedServiceMoveCost.Medium,
                    ScalingPolicies = { new ManagedServiceScalingPolicy(new PartitionInstanceCountScalingMechanism(3, 9, 2), new AveragePartitionLoadScalingTrigger("metricName", 2, 8, "00:01:00")) },
                },
                Tags =
{
["a"] = "b"
},
            };
            ArmOperation<ServiceFabricManagedServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serviceName, data);
            ServiceFabricManagedServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAServiceWithMinimumParameters()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServicePutOperation_example_min.json
            // this example is just showing the usage of "Services_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation
            string serviceName = "myService";
            ServiceFabricManagedServiceData data = new ServiceFabricManagedServiceData(new AzureLocation("eastus"))
            {
                Properties = new StatelessServiceProperties("myServiceType", new SingletonPartitionScheme(), 1),
            };
            ArmOperation<ServiceFabricManagedServiceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, serviceName, data);
            ServiceFabricManagedServiceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServiceGetOperation_example.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation
            string serviceName = "myService";
            ServiceFabricManagedServiceResource result = await collection.GetAsync(serviceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedServiceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAListOfServiceResources()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServiceListOperation_example.json
            // this example is just showing the usage of "Services_ListByApplications" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricManagedServiceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedServiceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServiceGetOperation_example.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation
            string serviceName = "myService";
            bool result = await collection.ExistsAsync(serviceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAService()
        {
            // Generated from example definition: specification/servicefabricmanagedclusters/resource-manager/Microsoft.ServiceFabric/preview/2024-09-01-preview/examples/ServiceGetOperation_example.json
            // this example is just showing the usage of "Services_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricManagedApplicationResource created on azure
            // for more information of creating ServiceFabricManagedApplicationResource, please refer to the document of ServiceFabricManagedApplicationResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            string applicationName = "myApp";
            ResourceIdentifier serviceFabricManagedApplicationResourceId = ServiceFabricManagedApplicationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, applicationName);
            ServiceFabricManagedApplicationResource serviceFabricManagedApplication = client.GetServiceFabricManagedApplicationResource(serviceFabricManagedApplicationResourceId);

            // get the collection of this ServiceFabricManagedServiceResource
            ServiceFabricManagedServiceCollection collection = serviceFabricManagedApplication.GetServiceFabricManagedServices();

            // invoke the operation
            string serviceName = "myService";
            NullableResponse<ServiceFabricManagedServiceResource> response = await collection.GetIfExistsAsync(serviceName);
            ServiceFabricManagedServiceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricManagedServiceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
