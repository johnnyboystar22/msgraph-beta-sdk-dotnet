using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Extensible Authentication Protocol (EAP) configuration types.</summary>
    public enum EapType {
        /// <summary>EAP-Transport Layer Security (EAP-TLS).</summary>
        [EnumMember(Value = "eapTls")]
        EapTls,
        /// <summary>Lightweight Extensible Authentication Protocol (LEAP).</summary>
        [EnumMember(Value = "leap")]
        Leap,
        /// <summary>EAP for GSM Subscriber Identity Module (EAP-SIM).</summary>
        [EnumMember(Value = "eapSim")]
        EapSim,
        /// <summary>EAP-Tunneled Transport Layer Security (EAP-TTLS).</summary>
        [EnumMember(Value = "eapTtls")]
        EapTtls,
        /// <summary>Protected Extensible Authentication Protocol (PEAP).</summary>
        [EnumMember(Value = "peap")]
        Peap,
        /// <summary>EAP-Flexible Authentication via Secure Tunneling (EAP-FAST).</summary>
        [EnumMember(Value = "eapFast")]
        EapFast,
        /// <summary>Tunnel Extensible Authentication Protocol (TEAP).</summary>
        [EnumMember(Value = "teap")]
        Teap,
    }
}
