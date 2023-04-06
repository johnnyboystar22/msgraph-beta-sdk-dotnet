using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The enum to specify the status of PolicySet.</summary>
    public enum PolicySetStatus {
        /// <summary>Default Value.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>All PolicySet items are now validating for corresponding settings of workloads.</summary>
        [EnumMember(Value = "validating")]
        Validating,
        /// <summary>Post process complete for all PolicySet items but there are failures.</summary>
        [EnumMember(Value = "partialSuccess")]
        PartialSuccess,
        /// <summary>All PolicySet items are deployed. Doesn’t mean that all deployment succeeded. </summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>PolicySet processing completely failed.</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>PolicySet/PolicySetItem is not assigned to any group.</summary>
        [EnumMember(Value = "notAssigned")]
        NotAssigned,
    }
}
