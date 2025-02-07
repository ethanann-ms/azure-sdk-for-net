// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A class representing the ActionGroup data model.
    /// An action group resource.
    /// </summary>
    public partial class ActionGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ActionGroupData. </summary>
        /// <param name="location"> The location. </param>
        public ActionGroupData(AzureLocation location) : base(location)
        {
            EmailReceivers = new ChangeTrackingList<MonitorEmailReceiver>();
            SmsReceivers = new ChangeTrackingList<MonitorSmsReceiver>();
            WebhookReceivers = new ChangeTrackingList<MonitorWebhookReceiver>();
            ItsmReceivers = new ChangeTrackingList<MonitorItsmReceiver>();
            AzureAppPushReceivers = new ChangeTrackingList<MonitorAzureAppPushReceiver>();
            AutomationRunbookReceivers = new ChangeTrackingList<MonitorAutomationRunbookReceiver>();
            VoiceReceivers = new ChangeTrackingList<MonitorVoiceReceiver>();
            LogicAppReceivers = new ChangeTrackingList<MonitorLogicAppReceiver>();
            AzureFunctionReceivers = new ChangeTrackingList<MonitorAzureFunctionReceiver>();
            ArmRoleReceivers = new ChangeTrackingList<MonitorArmRoleReceiver>();
            EventHubReceivers = new ChangeTrackingList<MonitorEventHubReceiver>();
        }

        /// <summary> Initializes a new instance of ActionGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="groupShortName"> The short name of the action group. This will be used in SMS messages. </param>
        /// <param name="isEnabled"> Indicates whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. </param>
        /// <param name="emailReceivers"> The list of email receivers that are part of this action group. </param>
        /// <param name="smsReceivers"> The list of SMS receivers that are part of this action group. </param>
        /// <param name="webhookReceivers"> The list of webhook receivers that are part of this action group. </param>
        /// <param name="itsmReceivers"> The list of ITSM receivers that are part of this action group. </param>
        /// <param name="azureAppPushReceivers"> The list of AzureAppPush receivers that are part of this action group. </param>
        /// <param name="automationRunbookReceivers"> The list of AutomationRunbook receivers that are part of this action group. </param>
        /// <param name="voiceReceivers"> The list of voice receivers that are part of this action group. </param>
        /// <param name="logicAppReceivers"> The list of logic app receivers that are part of this action group. </param>
        /// <param name="azureFunctionReceivers"> The list of azure function receivers that are part of this action group. </param>
        /// <param name="armRoleReceivers"> The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported. </param>
        /// <param name="eventHubReceivers"> The list of event hub receivers that are part of this action group. </param>
        internal ActionGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string groupShortName, bool? isEnabled, IList<MonitorEmailReceiver> emailReceivers, IList<MonitorSmsReceiver> smsReceivers, IList<MonitorWebhookReceiver> webhookReceivers, IList<MonitorItsmReceiver> itsmReceivers, IList<MonitorAzureAppPushReceiver> azureAppPushReceivers, IList<MonitorAutomationRunbookReceiver> automationRunbookReceivers, IList<MonitorVoiceReceiver> voiceReceivers, IList<MonitorLogicAppReceiver> logicAppReceivers, IList<MonitorAzureFunctionReceiver> azureFunctionReceivers, IList<MonitorArmRoleReceiver> armRoleReceivers, IList<MonitorEventHubReceiver> eventHubReceivers) : base(id, name, resourceType, systemData, tags, location)
        {
            GroupShortName = groupShortName;
            IsEnabled = isEnabled;
            EmailReceivers = emailReceivers;
            SmsReceivers = smsReceivers;
            WebhookReceivers = webhookReceivers;
            ItsmReceivers = itsmReceivers;
            AzureAppPushReceivers = azureAppPushReceivers;
            AutomationRunbookReceivers = automationRunbookReceivers;
            VoiceReceivers = voiceReceivers;
            LogicAppReceivers = logicAppReceivers;
            AzureFunctionReceivers = azureFunctionReceivers;
            ArmRoleReceivers = armRoleReceivers;
            EventHubReceivers = eventHubReceivers;
        }

        /// <summary> The short name of the action group. This will be used in SMS messages. </summary>
        public string GroupShortName { get; set; }
        /// <summary> Indicates whether this action group is enabled. If an action group is not enabled, then none of its receivers will receive communications. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The list of email receivers that are part of this action group. </summary>
        public IList<MonitorEmailReceiver> EmailReceivers { get; }
        /// <summary> The list of SMS receivers that are part of this action group. </summary>
        public IList<MonitorSmsReceiver> SmsReceivers { get; }
        /// <summary> The list of webhook receivers that are part of this action group. </summary>
        public IList<MonitorWebhookReceiver> WebhookReceivers { get; }
        /// <summary> The list of ITSM receivers that are part of this action group. </summary>
        public IList<MonitorItsmReceiver> ItsmReceivers { get; }
        /// <summary> The list of AzureAppPush receivers that are part of this action group. </summary>
        public IList<MonitorAzureAppPushReceiver> AzureAppPushReceivers { get; }
        /// <summary> The list of AutomationRunbook receivers that are part of this action group. </summary>
        public IList<MonitorAutomationRunbookReceiver> AutomationRunbookReceivers { get; }
        /// <summary> The list of voice receivers that are part of this action group. </summary>
        public IList<MonitorVoiceReceiver> VoiceReceivers { get; }
        /// <summary> The list of logic app receivers that are part of this action group. </summary>
        public IList<MonitorLogicAppReceiver> LogicAppReceivers { get; }
        /// <summary> The list of azure function receivers that are part of this action group. </summary>
        public IList<MonitorAzureFunctionReceiver> AzureFunctionReceivers { get; }
        /// <summary> The list of ARM role receivers that are part of this action group. Roles are Azure RBAC roles and only built-in roles are supported. </summary>
        public IList<MonitorArmRoleReceiver> ArmRoleReceivers { get; }
        /// <summary> The list of event hub receivers that are part of this action group. </summary>
        public IList<MonitorEventHubReceiver> EventHubReceivers { get; }
    }
}
