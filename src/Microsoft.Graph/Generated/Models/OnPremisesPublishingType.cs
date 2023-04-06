using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnPremisesPublishingType {
        [EnumMember(Value = "applicationProxy")]
        ApplicationProxy,
        [EnumMember(Value = "exchangeOnline")]
        ExchangeOnline,
        [EnumMember(Value = "authentication")]
        Authentication,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "intunePfx")]
        IntunePfx,
        [EnumMember(Value = "oflineDomainJoin")]
        OflineDomainJoin,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
