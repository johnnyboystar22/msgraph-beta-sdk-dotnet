using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The VPN action to take for a specific service.</summary>
    public enum VpnServiceExceptionAction {
        /// <summary>Make all traffic from that service go through the VPN</summary>
        [EnumMember(Value = "forceTrafficViaVPN")]
        ForceTrafficViaVPN,
        /// <summary>Allow the service outside of the VPN</summary>
        [EnumMember(Value = "allowTrafficOutside")]
        AllowTrafficOutside,
        /// <summary>Drop all traffic from the service</summary>
        [EnumMember(Value = "dropTraffic")]
        DropTraffic,
    }
}
