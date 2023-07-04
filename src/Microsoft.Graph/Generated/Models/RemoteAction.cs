using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Remote actions Intune supports.</summary>
    public enum RemoteAction {
        /// <summary>Indicate user initiates an unknown action.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicate user initiates an action to factory reset a device. </summary>
        [EnumMember(Value = "factoryReset")]
        FactoryReset,
        /// <summary>Indicate user initiates an action to remove company data from a device. </summary>
        [EnumMember(Value = "removeCompanyData")]
        RemoveCompanyData,
        /// <summary>Indicate user initiates an action to remove the passcode of an iOS device, or reset the passcode of Android / Windows device. </summary>
        [EnumMember(Value = "resetPasscode")]
        ResetPasscode,
        /// <summary>Indicate user initiates an action to remote lock a device.</summary>
        [EnumMember(Value = "remoteLock")]
        RemoteLock,
        /// <summary>Indicate user initiates an action to enable lost mode on a supervised iOS device.</summary>
        [EnumMember(Value = "enableLostMode")]
        EnableLostMode,
        /// <summary>Indicate user initiates an action to disable lost mode on a supervised iOS device.</summary>
        [EnumMember(Value = "disableLostMode")]
        DisableLostMode,
        /// <summary>Indicate user initiates an action to locate a supervised iOS device.</summary>
        [EnumMember(Value = "locateDevice")]
        LocateDevice,
        /// <summary>Indicate user initiates an action to reboot the device.</summary>
        [EnumMember(Value = "rebootNow")]
        RebootNow,
        /// <summary>Indicate user initiates an action to reset the pin for passport for work on windows phone device.</summary>
        [EnumMember(Value = "recoverPasscode")]
        RecoverPasscode,
        /// <summary>Indicate user initiates an action to clean up windows device.</summary>
        [EnumMember(Value = "cleanWindowsDevice")]
        CleanWindowsDevice,
        /// <summary>Indicate user initiates an action to log out current user on shared apple device.</summary>
        [EnumMember(Value = "logoutSharedAppleDeviceActiveUser")]
        LogoutSharedAppleDeviceActiveUser,
        /// <summary>Indicate user initiates an action to run quick scan on device.</summary>
        [EnumMember(Value = "quickScan")]
        QuickScan,
        /// <summary>Indicate user initiates an action to run full scan on device.</summary>
        [EnumMember(Value = "fullScan")]
        FullScan,
        /// <summary>Indicate user initiates an action to update malware signatures on device.</summary>
        [EnumMember(Value = "windowsDefenderUpdateSignatures")]
        WindowsDefenderUpdateSignatures,
        /// <summary>Indicate user initiates an action remote wipe device with keeping enrollment data.</summary>
        [EnumMember(Value = "factoryResetKeepEnrollmentData")]
        FactoryResetKeepEnrollmentData,
        /// <summary>Indicate user initiates an action to update account on device.</summary>
        [EnumMember(Value = "updateDeviceAccount")]
        UpdateDeviceAccount,
        /// <summary>Indicate user initiates an action to automatic redeploy the device</summary>
        [EnumMember(Value = "automaticRedeployment")]
        AutomaticRedeployment,
        /// <summary>Indicate user initiates an action to shut down the device.</summary>
        [EnumMember(Value = "shutDown")]
        ShutDown,
        /// <summary>Indicate user initiates an action to Rotate BitLockerKeys on the device.</summary>
        [EnumMember(Value = "rotateBitLockerKeys")]
        RotateBitLockerKeys,
        /// <summary>Indicate user initiates an action to Rotate FileVaultKey on mac.</summary>
        [EnumMember(Value = "rotateFileVaultKey")]
        RotateFileVaultKey,
        /// <summary>Indicate user initiates an action to Get FileVaultKey on mac.</summary>
        [EnumMember(Value = "getFileVaultKey")]
        GetFileVaultKey,
        /// <summary>Indicate user initiates an action to Set Device Name on the device.</summary>
        [EnumMember(Value = "setDeviceName")]
        SetDeviceName,
        /// <summary>Indicate user initiates an action to Activate eSIM on the device.</summary>
        [EnumMember(Value = "activateDeviceEsim")]
        ActivateDeviceEsim,
        /// <summary>Indicate user initiates an action to deprovision the device.</summary>
        [EnumMember(Value = "deprovision")]
        Deprovision,
        /// <summary>Indicate user initiates an action to disable the device.</summary>
        [EnumMember(Value = "disable")]
        Disable,
        /// <summary>Indicate user initiates an action to reenable the device.</summary>
        [EnumMember(Value = "reenable")]
        Reenable,
        /// <summary>Indicate user initiates an action to move the device to a new organizational unit.</summary>
        [EnumMember(Value = "moveDeviceToOrganizationalUnit")]
        MoveDeviceToOrganizationalUnit,
        /// <summary>Add device action of InitiateMobileDeviceManagementKeyRecovery</summary>
        [EnumMember(Value = "initiateMobileDeviceManagementKeyRecovery")]
        InitiateMobileDeviceManagementKeyRecovery,
        /// <summary>Add device action of InitiateOnDemandProactiveRemediation</summary>
        [EnumMember(Value = "initiateOnDemandProactiveRemediation")]
        InitiateOnDemandProactiveRemediation,
        /// <summary>Add device action of RotateLocalAdminPassword</summary>
        [EnumMember(Value = "rotateLocalAdminPassword")]
        RotateLocalAdminPassword,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
