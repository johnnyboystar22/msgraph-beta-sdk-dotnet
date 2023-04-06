using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The maxium threat level allowed for an app to be compliant.</summary>
    public enum ManagedAppDeviceThreatLevel {
        /// <summary>Value not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Device needs to have no threat</summary>
        [EnumMember(Value = "secured")]
        Secured,
        /// <summary>Device needs to have a low threat.</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>Device needs to have not more than medium threat.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Device needs to have not more than high threat</summary>
        [EnumMember(Value = "high")]
        High,
    }
}
