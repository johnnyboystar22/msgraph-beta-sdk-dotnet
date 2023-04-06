using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcUserAccessLevel {
        [EnumMember(Value = "unrestricted")]
        Unrestricted,
        [EnumMember(Value = "restricted")]
        Restricted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
