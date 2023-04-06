using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PersonRelationship {
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "colleague")]
        Colleague,
        [EnumMember(Value = "directReport")]
        DirectReport,
        [EnumMember(Value = "dotLineReport")]
        DotLineReport,
        [EnumMember(Value = "assistant")]
        Assistant,
        [EnumMember(Value = "dotLineManager")]
        DotLineManager,
        [EnumMember(Value = "alternateContact")]
        AlternateContact,
        [EnumMember(Value = "friend")]
        Friend,
        [EnumMember(Value = "spouse")]
        Spouse,
        [EnumMember(Value = "sibling")]
        Sibling,
        [EnumMember(Value = "child")]
        Child,
        [EnumMember(Value = "parent")]
        Parent,
        [EnumMember(Value = "sponsor")]
        Sponsor,
        [EnumMember(Value = "emergencyContact")]
        EmergencyContact,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
