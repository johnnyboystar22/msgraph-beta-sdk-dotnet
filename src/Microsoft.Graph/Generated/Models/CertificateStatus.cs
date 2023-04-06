using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CertificateStatus {
        [EnumMember(Value = "notProvisioned")]
        NotProvisioned,
        [EnumMember(Value = "provisioned")]
        Provisioned,
    }
}
