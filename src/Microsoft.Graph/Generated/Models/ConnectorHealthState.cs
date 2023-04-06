using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Connector health state for connector status</summary>
    public enum ConnectorHealthState {
        /// <summary>Indicates a healthy connector status and no action required.</summary>
        [EnumMember(Value = "healthy")]
        Healthy,
        /// <summary>Indicates that a connector needs attention.</summary>
        [EnumMember(Value = "warning")]
        Warning,
        /// <summary>Indicates that a connector needs immediate attention to retain functionality.</summary>
        [EnumMember(Value = "unhealthy")]
        Unhealthy,
        /// <summary>unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
