using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Wi-Fi Proxy Settings.</summary>
    public enum WiFiProxySetting {
        /// <summary>No Proxy.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Manual Proxy Settings via Address and Port.</summary>
        [EnumMember(Value = "manual")]
        Manual,
        /// <summary>Automatic Proxy Settings via URL.</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
    }
}
