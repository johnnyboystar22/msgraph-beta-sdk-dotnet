using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ProvisioningAction {
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "create")]
        Create,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "disable")]
        Disable,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "stagedDelete")]
        StagedDelete,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
