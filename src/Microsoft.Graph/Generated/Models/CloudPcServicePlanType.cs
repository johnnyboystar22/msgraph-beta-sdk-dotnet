using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcServicePlanType {
        [EnumMember(Value = "enterprise")]
        Enterprise,
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
