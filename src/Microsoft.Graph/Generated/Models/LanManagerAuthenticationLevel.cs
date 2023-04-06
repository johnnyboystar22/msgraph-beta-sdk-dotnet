using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for LanManagerAuthenticationLevel</summary>
    public enum LanManagerAuthenticationLevel {
        /// <summary>Send LM &amp; NTLM responses</summary>
        [EnumMember(Value = "lmAndNltm")]
        LmAndNltm,
        /// <summary>Send LM &amp; NTLM-use NTLMv2 session security if negotiated</summary>
        [EnumMember(Value = "lmNtlmAndNtlmV2")]
        LmNtlmAndNtlmV2,
        /// <summary>Send LM &amp; NTLM responses only</summary>
        [EnumMember(Value = "lmAndNtlmOnly")]
        LmAndNtlmOnly,
        /// <summary>Send LM &amp; NTLMv2 responses only</summary>
        [EnumMember(Value = "lmAndNtlmV2")]
        LmAndNtlmV2,
        /// <summary>Send LM &amp; NTLMv2 responses only. Refuse LM</summary>
        [EnumMember(Value = "lmNtlmV2AndNotLm")]
        LmNtlmV2AndNotLm,
        /// <summary>Send LM &amp; NTLMv2 responses only. Refuse LM &amp; NTLM</summary>
        [EnumMember(Value = "lmNtlmV2AndNotLmOrNtm")]
        LmNtlmV2AndNotLmOrNtm,
    }
}
