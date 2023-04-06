using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of Folder Protection</summary>
    public enum FolderProtectionType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Block functionality.</summary>
        [EnumMember(Value = "enable")]
        Enable,
        /// <summary>Allow functionality but generate logs.</summary>
        [EnumMember(Value = "auditMode")]
        AuditMode,
        /// <summary>Block untrusted apps from writing to disk sectors.</summary>
        [EnumMember(Value = "blockDiskModification")]
        BlockDiskModification,
        /// <summary>Generate logs when untrusted apps write to disk sectors.</summary>
        [EnumMember(Value = "auditDiskModification")]
        AuditDiskModification,
    }
}
