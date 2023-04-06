using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>CertificateStore types</summary>
    public enum CertificateStore {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "machine")]
        Machine,
    }
}
