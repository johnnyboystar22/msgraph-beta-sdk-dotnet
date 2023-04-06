using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for email sync schedule.</summary>
    public enum EmailSyncSchedule {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Sync as messages arrive.</summary>
        [EnumMember(Value = "asMessagesArrive")]
        AsMessagesArrive,
        /// <summary>Sync manually.</summary>
        [EnumMember(Value = "manual")]
        Manual,
        /// <summary>Sync every fifteen minutes.</summary>
        [EnumMember(Value = "fifteenMinutes")]
        FifteenMinutes,
        /// <summary>Sync every thirty minutes.</summary>
        [EnumMember(Value = "thirtyMinutes")]
        ThirtyMinutes,
        /// <summary>Sync every sixty minutes.</summary>
        [EnumMember(Value = "sixtyMinutes")]
        SixtyMinutes,
        /// <summary>Sync based on my usage.</summary>
        [EnumMember(Value = "basedOnMyUsage")]
        BasedOnMyUsage,
    }
}
