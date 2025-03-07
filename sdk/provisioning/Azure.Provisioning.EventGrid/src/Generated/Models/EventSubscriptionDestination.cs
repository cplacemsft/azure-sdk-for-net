// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the destination for an event subscription.
/// Please note
/// Azure.ResourceManager.EventGrid.Models.EventSubscriptionDestination is the
/// base class. According to the scenario, a derived class of the base class
/// might need to be assigned here, or this property needs to be casted to one
/// of the possible derived classes.             The available derived classes
/// include
/// Azure.ResourceManager.EventGrid.Models.AzureFunctionEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.EventHubEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.HybridConnectionEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.MonitorAlertEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.NamespaceTopicEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.PartnerEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.ServiceBusQueueEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.ServiceBusTopicEventSubscriptionDestination,
/// Azure.ResourceManager.EventGrid.Models.StorageQueueEventSubscriptionDestination
/// and
/// Azure.ResourceManager.EventGrid.Models.WebHookEventSubscriptionDestination.
/// </summary>
public partial class EventSubscriptionDestination : ProvisionableConstruct
{
    /// <summary>
    /// Creates a new EventSubscriptionDestination.
    /// </summary>
    public EventSubscriptionDestination()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of EventSubscriptionDestination.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
    }
}
