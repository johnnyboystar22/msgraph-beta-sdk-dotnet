using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcRegionGroup {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "australia")]
        Australia,
        [EnumMember(Value = "canada")]
        Canada,
        [EnumMember(Value = "usCentral")]
        UsCentral,
        [EnumMember(Value = "usEast")]
        UsEast,
        [EnumMember(Value = "usWest")]
        UsWest,
        [EnumMember(Value = "france")]
        France,
        [EnumMember(Value = "germany")]
        Germany,
        [EnumMember(Value = "europeUnion")]
        EuropeUnion,
        [EnumMember(Value = "unitedKingdom")]
        UnitedKingdom,
        [EnumMember(Value = "japan")]
        Japan,
        [EnumMember(Value = "asia")]
        Asia,
        [EnumMember(Value = "india")]
        India,
        [EnumMember(Value = "southAmerica")]
        SouthAmerica,
        [EnumMember(Value = "euap")]
        Euap,
        [EnumMember(Value = "usGovernment")]
        UsGovernment,
        [EnumMember(Value = "usGovernmentDOD")]
        UsGovernmentDOD,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "norway")]
        Norway,
        [EnumMember(Value = "switzerland")]
        Switzerland,
        [EnumMember(Value = "southKorea")]
        SouthKorea,
    }
}
