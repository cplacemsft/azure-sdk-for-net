// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(WorkspaceRepositoryConfigurationConverter))]
    public partial class WorkspaceRepositoryConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ProjectName))
            {
                writer.WritePropertyName("projectName"u8);
                writer.WriteStringValue(ProjectName);
            }
            if (Optional.IsDefined(RepositoryName))
            {
                writer.WritePropertyName("repositoryName"u8);
                writer.WriteStringValue(RepositoryName);
            }
            if (Optional.IsDefined(CollaborationBranch))
            {
                writer.WritePropertyName("collaborationBranch"u8);
                writer.WriteStringValue(CollaborationBranch);
            }
            if (Optional.IsDefined(RootFolder))
            {
                writer.WritePropertyName("rootFolder"u8);
                writer.WriteStringValue(RootFolder);
            }
            if (Optional.IsDefined(LastCommitId))
            {
                writer.WritePropertyName("lastCommitId"u8);
                writer.WriteStringValue(LastCommitId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteObjectValue(ClientSecret);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceRepositoryConfiguration DeserializeWorkspaceRepositoryConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string hostName = default;
            string accountName = default;
            string projectName = default;
            string repositoryName = default;
            string collaborationBranch = default;
            string rootFolder = default;
            string lastCommitId = default;
            Guid? tenantId = default;
            string clientId = default;
            GitHubClientSecret clientSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"u8))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"u8))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"u8))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"u8))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientSecret = GitHubClientSecret.DeserializeGitHubClientSecret(property.Value);
                    continue;
                }
            }
            return new WorkspaceRepositoryConfiguration(
                type,
                hostName,
                accountName,
                projectName,
                repositoryName,
                collaborationBranch,
                rootFolder,
                lastCommitId,
                tenantId,
                clientId,
                clientSecret);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WorkspaceRepositoryConfiguration FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWorkspaceRepositoryConfiguration(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class WorkspaceRepositoryConfigurationConverter : JsonConverter<WorkspaceRepositoryConfiguration>
        {
            public override void Write(Utf8JsonWriter writer, WorkspaceRepositoryConfiguration model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override WorkspaceRepositoryConfiguration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWorkspaceRepositoryConfiguration(document.RootElement);
            }
        }
    }
}
