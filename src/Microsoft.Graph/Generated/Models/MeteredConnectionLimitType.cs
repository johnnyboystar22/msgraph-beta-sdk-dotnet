using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Metered Connection Limit Settings.</summary>
    public enum MeteredConnectionLimitType {
        /// <summary>Unrestricted</summary>
        [EnumMember(Value = "unrestricted")]
        Unrestricted,
        /// <summary>Fixed</summary>
        [EnumMember(Value = "fixed")]
        Fixed,
        /// <summary>Variable</summary>
        [EnumMember(Value = "variable")]
        Variable,
    }
}
