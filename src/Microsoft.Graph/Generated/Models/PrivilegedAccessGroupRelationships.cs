using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrivilegedAccessGroupRelationships {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "member")]
        Member,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
