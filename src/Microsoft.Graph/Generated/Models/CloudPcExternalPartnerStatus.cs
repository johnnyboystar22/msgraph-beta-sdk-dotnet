using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcExternalPartnerStatus {
        [EnumMember(Value = "notAvailable")]
        NotAvailable,
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "healthy")]
        Healthy,
        [EnumMember(Value = "unhealthy")]
        Unhealthy,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
