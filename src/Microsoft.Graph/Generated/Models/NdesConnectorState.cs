using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The current status of the Ndes Connector.</summary>
    public enum NdesConnectorState {
        /// <summary>State not available yet for this connector.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Ndes connector has connected recently</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>No recent activity for the Ndes connector</summary>
        [EnumMember(Value = "inactive")]
        Inactive,
    }
}
