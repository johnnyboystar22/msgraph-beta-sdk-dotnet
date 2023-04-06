using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents various states for Zebra FOTA connector.</summary>
    public enum ZebraFotaConnectorState {
        /// <summary>Default value when the connector has not been setup (the feature has not been used yet).</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Connected state indicates that Intune is linked to Zebra Update Services for the current tenant.</summary>
        [EnumMember(Value = "connected")]
        Connected,
        /// <summary>Disconnected state indicates that the account was connected in the past and later disconnected.</summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,
        /// <summary>Unknown future enum value.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
