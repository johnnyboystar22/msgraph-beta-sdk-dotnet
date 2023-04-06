using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates whether global device health scripts are enabled and are in which state</summary>
    public enum GlobalDeviceHealthScriptState {
        /// <summary>Global device health scripts are not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Global device health scripts are configured but not fully enabled</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Global device health scripts are enabled and ready to use</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
    }
}
