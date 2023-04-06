using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OnlineMeetingPresenters {
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "roleIsPresenter")]
        RoleIsPresenter,
        [EnumMember(Value = "organizer")]
        Organizer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
