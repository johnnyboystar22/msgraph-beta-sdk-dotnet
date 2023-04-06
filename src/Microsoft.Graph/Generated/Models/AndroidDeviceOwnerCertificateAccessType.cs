using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum representing possible values for cross profile data sharing.</summary>
    public enum AndroidDeviceOwnerCertificateAccessType {
        /// <summary>Require user approval for all apps</summary>
        [EnumMember(Value = "userApproval")]
        UserApproval,
        /// <summary>Pre-grant certificate access for specific apps (require user approval for other apps).</summary>
        [EnumMember(Value = "specificApps")]
        SpecificApps,
        /// <summary>Unknown future value for evolvable enum patterns.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
