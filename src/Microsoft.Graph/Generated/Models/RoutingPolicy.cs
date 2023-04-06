using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RoutingPolicy {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "noMissedCall")]
        NoMissedCall,
        [EnumMember(Value = "disableForwardingExceptPhone")]
        DisableForwardingExceptPhone,
        [EnumMember(Value = "disableForwarding")]
        DisableForwarding,
        [EnumMember(Value = "preferSkypeForBusiness")]
        PreferSkypeForBusiness,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
