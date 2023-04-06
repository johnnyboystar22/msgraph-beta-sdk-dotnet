using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ApplicationPermissionsRequired {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "guest")]
        Guest,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
