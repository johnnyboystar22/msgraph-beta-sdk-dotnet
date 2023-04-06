using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The scheduling priority options for downloading and preparing the requested mac OS update</summary>
    public enum MacOSPriority {
        /// <summary>Indicates low scheduling priority for downloading and preparing the requested update</summary>
        [EnumMember(Value = "low")]
        Low,
        /// <summary>Indicates high scheduling priority for downloading and preparing the requested update</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
