using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Status of ServiceNow Connection</summary>
    public enum ServiceNowConnectionStatus {
        /// <summary>Tenant has disabled the connection</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Tenant has enabled the connection</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Future authentication method to be added here.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
