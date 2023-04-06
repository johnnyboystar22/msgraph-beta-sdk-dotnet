using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PayloadBrand {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "americanExpress")]
        AmericanExpress,
        [EnumMember(Value = "capitalOne")]
        CapitalOne,
        [EnumMember(Value = "dhl")]
        Dhl,
        [EnumMember(Value = "docuSign")]
        DocuSign,
        [EnumMember(Value = "dropbox")]
        Dropbox,
        [EnumMember(Value = "facebook")]
        Facebook,
        [EnumMember(Value = "firstAmerican")]
        FirstAmerican,
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "netflix")]
        Netflix,
        [EnumMember(Value = "scotiabank")]
        Scotiabank,
        [EnumMember(Value = "sendGrid")]
        SendGrid,
        [EnumMember(Value = "stewartTitle")]
        StewartTitle,
        [EnumMember(Value = "tesco")]
        Tesco,
        [EnumMember(Value = "wellsFargo")]
        WellsFargo,
        [EnumMember(Value = "syrinxCloud")]
        SyrinxCloud,
        [EnumMember(Value = "adobe")]
        Adobe,
        [EnumMember(Value = "teams")]
        Teams,
        [EnumMember(Value = "zoom")]
        Zoom,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
