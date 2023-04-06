using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Type of Group Policy operation status.</summary>
    public enum GroupPolicyOperationStatus {
        /// <summary>Group Policy unknown operation status.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Group Policy in progress operation status.</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Group Policy successful operation status.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>Group Policy failed operation status.</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
