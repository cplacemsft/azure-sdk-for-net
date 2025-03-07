// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingInvoiceSectionRoleAssignmentResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_BillingRoleAssignmentGetByInvoiceSection()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentGetByInvoiceSection.json
            // this example is just showing the usage of "BillingRoleAssignments_GetByInvoiceSection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingInvoiceSectionRoleAssignmentResource created on azure
            // for more information of creating BillingInvoiceSectionRoleAssignmentResource, please refer to the document of BillingInvoiceSectionRoleAssignmentResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "BKM6-54VH-BG7-PGB";
            string invoiceSectionName = "xxxx-xxxx-xxx-xxx";
            string billingRoleAssignmentName = "10000000-aaaa-bbbb-cccc-100000000000_6fd330f6-7d26-4aff-b9cf-7bd699f965b9";
            ResourceIdentifier billingInvoiceSectionRoleAssignmentResourceId = BillingInvoiceSectionRoleAssignmentResource.CreateResourceIdentifier(billingAccountName, billingProfileName, invoiceSectionName, billingRoleAssignmentName);
            BillingInvoiceSectionRoleAssignmentResource billingInvoiceSectionRoleAssignment = client.GetBillingInvoiceSectionRoleAssignmentResource(billingInvoiceSectionRoleAssignmentResourceId);

            // invoke the operation
            BillingInvoiceSectionRoleAssignmentResource result = await billingInvoiceSectionRoleAssignment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingRoleAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_BillingRoleAssignmentDeleteByInvoiceSection()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingRoleAssignmentDeleteByInvoiceSection.json
            // this example is just showing the usage of "BillingRoleAssignments_DeleteByInvoiceSection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingInvoiceSectionRoleAssignmentResource created on azure
            // for more information of creating BillingInvoiceSectionRoleAssignmentResource, please refer to the document of BillingInvoiceSectionRoleAssignmentResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2018-09-30";
            string billingProfileName = "BKM6-54VH-BG7-PGB";
            string invoiceSectionName = "xxxx-xxxx-xxx-xxx";
            string billingRoleAssignmentName = "10000000-aaaa-bbbb-cccc-100000000000_6fd330f6-7d26-4aff-b9cf-7bd699f965b9";
            ResourceIdentifier billingInvoiceSectionRoleAssignmentResourceId = BillingInvoiceSectionRoleAssignmentResource.CreateResourceIdentifier(billingAccountName, billingProfileName, invoiceSectionName, billingRoleAssignmentName);
            BillingInvoiceSectionRoleAssignmentResource billingInvoiceSectionRoleAssignment = client.GetBillingInvoiceSectionRoleAssignmentResource(billingInvoiceSectionRoleAssignmentResourceId);

            // invoke the operation
            await billingInvoiceSectionRoleAssignment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }
    }
}
