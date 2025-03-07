// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents information about the entity (such as Azure SQL table or CosmosDB collection) that will be indexed. </summary>
    public partial class SearchIndexerDataContainer
    {
        /// <summary> Initializes a new instance of <see cref="SearchIndexerDataContainer"/>. </summary>
        /// <param name="name"> The name of the table or view (for Azure SQL data source) or collection (for CosmosDB data source) that will be indexed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SearchIndexerDataContainer(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerDataContainer"/>. </summary>
        /// <param name="name"> The name of the table or view (for Azure SQL data source) or collection (for CosmosDB data source) that will be indexed. </param>
        /// <param name="query"> A query that is applied to this data container. The syntax and meaning of this parameter is datasource-specific. Not supported by Azure SQL datasources. </param>
        internal SearchIndexerDataContainer(string name, string query)
        {
            Name = name;
            Query = query;
        }

        /// <summary> The name of the table or view (for Azure SQL data source) or collection (for CosmosDB data source) that will be indexed. </summary>
        public string Name { get; set; }
        /// <summary> A query that is applied to this data container. The syntax and meaning of this parameter is datasource-specific. Not supported by Azure SQL datasources. </summary>
        public string Query { get; set; }
    }
}
