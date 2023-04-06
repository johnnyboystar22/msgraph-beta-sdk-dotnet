using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum IdentitySourceType {
        [EnumMember(Value = "azureActiveDirectory")]
        AzureActiveDirectory,
        [EnumMember(Value = "external")]
        External,
    }
}
