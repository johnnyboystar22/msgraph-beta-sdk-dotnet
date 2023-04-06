using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Setting type of the group policy.</summary>
    public enum GroupPolicySettingType {
        /// <summary>GroupPolicySettingType unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Policy setting type</summary>
        [EnumMember(Value = "policy")]
        Policy,
        /// <summary>Account setting type</summary>
        [EnumMember(Value = "account")]
        Account,
        /// <summary>SecurityOptions setting type</summary>
        [EnumMember(Value = "securityOptions")]
        SecurityOptions,
        /// <summary>UserRightsAssignment setting type</summary>
        [EnumMember(Value = "userRightsAssignment")]
        UserRightsAssignment,
        /// <summary>AuditSetting setting type</summary>
        [EnumMember(Value = "auditSetting")]
        AuditSetting,
        /// <summary>WindowsFirewallSettings setting type</summary>
        [EnumMember(Value = "windowsFirewallSettings")]
        WindowsFirewallSettings,
        /// <summary>AppLockerRuleCollection setting type</summary>
        [EnumMember(Value = "appLockerRuleCollection")]
        AppLockerRuleCollection,
        /// <summary>DataSourcesSettings setting type</summary>
        [EnumMember(Value = "dataSourcesSettings")]
        DataSourcesSettings,
        /// <summary>DevicesSettings setting type</summary>
        [EnumMember(Value = "devicesSettings")]
        DevicesSettings,
        /// <summary>DriveMapSettings setting type</summary>
        [EnumMember(Value = "driveMapSettings")]
        DriveMapSettings,
        /// <summary>EnvironmentVariables setting type</summary>
        [EnumMember(Value = "environmentVariables")]
        EnvironmentVariables,
        /// <summary>FilesSettings setting type</summary>
        [EnumMember(Value = "filesSettings")]
        FilesSettings,
        /// <summary>FolderOptions setting type</summary>
        [EnumMember(Value = "folderOptions")]
        FolderOptions,
        /// <summary>Folders setting type</summary>
        [EnumMember(Value = "folders")]
        Folders,
        /// <summary>IniFiles setting type</summary>
        [EnumMember(Value = "iniFiles")]
        IniFiles,
        /// <summary>InternetOptions setting type</summary>
        [EnumMember(Value = "internetOptions")]
        InternetOptions,
        /// <summary>LocalUsersAndGroups setting type</summary>
        [EnumMember(Value = "localUsersAndGroups")]
        LocalUsersAndGroups,
        /// <summary>NetworkOptions setting type</summary>
        [EnumMember(Value = "networkOptions")]
        NetworkOptions,
        /// <summary>NetworkShares setting type</summary>
        [EnumMember(Value = "networkShares")]
        NetworkShares,
        /// <summary>NTServices setting type</summary>
        [EnumMember(Value = "ntServices")]
        NtServices,
        /// <summary>PowerOptions setting type</summary>
        [EnumMember(Value = "powerOptions")]
        PowerOptions,
        /// <summary>Printers setting type</summary>
        [EnumMember(Value = "printers")]
        Printers,
        /// <summary>RegionalOptionsSettings setting type</summary>
        [EnumMember(Value = "regionalOptionsSettings")]
        RegionalOptionsSettings,
        /// <summary>RegistrySettings setting type</summary>
        [EnumMember(Value = "registrySettings")]
        RegistrySettings,
        /// <summary>ScheduledTasks setting type</summary>
        [EnumMember(Value = "scheduledTasks")]
        ScheduledTasks,
        /// <summary>ShortcutSettings setting type</summary>
        [EnumMember(Value = "shortcutSettings")]
        ShortcutSettings,
        /// <summary>StartMenuSettings setting type</summary>
        [EnumMember(Value = "startMenuSettings")]
        StartMenuSettings,
    }
}
