using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A list of possible states for application status on an individual device. When devices contact the Intune service and find targeted application enforcement intent, the status of the enforcement is recorded and becomes accessible in the Graph API. Since the application status is identified during device interaction with the Intune service, status records do not immediately appear upon application group assignment; it is created only after the assignment is evaluated in the service and devices start receiving the policy during check-ins.</summary>
    public enum ResultantAppState {
        /// <summary>The application is not applicable.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        /// <summary>The application is installed with no errors.</summary>
        [EnumMember(Value = "installed")]
        Installed,
        /// <summary>The application failed to install.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>The application is not installed.</summary>
        [EnumMember(Value = "notInstalled")]
        NotInstalled,
        /// <summary>The application failed to uninstall.</summary>
        [EnumMember(Value = "uninstallFailed")]
        UninstallFailed,
        /// <summary>The installation of the application is in progress.</summary>
        [EnumMember(Value = "pendingInstall")]
        PendingInstall,
        /// <summary>The status of the application is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
