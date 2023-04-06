using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>TV content rating labels in Ireland</summary>
    public enum RatingIrelandTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The GA classification is suitable for all audiences</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The CH classification is suitable for children</summary>
        [EnumMember(Value = "children")]
        Children,
        /// <summary>The YA classification is suitable for teenage audience</summary>
        [EnumMember(Value = "youngAdults")]
        YoungAdults,
        /// <summary>The PS classification invites parents and guardians to consider restriction children’s access</summary>
        [EnumMember(Value = "parentalSupervision")]
        ParentalSupervision,
        /// <summary>The MA classification is suitable for adults</summary>
        [EnumMember(Value = "mature")]
        Mature,
    }
}
