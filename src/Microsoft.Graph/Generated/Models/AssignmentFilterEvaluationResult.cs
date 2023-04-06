using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported evaluation results for filter.</summary>
    public enum AssignmentFilterEvaluationResult {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Match.</summary>
        [EnumMember(Value = "match")]
        Match,
        /// <summary>NotMatch.</summary>
        [EnumMember(Value = "notMatch")]
        NotMatch,
        /// <summary>Inconclusive.</summary>
        [EnumMember(Value = "inconclusive")]
        Inconclusive,
        /// <summary>Failure.</summary>
        [EnumMember(Value = "failure")]
        Failure,
        /// <summary>NotEvaluated.</summary>
        [EnumMember(Value = "notEvaluated")]
        NotEvaluated,
    }
}
