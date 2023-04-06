using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Non-EAP methods for authentication when PEAP is the selected EAP type.</summary>
    public enum NonEapAuthenticationMethodForPeap {
        /// <summary>None.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Microsoft CHAP Version 2 (MS-CHAP v2).</summary>
        [EnumMember(Value = "microsoftChapVersionTwo")]
        MicrosoftChapVersionTwo,
    }
}
