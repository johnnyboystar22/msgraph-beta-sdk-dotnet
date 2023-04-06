using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum RecordCompletionReason {
        [EnumMember(Value = "operationCanceled")]
        OperationCanceled,
        [EnumMember(Value = "stopToneDetected")]
        StopToneDetected,
        [EnumMember(Value = "maxRecordDurationReached")]
        MaxRecordDurationReached,
        [EnumMember(Value = "initialSilenceTimeout")]
        InitialSilenceTimeout,
        [EnumMember(Value = "maxSilenceTimeout")]
        MaxSilenceTimeout,
        [EnumMember(Value = "playPromptFailed")]
        PlayPromptFailed,
        [EnumMember(Value = "playBeepFailed")]
        PlayBeepFailed,
        [EnumMember(Value = "mediaReceiveTimeout")]
        MediaReceiveTimeout,
        [EnumMember(Value = "unspecifiedError")]
        UnspecifiedError,
    }
}
