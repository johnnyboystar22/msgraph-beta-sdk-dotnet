using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MailboxRecipientType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "linked")]
        Linked,
        [EnumMember(Value = "shared")]
        Shared,
        [EnumMember(Value = "room")]
        Room,
        [EnumMember(Value = "equipment")]
        Equipment,
        [EnumMember(Value = "others")]
        Others,
    }
}
