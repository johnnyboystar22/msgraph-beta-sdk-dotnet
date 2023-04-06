using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes current lifecycle state of a template</summary>
    public enum DeviceManagementTemplateLifecycleState {
        /// <summary>Invalid</summary>
        [EnumMember(Value = "invalid")]
        Invalid,
        /// <summary>Draft</summary>
        [EnumMember(Value = "draft")]
        Draft,
        /// <summary>Active</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Superseded</summary>
        [EnumMember(Value = "superseded")]
        Superseded,
        /// <summary>Deprecated</summary>
        [EnumMember(Value = "deprecated")]
        Deprecated,
        /// <summary>Retired</summary>
        [EnumMember(Value = "retired")]
        Retired,
    }
}
