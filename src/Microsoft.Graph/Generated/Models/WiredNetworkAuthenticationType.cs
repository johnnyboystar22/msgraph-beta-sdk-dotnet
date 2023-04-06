using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wired Network Authentication Type Settings.</summary>
    public enum WiredNetworkAuthenticationType {
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
        /// <summary>Sentinel member for cases where the client cannot handle the new enum values.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
