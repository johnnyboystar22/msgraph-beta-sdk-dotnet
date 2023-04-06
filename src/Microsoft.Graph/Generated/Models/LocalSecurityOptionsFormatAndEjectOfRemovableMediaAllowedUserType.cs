using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser</summary>
    public enum LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Administrators</summary>
        [EnumMember(Value = "administrators")]
        Administrators,
        /// <summary>Administrators and Power Users</summary>
        [EnumMember(Value = "administratorsAndPowerUsers")]
        AdministratorsAndPowerUsers,
        /// <summary>Administrators and Interactive Users </summary>
        [EnumMember(Value = "administratorsAndInteractiveUsers")]
        AdministratorsAndInteractiveUsers,
    }
}
