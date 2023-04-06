using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Forward Secrecy Group values for Windows10 VPN policies with IKEv2 connection type.</summary>
    public enum PerfectForwardSecrecyGroup {
        /// <summary>PFS1</summary>
        [EnumMember(Value = "pfs1")]
        Pfs1,
        /// <summary>PFS2</summary>
        [EnumMember(Value = "pfs2")]
        Pfs2,
        /// <summary>PFS2048</summary>
        [EnumMember(Value = "pfs2048")]
        Pfs2048,
        /// <summary>ECP256</summary>
        [EnumMember(Value = "ecp256")]
        Ecp256,
        /// <summary>ECP384</summary>
        [EnumMember(Value = "ecp384")]
        Ecp384,
        /// <summary>PFSMM</summary>
        [EnumMember(Value = "pfsMM")]
        PfsMM,
        /// <summary>PFS24</summary>
        [EnumMember(Value = "pfs24")]
        Pfs24,
    }
}
