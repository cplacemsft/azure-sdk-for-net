// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSession
    {
        internal static SparkSession DeserializeSparkSession(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkSessionState livyInfo = default;
            string name = default;
            string workspaceName = default;
            string sparkPoolName = default;
            string submitterName = default;
            string submitterId = default;
            string artifactId = default;
            SparkJobType? jobType = default;
            SparkSessionResultType? result = default;
            SparkScheduler schedulerInfo = default;
            SparkServicePlugin pluginInfo = default;
            IReadOnlyList<SparkServiceError> errorInfo = default;
            IReadOnlyDictionary<string, string> tags = default;
            int id = default;
            string appId = default;
            IReadOnlyDictionary<string, string> appInfo = default;
            LivyStates? state = default;
            IReadOnlyList<string> log = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("livyInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    livyInfo = SparkSessionState.DeserializeSparkSessionState(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceName"u8))
                {
                    workspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkPoolName"u8))
                {
                    sparkPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterName"u8))
                {
                    submitterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("submitterId"u8))
                {
                    submitterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobType = new SparkJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = new SparkSessionResultType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulerInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schedulerInfo = SparkScheduler.DeserializeSparkScheduler(property.Value);
                    continue;
                }
                if (property.NameEquals("pluginInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pluginInfo = SparkServicePlugin.DeserializeSparkServicePlugin(property.Value);
                    continue;
                }
                if (property.NameEquals("errorInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkServiceError> array = new List<SparkServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkServiceError.DeserializeSparkServiceError(item));
                    }
                    errorInfo = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        appId = null;
                        continue;
                    }
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    appInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new LivyStates(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("log"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    log = array;
                    continue;
                }
            }
            return new SparkSession(
                livyInfo,
                name,
                workspaceName,
                sparkPoolName,
                submitterName,
                submitterId,
                artifactId,
                jobType,
                result,
                schedulerInfo,
                pluginInfo,
                errorInfo ?? new ChangeTrackingList<SparkServiceError>(),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                id,
                appId,
                appInfo ?? new ChangeTrackingDictionary<string, string>(),
                state,
                log ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SparkSession FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeSparkSession(document.RootElement);
        }
    }
}
