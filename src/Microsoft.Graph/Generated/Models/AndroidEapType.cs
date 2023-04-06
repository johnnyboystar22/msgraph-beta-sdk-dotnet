using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Extensible Authentication Protocol (EAP) Configuration Types.</summary>
    public enum AndroidEapType {
        /// <summary>Extensible Authentication Protocol-Transport Layer Security (EAP-TLS).</summary>
        [EnumMember(Value = "eapTls")]
        EapTls,
        /// <summary>Extensible Authentication Protocol-Tunneled Transport Layer Security (EAP-TTLS).</summary>
        [EnumMember(Value = "eapTtls")]
        EapTtls,
        /// <summary>Protected Extensible Authentication Protocol (PEAP).</summary>
        [EnumMember(Value = "peap")]
        Peap,
    }
}
