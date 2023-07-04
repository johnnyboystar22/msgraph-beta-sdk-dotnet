using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EndUserNotificationType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "positiveReinforcement")]
        PositiveReinforcement,
        [EnumMember(Value = "noTraining")]
        NoTraining,
        [EnumMember(Value = "trainingAssignment")]
        TrainingAssignment,
        [EnumMember(Value = "trainingReminder")]
        TrainingReminder,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
