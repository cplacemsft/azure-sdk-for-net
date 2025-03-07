// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Profile of network configuration.             Serialized Name:
/// ContainerServiceNetworkProfile
/// </summary>
public partial class ContainerServiceNetworkProfile : ProvisionableConstruct
{
    /// <summary>
    /// Network plugin used for building the Kubernetes network.
    /// </summary>
    public BicepValue<ContainerServiceNetworkPlugin> NetworkPlugin 
    {
        get { Initialize(); return _networkPlugin!; }
        set { Initialize(); _networkPlugin!.Assign(value); }
    }
    private BicepValue<ContainerServiceNetworkPlugin>? _networkPlugin;

    /// <summary>
    /// The mode the network plugin should use.
    /// </summary>
    public BicepValue<ContainerServiceNetworkPluginMode> NetworkPluginMode 
    {
        get { Initialize(); return _networkPluginMode!; }
        set { Initialize(); _networkPluginMode!.Assign(value); }
    }
    private BicepValue<ContainerServiceNetworkPluginMode>? _networkPluginMode;

    /// <summary>
    /// Network policy used for building the Kubernetes network.
    /// </summary>
    public BicepValue<ContainerServiceNetworkPolicy> NetworkPolicy 
    {
        get { Initialize(); return _networkPolicy!; }
        set { Initialize(); _networkPolicy!.Assign(value); }
    }
    private BicepValue<ContainerServiceNetworkPolicy>? _networkPolicy;

    /// <summary>
    /// This cannot be specified if networkPlugin is anything other than
    /// &apos;azure&apos;.
    /// </summary>
    public BicepValue<ContainerServiceNetworkMode> NetworkMode 
    {
        get { Initialize(); return _networkMode!; }
        set { Initialize(); _networkMode!.Assign(value); }
    }
    private BicepValue<ContainerServiceNetworkMode>? _networkMode;

    /// <summary>
    /// Network dataplane used in the Kubernetes cluster.
    /// </summary>
    public BicepValue<NetworkDataplane> NetworkDataplane 
    {
        get { Initialize(); return _networkDataplane!; }
        set { Initialize(); _networkDataplane!.Assign(value); }
    }
    private BicepValue<NetworkDataplane>? _networkDataplane;

    /// <summary>
    /// A CIDR notation IP range from which to assign pod IPs when kubenet is
    /// used.
    /// </summary>
    public BicepValue<string> PodCidr 
    {
        get { Initialize(); return _podCidr!; }
        set { Initialize(); _podCidr!.Assign(value); }
    }
    private BicepValue<string>? _podCidr;

    /// <summary>
    /// A CIDR notation IP range from which to assign service cluster IPs. It
    /// must not overlap with any Subnet IP ranges.
    /// </summary>
    public BicepValue<string> ServiceCidr 
    {
        get { Initialize(); return _serviceCidr!; }
        set { Initialize(); _serviceCidr!.Assign(value); }
    }
    private BicepValue<string>? _serviceCidr;

    /// <summary>
    /// An IP address assigned to the Kubernetes DNS service. It must be within
    /// the Kubernetes service address range specified in serviceCidr.
    /// </summary>
    public BicepValue<string> DnsServiceIP 
    {
        get { Initialize(); return _dnsServiceIP!; }
        set { Initialize(); _dnsServiceIP!.Assign(value); }
    }
    private BicepValue<string>? _dnsServiceIP;

    /// <summary>
    /// This can only be set at cluster creation time and cannot be changed
    /// later. For more information see [egress outbound
    /// type](https://docs.microsoft.com/azure/aks/egress-outboundtype).
    /// </summary>
    public BicepValue<ContainerServiceOutboundType> OutboundType 
    {
        get { Initialize(); return _outboundType!; }
        set { Initialize(); _outboundType!.Assign(value); }
    }
    private BicepValue<ContainerServiceOutboundType>? _outboundType;

    /// <summary>
    /// The default is &apos;standard&apos;. See [Azure Load Balancer
    /// SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more
    /// information about the differences between load balancer SKUs.
    /// </summary>
    public BicepValue<ContainerServiceLoadBalancerSku> LoadBalancerSku 
    {
        get { Initialize(); return _loadBalancerSku!; }
        set { Initialize(); _loadBalancerSku!.Assign(value); }
    }
    private BicepValue<ContainerServiceLoadBalancerSku>? _loadBalancerSku;

    /// <summary>
    /// Profile of the cluster load balancer.
    /// </summary>
    public ManagedClusterLoadBalancerProfile LoadBalancerProfile 
    {
        get { Initialize(); return _loadBalancerProfile!; }
        set { Initialize(); AssignOrReplace(ref _loadBalancerProfile, value); }
    }
    private ManagedClusterLoadBalancerProfile? _loadBalancerProfile;

    /// <summary>
    /// Profile of the cluster NAT gateway.
    /// </summary>
    public ManagedClusterNatGatewayProfile NatGatewayProfile 
    {
        get { Initialize(); return _natGatewayProfile!; }
        set { Initialize(); AssignOrReplace(ref _natGatewayProfile, value); }
    }
    private ManagedClusterNatGatewayProfile? _natGatewayProfile;

    /// <summary>
    /// One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one
    /// for each IP family (IPv4/IPv6), is expected for dual-stack networking.
    /// </summary>
    public BicepList<string> PodCidrs 
    {
        get { Initialize(); return _podCidrs!; }
        set { Initialize(); _podCidrs!.Assign(value); }
    }
    private BicepList<string>? _podCidrs;

    /// <summary>
    /// One IPv4 CIDR is expected for single-stack networking. Two CIDRs, one
    /// for each IP family (IPv4/IPv6), is expected for dual-stack networking.
    /// They must not overlap with any Subnet IP ranges.
    /// </summary>
    public BicepList<string> ServiceCidrs 
    {
        get { Initialize(); return _serviceCidrs!; }
        set { Initialize(); _serviceCidrs!.Assign(value); }
    }
    private BicepList<string>? _serviceCidrs;

    /// <summary>
    /// IP families are used to determine single-stack or dual-stack clusters.
    /// For single-stack, the expected value is IPv4. For dual-stack, the
    /// expected values are IPv4 and IPv6.
    /// </summary>
    public BicepList<IPFamily> IPFamilies 
    {
        get { Initialize(); return _iPFamilies!; }
        set { Initialize(); _iPFamilies!.Assign(value); }
    }
    private BicepList<IPFamily>? _iPFamilies;

    /// <summary>
    /// Creates a new ContainerServiceNetworkProfile.
    /// </summary>
    public ContainerServiceNetworkProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerServiceNetworkProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _networkPlugin = DefineProperty<ContainerServiceNetworkPlugin>("NetworkPlugin", ["networkPlugin"]);
        _networkPluginMode = DefineProperty<ContainerServiceNetworkPluginMode>("NetworkPluginMode", ["networkPluginMode"]);
        _networkPolicy = DefineProperty<ContainerServiceNetworkPolicy>("NetworkPolicy", ["networkPolicy"]);
        _networkMode = DefineProperty<ContainerServiceNetworkMode>("NetworkMode", ["networkMode"]);
        _networkDataplane = DefineProperty<NetworkDataplane>("NetworkDataplane", ["networkDataplane"]);
        _podCidr = DefineProperty<string>("PodCidr", ["podCidr"]);
        _serviceCidr = DefineProperty<string>("ServiceCidr", ["serviceCidr"]);
        _dnsServiceIP = DefineProperty<string>("DnsServiceIP", ["dnsServiceIP"]);
        _outboundType = DefineProperty<ContainerServiceOutboundType>("OutboundType", ["outboundType"]);
        _loadBalancerSku = DefineProperty<ContainerServiceLoadBalancerSku>("LoadBalancerSku", ["loadBalancerSku"]);
        _loadBalancerProfile = DefineModelProperty<ManagedClusterLoadBalancerProfile>("LoadBalancerProfile", ["loadBalancerProfile"]);
        _natGatewayProfile = DefineModelProperty<ManagedClusterNatGatewayProfile>("NatGatewayProfile", ["natGatewayProfile"]);
        _podCidrs = DefineListProperty<string>("PodCidrs", ["podCidrs"]);
        _serviceCidrs = DefineListProperty<string>("ServiceCidrs", ["serviceCidrs"]);
        _iPFamilies = DefineListProperty<IPFamily>("IPFamilies", ["ipFamilies"]);
    }
}
