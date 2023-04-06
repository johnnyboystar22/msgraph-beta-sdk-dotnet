using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum TenantAllowBlockListAction {
        [EnumMember(Value = "allow")]
        Allow,
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
