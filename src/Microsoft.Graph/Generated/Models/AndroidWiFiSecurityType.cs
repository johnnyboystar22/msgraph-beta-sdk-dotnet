using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi Security Types for Android.</summary>
    public enum AndroidWiFiSecurityType {
        /// <summary>Open (No Authentication).</summary>
        [EnumMember(Value = "open")]
        Open,
        /// <summary>WPA-Enterprise. Must use AndroidEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpaEnterprise")]
        WpaEnterprise,
        /// <summary>WPA2-Enterprise. Must use AndroidEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpa2Enterprise")]
        Wpa2Enterprise,
    }
}
