using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi Security Types for AOSP Device Owner.</summary>
    public enum AospDeviceOwnerWiFiSecurityType {
        /// <summary>Open (No Authentication).</summary>
        [EnumMember(Value = "open")]
        Open,
        /// <summary>WEP Encryption.</summary>
        [EnumMember(Value = "wep")]
        Wep,
        /// <summary>WPA-Personal/WPA2-Personal.</summary>
        [EnumMember(Value = "wpaPersonal")]
        WpaPersonal,
        /// <summary>WPA-Enterprise/WPA2-Enterprise. Must use AOSPDeviceOwnerEnterpriseWifiConfiguration type to configure enterprise options.</summary>
        [EnumMember(Value = "wpaEnterprise")]
        WpaEnterprise,
    }
}
