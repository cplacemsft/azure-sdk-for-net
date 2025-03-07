// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Describes the capabilities/features allowed for a specific SKU.
/// </summary>
public partial class AppServiceSkuCapability : ProvisionableConstruct
{
    /// <summary>
    /// Name of the SKU capability.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Value of the SKU capability.
    /// </summary>
    public BicepValue<string> Value 
    {
        get { Initialize(); return _value!; }
        set { Initialize(); _value!.Assign(value); }
    }
    private BicepValue<string>? _value;

    /// <summary>
    /// Reason of the SKU capability.
    /// </summary>
    public BicepValue<string> Reason 
    {
        get { Initialize(); return _reason!; }
        set { Initialize(); _reason!.Assign(value); }
    }
    private BicepValue<string>? _reason;

    /// <summary>
    /// Creates a new AppServiceSkuCapability.
    /// </summary>
    public AppServiceSkuCapability()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppServiceSkuCapability.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _value = DefineProperty<string>("Value", ["value"]);
        _reason = DefineProperty<string>("Reason", ["reason"]);
    }
}
