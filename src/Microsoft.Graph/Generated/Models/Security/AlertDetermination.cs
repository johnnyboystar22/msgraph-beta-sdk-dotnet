using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public enum AlertDetermination {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "apt")]
        Apt,
        [EnumMember(Value = "malware")]
        Malware,
        [EnumMember(Value = "securityPersonnel")]
        SecurityPersonnel,
        [EnumMember(Value = "securityTesting")]
        SecurityTesting,
        [EnumMember(Value = "unwantedSoftware")]
        UnwantedSoftware,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "multiStagedAttack")]
        MultiStagedAttack,
        [EnumMember(Value = "compromisedAccount")]
        CompromisedAccount,
        [EnumMember(Value = "phishing")]
        Phishing,
        [EnumMember(Value = "maliciousUserActivity")]
        MaliciousUserActivity,
        [EnumMember(Value = "notMalicious")]
        NotMalicious,
        [EnumMember(Value = "notEnoughDataToValidate")]
        NotEnoughDataToValidate,
        [EnumMember(Value = "confirmedActivity")]
        ConfirmedActivity,
        [EnumMember(Value = "lineOfBusinessApplication")]
        LineOfBusinessApplication,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
