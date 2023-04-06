using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public enum ManagementCategory {
        [EnumMember(Value = "custom")]
        Custom,
        [EnumMember(Value = "devices")]
        Devices,
        [EnumMember(Value = "identity")]
        Identity,
        [EnumMember(Value = "data")]
        Data,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
