using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Group Policy Definition Class Type.</summary>
    public enum GroupPolicyDefinitionClassType {
        /// <summary>Identifies placement of the policy setting under the user configuration node.</summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>Identifies placement of the policy setting under the computer configuration node.</summary>
        [EnumMember(Value = "machine")]
        Machine,
    }
}
