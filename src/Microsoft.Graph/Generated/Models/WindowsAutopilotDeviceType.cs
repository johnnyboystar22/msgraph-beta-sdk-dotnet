using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum WindowsAutopilotDeviceType {
        /// <summary>Windows PC</summary>
        [EnumMember(Value = "windowsPc")]
        WindowsPc,
        /// <summary>Surface Hub 2</summary>
        [EnumMember(Value = "surfaceHub2")]
        SurfaceHub2,
        /// <summary>HoloLens</summary>
        [EnumMember(Value = "holoLens")]
        HoloLens,
        /// <summary>SurfaceHub2S</summary>
        [EnumMember(Value = "surfaceHub2S")]
        SurfaceHub2S,
        /// <summary>VirtualMachine</summary>
        [EnumMember(Value = "virtualMachine")]
        VirtualMachine,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.         </summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
