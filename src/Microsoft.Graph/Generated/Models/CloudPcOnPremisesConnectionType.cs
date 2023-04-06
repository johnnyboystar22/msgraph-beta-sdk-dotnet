using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcOnPremisesConnectionType {
        [EnumMember(Value = "hybridAzureADJoin")]
        HybridAzureADJoin,
        [EnumMember(Value = "azureADJoin")]
        AzureADJoin,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
