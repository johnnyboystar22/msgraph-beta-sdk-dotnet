using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TeamworkDeviceType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "ipPhone")]
        IpPhone,
        [EnumMember(Value = "teamsRoom")]
        TeamsRoom,
        [EnumMember(Value = "surfaceHub")]
        SurfaceHub,
        [EnumMember(Value = "collaborationBar")]
        CollaborationBar,
        [EnumMember(Value = "teamsDisplay")]
        TeamsDisplay,
        [EnumMember(Value = "touchConsole")]
        TouchConsole,
        [EnumMember(Value = "lowCostPhone")]
        LowCostPhone,
        [EnumMember(Value = "teamsPanel")]
        TeamsPanel,
        [EnumMember(Value = "sip")]
        Sip,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
