using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Certificate Validity Period Options.</summary>
    public enum CertificateValidityPeriodScale {
        /// <summary>Days.</summary>
        [EnumMember(Value = "days")]
        Days,
        /// <summary>Months.</summary>
        [EnumMember(Value = "months")]
        Months,
        /// <summary>Years.</summary>
        [EnumMember(Value = "years")]
        Years,
    }
}
