using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public enum InboundDomain {
        [EnumMember(Value = "educationRostering")]
        EducationRostering,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
