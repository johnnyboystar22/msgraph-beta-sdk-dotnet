using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of execution context the app runs in.</summary>
    public enum RunAsAccountType {
        /// <summary>System context</summary>
        [EnumMember(Value = "system")]
        System,
        /// <summary>User context</summary>
        [EnumMember(Value = "user")]
        User,
    }
}
