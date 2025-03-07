// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Details of a hostname derived from a domain.
/// </summary>
public partial class AppServiceHostName : ProvisionableConstruct
{
    /// <summary>
    /// Name of the hostname.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// List of apps the hostname is assigned to. This list will have more than
    /// one app only if the hostname is pointing to a Traffic Manager.
    /// </summary>
    public BicepList<string> SiteNames 
    {
        get { Initialize(); return _siteNames!; }
    }
    private BicepList<string>? _siteNames;

    /// <summary>
    /// Name of the Azure resource the hostname is assigned to. If it is
    /// assigned to a Traffic Manager then it will be the Traffic Manager name
    /// otherwise it will be the app name.
    /// </summary>
    public BicepValue<string> AzureResourceName 
    {
        get { Initialize(); return _azureResourceName!; }
    }
    private BicepValue<string>? _azureResourceName;

    /// <summary>
    /// Type of the Azure resource the hostname is assigned to.
    /// </summary>
    public BicepValue<AppServiceResourceType> AzureResourceType 
    {
        get { Initialize(); return _azureResourceType!; }
    }
    private BicepValue<AppServiceResourceType>? _azureResourceType;

    /// <summary>
    /// Type of the DNS record.
    /// </summary>
    public BicepValue<CustomHostNameDnsRecordType> CustomHostNameDnsRecordType 
    {
        get { Initialize(); return _customHostNameDnsRecordType!; }
    }
    private BicepValue<CustomHostNameDnsRecordType>? _customHostNameDnsRecordType;

    /// <summary>
    /// Type of the hostname.
    /// </summary>
    public BicepValue<AppServiceHostNameType> HostNameType 
    {
        get { Initialize(); return _hostNameType!; }
    }
    private BicepValue<AppServiceHostNameType>? _hostNameType;

    /// <summary>
    /// Creates a new AppServiceHostName.
    /// </summary>
    public AppServiceHostName()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppServiceHostName.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _siteNames = DefineListProperty<string>("SiteNames", ["siteNames"], isOutput: true);
        _azureResourceName = DefineProperty<string>("AzureResourceName", ["azureResourceName"], isOutput: true);
        _azureResourceType = DefineProperty<AppServiceResourceType>("AzureResourceType", ["azureResourceType"], isOutput: true);
        _customHostNameDnsRecordType = DefineProperty<CustomHostNameDnsRecordType>("CustomHostNameDnsRecordType", ["customHostNameDnsRecordType"], isOutput: true);
        _hostNameType = DefineProperty<AppServiceHostNameType>("HostNameType", ["hostNameType"], isOutput: true);
    }
}
