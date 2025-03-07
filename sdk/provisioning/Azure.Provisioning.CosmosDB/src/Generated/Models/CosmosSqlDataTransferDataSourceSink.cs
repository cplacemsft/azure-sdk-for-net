// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// A CosmosDB No Sql API data source/sink.
/// </summary>
public partial class CosmosSqlDataTransferDataSourceSink : BaseCosmosDataTransferDataSourceSink
{
    /// <summary>
    /// Gets or sets the database name.
    /// </summary>
    public BicepValue<string> DatabaseName 
    {
        get { Initialize(); return _databaseName!; }
        set { Initialize(); _databaseName!.Assign(value); }
    }
    private BicepValue<string>? _databaseName;

    /// <summary>
    /// Gets or sets the container name.
    /// </summary>
    public BicepValue<string> ContainerName 
    {
        get { Initialize(); return _containerName!; }
        set { Initialize(); _containerName!.Assign(value); }
    }
    private BicepValue<string>? _containerName;

    /// <summary>
    /// Creates a new CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    public CosmosSqlDataTransferDataSourceSink() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CosmosSqlDataTransferDataSourceSink.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        DefineProperty<string>("component", ["component"], defaultValue: "CosmosDBSql");
        _databaseName = DefineProperty<string>("DatabaseName", ["databaseName"]);
        _containerName = DefineProperty<string>("ContainerName", ["containerName"]);
    }
}
