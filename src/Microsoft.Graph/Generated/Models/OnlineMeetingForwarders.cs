using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnlineMeetingForwarders {
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "organizer")]
        Organizer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
