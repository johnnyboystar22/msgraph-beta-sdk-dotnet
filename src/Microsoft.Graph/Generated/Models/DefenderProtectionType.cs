using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of Defender PUA Protection</summary>
    public enum DefenderProtectionType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Block functionality.</summary>
        [EnumMember(Value = "enable")]
        Enable,
        /// <summary>Allow functionality but generate logs.</summary>
        [EnumMember(Value = "auditMode")]
        AuditMode,
        /// <summary>Warning message to end user with ability to bypass block from attack surface reduction rule.</summary>
        [EnumMember(Value = "warn")]
        Warn,
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
    }
}
