using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Restricted apps state</summary>
    public enum RestrictedAppsState {
        /// <summary>Prohibited apps</summary>
        [EnumMember(Value = "prohibitedApps")]
        ProhibitedApps,
        /// <summary>Not approved apps</summary>
        [EnumMember(Value = "notApprovedApps")]
        NotApprovedApps,
    }
}
