// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ExecutionActivity : IUtf8JsonSerializable, IJsonModel<ExecutionActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecutionActivity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExecutionActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionActivity)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName"u8);
                JsonSerializer.Serialize(writer, LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy"u8);
                writer.WriteObjectValue(Policy, options);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }

        ExecutionActivity IJsonModel<ExecutionActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionActivity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecutionActivity(document.RootElement, options);
        }

        internal static ExecutionActivity DeserializeExecutionActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureDataExplorerCommand": return AzureDataExplorerCommandActivity.DeserializeAzureDataExplorerCommandActivity(element, options);
                    case "AzureFunctionActivity": return AzureFunctionActivity.DeserializeAzureFunctionActivity(element, options);
                    case "AzureMLBatchExecution": return AzureMLBatchExecutionActivity.DeserializeAzureMLBatchExecutionActivity(element, options);
                    case "AzureMLExecutePipeline": return AzureMLExecutePipelineActivity.DeserializeAzureMLExecutePipelineActivity(element, options);
                    case "AzureMLUpdateResource": return AzureMLUpdateResourceActivity.DeserializeAzureMLUpdateResourceActivity(element, options);
                    case "Copy": return CopyActivity.DeserializeCopyActivity(element, options);
                    case "Custom": return CustomActivity.DeserializeCustomActivity(element, options);
                    case "DatabricksNotebook": return DatabricksNotebookActivity.DeserializeDatabricksNotebookActivity(element, options);
                    case "DatabricksSparkJar": return DatabricksSparkJarActivity.DeserializeDatabricksSparkJarActivity(element, options);
                    case "DatabricksSparkPython": return DatabricksSparkPythonActivity.DeserializeDatabricksSparkPythonActivity(element, options);
                    case "DataLakeAnalyticsU-SQL": return DataLakeAnalyticsUsqlActivity.DeserializeDataLakeAnalyticsUsqlActivity(element, options);
                    case "Delete": return DeleteActivity.DeserializeDeleteActivity(element, options);
                    case "ExecuteDataFlow": return ExecuteDataFlowActivity.DeserializeExecuteDataFlowActivity(element, options);
                    case "ExecuteSSISPackage": return ExecuteSsisPackageActivity.DeserializeExecuteSsisPackageActivity(element, options);
                    case "GetMetadata": return GetDatasetMetadataActivity.DeserializeGetDatasetMetadataActivity(element, options);
                    case "HDInsightHive": return HDInsightHiveActivity.DeserializeHDInsightHiveActivity(element, options);
                    case "HDInsightMapReduce": return HDInsightMapReduceActivity.DeserializeHDInsightMapReduceActivity(element, options);
                    case "HDInsightPig": return HDInsightPigActivity.DeserializeHDInsightPigActivity(element, options);
                    case "HDInsightSpark": return HDInsightSparkActivity.DeserializeHDInsightSparkActivity(element, options);
                    case "HDInsightStreaming": return HDInsightStreamingActivity.DeserializeHDInsightStreamingActivity(element, options);
                    case "Lookup": return LookupActivity.DeserializeLookupActivity(element, options);
                    case "Script": return DataFactoryScriptActivity.DeserializeDataFactoryScriptActivity(element, options);
                    case "SparkJob": return SynapseSparkJobDefinitionActivity.DeserializeSynapseSparkJobDefinitionActivity(element, options);
                    case "SqlServerStoredProcedure": return SqlServerStoredProcedureActivity.DeserializeSqlServerStoredProcedureActivity(element, options);
                    case "SynapseNotebook": return SynapseNotebookActivity.DeserializeSynapseNotebookActivity(element, options);
                    case "WebActivity": return WebActivity.DeserializeWebActivity(element, options);
                }
            }
            DataFactoryLinkedServiceReference linkedServiceName = default;
            PipelineActivityPolicy policy = default;
            string name = default;
            string type = "Execution";
            string description = default;
            PipelineActivityState? state = default;
            ActivityOnInactiveMarkAs? onInactiveMarkAs = default;
            IList<PipelineActivityDependency> dependsOn = default;
            IList<PipelineActivityUserProperty> userProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedServiceName = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("policy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policy = PipelineActivityPolicy.DeserializePipelineActivityPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new PipelineActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityDependency> array = new List<PipelineActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityDependency.DeserializePipelineActivityDependency(item, options));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PipelineActivityUserProperty> array = new List<PipelineActivityUserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineActivityUserProperty.DeserializePipelineActivityUserProperty(item, options));
                    }
                    userProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ExecutionActivity(
                name,
                type,
                description,
                state,
                onInactiveMarkAs,
                dependsOn ?? new ChangeTrackingList<PipelineActivityDependency>(),
                userProperties ?? new ChangeTrackingList<PipelineActivityUserProperty>(),
                additionalProperties,
                linkedServiceName,
                policy);
        }

        BinaryData IPersistableModel<ExecutionActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecutionActivity)} does not support writing '{options.Format}' format.");
            }
        }

        ExecutionActivity IPersistableModel<ExecutionActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExecutionActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecutionActivity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecutionActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
