using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android For Work cross profile data sharing type.</summary>
    public enum AndroidForWorkCrossProfileDataSharingType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Prevent any sharing.</summary>
        [EnumMember(Value = "preventAny")]
        PreventAny,
        /// <summary>Allow data sharing request from personal profile to work profile.</summary>
        [EnumMember(Value = "allowPersonalToWork")]
        AllowPersonalToWork,
        /// <summary>No restrictions on sharing.</summary>
        [EnumMember(Value = "noRestrictions")]
        NoRestrictions,
    }
}
