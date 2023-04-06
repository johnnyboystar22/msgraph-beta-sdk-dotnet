using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum TenantAllowBlockListEntryType {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "fileHash")]
        FileHash,
        [EnumMember(Value = "sender")]
        Sender,
        [EnumMember(Value = "recipient")]
        Recipient,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
