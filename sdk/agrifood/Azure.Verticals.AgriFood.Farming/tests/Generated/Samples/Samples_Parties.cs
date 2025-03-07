// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Verticals.AgriFood.Farming.Samples
{
    public partial class Samples_Parties
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetParty_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.GetParty("<partyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetParty_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.GetPartyAsync("<partyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetParty_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.GetParty("<partyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetParty_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.GetPartyAsync("<partyId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.CreateOrUpdate("<partyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.CreateOrUpdateAsync("<partyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateOrUpdate_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            using RequestContent content = RequestContent.Create(new
            {
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = client.CreateOrUpdate("<partyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateOrUpdate_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            using RequestContent content = RequestContent.Create(new
            {
                status = "<status>",
                source = "<source>",
                name = "<name>",
                description = "<description>",
                properties = new
                {
                    key = new object(),
                },
            });
            Response response = await client.CreateOrUpdateAsync("<partyId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("eTag").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
            Console.WriteLine(result.GetProperty("source").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
            Console.WriteLine(result.GetProperty("description").ToString());
            Console.WriteLine(result.GetProperty("createdBy").ToString());
            Console.WriteLine(result.GetProperty("modifiedBy").ToString());
            Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.Delete("<partyId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.DeleteAsync("<partyId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Delete_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.Delete("<partyId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Delete_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.DeleteAsync("<partyId>");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetCascadeDeleteJobDetails_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = client.GetCascadeDeleteJobDetails("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetCascadeDeleteJobDetails_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Response response = await client.GetCascadeDeleteJobDetailsAsync("<jobId>", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetParties_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            foreach (BinaryData item in client.GetParties(null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetParties_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            await foreach (BinaryData item in client.GetPartiesAsync(null, null, null, null, null, null, null, null, null, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetParties_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            foreach (BinaryData item in client.GetParties(new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetParties_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            await foreach (BinaryData item in client.GetPartiesAsync(new string[] { "<ids>" }, new string[] { "<names>" }, new string[] { "<propertyFilters>" }, new string[] { "<statuses>" }, DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), DateTimeOffset.Parse("2022-05-10T18:57:31.2311892Z"), 1234, "<skipToken>", null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("id").ToString());
                Console.WriteLine(result.GetProperty("eTag").ToString());
                Console.WriteLine(result.GetProperty("status").ToString());
                Console.WriteLine(result.GetProperty("createdDateTime").ToString());
                Console.WriteLine(result.GetProperty("modifiedDateTime").ToString());
                Console.WriteLine(result.GetProperty("source").ToString());
                Console.WriteLine(result.GetProperty("name").ToString());
                Console.WriteLine(result.GetProperty("description").ToString());
                Console.WriteLine(result.GetProperty("createdBy").ToString());
                Console.WriteLine(result.GetProperty("modifiedBy").ToString());
                Console.WriteLine(result.GetProperty("properties").GetProperty("<key>").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CreateCascadeDeleteJob_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Operation<BinaryData> operation = client.CreateCascadeDeleteJob(WaitUntil.Completed, "<jobId>", "<partyId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CreateCascadeDeleteJob_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            Parties client = new FarmBeatsClient(endpoint, credential).GetPartiesClient();

            Operation<BinaryData> operation = await client.CreateCascadeDeleteJobAsync(WaitUntil.Completed, "<jobId>", "<partyId>", null);
            BinaryData responseData = operation.Value;

            JsonElement result = JsonDocument.Parse(responseData.ToStream()).RootElement;
            Console.WriteLine(result.GetProperty("partyId").ToString());
            Console.WriteLine(result.GetProperty("resourceId").ToString());
            Console.WriteLine(result.GetProperty("resourceType").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("durationInSeconds").ToString());
            Console.WriteLine(result.GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errorCode").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastActionDateTime").ToString());
            Console.WriteLine(result.GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("endTime").ToString());
        }
    }
}
