using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for automatic update classification.</summary>
    public enum UpdateClassification {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Recommended and important.</summary>
        [EnumMember(Value = "recommendedAndImportant")]
        RecommendedAndImportant,
        /// <summary>Important.</summary>
        [EnumMember(Value = "important")]
        Important,
        /// <summary>None.</summary>
        [EnumMember(Value = "none")]
        None,
    }
}
