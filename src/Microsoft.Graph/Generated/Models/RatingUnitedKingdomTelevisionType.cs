using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>TV content rating labels in United Kingdom</summary>
    public enum RatingUnitedKingdomTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>Allowing TV contents with a warning message</summary>
        [EnumMember(Value = "caution")]
        Caution,
    }
}
