using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcSupportedRegionStatus {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "restricted")]
        Restricted,
        [EnumMember(Value = "unavailable")]
        Unavailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
