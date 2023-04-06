using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MeetingAudience {
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
