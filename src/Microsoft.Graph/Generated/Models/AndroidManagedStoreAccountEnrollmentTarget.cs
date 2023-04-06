using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android for Work device management targeting type for the account</summary>
    public enum AndroidManagedStoreAccountEnrollmentTarget {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "targeted")]
        Targeted,
        [EnumMember(Value = "targetedAsEnrollmentRestrictions")]
        TargetedAsEnrollmentRestrictions,
    }
}
