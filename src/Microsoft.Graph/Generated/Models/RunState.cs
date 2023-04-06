using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of execution status of the device management script.</summary>
    public enum RunState {
        /// <summary>Unknown result.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Script is run successfully.</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>Script failed to run.</summary>
        [EnumMember(Value = "fail")]
        Fail,
        /// <summary>Discovery script hits error.</summary>
        [EnumMember(Value = "scriptError")]
        ScriptError,
        /// <summary>Script is pending to execute.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Script is not applicable for this device.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
    }
}
