using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsInformationDisplayedOnLockScreen</summary>
    public enum LocalSecurityOptionsInformationDisplayedOnLockScreenType {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>User display name, domain and user names</summary>
        [EnumMember(Value = "administrators")]
        Administrators,
        /// <summary>User display name only</summary>
        [EnumMember(Value = "administratorsAndPowerUsers")]
        AdministratorsAndPowerUsers,
        /// <summary>Do not display user information</summary>
        [EnumMember(Value = "administratorsAndInteractiveUsers")]
        AdministratorsAndInteractiveUsers,
    }
}
