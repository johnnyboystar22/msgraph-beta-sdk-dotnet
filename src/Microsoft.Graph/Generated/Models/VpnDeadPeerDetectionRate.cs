using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Determines how often to check if a peer connection is still alive</summary>
    public enum VpnDeadPeerDetectionRate {
        /// <summary>Medium</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>None</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Low</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>High</summary>
        [EnumMember(Value = "high")]
        High,
    }
}
