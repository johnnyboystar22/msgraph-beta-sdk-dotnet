using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Non-EAP methods for authentication.</summary>
    public enum NonEapAuthenticationMethodForEapTtlsType {
        /// <summary>Unencrypted password (PAP).</summary>
        [EnumMember(Value = "unencryptedPassword")]
        UnencryptedPassword,
        /// <summary>Challenge Handshake Authentication Protocol (CHAP).</summary>
        [EnumMember(Value = "challengeHandshakeAuthenticationProtocol")]
        ChallengeHandshakeAuthenticationProtocol,
        /// <summary> Microsoft CHAP (MS-CHAP).</summary>
        [EnumMember(Value = "microsoftChap")]
        MicrosoftChap,
        /// <summary>Microsoft CHAP Version 2 (MS-CHAP v2).</summary>
        [EnumMember(Value = "microsoftChapVersionTwo")]
        MicrosoftChapVersionTwo,
    }
}
