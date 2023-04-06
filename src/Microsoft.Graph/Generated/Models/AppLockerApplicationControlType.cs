using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of AppLocker Application Control Types</summary>
    public enum AppLockerApplicationControlType {
        /// <summary>Device default value, no Application Control type selected.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Enforce Windows component and store apps.</summary>
        [EnumMember(Value = "enforceComponentsAndStoreApps")]
        EnforceComponentsAndStoreApps,
        /// <summary>Audit Windows component and store apps.</summary>
        [EnumMember(Value = "auditComponentsAndStoreApps")]
        AuditComponentsAndStoreApps,
        /// <summary>Enforce Windows components, store apps and smart locker.</summary>
        [EnumMember(Value = "enforceComponentsStoreAppsAndSmartlocker")]
        EnforceComponentsStoreAppsAndSmartlocker,
        /// <summary>Audit Windows components, store apps and smart locker​.</summary>
        [EnumMember(Value = "auditComponentsStoreAppsAndSmartlocker")]
        AuditComponentsStoreAppsAndSmartlocker,
    }
}
