using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The ODJ request states.</summary>
    public enum DeviceManagementDomainJoinConnectorState {
        /// <summary>Connector is actively pinging Intune.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>There is no heart-beat from connector from last one hour.</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>There is no heart-beat from connector from last 5 days.</summary>
        [EnumMember(Value = "inactive")]
        Inactive,
    }
}
