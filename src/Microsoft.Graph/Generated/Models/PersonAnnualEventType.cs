using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PersonAnnualEventType {
        [EnumMember(Value = "birthday")]
        Birthday,
        [EnumMember(Value = "wedding")]
        Wedding,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
