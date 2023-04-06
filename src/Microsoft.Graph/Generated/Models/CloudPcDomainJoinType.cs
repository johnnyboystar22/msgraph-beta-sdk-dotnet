using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcDomainJoinType {
        [EnumMember(Value = "azureADJoin")]
        AzureADJoin,
        [EnumMember(Value = "hybridAzureADJoin")]
        HybridAzureADJoin,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
