using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>TV content rating labels in United States</summary>
    public enum RatingUnitedStatesTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>TV-Y, all children</summary>
        [EnumMember(Value = "childrenAll")]
        ChildrenAll,
        /// <summary>TV-Y7, children age 7 and above</summary>
        [EnumMember(Value = "childrenAbove7")]
        ChildrenAbove7,
        /// <summary>TV-G, suitable for all ages</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>TV-PG, parental guidance</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>TV-14, children age 14 and above</summary>
        [EnumMember(Value = "childrenAbove14")]
        ChildrenAbove14,
        /// <summary>TV-MA, adults only</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}
