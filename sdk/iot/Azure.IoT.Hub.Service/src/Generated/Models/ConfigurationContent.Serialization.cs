// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class ConfigurationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DeviceContent))
            {
                writer.WritePropertyName("deviceContent"u8);
                writer.WriteStartObject();
                foreach (var item in DeviceContent)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ModulesContent))
            {
                writer.WritePropertyName("modulesContent"u8);
                writer.WriteStartObject();
                foreach (var item in ModulesContent)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        if (item0.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteObjectValue<object>(item0.Value);
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ModuleContent))
            {
                writer.WritePropertyName("moduleContent"u8);
                writer.WriteStartObject();
                foreach (var item in ModuleContent)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue<object>(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ConfigurationContent DeserializeConfigurationContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, object> deviceContent = default;
            IDictionary<string, IDictionary<string, object>> modulesContent = default;
            IDictionary<string, object> moduleContent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deviceContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    deviceContent = dictionary;
                    continue;
                }
                if (property.NameEquals("modulesContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IDictionary<string, object>> dictionary = new Dictionary<string, IDictionary<string, object>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            Dictionary<string, object> dictionary0 = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary0.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary0.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            dictionary.Add(property0.Name, dictionary0);
                        }
                    }
                    modulesContent = dictionary;
                    continue;
                }
                if (property.NameEquals("moduleContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    moduleContent = dictionary;
                    continue;
                }
            }
            return new ConfigurationContent(deviceContent ?? new ChangeTrackingDictionary<string, object>(), modulesContent ?? new ChangeTrackingDictionary<string, IDictionary<string, object>>(), moduleContent ?? new ChangeTrackingDictionary<string, object>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConfigurationContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeConfigurationContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
