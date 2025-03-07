// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Notebook resource type. </summary>
    public partial class NotebookResource
    {
        /// <summary> Initializes a new instance of <see cref="NotebookResource"/>. </summary>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="properties"> Properties of Notebook. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public NotebookResource(string name, Notebook properties)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(properties, nameof(properties));

            Name = name;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="NotebookResource"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="etag"> Resource Etag. </param>
        /// <param name="properties"> Properties of Notebook. </param>
        internal NotebookResource(string id, string name, string type, string etag, Notebook properties)
        {
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
            Properties = properties;
        }

        /// <summary> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </summary>
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </summary>
        public string Type { get; }
        /// <summary> Resource Etag. </summary>
        public string Etag { get; }
        /// <summary> Properties of Notebook. </summary>
        public Notebook Properties { get; set; }
    }
}
