using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values for internet site security level.</summary>
    public enum InternetSiteSecurityLevel {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Medium.</summary>
        [EnumMember(Value = "medium")]
        Medium,
        /// <summary>Medium-High.</summary>
        [EnumMember(Value = "mediumHigh")]
        MediumHigh,
        /// <summary>High.</summary>
        [EnumMember(Value = "high")]
        High,
    }
}
