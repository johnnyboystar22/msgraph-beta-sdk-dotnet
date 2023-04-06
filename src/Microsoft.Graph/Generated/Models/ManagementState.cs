using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Management state of device in Microsoft Intune.</summary>
    public enum ManagementState {
        /// <summary>The device is under management</summary>
        [EnumMember(Value = "managed")]
        Managed,
        /// <summary>A retire command is occuring on the device and in the process of unenrolling from management</summary>
        [EnumMember(Value = "retirePending")]
        RetirePending,
        /// <summary>Retire command failed on the device</summary>
        [EnumMember(Value = "retireFailed")]
        RetireFailed,
        /// <summary>A wipe command is occuring on the device and in the process of unenrolling from management</summary>
        [EnumMember(Value = "wipePending")]
        WipePending,
        /// <summary>Wipe command failed on the device</summary>
        [EnumMember(Value = "wipeFailed")]
        WipeFailed,
        /// <summary>The device is unhealthy.</summary>
        [EnumMember(Value = "unhealthy")]
        Unhealthy,
        /// <summary>A delete command is occuring on the device </summary>
        [EnumMember(Value = "deletePending")]
        DeletePending,
        /// <summary>A retire command was issued for the device</summary>
        [EnumMember(Value = "retireIssued")]
        RetireIssued,
        /// <summary>A wipe command was issued for the device</summary>
        [EnumMember(Value = "wipeIssued")]
        WipeIssued,
        /// <summary>A wipe command for this device has been canceled</summary>
        [EnumMember(Value = "wipeCanceled")]
        WipeCanceled,
        /// <summary>A retire command for this device has been canceled</summary>
        [EnumMember(Value = "retireCanceled")]
        RetireCanceled,
        /// <summary>The device is discovered but not fully enrolled.</summary>
        [EnumMember(Value = "discovered")]
        Discovered,
    }
}
