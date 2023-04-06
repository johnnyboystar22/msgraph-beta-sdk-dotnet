using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LocalSecurityOptionsSmartCardRemovalBehaviorType</summary>
    public enum LocalSecurityOptionsSmartCardRemovalBehaviorType {
        /// <summary>No Action</summary>
        [EnumMember(Value = "noAction")]
        NoAction,
        /// <summary>Lock Workstation</summary>
        [EnumMember(Value = "lockWorkstation")]
        LockWorkstation,
        /// <summary>Force Logoff</summary>
        [EnumMember(Value = "forceLogoff")]
        ForceLogoff,
        /// <summary>Disconnect if a remote Remote Desktop Services session</summary>
        [EnumMember(Value = "disconnectRemoteDesktopSession")]
        DisconnectRemoteDesktopSession,
    }
}
