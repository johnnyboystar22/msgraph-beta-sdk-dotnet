using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RegistrationAuthMethod {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobilePhone")]
        MobilePhone,
        [EnumMember(Value = "officePhone")]
        OfficePhone,
        [EnumMember(Value = "securityQuestion")]
        SecurityQuestion,
        [EnumMember(Value = "appNotification")]
        AppNotification,
        [EnumMember(Value = "appCode")]
        AppCode,
        [EnumMember(Value = "alternateMobilePhone")]
        AlternateMobilePhone,
        [EnumMember(Value = "fido")]
        Fido,
        [EnumMember(Value = "appPassword")]
        AppPassword,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
