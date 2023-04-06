using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi Authentication Type Settings.</summary>
    public enum WifiAuthenticationType {
        /// <summary>None</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>User Authentication</summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>Machine Authentication</summary>
        [EnumMember(Value = "machine")]
        Machine,
        /// <summary>Machine or User Authentication</summary>
        [EnumMember(Value = "machineOrUser")]
        MachineOrUser,
        /// <summary>Guest Authentication</summary>
        [EnumMember(Value = "guest")]
        Guest,
    }
}
