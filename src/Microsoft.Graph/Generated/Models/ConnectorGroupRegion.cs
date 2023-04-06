using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ConnectorGroupRegion {
        [EnumMember(Value = "nam")]
        Nam,
        [EnumMember(Value = "eur")]
        Eur,
        [EnumMember(Value = "aus")]
        Aus,
        [EnumMember(Value = "asia")]
        Asia,
        [EnumMember(Value = "ind")]
        Ind,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
