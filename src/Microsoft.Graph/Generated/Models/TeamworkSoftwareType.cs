using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkSoftwareType {
        [EnumMember(Value = "adminAgent")]
        AdminAgent,
        [EnumMember(Value = "operatingSystem")]
        OperatingSystem,
        [EnumMember(Value = "teamsClient")]
        TeamsClient,
        [EnumMember(Value = "firmware")]
        Firmware,
        [EnumMember(Value = "partnerAgent")]
        PartnerAgent,
        [EnumMember(Value = "companyPortal")]
        CompanyPortal,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
