// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.StorageCache.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.StorageCache.Samples
{
    public partial class Sample_StorageTargetCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_StorageTargetsCreateOrUpdate()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_CreateOrUpdate.json
            // this example is just showing the usage of "StorageTargets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            StorageTargetData data = new StorageTargetData
            {
                Junctions = {new NamespaceJunction
{
NamespacePath = "/path/on/cache",
TargetPath = "/path/on/exp1",
NfsExport = "exp1",
NfsAccessPolicy = "default",
}, new NamespaceJunction
{
NamespacePath = "/path2/on/cache",
TargetPath = "/path2/on/exp2",
NfsExport = "exp2",
NfsAccessPolicy = "rootSquash",
}},
                TargetType = StorageTargetType.Nfs3,
                Nfs3 = new Nfs3Target
                {
                    Target = "10.0.44.44",
                    UsageModel = "READ_ONLY",
                    VerificationDelayInSeconds = 30,
                },
            };
            ArmOperation<StorageTargetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageTargetName, data);
            StorageTargetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_StorageTargetsCreateOrUpdateBlobNfs()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_CreateOrUpdate_BlobNfs.json
            // this example is just showing the usage of "StorageTargets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            StorageTargetData data = new StorageTargetData
            {
                Junctions = {new NamespaceJunction
{
NamespacePath = "/blobnfs",
}},
                TargetType = StorageTargetType.BlobNfs,
                BlobNfs = new BlobNfsTarget
                {
                    Target = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scgroup/providers/Microsoft.Storage/storageAccounts/blofnfs/blobServices/default/containers/blobnfs"),
                    UsageModel = "READ_WRITE",
                    VerificationDelayInSeconds = 28800,
                    WriteBackDelayInSeconds = 3600,
                },
            };
            ArmOperation<StorageTargetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageTargetName, data);
            StorageTargetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_StorageTargetsCreateOrUpdateNoJunctions()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_CreateOrUpdate_NoJunctions.json
            // this example is just showing the usage of "StorageTargets_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            StorageTargetData data = new StorageTargetData
            {
                TargetType = StorageTargetType.Nfs3,
                Nfs3 = new Nfs3Target
                {
                    Target = "10.0.44.44",
                    UsageModel = "READ_ONLY",
                    VerificationDelayInSeconds = 30,
                },
            };
            ArmOperation<StorageTargetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, storageTargetName, data);
            StorageTargetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_StorageTargetsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_Get.json
            // this example is just showing the usage of "StorageTargets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            StorageTargetResource result = await collection.GetAsync(storageTargetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StorageTargetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_StorageTargetsList()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_ListByCache.json
            // this example is just showing the usage of "StorageTargets_ListByCache" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation and iterate over the result
            await foreach (StorageTargetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageTargetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_StorageTargetsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_Get.json
            // this example is just showing the usage of "StorageTargets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            bool result = await collection.ExistsAsync(storageTargetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_StorageTargetsGet()
        {
            // Generated from example definition: specification/storagecache/resource-manager/Microsoft.StorageCache/stable/2024-03-01/examples/StorageTargets_Get.json
            // this example is just showing the usage of "StorageTargets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StorageCacheResource created on azure
            // for more information of creating StorageCacheResource, please refer to the document of StorageCacheResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "scgroup";
            string cacheName = "sc1";
            ResourceIdentifier storageCacheResourceId = StorageCacheResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            StorageCacheResource storageCache = client.GetStorageCacheResource(storageCacheResourceId);

            // get the collection of this StorageTargetResource
            StorageTargetCollection collection = storageCache.GetStorageTargets();

            // invoke the operation
            string storageTargetName = "st1";
            NullableResponse<StorageTargetResource> response = await collection.GetIfExistsAsync(storageTargetName);
            StorageTargetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StorageTargetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
