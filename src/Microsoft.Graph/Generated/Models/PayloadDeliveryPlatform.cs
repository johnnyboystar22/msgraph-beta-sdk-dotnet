using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PayloadDeliveryPlatform {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "teams")]
        Teams,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
