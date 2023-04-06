using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The administrator intent for the assignment of the profile.</summary>
    public enum DeviceManagementResourceAccessProfileIntent {
        /// <summary>Apply the profile.</summary>
        [EnumMember(Value = "apply")]
        Apply,
        /// <summary>Remove the profile from devices that have installed the profile.</summary>
        [EnumMember(Value = "remove")]
        Remove,
    }
}
