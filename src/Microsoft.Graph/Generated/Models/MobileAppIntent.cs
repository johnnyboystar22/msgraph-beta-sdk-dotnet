using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the status of the mobile app on the device.</summary>
    public enum MobileAppIntent {
        /// <summary>Available</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>Not Available</summary>
        [EnumMember(Value = "notAvailable")]
        NotAvailable,
        /// <summary>Required Install</summary>
        [EnumMember(Value = "requiredInstall")]
        RequiredInstall,
        /// <summary>Required Uninstall</summary>
        [EnumMember(Value = "requiredUninstall")]
        RequiredUninstall,
        /// <summary>RequiredAndAvailableInstall</summary>
        [EnumMember(Value = "requiredAndAvailableInstall")]
        RequiredAndAvailableInstall,
        /// <summary>AvailableInstallWithoutEnrollment</summary>
        [EnumMember(Value = "availableInstallWithoutEnrollment")]
        AvailableInstallWithoutEnrollment,
        /// <summary>Exclude</summary>
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}
