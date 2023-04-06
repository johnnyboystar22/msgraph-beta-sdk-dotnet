using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UsageAuthMethod {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobileSMS")]
        MobileSMS,
        [EnumMember(Value = "mobileCall")]
        MobileCall,
        [EnumMember(Value = "officePhone")]
        OfficePhone,
        [EnumMember(Value = "securityQuestion")]
        SecurityQuestion,
        [EnumMember(Value = "appNotification")]
        AppNotification,
        [EnumMember(Value = "appCode")]
        AppCode,
        [EnumMember(Value = "alternateMobileCall")]
        AlternateMobileCall,
        [EnumMember(Value = "fido")]
        Fido,
        [EnumMember(Value = "appPassword")]
        AppPassword,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
