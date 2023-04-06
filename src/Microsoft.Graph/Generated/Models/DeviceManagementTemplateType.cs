using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Template type</summary>
    public enum DeviceManagementTemplateType {
        /// <summary>Security baseline template</summary>
        [EnumMember(Value = "securityBaseline")]
        SecurityBaseline,
        /// <summary>Specialized devices template</summary>
        [EnumMember(Value = "specializedDevices")]
        SpecializedDevices,
        /// <summary>Advanced Threat Protection security baseline template</summary>
        [EnumMember(Value = "advancedThreatProtectionSecurityBaseline")]
        AdvancedThreatProtectionSecurityBaseline,
        /// <summary>Device configuration template</summary>
        [EnumMember(Value = "deviceConfiguration")]
        DeviceConfiguration,
        /// <summary>Custom admin defined template</summary>
        [EnumMember(Value = "custom")]
        Custom,
        /// <summary>Templates containing specific security focused settings</summary>
        [EnumMember(Value = "securityTemplate")]
        SecurityTemplate,
        /// <summary>Microsoft Edge security baseline template</summary>
        [EnumMember(Value = "microsoftEdgeSecurityBaseline")]
        MicrosoftEdgeSecurityBaseline,
        /// <summary>Microsoft Office 365 ProPlus security baseline template</summary>
        [EnumMember(Value = "microsoftOffice365ProPlusSecurityBaseline")]
        MicrosoftOffice365ProPlusSecurityBaseline,
        /// <summary>Device compliance template</summary>
        [EnumMember(Value = "deviceCompliance")]
        DeviceCompliance,
        /// <summary>Device Configuration for Microsoft Office 365 settings</summary>
        [EnumMember(Value = "deviceConfigurationForOffice365")]
        DeviceConfigurationForOffice365,
        /// <summary>Windows 365 security baseline template</summary>
        [EnumMember(Value = "cloudPC")]
        CloudPC,
        /// <summary>Firewall Shared Object templates for reference settings</summary>
        [EnumMember(Value = "firewallSharedSettings")]
        FirewallSharedSettings,
    }
}
