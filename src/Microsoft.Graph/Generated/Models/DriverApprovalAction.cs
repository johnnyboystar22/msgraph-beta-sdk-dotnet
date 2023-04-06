using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum type to represent approval actions of single or list of drivers.</summary>
    public enum DriverApprovalAction {
        /// <summary>This indicates the action to approve single or list of drivers.</summary>
        [EnumMember(Value = "approve")]
        Approve,
        /// <summary>This indicates the action to approve single or list of drivers.</summary>
        [EnumMember(Value = "decline")]
        Decline,
        /// <summary>This indicates the action to suspend single or list of drivers.</summary>
        [EnumMember(Value = "suspend")]
        Suspend,
    }
}
