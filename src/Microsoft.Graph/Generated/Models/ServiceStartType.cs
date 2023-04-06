using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of xbox service start type</summary>
    public enum ServiceStartType {
        /// <summary>Manual service start type(default)</summary>
        [EnumMember(Value = "manual")]
        Manual,
        /// <summary>Automatic service start type</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
        /// <summary>Service start type disabled</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
