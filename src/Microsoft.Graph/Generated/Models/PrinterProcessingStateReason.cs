using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum PrinterProcessingStateReason {
        [EnumMember(Value = "paused")]
        Paused,
        [EnumMember(Value = "mediaJam")]
        MediaJam,
        [EnumMember(Value = "mediaNeeded")]
        MediaNeeded,
        [EnumMember(Value = "mediaLow")]
        MediaLow,
        [EnumMember(Value = "mediaEmpty")]
        MediaEmpty,
        [EnumMember(Value = "coverOpen")]
        CoverOpen,
        [EnumMember(Value = "interlockOpen")]
        InterlockOpen,
        [EnumMember(Value = "outputTrayMissing")]
        OutputTrayMissing,
        [EnumMember(Value = "outputAreaFull")]
        OutputAreaFull,
        [EnumMember(Value = "markerSupplyLow")]
        MarkerSupplyLow,
        [EnumMember(Value = "markerSupplyEmpty")]
        MarkerSupplyEmpty,
        [EnumMember(Value = "inputTrayMissing")]
        InputTrayMissing,
        [EnumMember(Value = "outputAreaAlmostFull")]
        OutputAreaAlmostFull,
        [EnumMember(Value = "markerWasteAlmostFull")]
        MarkerWasteAlmostFull,
        [EnumMember(Value = "markerWasteFull")]
        MarkerWasteFull,
        [EnumMember(Value = "fuserOverTemp")]
        FuserOverTemp,
        [EnumMember(Value = "fuserUnderTemp")]
        FuserUnderTemp,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "movingToPaused")]
        MovingToPaused,
        [EnumMember(Value = "shutdown")]
        Shutdown,
        [EnumMember(Value = "connectingToDevice")]
        ConnectingToDevice,
        [EnumMember(Value = "timedOut")]
        TimedOut,
        [EnumMember(Value = "stopping")]
        Stopping,
        [EnumMember(Value = "stoppedPartially")]
        StoppedPartially,
        [EnumMember(Value = "tonerLow")]
        TonerLow,
        [EnumMember(Value = "tonerEmpty")]
        TonerEmpty,
        [EnumMember(Value = "spoolAreaFull")]
        SpoolAreaFull,
        [EnumMember(Value = "doorOpen")]
        DoorOpen,
        [EnumMember(Value = "opticalPhotoConductorNearEndOfLife")]
        OpticalPhotoConductorNearEndOfLife,
        [EnumMember(Value = "opticalPhotoConductorLifeOver")]
        OpticalPhotoConductorLifeOver,
        [EnumMember(Value = "developerLow")]
        DeveloperLow,
        [EnumMember(Value = "developerEmpty")]
        DeveloperEmpty,
        [EnumMember(Value = "interpreterResourceUnavailable")]
        InterpreterResourceUnavailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
