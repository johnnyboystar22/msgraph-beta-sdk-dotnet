using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ExpirationPatternType {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "noExpiration")]
        NoExpiration,
        [EnumMember(Value = "afterDateTime")]
        AfterDateTime,
        [EnumMember(Value = "afterDuration")]
        AfterDuration,
    }
}
