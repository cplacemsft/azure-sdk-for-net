// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteBackupResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetWebAppBackup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/GetWebAppBackup.json
            // this example is just showing the usage of "WebApps_GetBackupStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteBackupResource created on azure
            // for more information of creating SiteBackupResource, please refer to the document of SiteBackupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "sitef6141";
            string backupId = "12345";
            ResourceIdentifier siteBackupResourceId = SiteBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, backupId);
            SiteBackupResource siteBackup = client.GetSiteBackupResource(siteBackupResourceId);

            // invoke the operation
            SiteBackupResource result = await siteBackup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteWebAppBackup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/DeleteWebAppBackup.json
            // this example is just showing the usage of "WebApps_DeleteBackup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteBackupResource created on azure
            // for more information of creating SiteBackupResource, please refer to the document of SiteBackupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "sitef6141";
            string backupId = "12345";
            ResourceIdentifier siteBackupResourceId = SiteBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, backupId);
            SiteBackupResource siteBackup = client.GetSiteBackupResource(siteBackupResourceId);

            // invoke the operation
            await siteBackup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBackupStatusSecrets_GetWebAppBackupWithSecrets()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/GetWebAppBackupWithSecrets.json
            // this example is just showing the usage of "WebApps_ListBackupStatusSecrets" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteBackupResource created on azure
            // for more information of creating SiteBackupResource, please refer to the document of SiteBackupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "sitef6141";
            string backupId = "12345";
            ResourceIdentifier siteBackupResourceId = SiteBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, backupId);
            SiteBackupResource siteBackup = client.GetSiteBackupResource(siteBackupResourceId);

            // invoke the operation
            WebAppBackupInfo info = new WebAppBackupInfo
            {
                BackupName = "abcdwe",
                IsEnabled = true,
                StorageAccountUri = new Uri("DefaultEndpointsProtocol=https;AccountName=storagesample;AccountKey=<account-key>"),
                BackupSchedule = new WebAppBackupSchedule(7, BackupFrequencyUnit.Day, true, 30)
                {
                    StartOn = DateTimeOffset.Parse("2022-09-02T17:33:11.641Z"),
                },
                Databases = {new AppServiceDatabaseBackupSetting(AppServiceDatabaseType.SqlAzure)
{
Name = "backenddb",
ConnectionStringName = "backend",
ConnectionString = "DSN=data-source-name[;SERVER=value] [;PWD=value] [;UID=value] [;<Attribute>=<value>]",
}, new AppServiceDatabaseBackupSetting(AppServiceDatabaseType.SqlAzure)
{
Name = "statsdb",
ConnectionStringName = "stats",
ConnectionString = "DSN=data-source-name[;SERVER=value] [;PWD=value] [;UID=value] [;<Attribute>=<value>]",
}},
            };
            SiteBackupResource result = await siteBackup.GetBackupStatusSecretsAsync(info);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebAppBackupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Restore_RestoreWebAppFromBackup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/RestoreWebAppBackup.json
            // this example is just showing the usage of "WebApps_Restore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteBackupResource created on azure
            // for more information of creating SiteBackupResource, please refer to the document of SiteBackupResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "sitef6141";
            string backupId = "123244";
            ResourceIdentifier siteBackupResourceId = SiteBackupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, backupId);
            SiteBackupResource siteBackup = client.GetSiteBackupResource(siteBackupResourceId);

            // invoke the operation
            RestoreRequestInfo info = new RestoreRequestInfo
            {
                StorageAccountUri = new Uri("DefaultEndpointsProtocol=https;AccountName=storagesample;AccountKey=<account-key>"),
                CanOverwrite = true,
                SiteName = "sitef6141",
                Databases = {new AppServiceDatabaseBackupSetting(AppServiceDatabaseType.SqlAzure)
{
Name = "backenddb",
ConnectionStringName = "backend",
ConnectionString = "DSN=data-source-name[;SERVER=value] [;PWD=value] [;UID=value] [;<Attribute>=<value>]",
}, new AppServiceDatabaseBackupSetting(AppServiceDatabaseType.SqlAzure)
{
Name = "statsdb",
ConnectionStringName = "stats",
ConnectionString = "DSN=data-source-name[;SERVER=value] [;PWD=value] [;UID=value] [;<Attribute>=<value>]",
}},
            };
            await siteBackup.RestoreAsync(WaitUntil.Completed, info);

            Console.WriteLine("Succeeded");
        }
    }
}
