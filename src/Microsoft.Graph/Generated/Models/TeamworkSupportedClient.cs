using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkSupportedClient {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "skypeDefaultAndTeams")]
        SkypeDefaultAndTeams,
        [EnumMember(Value = "teamsDefaultAndSkype")]
        TeamsDefaultAndSkype,
        [EnumMember(Value = "skypeOnly")]
        SkypeOnly,
        [EnumMember(Value = "teamsOnly")]
        TeamsOnly,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
