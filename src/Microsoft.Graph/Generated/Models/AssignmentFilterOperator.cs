using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents the different type of operators which can be used to craft the AssignmentFilter rule.</summary>
    public enum AssignmentFilterOperator {
        /// <summary>NotSet.</summary>
        [EnumMember(Value = "notSet")]
        NotSet,
        /// <summary>Equals.</summary>
        [EnumMember(Value = "equals")]
        Equals,
        /// <summary>NotEquals.</summary>
        [EnumMember(Value = "notEquals")]
        NotEquals,
        /// <summary>StartsWith.</summary>
        [EnumMember(Value = "startsWith")]
        StartsWith,
        /// <summary>NotStartsWith.</summary>
        [EnumMember(Value = "notStartsWith")]
        NotStartsWith,
        /// <summary>Contains.</summary>
        [EnumMember(Value = "contains")]
        Contains,
        /// <summary>NotContains.</summary>
        [EnumMember(Value = "notContains")]
        NotContains,
        /// <summary>In.</summary>
        [EnumMember(Value = "in")]
        In,
        /// <summary>NotIn.</summary>
        [EnumMember(Value = "notIn")]
        NotIn,
        /// <summary>EndsWith.</summary>
        [EnumMember(Value = "endsWith")]
        EndsWith,
        /// <summary>NotEndsWith.</summary>
        [EnumMember(Value = "notEndsWith")]
        NotEndsWith,
    }
}
