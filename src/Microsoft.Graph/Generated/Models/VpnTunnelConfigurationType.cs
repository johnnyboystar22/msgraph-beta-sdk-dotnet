using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The type of tunnels that will be present to the VPN client for configuration</summary>
    public enum VpnTunnelConfigurationType {
        /// <summary>WiFi and Cellular Tunnels</summary>
        [EnumMember(Value = "wifiAndCellular")]
        WifiAndCellular,
        /// <summary>Cellular Tunnel Only</summary>
        [EnumMember(Value = "cellular")]
        Cellular,
        /// <summary>WiFi Tunnel Only</summary>
        [EnumMember(Value = "wifi")]
        Wifi,
    }
}
