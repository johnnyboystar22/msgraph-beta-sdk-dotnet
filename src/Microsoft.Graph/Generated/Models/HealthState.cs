using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates health state of the Windows management app.</summary>
    public enum HealthState {
        /// <summary>Unknown state.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Healthy state.</summary>
        [EnumMember(Value = "healthy")]
        Healthy,
        /// <summary>Unhealthy state.</summary>
        [EnumMember(Value = "unhealthy")]
        Unhealthy,
    }
}
