using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum MigrationStatus {
        [EnumMember(Value = "ready")]
        Ready,
        [EnumMember(Value = "needsReview")]
        NeedsReview,
        [EnumMember(Value = "additionalStepsRequired")]
        AdditionalStepsRequired,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
