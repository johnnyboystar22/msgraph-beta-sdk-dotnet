using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum GroupType {
        [EnumMember(Value = "unifiedGroups")]
        UnifiedGroups,
        [EnumMember(Value = "azureAD")]
        AzureAD,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
