// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Properties of column in sync group table.
/// </summary>
public partial class SyncGroupSchemaTableColumn : ProvisionableConstruct
{
    /// <summary>
    /// Quoted name of sync group table column.
    /// </summary>
    public BicepValue<string> QuotedName 
    {
        get { Initialize(); return _quotedName!; }
        set { Initialize(); _quotedName!.Assign(value); }
    }
    private BicepValue<string>? _quotedName;

    /// <summary>
    /// Data size of the column.
    /// </summary>
    public BicepValue<string> DataSize 
    {
        get { Initialize(); return _dataSize!; }
        set { Initialize(); _dataSize!.Assign(value); }
    }
    private BicepValue<string>? _dataSize;

    /// <summary>
    /// Data type of the column.
    /// </summary>
    public BicepValue<string> DataType 
    {
        get { Initialize(); return _dataType!; }
        set { Initialize(); _dataType!.Assign(value); }
    }
    private BicepValue<string>? _dataType;

    /// <summary>
    /// Creates a new SyncGroupSchemaTableColumn.
    /// </summary>
    public SyncGroupSchemaTableColumn()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SyncGroupSchemaTableColumn.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _quotedName = DefineProperty<string>("QuotedName", ["quotedName"]);
        _dataSize = DefineProperty<string>("DataSize", ["dataSize"]);
        _dataType = DefineProperty<string>("DataType", ["dataType"]);
    }
}
