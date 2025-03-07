// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute
{
    public partial class MachineRunCommandData : IUtf8JsonSerializable, IJsonModel<MachineRunCommandData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineRunCommandData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineRunCommandData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineRunCommandData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source, options);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ProtectedParameters))
            {
                writer.WritePropertyName("protectedParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AsyncExecution))
            {
                writer.WritePropertyName("asyncExecution"u8);
                writer.WriteBooleanValue(AsyncExecution.Value);
            }
            if (Optional.IsDefined(RunAsUser))
            {
                writer.WritePropertyName("runAsUser"u8);
                writer.WriteStringValue(RunAsUser);
            }
            if (Optional.IsDefined(RunAsPassword))
            {
                writer.WritePropertyName("runAsPassword"u8);
                writer.WriteStringValue(RunAsPassword);
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                writer.WritePropertyName("timeoutInSeconds"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(OutputBlobUri))
            {
                writer.WritePropertyName("outputBlobUri"u8);
                writer.WriteStringValue(OutputBlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ErrorBlobUri))
            {
                writer.WritePropertyName("errorBlobUri"u8);
                writer.WriteStringValue(ErrorBlobUri.AbsoluteUri);
            }
            if (Optional.IsDefined(OutputBlobManagedIdentity))
            {
                writer.WritePropertyName("outputBlobManagedIdentity"u8);
                writer.WriteObjectValue(OutputBlobManagedIdentity, options);
            }
            if (Optional.IsDefined(ErrorBlobManagedIdentity))
            {
                writer.WritePropertyName("errorBlobManagedIdentity"u8);
                writer.WriteObjectValue(ErrorBlobManagedIdentity, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceView))
            {
                writer.WritePropertyName("instanceView"u8);
                writer.WriteObjectValue(InstanceView, options);
            }
            writer.WriteEndObject();
        }

        MachineRunCommandData IJsonModel<MachineRunCommandData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineRunCommandData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineRunCommandData(document.RootElement, options);
        }

        internal static MachineRunCommandData DeserializeMachineRunCommandData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            MachineRunCommandScriptSource source = default;
            IList<RunCommandInputParameter> parameters = default;
            IList<RunCommandInputParameter> protectedParameters = default;
            bool? asyncExecution = default;
            string runAsUser = default;
            string runAsPassword = default;
            int? timeoutInSeconds = default;
            Uri outputBlobUri = default;
            Uri errorBlobUri = default;
            RunCommandManagedIdentity outputBlobManagedIdentity = default;
            RunCommandManagedIdentity errorBlobManagedIdentity = default;
            string provisioningState = default;
            MachineRunCommandInstanceView instanceView = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = MachineRunCommandScriptSource.DeserializeMachineRunCommandScriptSource(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            parameters = array;
                            continue;
                        }
                        if (property0.NameEquals("protectedParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RunCommandInputParameter> array = new List<RunCommandInputParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RunCommandInputParameter.DeserializeRunCommandInputParameter(item, options));
                            }
                            protectedParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("asyncExecution"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asyncExecution = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("runAsUser"u8))
                        {
                            runAsUser = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("runAsPassword"u8))
                        {
                            runAsPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeoutInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeoutInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("outputBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errorBlobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("outputBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            outputBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("errorBlobManagedIdentity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorBlobManagedIdentity = RunCommandManagedIdentity.DeserializeRunCommandManagedIdentity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceView = MachineRunCommandInstanceView.DeserializeMachineRunCommandInstanceView(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineRunCommandData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                source,
                parameters ?? new ChangeTrackingList<RunCommandInputParameter>(),
                protectedParameters ?? new ChangeTrackingList<RunCommandInputParameter>(),
                asyncExecution,
                runAsUser,
                runAsPassword,
                timeoutInSeconds,
                outputBlobUri,
                errorBlobUri,
                outputBlobManagedIdentity,
                errorBlobManagedIdentity,
                provisioningState,
                instanceView,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  location: ");
                builder.AppendLine($"'{Location.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Tags))
                {
                    if (Tags.Any())
                    {
                        builder.Append("  tags: ");
                        builder.AppendLine("{");
                        foreach (var item in Tags)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Source), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    source: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Source))
                {
                    builder.Append("    source: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Source, options, 4, false, "    source: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Parameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    parameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Parameters))
                {
                    if (Parameters.Any())
                    {
                        builder.Append("    parameters: ");
                        builder.AppendLine("[");
                        foreach (var item in Parameters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    parameters: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProtectedParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    protectedParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ProtectedParameters))
                {
                    if (ProtectedParameters.Any())
                    {
                        builder.Append("    protectedParameters: ");
                        builder.AppendLine("[");
                        foreach (var item in ProtectedParameters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 6, true, "    protectedParameters: ");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AsyncExecution), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    asyncExecution: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AsyncExecution))
                {
                    builder.Append("    asyncExecution: ");
                    var boolValue = AsyncExecution.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunAsUser), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    runAsUser: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunAsUser))
                {
                    builder.Append("    runAsUser: ");
                    if (RunAsUser.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunAsUser}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunAsUser}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunAsPassword), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    runAsPassword: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunAsPassword))
                {
                    builder.Append("    runAsPassword: ");
                    if (RunAsPassword.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunAsPassword}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunAsPassword}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    timeoutInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("    timeoutInSeconds: ");
                    builder.AppendLine($"{TimeoutInSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutputBlobUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    outputBlobUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OutputBlobUri))
                {
                    builder.Append("    outputBlobUri: ");
                    builder.AppendLine($"'{OutputBlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorBlobUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    errorBlobUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ErrorBlobUri))
                {
                    builder.Append("    errorBlobUri: ");
                    builder.AppendLine($"'{ErrorBlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutputBlobManagedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    outputBlobManagedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OutputBlobManagedIdentity))
                {
                    builder.Append("    outputBlobManagedIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, OutputBlobManagedIdentity, options, 4, false, "    outputBlobManagedIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ErrorBlobManagedIdentity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    errorBlobManagedIdentity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ErrorBlobManagedIdentity))
                {
                    builder.Append("    errorBlobManagedIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ErrorBlobManagedIdentity, options, 4, false, "    errorBlobManagedIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("    provisioningState: ");
                    if (ProvisioningState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProvisioningState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProvisioningState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceView), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    instanceView: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceView))
                {
                    builder.Append("    instanceView: ");
                    BicepSerializationHelpers.AppendChildObject(builder, InstanceView, options, 4, false, "    instanceView: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineRunCommandData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineRunCommandData)} does not support writing '{options.Format}' format.");
            }
        }

        MachineRunCommandData IPersistableModel<MachineRunCommandData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineRunCommandData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineRunCommandData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineRunCommandData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineRunCommandData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
