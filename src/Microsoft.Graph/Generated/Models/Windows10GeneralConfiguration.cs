using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10GeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail {
            get { return BackingStore?.Get<bool?>("accountsBlockAddingNonMicrosoftAccountEmail"); }
            set { BackingStore?.Set("accountsBlockAddingNonMicrosoftAccountEmail", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? ActivateAppsWithVoice {
            get { return BackingStore?.Get<Enablement?>("activateAppsWithVoice"); }
            set { BackingStore?.Set("activateAppsWithVoice", value); }
        }
        /// <summary>Indicates whether or not to block the user from selecting an AntiTheft mode preference (Windows 10 Mobile only).</summary>
        public bool? AntiTheftModeBlocked {
            get { return BackingStore?.Get<bool?>("antiTheftModeBlocked"); }
            set { BackingStore?.Set("antiTheftModeBlocked", value); }
        }
        /// <summary>This policy setting permits users to change installation options that typically are available only to system administrators.</summary>
        public bool? AppManagementMSIAllowUserControlOverInstall {
            get { return BackingStore?.Get<bool?>("appManagementMSIAllowUserControlOverInstall"); }
            set { BackingStore?.Set("appManagementMSIAllowUserControlOverInstall", value); }
        }
        /// <summary>This policy setting directs Windows Installer to use elevated permissions when it installs any program on the system.</summary>
        public bool? AppManagementMSIAlwaysInstallWithElevatedPrivileges {
            get { return BackingStore?.Get<bool?>("appManagementMSIAlwaysInstallWithElevatedPrivileges"); }
            set { BackingStore?.Set("appManagementMSIAlwaysInstallWithElevatedPrivileges", value); }
        }
        /// <summary>List of semi-colon delimited Package Family Names of Windows apps. Listed Windows apps are to be launched after logon.​</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AppManagementPackageFamilyNamesToLaunchAfterLogOn {
            get { return BackingStore?.Get<List<string>?>("appManagementPackageFamilyNamesToLaunchAfterLogOn"); }
            set { BackingStore?.Set("appManagementPackageFamilyNamesToLaunchAfterLogOn", value); }
        }
#nullable restore
#else
        public List<string> AppManagementPackageFamilyNamesToLaunchAfterLogOn {
            get { return BackingStore?.Get<List<string>>("appManagementPackageFamilyNamesToLaunchAfterLogOn"); }
            set { BackingStore?.Set("appManagementPackageFamilyNamesToLaunchAfterLogOn", value); }
        }
#endif
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? AppsAllowTrustedAppsSideloading {
            get { return BackingStore?.Get<StateManagementSetting?>("appsAllowTrustedAppsSideloading"); }
            set { BackingStore?.Set("appsAllowTrustedAppsSideloading", value); }
        }
        /// <summary>Indicates whether or not to disable the launch of all apps from Windows Store that came pre-installed or were downloaded.</summary>
        public bool? AppsBlockWindowsStoreOriginatedApps {
            get { return BackingStore?.Get<bool?>("appsBlockWindowsStoreOriginatedApps"); }
            set { BackingStore?.Set("appsBlockWindowsStoreOriginatedApps", value); }
        }
        /// <summary>Allows secondary authentication devices to work with Windows.</summary>
        public bool? AuthenticationAllowSecondaryDevice {
            get { return BackingStore?.Get<bool?>("authenticationAllowSecondaryDevice"); }
            set { BackingStore?.Set("authenticationAllowSecondaryDevice", value); }
        }
        /// <summary>Specifies the preferred domain among available domains in the Azure AD tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationPreferredAzureADTenantDomainName {
            get { return BackingStore?.Get<string?>("authenticationPreferredAzureADTenantDomainName"); }
            set { BackingStore?.Set("authenticationPreferredAzureADTenantDomainName", value); }
        }
#nullable restore
#else
        public string AuthenticationPreferredAzureADTenantDomainName {
            get { return BackingStore?.Get<string>("authenticationPreferredAzureADTenantDomainName"); }
            set { BackingStore?.Set("authenticationPreferredAzureADTenantDomainName", value); }
        }
#endif
        /// <summary>Possible values of a property</summary>
        public Enablement? AuthenticationWebSignIn {
            get { return BackingStore?.Get<Enablement?>("authenticationWebSignIn"); }
            set { BackingStore?.Set("authenticationWebSignIn", value); }
        }
        /// <summary>Specify a list of allowed Bluetooth services and profiles in hex formatted strings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BluetoothAllowedServices {
            get { return BackingStore?.Get<List<string>?>("bluetoothAllowedServices"); }
            set { BackingStore?.Set("bluetoothAllowedServices", value); }
        }
#nullable restore
#else
        public List<string> BluetoothAllowedServices {
            get { return BackingStore?.Get<List<string>>("bluetoothAllowedServices"); }
            set { BackingStore?.Set("bluetoothAllowedServices", value); }
        }
#endif
        /// <summary>Whether or not to Block the user from using bluetooth advertising.</summary>
        public bool? BluetoothBlockAdvertising {
            get { return BackingStore?.Get<bool?>("bluetoothBlockAdvertising"); }
            set { BackingStore?.Set("bluetoothBlockAdvertising", value); }
        }
        /// <summary>Whether or not to Block the user from using bluetooth discoverable mode.</summary>
        public bool? BluetoothBlockDiscoverableMode {
            get { return BackingStore?.Get<bool?>("bluetoothBlockDiscoverableMode"); }
            set { BackingStore?.Set("bluetoothBlockDiscoverableMode", value); }
        }
        /// <summary>Whether or not to Block the user from using bluetooth.</summary>
        public bool? BluetoothBlocked {
            get { return BackingStore?.Get<bool?>("bluetoothBlocked"); }
            set { BackingStore?.Set("bluetoothBlocked", value); }
        }
        /// <summary>Whether or not to block specific bundled Bluetooth peripherals to automatically pair with the host device.</summary>
        public bool? BluetoothBlockPrePairing {
            get { return BackingStore?.Get<bool?>("bluetoothBlockPrePairing"); }
            set { BackingStore?.Set("bluetoothBlockPrePairing", value); }
        }
        /// <summary>Whether or not to block the users from using Swift Pair and other proximity based scenarios.</summary>
        public bool? BluetoothBlockPromptedProximalConnections {
            get { return BackingStore?.Get<bool?>("bluetoothBlockPromptedProximalConnections"); }
            set { BackingStore?.Set("bluetoothBlockPromptedProximalConnections", value); }
        }
        /// <summary>Whether or not to Block the user from accessing the camera of the device.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>("cameraBlocked"); }
            set { BackingStore?.Set("cameraBlocked", value); }
        }
        /// <summary>Whether or not to Block the user from using data over cellular while roaming.</summary>
        public bool? CellularBlockDataWhenRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockDataWhenRoaming"); }
            set { BackingStore?.Set("cellularBlockDataWhenRoaming", value); }
        }
        /// <summary>Whether or not to Block the user from using VPN over cellular.</summary>
        public bool? CellularBlockVpn {
            get { return BackingStore?.Get<bool?>("cellularBlockVpn"); }
            set { BackingStore?.Set("cellularBlockVpn", value); }
        }
        /// <summary>Whether or not to Block the user from using VPN when roaming over cellular.</summary>
        public bool? CellularBlockVpnWhenRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockVpnWhenRoaming"); }
            set { BackingStore?.Set("cellularBlockVpnWhenRoaming", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? CellularData {
            get { return BackingStore?.Get<ConfigurationUsage?>("cellularData"); }
            set { BackingStore?.Set("cellularData", value); }
        }
        /// <summary>Whether or not to Block the user from doing manual root certificate installation.</summary>
        public bool? CertificatesBlockManualRootCertificateInstallation {
            get { return BackingStore?.Get<bool?>("certificatesBlockManualRootCertificateInstallation"); }
            set { BackingStore?.Set("certificatesBlockManualRootCertificateInstallation", value); }
        }
        /// <summary>Specifies the time zone to be applied to the device. This is the standard Windows name for the target time zone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigureTimeZone {
            get { return BackingStore?.Get<string?>("configureTimeZone"); }
            set { BackingStore?.Set("configureTimeZone", value); }
        }
#nullable restore
#else
        public string ConfigureTimeZone {
            get { return BackingStore?.Get<string>("configureTimeZone"); }
            set { BackingStore?.Set("configureTimeZone", value); }
        }
#endif
        /// <summary>Whether or not to block Connected Devices Service which enables discovery and connection to other devices, remote messaging, remote app sessions and other cross-device experiences.</summary>
        public bool? ConnectedDevicesServiceBlocked {
            get { return BackingStore?.Get<bool?>("connectedDevicesServiceBlocked"); }
            set { BackingStore?.Set("connectedDevicesServiceBlocked", value); }
        }
        /// <summary>Whether or not to Block the user from using copy paste.</summary>
        public bool? CopyPasteBlocked {
            get { return BackingStore?.Get<bool?>("copyPasteBlocked"); }
            set { BackingStore?.Set("copyPasteBlocked", value); }
        }
        /// <summary>Whether or not to Block the user from using Cortana.</summary>
        public bool? CortanaBlocked {
            get { return BackingStore?.Get<bool?>("cortanaBlocked"); }
            set { BackingStore?.Set("cortanaBlocked", value); }
        }
        /// <summary>Specify whether to allow or disallow the Federal Information Processing Standard (FIPS) policy.</summary>
        public bool? CryptographyAllowFipsAlgorithmPolicy {
            get { return BackingStore?.Get<bool?>("cryptographyAllowFipsAlgorithmPolicy"); }
            set { BackingStore?.Set("cryptographyAllowFipsAlgorithmPolicy", value); }
        }
        /// <summary>This policy setting allows you to block direct memory access (DMA) for all hot pluggable PCI downstream ports until a user logs into Windows.</summary>
        public bool? DataProtectionBlockDirectMemoryAccess {
            get { return BackingStore?.Get<bool?>("dataProtectionBlockDirectMemoryAccess"); }
            set { BackingStore?.Set("dataProtectionBlockDirectMemoryAccess", value); }
        }
        /// <summary>Whether or not to block end user access to Defender.</summary>
        public bool? DefenderBlockEndUserAccess {
            get { return BackingStore?.Get<bool?>("defenderBlockEndUserAccess"); }
            set { BackingStore?.Set("defenderBlockEndUserAccess", value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderBlockOnAccessProtection {
            get { return BackingStore?.Get<bool?>("defenderBlockOnAccessProtection"); }
            set { BackingStore?.Set("defenderBlockOnAccessProtection", value); }
        }
        /// <summary>Possible values of Cloud Block Level</summary>
        public DefenderCloudBlockLevelType? DefenderCloudBlockLevel {
            get { return BackingStore?.Get<DefenderCloudBlockLevelType?>("defenderCloudBlockLevel"); }
            set { BackingStore?.Set("defenderCloudBlockLevel", value); }
        }
        /// <summary>Timeout extension for file scanning by the cloud. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeout {
            get { return BackingStore?.Get<int?>("defenderCloudExtendedTimeout"); }
            set { BackingStore?.Set("defenderCloudExtendedTimeout", value); }
        }
        /// <summary>Timeout extension for file scanning by the cloud. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("defenderCloudExtendedTimeoutInSeconds"); }
            set { BackingStore?.Set("defenderCloudExtendedTimeoutInSeconds", value); }
        }
        /// <summary>Number of days before deleting quarantined malware. Valid values 0 to 90</summary>
        public int? DefenderDaysBeforeDeletingQuarantinedMalware {
            get { return BackingStore?.Get<int?>("defenderDaysBeforeDeletingQuarantinedMalware"); }
            set { BackingStore?.Set("defenderDaysBeforeDeletingQuarantinedMalware", value); }
        }
        /// <summary>Gets or sets Defender’s actions to take on detected Malware per threat level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions? DefenderDetectedMalwareActions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions?>("defenderDetectedMalwareActions"); }
            set { BackingStore?.Set("defenderDetectedMalwareActions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions DefenderDetectedMalwareActions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>("defenderDetectedMalwareActions"); }
            set { BackingStore?.Set("defenderDetectedMalwareActions", value); }
        }
#endif
        /// <summary>When blocked, catch-up scans for scheduled full scans will be turned off.</summary>
        public bool? DefenderDisableCatchupFullScan {
            get { return BackingStore?.Get<bool?>("defenderDisableCatchupFullScan"); }
            set { BackingStore?.Set("defenderDisableCatchupFullScan", value); }
        }
        /// <summary>When blocked, catch-up scans for scheduled quick scans will be turned off.</summary>
        public bool? DefenderDisableCatchupQuickScan {
            get { return BackingStore?.Get<bool?>("defenderDisableCatchupQuickScan"); }
            set { BackingStore?.Set("defenderDisableCatchupQuickScan", value); }
        }
        /// <summary>File extensions to exclude from scans and real time protection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderFileExtensionsToExclude {
            get { return BackingStore?.Get<List<string>?>("defenderFileExtensionsToExclude"); }
            set { BackingStore?.Set("defenderFileExtensionsToExclude", value); }
        }
#nullable restore
#else
        public List<string> DefenderFileExtensionsToExclude {
            get { return BackingStore?.Get<List<string>>("defenderFileExtensionsToExclude"); }
            set { BackingStore?.Set("defenderFileExtensionsToExclude", value); }
        }
#endif
        /// <summary>Files and folder to exclude from scans and real time protection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderFilesAndFoldersToExclude {
            get { return BackingStore?.Get<List<string>?>("defenderFilesAndFoldersToExclude"); }
            set { BackingStore?.Set("defenderFilesAndFoldersToExclude", value); }
        }
#nullable restore
#else
        public List<string> DefenderFilesAndFoldersToExclude {
            get { return BackingStore?.Get<List<string>>("defenderFilesAndFoldersToExclude"); }
            set { BackingStore?.Set("defenderFilesAndFoldersToExclude", value); }
        }
#endif
        /// <summary>Possible values for monitoring file activity.</summary>
        public Microsoft.Graph.Beta.Models.DefenderMonitorFileActivity? DefenderMonitorFileActivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderMonitorFileActivity?>("defenderMonitorFileActivity"); }
            set { BackingStore?.Set("defenderMonitorFileActivity", value); }
        }
        /// <summary>Gets or sets Defender’s action to take on Potentially Unwanted Application (PUA), which includes software with behaviors of ad-injection, software bundling, persistent solicitation for payment or subscription, etc. Defender alerts user when PUA is being downloaded or attempts to install itself. Added in Windows 10 for desktop. Possible values are: deviceDefault, block, audit.</summary>
        public Microsoft.Graph.Beta.Models.DefenderPotentiallyUnwantedAppAction? DefenderPotentiallyUnwantedAppAction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderPotentiallyUnwantedAppAction?>("defenderPotentiallyUnwantedAppAction"); }
            set { BackingStore?.Set("defenderPotentiallyUnwantedAppAction", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderPotentiallyUnwantedAppActionSetting {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderPotentiallyUnwantedAppActionSetting"); }
            set { BackingStore?.Set("defenderPotentiallyUnwantedAppActionSetting", value); }
        }
        /// <summary>Processes to exclude from scans and real time protection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderProcessesToExclude {
            get { return BackingStore?.Get<List<string>?>("defenderProcessesToExclude"); }
            set { BackingStore?.Set("defenderProcessesToExclude", value); }
        }
#nullable restore
#else
        public List<string> DefenderProcessesToExclude {
            get { return BackingStore?.Get<List<string>>("defenderProcessesToExclude"); }
            set { BackingStore?.Set("defenderProcessesToExclude", value); }
        }
#endif
        /// <summary>Possible values for prompting user for samples submission.</summary>
        public Microsoft.Graph.Beta.Models.DefenderPromptForSampleSubmission? DefenderPromptForSampleSubmission {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderPromptForSampleSubmission?>("defenderPromptForSampleSubmission"); }
            set { BackingStore?.Set("defenderPromptForSampleSubmission", value); }
        }
        /// <summary>Indicates whether or not to require behavior monitoring.</summary>
        public bool? DefenderRequireBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>("defenderRequireBehaviorMonitoring"); }
            set { BackingStore?.Set("defenderRequireBehaviorMonitoring", value); }
        }
        /// <summary>Indicates whether or not to require cloud protection.</summary>
        public bool? DefenderRequireCloudProtection {
            get { return BackingStore?.Get<bool?>("defenderRequireCloudProtection"); }
            set { BackingStore?.Set("defenderRequireCloudProtection", value); }
        }
        /// <summary>Indicates whether or not to require network inspection system.</summary>
        public bool? DefenderRequireNetworkInspectionSystem {
            get { return BackingStore?.Get<bool?>("defenderRequireNetworkInspectionSystem"); }
            set { BackingStore?.Set("defenderRequireNetworkInspectionSystem", value); }
        }
        /// <summary>Indicates whether or not to require real time monitoring.</summary>
        public bool? DefenderRequireRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>("defenderRequireRealTimeMonitoring"); }
            set { BackingStore?.Set("defenderRequireRealTimeMonitoring", value); }
        }
        /// <summary>Indicates whether or not to scan archive files.</summary>
        public bool? DefenderScanArchiveFiles {
            get { return BackingStore?.Get<bool?>("defenderScanArchiveFiles"); }
            set { BackingStore?.Set("defenderScanArchiveFiles", value); }
        }
        /// <summary>Indicates whether or not to scan downloads.</summary>
        public bool? DefenderScanDownloads {
            get { return BackingStore?.Get<bool?>("defenderScanDownloads"); }
            set { BackingStore?.Set("defenderScanDownloads", value); }
        }
        /// <summary>Indicates whether or not to scan incoming mail messages.</summary>
        public bool? DefenderScanIncomingMail {
            get { return BackingStore?.Get<bool?>("defenderScanIncomingMail"); }
            set { BackingStore?.Set("defenderScanIncomingMail", value); }
        }
        /// <summary>Indicates whether or not to scan mapped network drives during full scan.</summary>
        public bool? DefenderScanMappedNetworkDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>("defenderScanMappedNetworkDrivesDuringFullScan"); }
            set { BackingStore?.Set("defenderScanMappedNetworkDrivesDuringFullScan", value); }
        }
        /// <summary>Max CPU usage percentage during scan. Valid values 0 to 100</summary>
        public int? DefenderScanMaxCpu {
            get { return BackingStore?.Get<int?>("defenderScanMaxCpu"); }
            set { BackingStore?.Set("defenderScanMaxCpu", value); }
        }
        /// <summary>Indicates whether or not to scan files opened from a network folder.</summary>
        public bool? DefenderScanNetworkFiles {
            get { return BackingStore?.Get<bool?>("defenderScanNetworkFiles"); }
            set { BackingStore?.Set("defenderScanNetworkFiles", value); }
        }
        /// <summary>Indicates whether or not to scan removable drives during full scan.</summary>
        public bool? DefenderScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>("defenderScanRemovableDrivesDuringFullScan"); }
            set { BackingStore?.Set("defenderScanRemovableDrivesDuringFullScan", value); }
        }
        /// <summary>Indicates whether or not to scan scripts loaded in Internet Explorer browser.</summary>
        public bool? DefenderScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>("defenderScanScriptsLoadedInInternetExplorer"); }
            set { BackingStore?.Set("defenderScanScriptsLoadedInInternetExplorer", value); }
        }
        /// <summary>Possible values for system scan type.</summary>
        public Microsoft.Graph.Beta.Models.DefenderScanType? DefenderScanType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderScanType?>("defenderScanType"); }
            set { BackingStore?.Set("defenderScanType", value); }
        }
        /// <summary>The time to perform a daily quick scan.</summary>
        public Time? DefenderScheduledQuickScanTime {
            get { return BackingStore?.Get<Time?>("defenderScheduledQuickScanTime"); }
            set { BackingStore?.Set("defenderScheduledQuickScanTime", value); }
        }
        /// <summary>The defender time for the system scan.</summary>
        public Time? DefenderScheduledScanTime {
            get { return BackingStore?.Get<Time?>("defenderScheduledScanTime"); }
            set { BackingStore?.Set("defenderScheduledScanTime", value); }
        }
        /// <summary>When enabled, low CPU priority will be used during scheduled scans.</summary>
        public bool? DefenderScheduleScanEnableLowCpuPriority {
            get { return BackingStore?.Get<bool?>("defenderScheduleScanEnableLowCpuPriority"); }
            set { BackingStore?.Set("defenderScheduleScanEnableLowCpuPriority", value); }
        }
        /// <summary>The signature update interval in hours. Specify 0 not to check. Valid values 0 to 24</summary>
        public int? DefenderSignatureUpdateIntervalInHours {
            get { return BackingStore?.Get<int?>("defenderSignatureUpdateIntervalInHours"); }
            set { BackingStore?.Set("defenderSignatureUpdateIntervalInHours", value); }
        }
        /// <summary>Checks for the user consent level in Windows Defender to send data. Possible values are: sendSafeSamplesAutomatically, alwaysPrompt, neverSend, sendAllSamplesAutomatically.</summary>
        public Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType? DefenderSubmitSamplesConsentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType?>("defenderSubmitSamplesConsentType"); }
            set { BackingStore?.Set("defenderSubmitSamplesConsentType", value); }
        }
        /// <summary>Possible values for a weekly schedule.</summary>
        public WeeklySchedule? DefenderSystemScanSchedule {
            get { return BackingStore?.Get<WeeklySchedule?>("defenderSystemScanSchedule"); }
            set { BackingStore?.Set("defenderSystemScanSchedule", value); }
        }
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? DeveloperUnlockSetting {
            get { return BackingStore?.Get<StateManagementSetting?>("developerUnlockSetting"); }
            set { BackingStore?.Set("developerUnlockSetting", value); }
        }
        /// <summary>Indicates whether or not to Block the user from resetting their phone.</summary>
        public bool? DeviceManagementBlockFactoryResetOnMobile {
            get { return BackingStore?.Get<bool?>("deviceManagementBlockFactoryResetOnMobile"); }
            set { BackingStore?.Set("deviceManagementBlockFactoryResetOnMobile", value); }
        }
        /// <summary>Indicates whether or not to Block the user from doing manual un-enrollment from device management.</summary>
        public bool? DeviceManagementBlockManualUnenroll {
            get { return BackingStore?.Get<bool?>("deviceManagementBlockManualUnenroll"); }
            set { BackingStore?.Set("deviceManagementBlockManualUnenroll", value); }
        }
        /// <summary>Allow the device to send diagnostic and usage telemetry data, such as Watson.</summary>
        public DiagnosticDataSubmissionMode? DiagnosticsDataSubmissionMode {
            get { return BackingStore?.Get<DiagnosticDataSubmissionMode?>("diagnosticsDataSubmissionMode"); }
            set { BackingStore?.Set("diagnosticsDataSubmissionMode", value); }
        }
        /// <summary>List of legacy applications that have GDI DPI Scaling turned off.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisplayAppListWithGdiDPIScalingTurnedOff {
            get { return BackingStore?.Get<List<string>?>("displayAppListWithGdiDPIScalingTurnedOff"); }
            set { BackingStore?.Set("displayAppListWithGdiDPIScalingTurnedOff", value); }
        }
#nullable restore
#else
        public List<string> DisplayAppListWithGdiDPIScalingTurnedOff {
            get { return BackingStore?.Get<List<string>>("displayAppListWithGdiDPIScalingTurnedOff"); }
            set { BackingStore?.Set("displayAppListWithGdiDPIScalingTurnedOff", value); }
        }
#endif
        /// <summary>List of legacy applications that have GDI DPI Scaling turned on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DisplayAppListWithGdiDPIScalingTurnedOn {
            get { return BackingStore?.Get<List<string>?>("displayAppListWithGdiDPIScalingTurnedOn"); }
            set { BackingStore?.Set("displayAppListWithGdiDPIScalingTurnedOn", value); }
        }
#nullable restore
#else
        public List<string> DisplayAppListWithGdiDPIScalingTurnedOn {
            get { return BackingStore?.Get<List<string>>("displayAppListWithGdiDPIScalingTurnedOn"); }
            set { BackingStore?.Set("displayAppListWithGdiDPIScalingTurnedOn", value); }
        }
#endif
        /// <summary>Allow users to change Start pages on Edge. Use the EdgeHomepageUrls to specify the Start pages that the user would see by default when they open Edge.</summary>
        public bool? EdgeAllowStartPagesModification {
            get { return BackingStore?.Get<bool?>("edgeAllowStartPagesModification"); }
            set { BackingStore?.Set("edgeAllowStartPagesModification", value); }
        }
        /// <summary>Indicates whether or not to prevent access to about flags on Edge browser.</summary>
        public bool? EdgeBlockAccessToAboutFlags {
            get { return BackingStore?.Get<bool?>("edgeBlockAccessToAboutFlags"); }
            set { BackingStore?.Set("edgeBlockAccessToAboutFlags", value); }
        }
        /// <summary>Block the address bar dropdown functionality in Microsoft Edge. Disable this settings to minimize network connections from Microsoft Edge to Microsoft services.</summary>
        public bool? EdgeBlockAddressBarDropdown {
            get { return BackingStore?.Get<bool?>("edgeBlockAddressBarDropdown"); }
            set { BackingStore?.Set("edgeBlockAddressBarDropdown", value); }
        }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? EdgeBlockAutofill {
            get { return BackingStore?.Get<bool?>("edgeBlockAutofill"); }
            set { BackingStore?.Set("edgeBlockAutofill", value); }
        }
        /// <summary>Block Microsoft compatibility list in Microsoft Edge. This list from Microsoft helps Edge properly display sites with known compatibility issues.</summary>
        public bool? EdgeBlockCompatibilityList {
            get { return BackingStore?.Get<bool?>("edgeBlockCompatibilityList"); }
            set { BackingStore?.Set("edgeBlockCompatibilityList", value); }
        }
        /// <summary>Indicates whether or not to block developer tools in the Edge browser.</summary>
        public bool? EdgeBlockDeveloperTools {
            get { return BackingStore?.Get<bool?>("edgeBlockDeveloperTools"); }
            set { BackingStore?.Set("edgeBlockDeveloperTools", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using the Edge browser.</summary>
        public bool? EdgeBlocked {
            get { return BackingStore?.Get<bool?>("edgeBlocked"); }
            set { BackingStore?.Set("edgeBlocked", value); }
        }
        /// <summary>Indicates whether or not to Block the user from making changes to Favorites.</summary>
        public bool? EdgeBlockEditFavorites {
            get { return BackingStore?.Get<bool?>("edgeBlockEditFavorites"); }
            set { BackingStore?.Set("edgeBlockEditFavorites", value); }
        }
        /// <summary>Indicates whether or not to block extensions in the Edge browser.</summary>
        public bool? EdgeBlockExtensions {
            get { return BackingStore?.Get<bool?>("edgeBlockExtensions"); }
            set { BackingStore?.Set("edgeBlockExtensions", value); }
        }
        /// <summary>Allow or prevent Edge from entering the full screen mode.</summary>
        public bool? EdgeBlockFullScreenMode {
            get { return BackingStore?.Get<bool?>("edgeBlockFullScreenMode"); }
            set { BackingStore?.Set("edgeBlockFullScreenMode", value); }
        }
        /// <summary>Indicates whether or not to block InPrivate browsing on corporate networks, in the Edge browser.</summary>
        public bool? EdgeBlockInPrivateBrowsing {
            get { return BackingStore?.Get<bool?>("edgeBlockInPrivateBrowsing"); }
            set { BackingStore?.Set("edgeBlockInPrivateBrowsing", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? EdgeBlockJavaScript {
            get { return BackingStore?.Get<bool?>("edgeBlockJavaScript"); }
            set { BackingStore?.Set("edgeBlockJavaScript", value); }
        }
        /// <summary>Block the collection of information by Microsoft for live tile creation when users pin a site to Start from Microsoft Edge.</summary>
        public bool? EdgeBlockLiveTileDataCollection {
            get { return BackingStore?.Get<bool?>("edgeBlockLiveTileDataCollection"); }
            set { BackingStore?.Set("edgeBlockLiveTileDataCollection", value); }
        }
        /// <summary>Indicates whether or not to Block password manager.</summary>
        public bool? EdgeBlockPasswordManager {
            get { return BackingStore?.Get<bool?>("edgeBlockPasswordManager"); }
            set { BackingStore?.Set("edgeBlockPasswordManager", value); }
        }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? EdgeBlockPopups {
            get { return BackingStore?.Get<bool?>("edgeBlockPopups"); }
            set { BackingStore?.Set("edgeBlockPopups", value); }
        }
        /// <summary>Decide whether Microsoft Edge is prelaunched at Windows startup.</summary>
        public bool? EdgeBlockPrelaunch {
            get { return BackingStore?.Get<bool?>("edgeBlockPrelaunch"); }
            set { BackingStore?.Set("edgeBlockPrelaunch", value); }
        }
        /// <summary>Configure Edge to allow or block printing.</summary>
        public bool? EdgeBlockPrinting {
            get { return BackingStore?.Get<bool?>("edgeBlockPrinting"); }
            set { BackingStore?.Set("edgeBlockPrinting", value); }
        }
        /// <summary>Configure Edge to allow browsing history to be saved or to never save browsing history.</summary>
        public bool? EdgeBlockSavingHistory {
            get { return BackingStore?.Get<bool?>("edgeBlockSavingHistory"); }
            set { BackingStore?.Set("edgeBlockSavingHistory", value); }
        }
        /// <summary>Indicates whether or not to block the user from adding new search engine or changing the default search engine.</summary>
        public bool? EdgeBlockSearchEngineCustomization {
            get { return BackingStore?.Get<bool?>("edgeBlockSearchEngineCustomization"); }
            set { BackingStore?.Set("edgeBlockSearchEngineCustomization", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the search suggestions in the address bar.</summary>
        public bool? EdgeBlockSearchSuggestions {
            get { return BackingStore?.Get<bool?>("edgeBlockSearchSuggestions"); }
            set { BackingStore?.Set("edgeBlockSearchSuggestions", value); }
        }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? EdgeBlockSendingDoNotTrackHeader {
            get { return BackingStore?.Get<bool?>("edgeBlockSendingDoNotTrackHeader"); }
            set { BackingStore?.Set("edgeBlockSendingDoNotTrackHeader", value); }
        }
        /// <summary>Indicates whether or not to switch the intranet traffic from Edge to Internet Explorer. Note: the name of this property is misleading; the property is obsolete, use EdgeSendIntranetTrafficToInternetExplorer instead.</summary>
        public bool? EdgeBlockSendingIntranetTrafficToInternetExplorer {
            get { return BackingStore?.Get<bool?>("edgeBlockSendingIntranetTrafficToInternetExplorer"); }
            set { BackingStore?.Set("edgeBlockSendingIntranetTrafficToInternetExplorer", value); }
        }
        /// <summary>Indicates whether the user can sideload extensions.</summary>
        public bool? EdgeBlockSideloadingExtensions {
            get { return BackingStore?.Get<bool?>("edgeBlockSideloadingExtensions"); }
            set { BackingStore?.Set("edgeBlockSideloadingExtensions", value); }
        }
        /// <summary>Configure whether Edge preloads the new tab page at Windows startup.</summary>
        public bool? EdgeBlockTabPreloading {
            get { return BackingStore?.Get<bool?>("edgeBlockTabPreloading"); }
            set { BackingStore?.Set("edgeBlockTabPreloading", value); }
        }
        /// <summary>Configure to load a blank page in Edge instead of the default New tab page and prevent users from changing it.</summary>
        public bool? EdgeBlockWebContentOnNewTabPage {
            get { return BackingStore?.Get<bool?>("edgeBlockWebContentOnNewTabPage"); }
            set { BackingStore?.Set("edgeBlockWebContentOnNewTabPage", value); }
        }
        /// <summary>Clear browsing data on exiting Microsoft Edge.</summary>
        public bool? EdgeClearBrowsingDataOnExit {
            get { return BackingStore?.Get<bool?>("edgeClearBrowsingDataOnExit"); }
            set { BackingStore?.Set("edgeClearBrowsingDataOnExit", value); }
        }
        /// <summary>Possible values to specify which cookies are allowed in Microsoft Edge.</summary>
        public Microsoft.Graph.Beta.Models.EdgeCookiePolicy? EdgeCookiePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeCookiePolicy?>("edgeCookiePolicy"); }
            set { BackingStore?.Set("edgeCookiePolicy", value); }
        }
        /// <summary>Block the Microsoft web page that opens on the first use of Microsoft Edge. This policy allows enterprises, like those enrolled in zero emissions configurations, to block this page.</summary>
        public bool? EdgeDisableFirstRunPage {
            get { return BackingStore?.Get<bool?>("edgeDisableFirstRunPage"); }
            set { BackingStore?.Set("edgeDisableFirstRunPage", value); }
        }
        /// <summary>Indicates the enterprise mode site list location. Could be a local file, local network or http location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string?>("edgeEnterpriseModeSiteListLocation"); }
            set { BackingStore?.Set("edgeEnterpriseModeSiteListLocation", value); }
        }
#nullable restore
#else
        public string EdgeEnterpriseModeSiteListLocation {
            get { return BackingStore?.Get<string>("edgeEnterpriseModeSiteListLocation"); }
            set { BackingStore?.Set("edgeEnterpriseModeSiteListLocation", value); }
        }
#endif
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? EdgeFavoritesBarVisibility {
            get { return BackingStore?.Get<VisibilitySetting?>("edgeFavoritesBarVisibility"); }
            set { BackingStore?.Set("edgeFavoritesBarVisibility", value); }
        }
        /// <summary>The location of the favorites list to provision. Could be a local file, local network or http location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeFavoritesListLocation {
            get { return BackingStore?.Get<string?>("edgeFavoritesListLocation"); }
            set { BackingStore?.Set("edgeFavoritesListLocation", value); }
        }
#nullable restore
#else
        public string EdgeFavoritesListLocation {
            get { return BackingStore?.Get<string>("edgeFavoritesListLocation"); }
            set { BackingStore?.Set("edgeFavoritesListLocation", value); }
        }
#endif
        /// <summary>The first run URL for when Edge browser is opened for the first time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeFirstRunUrl {
            get { return BackingStore?.Get<string?>("edgeFirstRunUrl"); }
            set { BackingStore?.Set("edgeFirstRunUrl", value); }
        }
#nullable restore
#else
        public string EdgeFirstRunUrl {
            get { return BackingStore?.Get<string>("edgeFirstRunUrl"); }
            set { BackingStore?.Set("edgeFirstRunUrl", value); }
        }
#endif
        /// <summary>Causes the Home button to either hide, load the default Start page, load a New tab page, or a custom URL</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration? EdgeHomeButtonConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration?>("edgeHomeButtonConfiguration"); }
            set { BackingStore?.Set("edgeHomeButtonConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration EdgeHomeButtonConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>("edgeHomeButtonConfiguration"); }
            set { BackingStore?.Set("edgeHomeButtonConfiguration", value); }
        }
#endif
        /// <summary>Enable the Home button configuration.</summary>
        public bool? EdgeHomeButtonConfigurationEnabled {
            get { return BackingStore?.Get<bool?>("edgeHomeButtonConfigurationEnabled"); }
            set { BackingStore?.Set("edgeHomeButtonConfigurationEnabled", value); }
        }
        /// <summary>The list of URLs for homepages shodwn on MDM-enrolled devices on Edge browser.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EdgeHomepageUrls {
            get { return BackingStore?.Get<List<string>?>("edgeHomepageUrls"); }
            set { BackingStore?.Set("edgeHomepageUrls", value); }
        }
#nullable restore
#else
        public List<string> EdgeHomepageUrls {
            get { return BackingStore?.Get<List<string>>("edgeHomepageUrls"); }
            set { BackingStore?.Set("edgeHomepageUrls", value); }
        }
#endif
        /// <summary>Specify how the Microsoft Edge settings are restricted based on kiosk mode.</summary>
        public EdgeKioskModeRestrictionType? EdgeKioskModeRestriction {
            get { return BackingStore?.Get<EdgeKioskModeRestrictionType?>("edgeKioskModeRestriction"); }
            set { BackingStore?.Set("edgeKioskModeRestriction", value); }
        }
        /// <summary>Specifies the time in minutes from the last user activity before Microsoft Edge kiosk resets.  Valid values are 0-1440. The default is 5. 0 indicates no reset. Valid values 0 to 1440</summary>
        public int? EdgeKioskResetAfterIdleTimeInMinutes {
            get { return BackingStore?.Get<int?>("edgeKioskResetAfterIdleTimeInMinutes"); }
            set { BackingStore?.Set("edgeKioskResetAfterIdleTimeInMinutes", value); }
        }
        /// <summary>Specify the page opened when new tabs are created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EdgeNewTabPageURL {
            get { return BackingStore?.Get<string?>("edgeNewTabPageURL"); }
            set { BackingStore?.Set("edgeNewTabPageURL", value); }
        }
#nullable restore
#else
        public string EdgeNewTabPageURL {
            get { return BackingStore?.Get<string>("edgeNewTabPageURL"); }
            set { BackingStore?.Set("edgeNewTabPageURL", value); }
        }
#endif
        /// <summary>Possible values for the EdgeOpensWith setting.</summary>
        public EdgeOpenOptions? EdgeOpensWith {
            get { return BackingStore?.Get<EdgeOpenOptions?>("edgeOpensWith"); }
            set { BackingStore?.Set("edgeOpensWith", value); }
        }
        /// <summary>Allow or prevent users from overriding certificate errors.</summary>
        public bool? EdgePreventCertificateErrorOverride {
            get { return BackingStore?.Get<bool?>("edgePreventCertificateErrorOverride"); }
            set { BackingStore?.Set("edgePreventCertificateErrorOverride", value); }
        }
        /// <summary>Specify the list of package family names of browser extensions that are required and cannot be turned off by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EdgeRequiredExtensionPackageFamilyNames {
            get { return BackingStore?.Get<List<string>?>("edgeRequiredExtensionPackageFamilyNames"); }
            set { BackingStore?.Set("edgeRequiredExtensionPackageFamilyNames", value); }
        }
#nullable restore
#else
        public List<string> EdgeRequiredExtensionPackageFamilyNames {
            get { return BackingStore?.Get<List<string>>("edgeRequiredExtensionPackageFamilyNames"); }
            set { BackingStore?.Set("edgeRequiredExtensionPackageFamilyNames", value); }
        }
#endif
        /// <summary>Indicates whether or not to Require the user to use the smart screen filter.</summary>
        public bool? EdgeRequireSmartScreen {
            get { return BackingStore?.Get<bool?>("edgeRequireSmartScreen"); }
            set { BackingStore?.Set("edgeRequireSmartScreen", value); }
        }
        /// <summary>Allows IT admins to set a default search engine for MDM-Controlled devices. Users can override this and change their default search engine provided the AllowSearchEngineCustomization policy is not set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdgeSearchEngineBase? EdgeSearchEngine {
            get { return BackingStore?.Get<EdgeSearchEngineBase?>("edgeSearchEngine"); }
            set { BackingStore?.Set("edgeSearchEngine", value); }
        }
#nullable restore
#else
        public EdgeSearchEngineBase EdgeSearchEngine {
            get { return BackingStore?.Get<EdgeSearchEngineBase>("edgeSearchEngine"); }
            set { BackingStore?.Set("edgeSearchEngine", value); }
        }
#endif
        /// <summary>Indicates whether or not to switch the intranet traffic from Edge to Internet Explorer.</summary>
        public bool? EdgeSendIntranetTrafficToInternetExplorer {
            get { return BackingStore?.Get<bool?>("edgeSendIntranetTrafficToInternetExplorer"); }
            set { BackingStore?.Set("edgeSendIntranetTrafficToInternetExplorer", value); }
        }
        /// <summary>What message will be displayed by Edge before switching to Internet Explorer.</summary>
        public InternetExplorerMessageSetting? EdgeShowMessageWhenOpeningInternetExplorerSites {
            get { return BackingStore?.Get<InternetExplorerMessageSetting?>("edgeShowMessageWhenOpeningInternetExplorerSites"); }
            set { BackingStore?.Set("edgeShowMessageWhenOpeningInternetExplorerSites", value); }
        }
        /// <summary>Enable favorites sync between Internet Explorer and Microsoft Edge. Additions, deletions, modifications and order changes to favorites are shared between browsers.</summary>
        public bool? EdgeSyncFavoritesWithInternetExplorer {
            get { return BackingStore?.Get<bool?>("edgeSyncFavoritesWithInternetExplorer"); }
            set { BackingStore?.Set("edgeSyncFavoritesWithInternetExplorer", value); }
        }
        /// <summary>Type of browsing data sent to Microsoft 365 analytics</summary>
        public EdgeTelemetryMode? EdgeTelemetryForMicrosoft365Analytics {
            get { return BackingStore?.Get<EdgeTelemetryMode?>("edgeTelemetryForMicrosoft365Analytics"); }
            set { BackingStore?.Set("edgeTelemetryForMicrosoft365Analytics", value); }
        }
        /// <summary>Allow users with administrative rights to delete all user data and settings using CTRL + Win + R at the device lock screen so that the device can be automatically re-configured and re-enrolled into management.</summary>
        public bool? EnableAutomaticRedeployment {
            get { return BackingStore?.Get<bool?>("enableAutomaticRedeployment"); }
            set { BackingStore?.Set("enableAutomaticRedeployment", value); }
        }
        /// <summary>This setting allows you to specify battery charge level at which Energy Saver is turned on. While on battery, Energy Saver is automatically turned on at (and below) the specified battery charge level. Valid input range (0-100). Valid values 0 to 100</summary>
        public int? EnergySaverOnBatteryThresholdPercentage {
            get { return BackingStore?.Get<int?>("energySaverOnBatteryThresholdPercentage"); }
            set { BackingStore?.Set("energySaverOnBatteryThresholdPercentage", value); }
        }
        /// <summary>This setting allows you to specify battery charge level at which Energy Saver is turned on. While plugged in, Energy Saver is automatically turned on at (and below) the specified battery charge level. Valid input range (0-100). Valid values 0 to 100</summary>
        public int? EnergySaverPluggedInThresholdPercentage {
            get { return BackingStore?.Get<int?>("energySaverPluggedInThresholdPercentage"); }
            set { BackingStore?.Set("energySaverPluggedInThresholdPercentage", value); }
        }
        /// <summary>Endpoint for discovering cloud printers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseCloudPrintDiscoveryEndPoint {
            get { return BackingStore?.Get<string?>("enterpriseCloudPrintDiscoveryEndPoint"); }
            set { BackingStore?.Set("enterpriseCloudPrintDiscoveryEndPoint", value); }
        }
#nullable restore
#else
        public string EnterpriseCloudPrintDiscoveryEndPoint {
            get { return BackingStore?.Get<string>("enterpriseCloudPrintDiscoveryEndPoint"); }
            set { BackingStore?.Set("enterpriseCloudPrintDiscoveryEndPoint", value); }
        }
#endif
        /// <summary>Maximum number of printers that should be queried from a discovery endpoint. This is a mobile only setting. Valid values 1 to 65535</summary>
        public int? EnterpriseCloudPrintDiscoveryMaxLimit {
            get { return BackingStore?.Get<int?>("enterpriseCloudPrintDiscoveryMaxLimit"); }
            set { BackingStore?.Set("enterpriseCloudPrintDiscoveryMaxLimit", value); }
        }
        /// <summary>OAuth resource URI for printer discovery service as configured in Azure portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier {
            get { return BackingStore?.Get<string?>("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", value); }
        }
#nullable restore
#else
        public string EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier {
            get { return BackingStore?.Get<string>("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", value); }
        }
#endif
        /// <summary>Authentication endpoint for acquiring OAuth tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseCloudPrintOAuthAuthority {
            get { return BackingStore?.Get<string?>("enterpriseCloudPrintOAuthAuthority"); }
            set { BackingStore?.Set("enterpriseCloudPrintOAuthAuthority", value); }
        }
#nullable restore
#else
        public string EnterpriseCloudPrintOAuthAuthority {
            get { return BackingStore?.Get<string>("enterpriseCloudPrintOAuthAuthority"); }
            set { BackingStore?.Set("enterpriseCloudPrintOAuthAuthority", value); }
        }
#endif
        /// <summary>GUID of a client application authorized to retrieve OAuth tokens from the OAuth Authority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseCloudPrintOAuthClientIdentifier {
            get { return BackingStore?.Get<string?>("enterpriseCloudPrintOAuthClientIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintOAuthClientIdentifier", value); }
        }
#nullable restore
#else
        public string EnterpriseCloudPrintOAuthClientIdentifier {
            get { return BackingStore?.Get<string>("enterpriseCloudPrintOAuthClientIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintOAuthClientIdentifier", value); }
        }
#endif
        /// <summary>OAuth resource URI for print service as configured in the Azure portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnterpriseCloudPrintResourceIdentifier {
            get { return BackingStore?.Get<string?>("enterpriseCloudPrintResourceIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintResourceIdentifier", value); }
        }
#nullable restore
#else
        public string EnterpriseCloudPrintResourceIdentifier {
            get { return BackingStore?.Get<string>("enterpriseCloudPrintResourceIdentifier"); }
            set { BackingStore?.Set("enterpriseCloudPrintResourceIdentifier", value); }
        }
#endif
        /// <summary>Indicates whether or not to enable device discovery UX.</summary>
        public bool? ExperienceBlockDeviceDiscovery {
            get { return BackingStore?.Get<bool?>("experienceBlockDeviceDiscovery"); }
            set { BackingStore?.Set("experienceBlockDeviceDiscovery", value); }
        }
        /// <summary>Indicates whether or not to allow the error dialog from displaying if no SIM card is detected.</summary>
        public bool? ExperienceBlockErrorDialogWhenNoSIM {
            get { return BackingStore?.Get<bool?>("experienceBlockErrorDialogWhenNoSIM"); }
            set { BackingStore?.Set("experienceBlockErrorDialogWhenNoSIM", value); }
        }
        /// <summary>Indicates whether or not to enable task switching on the device.</summary>
        public bool? ExperienceBlockTaskSwitcher {
            get { return BackingStore?.Get<bool?>("experienceBlockTaskSwitcher"); }
            set { BackingStore?.Set("experienceBlockTaskSwitcher", value); }
        }
        /// <summary>Allow(Not Configured) or prevent(Block) the syncing of Microsoft Edge Browser settings. Option to prevent syncing across devices, but allow user override.</summary>
        public BrowserSyncSetting? ExperienceDoNotSyncBrowserSettings {
            get { return BackingStore?.Get<BrowserSyncSetting?>("experienceDoNotSyncBrowserSettings"); }
            set { BackingStore?.Set("experienceDoNotSyncBrowserSettings", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? FindMyFiles {
            get { return BackingStore?.Get<Enablement?>("findMyFiles"); }
            set { BackingStore?.Set("findMyFiles", value); }
        }
        /// <summary>Indicates whether or not to block DVR and broadcasting.</summary>
        public bool? GameDvrBlocked {
            get { return BackingStore?.Get<bool?>("gameDvrBlocked"); }
            set { BackingStore?.Set("gameDvrBlocked", value); }
        }
        /// <summary>Values for the InkWorkspaceAccess setting.</summary>
        public InkAccessSetting? InkWorkspaceAccess {
            get { return BackingStore?.Get<InkAccessSetting?>("inkWorkspaceAccess"); }
            set { BackingStore?.Set("inkWorkspaceAccess", value); }
        }
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? InkWorkspaceAccessState {
            get { return BackingStore?.Get<StateManagementSetting?>("inkWorkspaceAccessState"); }
            set { BackingStore?.Set("inkWorkspaceAccessState", value); }
        }
        /// <summary>Specify whether to show recommended app suggestions in the ink workspace.</summary>
        public bool? InkWorkspaceBlockSuggestedApps {
            get { return BackingStore?.Get<bool?>("inkWorkspaceBlockSuggestedApps"); }
            set { BackingStore?.Set("inkWorkspaceBlockSuggestedApps", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using internet sharing.</summary>
        public bool? InternetSharingBlocked {
            get { return BackingStore?.Get<bool?>("internetSharingBlocked"); }
            set { BackingStore?.Set("internetSharingBlocked", value); }
        }
        /// <summary>Indicates whether or not to Block the user from location services.</summary>
        public bool? LocationServicesBlocked {
            get { return BackingStore?.Get<bool?>("locationServicesBlocked"); }
            set { BackingStore?.Set("locationServicesBlocked", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? LockScreenActivateAppsWithVoice {
            get { return BackingStore?.Get<Enablement?>("lockScreenActivateAppsWithVoice"); }
            set { BackingStore?.Set("lockScreenActivateAppsWithVoice", value); }
        }
        /// <summary>Specify whether to show a user-configurable setting to control the screen timeout while on the lock screen of Windows 10 Mobile devices. If this policy is set to Allow, the value set by lockScreenTimeoutInSeconds is ignored.</summary>
        public bool? LockScreenAllowTimeoutConfiguration {
            get { return BackingStore?.Get<bool?>("lockScreenAllowTimeoutConfiguration"); }
            set { BackingStore?.Set("lockScreenAllowTimeoutConfiguration", value); }
        }
        /// <summary>Indicates whether or not to block action center notifications over lock screen.</summary>
        public bool? LockScreenBlockActionCenterNotifications {
            get { return BackingStore?.Get<bool?>("lockScreenBlockActionCenterNotifications"); }
            set { BackingStore?.Set("lockScreenBlockActionCenterNotifications", value); }
        }
        /// <summary>Indicates whether or not the user can interact with Cortana using speech while the system is locked.</summary>
        public bool? LockScreenBlockCortana {
            get { return BackingStore?.Get<bool?>("lockScreenBlockCortana"); }
            set { BackingStore?.Set("lockScreenBlockCortana", value); }
        }
        /// <summary>Indicates whether to allow toast notifications above the device lock screen.</summary>
        public bool? LockScreenBlockToastNotifications {
            get { return BackingStore?.Get<bool?>("lockScreenBlockToastNotifications"); }
            set { BackingStore?.Set("lockScreenBlockToastNotifications", value); }
        }
        /// <summary>Set the duration (in seconds) from the screen locking to the screen turning off for Windows 10 Mobile devices. Supported values are 11-1800. Valid values 11 to 1800</summary>
        public int? LockScreenTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("lockScreenTimeoutInSeconds"); }
            set { BackingStore?.Set("lockScreenTimeoutInSeconds", value); }
        }
        /// <summary>Disables the ability to quickly switch between users that are logged on simultaneously without logging off.</summary>
        public bool? LogonBlockFastUserSwitching {
            get { return BackingStore?.Get<bool?>("logonBlockFastUserSwitching"); }
            set { BackingStore?.Set("logonBlockFastUserSwitching", value); }
        }
        /// <summary>Indicates whether or not to block the MMS send/receive functionality on the device.</summary>
        public bool? MessagingBlockMMS {
            get { return BackingStore?.Get<bool?>("messagingBlockMMS"); }
            set { BackingStore?.Set("messagingBlockMMS", value); }
        }
        /// <summary>Indicates whether or not to block the RCS send/receive functionality on the device.</summary>
        public bool? MessagingBlockRichCommunicationServices {
            get { return BackingStore?.Get<bool?>("messagingBlockRichCommunicationServices"); }
            set { BackingStore?.Set("messagingBlockRichCommunicationServices", value); }
        }
        /// <summary>Indicates whether or not to block text message back up and restore and Messaging Everywhere.</summary>
        public bool? MessagingBlockSync {
            get { return BackingStore?.Get<bool?>("messagingBlockSync"); }
            set { BackingStore?.Set("messagingBlockSync", value); }
        }
        /// <summary>Indicates whether or not to Block a Microsoft account.</summary>
        public bool? MicrosoftAccountBlocked {
            get { return BackingStore?.Get<bool?>("microsoftAccountBlocked"); }
            set { BackingStore?.Set("microsoftAccountBlocked", value); }
        }
        /// <summary>Indicates whether or not to Block Microsoft account settings sync.</summary>
        public bool? MicrosoftAccountBlockSettingsSync {
            get { return BackingStore?.Get<bool?>("microsoftAccountBlockSettingsSync"); }
            set { BackingStore?.Set("microsoftAccountBlockSettingsSync", value); }
        }
        /// <summary>Values for the SignInAssistantSettings.</summary>
        public SignInAssistantOptions? MicrosoftAccountSignInAssistantSettings {
            get { return BackingStore?.Get<SignInAssistantOptions?>("microsoftAccountSignInAssistantSettings"); }
            set { BackingStore?.Set("microsoftAccountSignInAssistantSettings", value); }
        }
        /// <summary>If set, proxy settings will be applied to all processes and accounts in the device. Otherwise, it will be applied to the user account that’s enrolled into MDM.</summary>
        public bool? NetworkProxyApplySettingsDeviceWide {
            get { return BackingStore?.Get<bool?>("networkProxyApplySettingsDeviceWide"); }
            set { BackingStore?.Set("networkProxyApplySettingsDeviceWide", value); }
        }
        /// <summary>Address to the proxy auto-config (PAC) script you want to use.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string?>("networkProxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("networkProxyAutomaticConfigurationUrl", value); }
        }
#nullable restore
#else
        public string NetworkProxyAutomaticConfigurationUrl {
            get { return BackingStore?.Get<string>("networkProxyAutomaticConfigurationUrl"); }
            set { BackingStore?.Set("networkProxyAutomaticConfigurationUrl", value); }
        }
#endif
        /// <summary>Disable automatic detection of settings. If enabled, the system will try to find the path to a proxy auto-config (PAC) script.</summary>
        public bool? NetworkProxyDisableAutoDetect {
            get { return BackingStore?.Get<bool?>("networkProxyDisableAutoDetect"); }
            set { BackingStore?.Set("networkProxyDisableAutoDetect", value); }
        }
        /// <summary>Specifies manual proxy server settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Windows10NetworkProxyServer? NetworkProxyServer {
            get { return BackingStore?.Get<Windows10NetworkProxyServer?>("networkProxyServer"); }
            set { BackingStore?.Set("networkProxyServer", value); }
        }
#nullable restore
#else
        public Windows10NetworkProxyServer NetworkProxyServer {
            get { return BackingStore?.Get<Windows10NetworkProxyServer>("networkProxyServer"); }
            set { BackingStore?.Set("networkProxyServer", value); }
        }
#endif
        /// <summary>Indicates whether or not to Block the user from using near field communication.</summary>
        public bool? NfcBlocked {
            get { return BackingStore?.Get<bool?>("nfcBlocked"); }
            set { BackingStore?.Set("nfcBlocked", value); }
        }
        /// <summary>Gets or sets a value allowing IT admins to prevent apps and features from working with files on OneDrive.</summary>
        public bool? OneDriveDisableFileSync {
            get { return BackingStore?.Get<bool?>("oneDriveDisableFileSync"); }
            set { BackingStore?.Set("oneDriveDisableFileSync", value); }
        }
        /// <summary>Specify whether PINs or passwords such as &apos;1111&apos; or &apos;1234&apos; are allowed. For Windows 10 desktops, it also controls the use of picture passwords.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>The password expiration in days. Valid values 0 to 730</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>This security setting determines the period of time (in days) that a password must be used before the user can change it. Valid values 0 to 998</summary>
        public int? PasswordMinimumAgeInDays {
            get { return BackingStore?.Get<int?>("passwordMinimumAgeInDays"); }
            set { BackingStore?.Set("passwordMinimumAgeInDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>The minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>The number of previous passwords to prevent reuse of. Valid values 0 to 50</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Indicates whether or not to require the user to have a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Indicates whether or not to require a password upon resuming from an idle state.</summary>
        public bool? PasswordRequireWhenResumeFromIdleState {
            get { return BackingStore?.Get<bool?>("passwordRequireWhenResumeFromIdleState"); }
            set { BackingStore?.Set("passwordRequireWhenResumeFromIdleState", value); }
        }
        /// <summary>The number of sign in failures before factory reset. Valid values 0 to 999</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>A http or https Url to a jpg, jpeg or png image that needs to be downloaded and used as the Desktop Image or a file Url to a local image on the file system that needs to used as the Desktop Image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalizationDesktopImageUrl {
            get { return BackingStore?.Get<string?>("personalizationDesktopImageUrl"); }
            set { BackingStore?.Set("personalizationDesktopImageUrl", value); }
        }
#nullable restore
#else
        public string PersonalizationDesktopImageUrl {
            get { return BackingStore?.Get<string>("personalizationDesktopImageUrl"); }
            set { BackingStore?.Set("personalizationDesktopImageUrl", value); }
        }
#endif
        /// <summary>A http or https Url to a jpg, jpeg or png image that neeeds to be downloaded and used as the Lock Screen Image or a file Url to a local image on the file system that needs to be used as the Lock Screen Image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalizationLockScreenImageUrl {
            get { return BackingStore?.Get<string?>("personalizationLockScreenImageUrl"); }
            set { BackingStore?.Set("personalizationLockScreenImageUrl", value); }
        }
#nullable restore
#else
        public string PersonalizationLockScreenImageUrl {
            get { return BackingStore?.Get<string>("personalizationLockScreenImageUrl"); }
            set { BackingStore?.Set("personalizationLockScreenImageUrl", value); }
        }
#endif
        /// <summary>Power action types</summary>
        public PowerActionType? PowerButtonActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>("powerButtonActionOnBattery"); }
            set { BackingStore?.Set("powerButtonActionOnBattery", value); }
        }
        /// <summary>Power action types</summary>
        public PowerActionType? PowerButtonActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>("powerButtonActionPluggedIn"); }
            set { BackingStore?.Set("powerButtonActionPluggedIn", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? PowerHybridSleepOnBattery {
            get { return BackingStore?.Get<Enablement?>("powerHybridSleepOnBattery"); }
            set { BackingStore?.Set("powerHybridSleepOnBattery", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? PowerHybridSleepPluggedIn {
            get { return BackingStore?.Get<Enablement?>("powerHybridSleepPluggedIn"); }
            set { BackingStore?.Set("powerHybridSleepPluggedIn", value); }
        }
        /// <summary>Power action types</summary>
        public PowerActionType? PowerLidCloseActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>("powerLidCloseActionOnBattery"); }
            set { BackingStore?.Set("powerLidCloseActionOnBattery", value); }
        }
        /// <summary>Power action types</summary>
        public PowerActionType? PowerLidCloseActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>("powerLidCloseActionPluggedIn"); }
            set { BackingStore?.Set("powerLidCloseActionPluggedIn", value); }
        }
        /// <summary>Power action types</summary>
        public PowerActionType? PowerSleepButtonActionOnBattery {
            get { return BackingStore?.Get<PowerActionType?>("powerSleepButtonActionOnBattery"); }
            set { BackingStore?.Set("powerSleepButtonActionOnBattery", value); }
        }
        /// <summary>Power action types</summary>
        public PowerActionType? PowerSleepButtonActionPluggedIn {
            get { return BackingStore?.Get<PowerActionType?>("powerSleepButtonActionPluggedIn"); }
            set { BackingStore?.Set("powerSleepButtonActionPluggedIn", value); }
        }
        /// <summary>Prevent user installation of additional printers from printers settings.</summary>
        public bool? PrinterBlockAddition {
            get { return BackingStore?.Get<bool?>("printerBlockAddition"); }
            set { BackingStore?.Set("printerBlockAddition", value); }
        }
        /// <summary>Name (network host name) of an installed printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrinterDefaultName {
            get { return BackingStore?.Get<string?>("printerDefaultName"); }
            set { BackingStore?.Set("printerDefaultName", value); }
        }
#nullable restore
#else
        public string PrinterDefaultName {
            get { return BackingStore?.Get<string>("printerDefaultName"); }
            set { BackingStore?.Set("printerDefaultName", value); }
        }
#endif
        /// <summary>Automatically provision printers based on their names (network host names).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PrinterNames {
            get { return BackingStore?.Get<List<string>?>("printerNames"); }
            set { BackingStore?.Set("printerNames", value); }
        }
#nullable restore
#else
        public List<string> PrinterNames {
            get { return BackingStore?.Get<List<string>>("printerNames"); }
            set { BackingStore?.Set("printerNames", value); }
        }
#endif
        /// <summary>Indicates a list of applications with their access control levels over privacy data categories, and/or the default access levels per category. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsPrivacyDataAccessControlItem>? PrivacyAccessControls {
            get { return BackingStore?.Get<List<WindowsPrivacyDataAccessControlItem>?>("privacyAccessControls"); }
            set { BackingStore?.Set("privacyAccessControls", value); }
        }
#nullable restore
#else
        public List<WindowsPrivacyDataAccessControlItem> PrivacyAccessControls {
            get { return BackingStore?.Get<List<WindowsPrivacyDataAccessControlItem>>("privacyAccessControls"); }
            set { BackingStore?.Set("privacyAccessControls", value); }
        }
#endif
        /// <summary>State Management Setting.</summary>
        public StateManagementSetting? PrivacyAdvertisingId {
            get { return BackingStore?.Get<StateManagementSetting?>("privacyAdvertisingId"); }
            set { BackingStore?.Set("privacyAdvertisingId", value); }
        }
        /// <summary>Indicates whether or not to allow the automatic acceptance of the pairing and privacy user consent dialog when launching apps.</summary>
        public bool? PrivacyAutoAcceptPairingAndConsentPrompts {
            get { return BackingStore?.Get<bool?>("privacyAutoAcceptPairingAndConsentPrompts"); }
            set { BackingStore?.Set("privacyAutoAcceptPairingAndConsentPrompts", value); }
        }
        /// <summary>Blocks the usage of cloud based speech services for Cortana, Dictation, or Store applications.</summary>
        public bool? PrivacyBlockActivityFeed {
            get { return BackingStore?.Get<bool?>("privacyBlockActivityFeed"); }
            set { BackingStore?.Set("privacyBlockActivityFeed", value); }
        }
        /// <summary>Indicates whether or not to block the usage of cloud based speech services for Cortana, Dictation, or Store applications.</summary>
        public bool? PrivacyBlockInputPersonalization {
            get { return BackingStore?.Get<bool?>("privacyBlockInputPersonalization"); }
            set { BackingStore?.Set("privacyBlockInputPersonalization", value); }
        }
        /// <summary>Blocks the shared experiences/discovery of recently used resources in task switcher etc.</summary>
        public bool? PrivacyBlockPublishUserActivities {
            get { return BackingStore?.Get<bool?>("privacyBlockPublishUserActivities"); }
            set { BackingStore?.Set("privacyBlockPublishUserActivities", value); }
        }
        /// <summary>This policy prevents the privacy experience from launching during user logon for new and upgraded users.​</summary>
        public bool? PrivacyDisableLaunchExperience {
            get { return BackingStore?.Get<bool?>("privacyDisableLaunchExperience"); }
            set { BackingStore?.Set("privacyDisableLaunchExperience", value); }
        }
        /// <summary>Indicates whether or not to Block the user from reset protection mode.</summary>
        public bool? ResetProtectionModeBlocked {
            get { return BackingStore?.Get<bool?>("resetProtectionModeBlocked"); }
            set { BackingStore?.Set("resetProtectionModeBlocked", value); }
        }
        /// <summary>Specifies what level of safe search (filtering adult content) is required</summary>
        public SafeSearchFilterType? SafeSearchFilter {
            get { return BackingStore?.Get<SafeSearchFilterType?>("safeSearchFilter"); }
            set { BackingStore?.Set("safeSearchFilter", value); }
        }
        /// <summary>Indicates whether or not to Block the user from taking Screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Specifies if search can use diacritics.</summary>
        public bool? SearchBlockDiacritics {
            get { return BackingStore?.Get<bool?>("searchBlockDiacritics"); }
            set { BackingStore?.Set("searchBlockDiacritics", value); }
        }
        /// <summary>Indicates whether or not to block the web search.</summary>
        public bool? SearchBlockWebResults {
            get { return BackingStore?.Get<bool?>("searchBlockWebResults"); }
            set { BackingStore?.Set("searchBlockWebResults", value); }
        }
        /// <summary>Specifies whether to use automatic language detection when indexing content and properties.</summary>
        public bool? SearchDisableAutoLanguageDetection {
            get { return BackingStore?.Get<bool?>("searchDisableAutoLanguageDetection"); }
            set { BackingStore?.Set("searchDisableAutoLanguageDetection", value); }
        }
        /// <summary>Indicates whether or not to disable the search indexer backoff feature.</summary>
        public bool? SearchDisableIndexerBackoff {
            get { return BackingStore?.Get<bool?>("searchDisableIndexerBackoff"); }
            set { BackingStore?.Set("searchDisableIndexerBackoff", value); }
        }
        /// <summary>Indicates whether or not to block indexing of WIP-protected items to prevent them from appearing in search results for Cortana or Explorer.</summary>
        public bool? SearchDisableIndexingEncryptedItems {
            get { return BackingStore?.Get<bool?>("searchDisableIndexingEncryptedItems"); }
            set { BackingStore?.Set("searchDisableIndexingEncryptedItems", value); }
        }
        /// <summary>Indicates whether or not to allow users to add locations on removable drives to libraries and to be indexed.</summary>
        public bool? SearchDisableIndexingRemovableDrive {
            get { return BackingStore?.Get<bool?>("searchDisableIndexingRemovableDrive"); }
            set { BackingStore?.Set("searchDisableIndexingRemovableDrive", value); }
        }
        /// <summary>Specifies if search can use location information.</summary>
        public bool? SearchDisableLocation {
            get { return BackingStore?.Get<bool?>("searchDisableLocation"); }
            set { BackingStore?.Set("searchDisableLocation", value); }
        }
        /// <summary>Specifies if search can use location information.</summary>
        public bool? SearchDisableUseLocation {
            get { return BackingStore?.Get<bool?>("searchDisableUseLocation"); }
            set { BackingStore?.Set("searchDisableUseLocation", value); }
        }
        /// <summary>Specifies minimum amount of hard drive space on the same drive as the index location before indexing stops.</summary>
        public bool? SearchEnableAutomaticIndexSizeManangement {
            get { return BackingStore?.Get<bool?>("searchEnableAutomaticIndexSizeManangement"); }
            set { BackingStore?.Set("searchEnableAutomaticIndexSizeManangement", value); }
        }
        /// <summary>Indicates whether or not to block remote queries of this computer’s index.</summary>
        public bool? SearchEnableRemoteQueries {
            get { return BackingStore?.Get<bool?>("searchEnableRemoteQueries"); }
            set { BackingStore?.Set("searchEnableRemoteQueries", value); }
        }
        /// <summary>Specify whether to allow automatic device encryption during OOBE when the device is Azure AD joined (desktop only).</summary>
        public bool? SecurityBlockAzureADJoinedDevicesAutoEncryption {
            get { return BackingStore?.Get<bool?>("securityBlockAzureADJoinedDevicesAutoEncryption"); }
            set { BackingStore?.Set("securityBlockAzureADJoinedDevicesAutoEncryption", value); }
        }
        /// <summary>Indicates whether or not to block access to Accounts in Settings app.</summary>
        public bool? SettingsBlockAccountsPage {
            get { return BackingStore?.Get<bool?>("settingsBlockAccountsPage"); }
            set { BackingStore?.Set("settingsBlockAccountsPage", value); }
        }
        /// <summary>Indicates whether or not to block the user from installing provisioning packages.</summary>
        public bool? SettingsBlockAddProvisioningPackage {
            get { return BackingStore?.Get<bool?>("settingsBlockAddProvisioningPackage"); }
            set { BackingStore?.Set("settingsBlockAddProvisioningPackage", value); }
        }
        /// <summary>Indicates whether or not to block access to Apps in Settings app.</summary>
        public bool? SettingsBlockAppsPage {
            get { return BackingStore?.Get<bool?>("settingsBlockAppsPage"); }
            set { BackingStore?.Set("settingsBlockAppsPage", value); }
        }
        /// <summary>Indicates whether or not to block the user from changing the language settings.</summary>
        public bool? SettingsBlockChangeLanguage {
            get { return BackingStore?.Get<bool?>("settingsBlockChangeLanguage"); }
            set { BackingStore?.Set("settingsBlockChangeLanguage", value); }
        }
        /// <summary>Indicates whether or not to block the user from changing power and sleep settings.</summary>
        public bool? SettingsBlockChangePowerSleep {
            get { return BackingStore?.Get<bool?>("settingsBlockChangePowerSleep"); }
            set { BackingStore?.Set("settingsBlockChangePowerSleep", value); }
        }
        /// <summary>Indicates whether or not to block the user from changing the region settings.</summary>
        public bool? SettingsBlockChangeRegion {
            get { return BackingStore?.Get<bool?>("settingsBlockChangeRegion"); }
            set { BackingStore?.Set("settingsBlockChangeRegion", value); }
        }
        /// <summary>Indicates whether or not to block the user from changing date and time settings.</summary>
        public bool? SettingsBlockChangeSystemTime {
            get { return BackingStore?.Get<bool?>("settingsBlockChangeSystemTime"); }
            set { BackingStore?.Set("settingsBlockChangeSystemTime", value); }
        }
        /// <summary>Indicates whether or not to block access to Devices in Settings app.</summary>
        public bool? SettingsBlockDevicesPage {
            get { return BackingStore?.Get<bool?>("settingsBlockDevicesPage"); }
            set { BackingStore?.Set("settingsBlockDevicesPage", value); }
        }
        /// <summary>Indicates whether or not to block access to Ease of Access in Settings app.</summary>
        public bool? SettingsBlockEaseOfAccessPage {
            get { return BackingStore?.Get<bool?>("settingsBlockEaseOfAccessPage"); }
            set { BackingStore?.Set("settingsBlockEaseOfAccessPage", value); }
        }
        /// <summary>Indicates whether or not to block the user from editing the device name.</summary>
        public bool? SettingsBlockEditDeviceName {
            get { return BackingStore?.Get<bool?>("settingsBlockEditDeviceName"); }
            set { BackingStore?.Set("settingsBlockEditDeviceName", value); }
        }
        /// <summary>Indicates whether or not to block access to Gaming in Settings app.</summary>
        public bool? SettingsBlockGamingPage {
            get { return BackingStore?.Get<bool?>("settingsBlockGamingPage"); }
            set { BackingStore?.Set("settingsBlockGamingPage", value); }
        }
        /// <summary>Indicates whether or not to block access to Network &amp; Internet in Settings app.</summary>
        public bool? SettingsBlockNetworkInternetPage {
            get { return BackingStore?.Get<bool?>("settingsBlockNetworkInternetPage"); }
            set { BackingStore?.Set("settingsBlockNetworkInternetPage", value); }
        }
        /// <summary>Indicates whether or not to block access to Personalization in Settings app.</summary>
        public bool? SettingsBlockPersonalizationPage {
            get { return BackingStore?.Get<bool?>("settingsBlockPersonalizationPage"); }
            set { BackingStore?.Set("settingsBlockPersonalizationPage", value); }
        }
        /// <summary>Indicates whether or not to block access to Privacy in Settings app.</summary>
        public bool? SettingsBlockPrivacyPage {
            get { return BackingStore?.Get<bool?>("settingsBlockPrivacyPage"); }
            set { BackingStore?.Set("settingsBlockPrivacyPage", value); }
        }
        /// <summary>Indicates whether or not to block the runtime configuration agent from removing provisioning packages.</summary>
        public bool? SettingsBlockRemoveProvisioningPackage {
            get { return BackingStore?.Get<bool?>("settingsBlockRemoveProvisioningPackage"); }
            set { BackingStore?.Set("settingsBlockRemoveProvisioningPackage", value); }
        }
        /// <summary>Indicates whether or not to block access to Settings app.</summary>
        public bool? SettingsBlockSettingsApp {
            get { return BackingStore?.Get<bool?>("settingsBlockSettingsApp"); }
            set { BackingStore?.Set("settingsBlockSettingsApp", value); }
        }
        /// <summary>Indicates whether or not to block access to System in Settings app.</summary>
        public bool? SettingsBlockSystemPage {
            get { return BackingStore?.Get<bool?>("settingsBlockSystemPage"); }
            set { BackingStore?.Set("settingsBlockSystemPage", value); }
        }
        /// <summary>Indicates whether or not to block access to Time &amp; Language in Settings app.</summary>
        public bool? SettingsBlockTimeLanguagePage {
            get { return BackingStore?.Get<bool?>("settingsBlockTimeLanguagePage"); }
            set { BackingStore?.Set("settingsBlockTimeLanguagePage", value); }
        }
        /// <summary>Indicates whether or not to block access to Update &amp; Security in Settings app.</summary>
        public bool? SettingsBlockUpdateSecurityPage {
            get { return BackingStore?.Get<bool?>("settingsBlockUpdateSecurityPage"); }
            set { BackingStore?.Set("settingsBlockUpdateSecurityPage", value); }
        }
        /// <summary>Indicates whether or not to block multiple users of the same app to share data.</summary>
        public bool? SharedUserAppDataAllowed {
            get { return BackingStore?.Get<bool?>("sharedUserAppDataAllowed"); }
            set { BackingStore?.Set("sharedUserAppDataAllowed", value); }
        }
        /// <summary>App Install control Setting</summary>
        public AppInstallControlType? SmartScreenAppInstallControl {
            get { return BackingStore?.Get<AppInstallControlType?>("smartScreenAppInstallControl"); }
            set { BackingStore?.Set("smartScreenAppInstallControl", value); }
        }
        /// <summary>Indicates whether or not users can override SmartScreen Filter warnings about potentially malicious websites.</summary>
        public bool? SmartScreenBlockPromptOverride {
            get { return BackingStore?.Get<bool?>("smartScreenBlockPromptOverride"); }
            set { BackingStore?.Set("smartScreenBlockPromptOverride", value); }
        }
        /// <summary>Indicates whether or not users can override the SmartScreen Filter warnings about downloading unverified files</summary>
        public bool? SmartScreenBlockPromptOverrideForFiles {
            get { return BackingStore?.Get<bool?>("smartScreenBlockPromptOverrideForFiles"); }
            set { BackingStore?.Set("smartScreenBlockPromptOverrideForFiles", value); }
        }
        /// <summary>This property will be deprecated in July 2019 and will be replaced by property SmartScreenAppInstallControl. Allows IT Admins to control whether users are allowed to install apps from places other than the Store.</summary>
        public bool? SmartScreenEnableAppInstallControl {
            get { return BackingStore?.Get<bool?>("smartScreenEnableAppInstallControl"); }
            set { BackingStore?.Set("smartScreenEnableAppInstallControl", value); }
        }
        /// <summary>Indicates whether or not to block the user from unpinning apps from taskbar.</summary>
        public bool? StartBlockUnpinningAppsFromTaskbar {
            get { return BackingStore?.Get<bool?>("startBlockUnpinningAppsFromTaskbar"); }
            set { BackingStore?.Set("startBlockUnpinningAppsFromTaskbar", value); }
        }
        /// <summary>Type of start menu app list visibility.</summary>
        public WindowsStartMenuAppListVisibilityType? StartMenuAppListVisibility {
            get { return BackingStore?.Get<WindowsStartMenuAppListVisibilityType?>("startMenuAppListVisibility"); }
            set { BackingStore?.Set("startMenuAppListVisibility", value); }
        }
        /// <summary>Enabling this policy hides the change account setting from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideChangeAccountSettings {
            get { return BackingStore?.Get<bool?>("startMenuHideChangeAccountSettings"); }
            set { BackingStore?.Set("startMenuHideChangeAccountSettings", value); }
        }
        /// <summary>Enabling this policy hides the most used apps from appearing on the start menu and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideFrequentlyUsedApps {
            get { return BackingStore?.Get<bool?>("startMenuHideFrequentlyUsedApps"); }
            set { BackingStore?.Set("startMenuHideFrequentlyUsedApps", value); }
        }
        /// <summary>Enabling this policy hides hibernate from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideHibernate {
            get { return BackingStore?.Get<bool?>("startMenuHideHibernate"); }
            set { BackingStore?.Set("startMenuHideHibernate", value); }
        }
        /// <summary>Enabling this policy hides lock from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideLock {
            get { return BackingStore?.Get<bool?>("startMenuHideLock"); }
            set { BackingStore?.Set("startMenuHideLock", value); }
        }
        /// <summary>Enabling this policy hides the power button from appearing in the start menu.</summary>
        public bool? StartMenuHidePowerButton {
            get { return BackingStore?.Get<bool?>("startMenuHidePowerButton"); }
            set { BackingStore?.Set("startMenuHidePowerButton", value); }
        }
        /// <summary>Enabling this policy hides recent jump lists from appearing on the start menu/taskbar and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideRecentJumpLists {
            get { return BackingStore?.Get<bool?>("startMenuHideRecentJumpLists"); }
            set { BackingStore?.Set("startMenuHideRecentJumpLists", value); }
        }
        /// <summary>Enabling this policy hides recently added apps from appearing on the start menu and disables the corresponding toggle in the Settings app.</summary>
        public bool? StartMenuHideRecentlyAddedApps {
            get { return BackingStore?.Get<bool?>("startMenuHideRecentlyAddedApps"); }
            set { BackingStore?.Set("startMenuHideRecentlyAddedApps", value); }
        }
        /// <summary>Enabling this policy hides &apos;Restart/Update and Restart&apos; from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideRestartOptions {
            get { return BackingStore?.Get<bool?>("startMenuHideRestartOptions"); }
            set { BackingStore?.Set("startMenuHideRestartOptions", value); }
        }
        /// <summary>Enabling this policy hides shut down/update and shut down from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideShutDown {
            get { return BackingStore?.Get<bool?>("startMenuHideShutDown"); }
            set { BackingStore?.Set("startMenuHideShutDown", value); }
        }
        /// <summary>Enabling this policy hides sign out from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideSignOut {
            get { return BackingStore?.Get<bool?>("startMenuHideSignOut"); }
            set { BackingStore?.Set("startMenuHideSignOut", value); }
        }
        /// <summary>Enabling this policy hides sleep from appearing in the power button in the start menu.</summary>
        public bool? StartMenuHideSleep {
            get { return BackingStore?.Get<bool?>("startMenuHideSleep"); }
            set { BackingStore?.Set("startMenuHideSleep", value); }
        }
        /// <summary>Enabling this policy hides switch account from appearing in the user tile in the start menu.</summary>
        public bool? StartMenuHideSwitchAccount {
            get { return BackingStore?.Get<bool?>("startMenuHideSwitchAccount"); }
            set { BackingStore?.Set("startMenuHideSwitchAccount", value); }
        }
        /// <summary>Enabling this policy hides the user tile from appearing in the start menu.</summary>
        public bool? StartMenuHideUserTile {
            get { return BackingStore?.Get<bool?>("startMenuHideUserTile"); }
            set { BackingStore?.Set("startMenuHideUserTile", value); }
        }
        /// <summary>This policy setting allows you to import Edge assets to be used with startMenuLayoutXml policy. Start layout can contain secondary tile from Edge app which looks for Edge local asset file. Edge local asset would not exist and cause Edge secondary tile to appear empty in this case. This policy only gets applied when startMenuLayoutXml policy is modified. The value should be a UTF-8 Base64 encoded byte array.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? StartMenuLayoutEdgeAssetsXml {
            get { return BackingStore?.Get<byte[]?>("startMenuLayoutEdgeAssetsXml"); }
            set { BackingStore?.Set("startMenuLayoutEdgeAssetsXml", value); }
        }
#nullable restore
#else
        public byte[] StartMenuLayoutEdgeAssetsXml {
            get { return BackingStore?.Get<byte[]>("startMenuLayoutEdgeAssetsXml"); }
            set { BackingStore?.Set("startMenuLayoutEdgeAssetsXml", value); }
        }
#endif
        /// <summary>Allows admins to override the default Start menu layout and prevents the user from changing it. The layout is modified by specifying an XML file based on a layout modification schema. XML needs to be in a UTF8 encoded byte array format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]?>("startMenuLayoutXml"); }
            set { BackingStore?.Set("startMenuLayoutXml", value); }
        }
#nullable restore
#else
        public byte[] StartMenuLayoutXml {
            get { return BackingStore?.Get<byte[]>("startMenuLayoutXml"); }
            set { BackingStore?.Set("startMenuLayoutXml", value); }
        }
#endif
        /// <summary>Type of display modes for the start menu.</summary>
        public WindowsStartMenuModeType? StartMenuMode {
            get { return BackingStore?.Get<WindowsStartMenuModeType?>("startMenuMode"); }
            set { BackingStore?.Set("startMenuMode", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderDocuments {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderDocuments"); }
            set { BackingStore?.Set("startMenuPinnedFolderDocuments", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderDownloads {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderDownloads"); }
            set { BackingStore?.Set("startMenuPinnedFolderDownloads", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderFileExplorer {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderFileExplorer"); }
            set { BackingStore?.Set("startMenuPinnedFolderFileExplorer", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderHomeGroup {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderHomeGroup"); }
            set { BackingStore?.Set("startMenuPinnedFolderHomeGroup", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderMusic {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderMusic"); }
            set { BackingStore?.Set("startMenuPinnedFolderMusic", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderNetwork {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderNetwork"); }
            set { BackingStore?.Set("startMenuPinnedFolderNetwork", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderPersonalFolder {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderPersonalFolder"); }
            set { BackingStore?.Set("startMenuPinnedFolderPersonalFolder", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderPictures {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderPictures"); }
            set { BackingStore?.Set("startMenuPinnedFolderPictures", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderSettings {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderSettings"); }
            set { BackingStore?.Set("startMenuPinnedFolderSettings", value); }
        }
        /// <summary>Generic visibility state.</summary>
        public VisibilitySetting? StartMenuPinnedFolderVideos {
            get { return BackingStore?.Get<VisibilitySetting?>("startMenuPinnedFolderVideos"); }
            set { BackingStore?.Set("startMenuPinnedFolderVideos", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using removable storage.</summary>
        public bool? StorageBlockRemovableStorage {
            get { return BackingStore?.Get<bool?>("storageBlockRemovableStorage"); }
            set { BackingStore?.Set("storageBlockRemovableStorage", value); }
        }
        /// <summary>Indicating whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireMobileDeviceEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireMobileDeviceEncryption"); }
            set { BackingStore?.Set("storageRequireMobileDeviceEncryption", value); }
        }
        /// <summary>Indicates whether application data is restricted to the system drive.</summary>
        public bool? StorageRestrictAppDataToSystemVolume {
            get { return BackingStore?.Get<bool?>("storageRestrictAppDataToSystemVolume"); }
            set { BackingStore?.Set("storageRestrictAppDataToSystemVolume", value); }
        }
        /// <summary>Indicates whether the installation of applications is restricted to the system drive.</summary>
        public bool? StorageRestrictAppInstallToSystemVolume {
            get { return BackingStore?.Get<bool?>("storageRestrictAppInstallToSystemVolume"); }
            set { BackingStore?.Set("storageRestrictAppInstallToSystemVolume", value); }
        }
        /// <summary>Gets or sets the fully qualified domain name (FQDN) or IP address of a proxy server to forward Connected User Experiences and Telemetry requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemTelemetryProxyServer {
            get { return BackingStore?.Get<string?>("systemTelemetryProxyServer"); }
            set { BackingStore?.Set("systemTelemetryProxyServer", value); }
        }
#nullable restore
#else
        public string SystemTelemetryProxyServer {
            get { return BackingStore?.Get<string>("systemTelemetryProxyServer"); }
            set { BackingStore?.Set("systemTelemetryProxyServer", value); }
        }
#endif
        /// <summary>Specify whether non-administrators can use Task Manager to end tasks.</summary>
        public bool? TaskManagerBlockEndTask {
            get { return BackingStore?.Get<bool?>("taskManagerBlockEndTask"); }
            set { BackingStore?.Set("taskManagerBlockEndTask", value); }
        }
        /// <summary>Whether the device is required to connect to the network.</summary>
        public bool? TenantLockdownRequireNetworkDuringOutOfBoxExperience {
            get { return BackingStore?.Get<bool?>("tenantLockdownRequireNetworkDuringOutOfBoxExperience"); }
            set { BackingStore?.Set("tenantLockdownRequireNetworkDuringOutOfBoxExperience", value); }
        }
        /// <summary>Indicates whether or not to uninstall a fixed list of built-in Windows apps.</summary>
        public bool? UninstallBuiltInApps {
            get { return BackingStore?.Get<bool?>("uninstallBuiltInApps"); }
            set { BackingStore?.Set("uninstallBuiltInApps", value); }
        }
        /// <summary>Indicates whether or not to Block the user from USB connection.</summary>
        public bool? UsbBlocked {
            get { return BackingStore?.Get<bool?>("usbBlocked"); }
            set { BackingStore?.Set("usbBlocked", value); }
        }
        /// <summary>Indicates whether or not to Block the user from voice recording.</summary>
        public bool? VoiceRecordingBlocked {
            get { return BackingStore?.Get<bool?>("voiceRecordingBlocked"); }
            set { BackingStore?.Set("voiceRecordingBlocked", value); }
        }
        /// <summary>Indicates whether or not user&apos;s localhost IP address is displayed while making phone calls using the WebRTC</summary>
        public bool? WebRtcBlockLocalhostIpAddress {
            get { return BackingStore?.Get<bool?>("webRtcBlockLocalhostIpAddress"); }
            set { BackingStore?.Set("webRtcBlockLocalhostIpAddress", value); }
        }
        /// <summary>Indicating whether or not to block automatically connecting to Wi-Fi hotspots. Has no impact if Wi-Fi is blocked.</summary>
        public bool? WiFiBlockAutomaticConnectHotspots {
            get { return BackingStore?.Get<bool?>("wiFiBlockAutomaticConnectHotspots"); }
            set { BackingStore?.Set("wiFiBlockAutomaticConnectHotspots", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using Wi-Fi.</summary>
        public bool? WiFiBlocked {
            get { return BackingStore?.Get<bool?>("wiFiBlocked"); }
            set { BackingStore?.Set("wiFiBlocked", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using Wi-Fi manual configuration.</summary>
        public bool? WiFiBlockManualConfiguration {
            get { return BackingStore?.Get<bool?>("wiFiBlockManualConfiguration"); }
            set { BackingStore?.Set("wiFiBlockManualConfiguration", value); }
        }
        /// <summary>Specify how often devices scan for Wi-Fi networks. Supported values are 1-500, where 100 = default, and 500 = low frequency. Valid values 1 to 500</summary>
        public int? WiFiScanInterval {
            get { return BackingStore?.Get<int?>("wiFiScanInterval"); }
            set { BackingStore?.Set("wiFiScanInterval", value); }
        }
        /// <summary>Windows 10 force update schedule for Apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule? Windows10AppsForceUpdateSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule?>("windows10AppsForceUpdateSchedule"); }
            set { BackingStore?.Set("windows10AppsForceUpdateSchedule", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule Windows10AppsForceUpdateSchedule {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>("windows10AppsForceUpdateSchedule"); }
            set { BackingStore?.Set("windows10AppsForceUpdateSchedule", value); }
        }
#endif
        /// <summary>Allows IT admins to block experiences that are typically for consumers only, such as Start suggestions, Membership notifications, Post-OOBE app install and redirect tiles.</summary>
        public bool? WindowsSpotlightBlockConsumerSpecificFeatures {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockConsumerSpecificFeatures"); }
            set { BackingStore?.Set("windowsSpotlightBlockConsumerSpecificFeatures", value); }
        }
        /// <summary>Allows IT admins to turn off all Windows Spotlight features</summary>
        public bool? WindowsSpotlightBlocked {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlocked"); }
            set { BackingStore?.Set("windowsSpotlightBlocked", value); }
        }
        /// <summary>Block suggestions from Microsoft that show after each OS clean install, upgrade or in an on-going basis to introduce users to what is new or changed</summary>
        public bool? WindowsSpotlightBlockOnActionCenter {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockOnActionCenter"); }
            set { BackingStore?.Set("windowsSpotlightBlockOnActionCenter", value); }
        }
        /// <summary>Block personalized content in Windows spotlight based on user’s device usage.</summary>
        public bool? WindowsSpotlightBlockTailoredExperiences {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockTailoredExperiences"); }
            set { BackingStore?.Set("windowsSpotlightBlockTailoredExperiences", value); }
        }
        /// <summary>Block third party content delivered via Windows Spotlight</summary>
        public bool? WindowsSpotlightBlockThirdPartyNotifications {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockThirdPartyNotifications"); }
            set { BackingStore?.Set("windowsSpotlightBlockThirdPartyNotifications", value); }
        }
        /// <summary>Block Windows Spotlight Windows welcome experience</summary>
        public bool? WindowsSpotlightBlockWelcomeExperience {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockWelcomeExperience"); }
            set { BackingStore?.Set("windowsSpotlightBlockWelcomeExperience", value); }
        }
        /// <summary>Allows IT admins to turn off the popup of Windows Tips.</summary>
        public bool? WindowsSpotlightBlockWindowsTips {
            get { return BackingStore?.Get<bool?>("windowsSpotlightBlockWindowsTips"); }
            set { BackingStore?.Set("windowsSpotlightBlockWindowsTips", value); }
        }
        /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
        public WindowsSpotlightEnablementSettings? WindowsSpotlightConfigureOnLockScreen {
            get { return BackingStore?.Get<WindowsSpotlightEnablementSettings?>("windowsSpotlightConfigureOnLockScreen"); }
            set { BackingStore?.Set("windowsSpotlightConfigureOnLockScreen", value); }
        }
        /// <summary>Indicates whether or not to block automatic update of apps from Windows Store.</summary>
        public bool? WindowsStoreBlockAutoUpdate {
            get { return BackingStore?.Get<bool?>("windowsStoreBlockAutoUpdate"); }
            set { BackingStore?.Set("windowsStoreBlockAutoUpdate", value); }
        }
        /// <summary>Indicates whether or not to Block the user from using the Windows store.</summary>
        public bool? WindowsStoreBlocked {
            get { return BackingStore?.Get<bool?>("windowsStoreBlocked"); }
            set { BackingStore?.Set("windowsStoreBlocked", value); }
        }
        /// <summary>Indicates whether or not to enable Private Store Only.</summary>
        public bool? WindowsStoreEnablePrivateStoreOnly {
            get { return BackingStore?.Get<bool?>("windowsStoreEnablePrivateStoreOnly"); }
            set { BackingStore?.Set("windowsStoreEnablePrivateStoreOnly", value); }
        }
        /// <summary>Indicates whether or not to allow other devices from discovering this PC for projection.</summary>
        public bool? WirelessDisplayBlockProjectionToThisDevice {
            get { return BackingStore?.Get<bool?>("wirelessDisplayBlockProjectionToThisDevice"); }
            set { BackingStore?.Set("wirelessDisplayBlockProjectionToThisDevice", value); }
        }
        /// <summary>Indicates whether or not to allow user input from wireless display receiver.</summary>
        public bool? WirelessDisplayBlockUserInputFromReceiver {
            get { return BackingStore?.Get<bool?>("wirelessDisplayBlockUserInputFromReceiver"); }
            set { BackingStore?.Set("wirelessDisplayBlockUserInputFromReceiver", value); }
        }
        /// <summary>Indicates whether or not to require a PIN for new devices to initiate pairing.</summary>
        public bool? WirelessDisplayRequirePinForPairing {
            get { return BackingStore?.Get<bool?>("wirelessDisplayRequirePinForPairing"); }
            set { BackingStore?.Set("wirelessDisplayRequirePinForPairing", value); }
        }
        /// <summary>
        /// Instantiates a new Windows10GeneralConfiguration and sets the default values.
        /// </summary>
        public Windows10GeneralConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10GeneralConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                {"activateAppsWithVoice", n => { ActivateAppsWithVoice = n.GetEnumValue<Enablement>(); } },
                {"antiTheftModeBlocked", n => { AntiTheftModeBlocked = n.GetBoolValue(); } },
                {"appManagementMSIAllowUserControlOverInstall", n => { AppManagementMSIAllowUserControlOverInstall = n.GetBoolValue(); } },
                {"appManagementMSIAlwaysInstallWithElevatedPrivileges", n => { AppManagementMSIAlwaysInstallWithElevatedPrivileges = n.GetBoolValue(); } },
                {"appManagementPackageFamilyNamesToLaunchAfterLogOn", n => { AppManagementPackageFamilyNamesToLaunchAfterLogOn = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"appsAllowTrustedAppsSideloading", n => { AppsAllowTrustedAppsSideloading = n.GetEnumValue<StateManagementSetting>(); } },
                {"appsBlockWindowsStoreOriginatedApps", n => { AppsBlockWindowsStoreOriginatedApps = n.GetBoolValue(); } },
                {"authenticationAllowSecondaryDevice", n => { AuthenticationAllowSecondaryDevice = n.GetBoolValue(); } },
                {"authenticationPreferredAzureADTenantDomainName", n => { AuthenticationPreferredAzureADTenantDomainName = n.GetStringValue(); } },
                {"authenticationWebSignIn", n => { AuthenticationWebSignIn = n.GetEnumValue<Enablement>(); } },
                {"bluetoothAllowedServices", n => { BluetoothAllowedServices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"bluetoothBlockAdvertising", n => { BluetoothBlockAdvertising = n.GetBoolValue(); } },
                {"bluetoothBlockDiscoverableMode", n => { BluetoothBlockDiscoverableMode = n.GetBoolValue(); } },
                {"bluetoothBlocked", n => { BluetoothBlocked = n.GetBoolValue(); } },
                {"bluetoothBlockPrePairing", n => { BluetoothBlockPrePairing = n.GetBoolValue(); } },
                {"bluetoothBlockPromptedProximalConnections", n => { BluetoothBlockPromptedProximalConnections = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataWhenRoaming", n => { CellularBlockDataWhenRoaming = n.GetBoolValue(); } },
                {"cellularBlockVpn", n => { CellularBlockVpn = n.GetBoolValue(); } },
                {"cellularBlockVpnWhenRoaming", n => { CellularBlockVpnWhenRoaming = n.GetBoolValue(); } },
                {"cellularData", n => { CellularData = n.GetEnumValue<ConfigurationUsage>(); } },
                {"certificatesBlockManualRootCertificateInstallation", n => { CertificatesBlockManualRootCertificateInstallation = n.GetBoolValue(); } },
                {"configureTimeZone", n => { ConfigureTimeZone = n.GetStringValue(); } },
                {"connectedDevicesServiceBlocked", n => { ConnectedDevicesServiceBlocked = n.GetBoolValue(); } },
                {"copyPasteBlocked", n => { CopyPasteBlocked = n.GetBoolValue(); } },
                {"cortanaBlocked", n => { CortanaBlocked = n.GetBoolValue(); } },
                {"cryptographyAllowFipsAlgorithmPolicy", n => { CryptographyAllowFipsAlgorithmPolicy = n.GetBoolValue(); } },
                {"dataProtectionBlockDirectMemoryAccess", n => { DataProtectionBlockDirectMemoryAccess = n.GetBoolValue(); } },
                {"defenderBlockEndUserAccess", n => { DefenderBlockEndUserAccess = n.GetBoolValue(); } },
                {"defenderBlockOnAccessProtection", n => { DefenderBlockOnAccessProtection = n.GetBoolValue(); } },
                {"defenderCloudBlockLevel", n => { DefenderCloudBlockLevel = n.GetEnumValue<DefenderCloudBlockLevelType>(); } },
                {"defenderCloudExtendedTimeout", n => { DefenderCloudExtendedTimeout = n.GetIntValue(); } },
                {"defenderCloudExtendedTimeoutInSeconds", n => { DefenderCloudExtendedTimeoutInSeconds = n.GetIntValue(); } },
                {"defenderDaysBeforeDeletingQuarantinedMalware", n => { DefenderDaysBeforeDeletingQuarantinedMalware = n.GetIntValue(); } },
                {"defenderDetectedMalwareActions", n => { DefenderDetectedMalwareActions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions.CreateFromDiscriminatorValue); } },
                {"defenderDisableCatchupFullScan", n => { DefenderDisableCatchupFullScan = n.GetBoolValue(); } },
                {"defenderDisableCatchupQuickScan", n => { DefenderDisableCatchupQuickScan = n.GetBoolValue(); } },
                {"defenderFileExtensionsToExclude", n => { DefenderFileExtensionsToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderFilesAndFoldersToExclude", n => { DefenderFilesAndFoldersToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderMonitorFileActivity", n => { DefenderMonitorFileActivity = n.GetEnumValue<DefenderMonitorFileActivity>(); } },
                {"defenderPotentiallyUnwantedAppAction", n => { DefenderPotentiallyUnwantedAppAction = n.GetEnumValue<DefenderPotentiallyUnwantedAppAction>(); } },
                {"defenderPotentiallyUnwantedAppActionSetting", n => { DefenderPotentiallyUnwantedAppActionSetting = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessesToExclude", n => { DefenderProcessesToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderPromptForSampleSubmission", n => { DefenderPromptForSampleSubmission = n.GetEnumValue<DefenderPromptForSampleSubmission>(); } },
                {"defenderRequireBehaviorMonitoring", n => { DefenderRequireBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderRequireCloudProtection", n => { DefenderRequireCloudProtection = n.GetBoolValue(); } },
                {"defenderRequireNetworkInspectionSystem", n => { DefenderRequireNetworkInspectionSystem = n.GetBoolValue(); } },
                {"defenderRequireRealTimeMonitoring", n => { DefenderRequireRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderScanArchiveFiles", n => { DefenderScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderScanDownloads", n => { DefenderScanDownloads = n.GetBoolValue(); } },
                {"defenderScanIncomingMail", n => { DefenderScanIncomingMail = n.GetBoolValue(); } },
                {"defenderScanMappedNetworkDrivesDuringFullScan", n => { DefenderScanMappedNetworkDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderScanMaxCpu", n => { DefenderScanMaxCpu = n.GetIntValue(); } },
                {"defenderScanNetworkFiles", n => { DefenderScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderScanRemovableDrivesDuringFullScan", n => { DefenderScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderScanScriptsLoadedInInternetExplorer", n => { DefenderScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderScanType", n => { DefenderScanType = n.GetEnumValue<DefenderScanType>(); } },
                {"defenderScheduledQuickScanTime", n => { DefenderScheduledQuickScanTime = n.GetTimeValue(); } },
                {"defenderScheduledScanTime", n => { DefenderScheduledScanTime = n.GetTimeValue(); } },
                {"defenderScheduleScanEnableLowCpuPriority", n => { DefenderScheduleScanEnableLowCpuPriority = n.GetBoolValue(); } },
                {"defenderSignatureUpdateIntervalInHours", n => { DefenderSignatureUpdateIntervalInHours = n.GetIntValue(); } },
                {"defenderSubmitSamplesConsentType", n => { DefenderSubmitSamplesConsentType = n.GetEnumValue<DefenderSubmitSamplesConsentType>(); } },
                {"defenderSystemScanSchedule", n => { DefenderSystemScanSchedule = n.GetEnumValue<WeeklySchedule>(); } },
                {"developerUnlockSetting", n => { DeveloperUnlockSetting = n.GetEnumValue<StateManagementSetting>(); } },
                {"deviceManagementBlockFactoryResetOnMobile", n => { DeviceManagementBlockFactoryResetOnMobile = n.GetBoolValue(); } },
                {"deviceManagementBlockManualUnenroll", n => { DeviceManagementBlockManualUnenroll = n.GetBoolValue(); } },
                {"diagnosticsDataSubmissionMode", n => { DiagnosticsDataSubmissionMode = n.GetEnumValue<DiagnosticDataSubmissionMode>(); } },
                {"displayAppListWithGdiDPIScalingTurnedOff", n => { DisplayAppListWithGdiDPIScalingTurnedOff = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"displayAppListWithGdiDPIScalingTurnedOn", n => { DisplayAppListWithGdiDPIScalingTurnedOn = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"edgeAllowStartPagesModification", n => { EdgeAllowStartPagesModification = n.GetBoolValue(); } },
                {"edgeBlockAccessToAboutFlags", n => { EdgeBlockAccessToAboutFlags = n.GetBoolValue(); } },
                {"edgeBlockAddressBarDropdown", n => { EdgeBlockAddressBarDropdown = n.GetBoolValue(); } },
                {"edgeBlockAutofill", n => { EdgeBlockAutofill = n.GetBoolValue(); } },
                {"edgeBlockCompatibilityList", n => { EdgeBlockCompatibilityList = n.GetBoolValue(); } },
                {"edgeBlockDeveloperTools", n => { EdgeBlockDeveloperTools = n.GetBoolValue(); } },
                {"edgeBlocked", n => { EdgeBlocked = n.GetBoolValue(); } },
                {"edgeBlockEditFavorites", n => { EdgeBlockEditFavorites = n.GetBoolValue(); } },
                {"edgeBlockExtensions", n => { EdgeBlockExtensions = n.GetBoolValue(); } },
                {"edgeBlockFullScreenMode", n => { EdgeBlockFullScreenMode = n.GetBoolValue(); } },
                {"edgeBlockInPrivateBrowsing", n => { EdgeBlockInPrivateBrowsing = n.GetBoolValue(); } },
                {"edgeBlockJavaScript", n => { EdgeBlockJavaScript = n.GetBoolValue(); } },
                {"edgeBlockLiveTileDataCollection", n => { EdgeBlockLiveTileDataCollection = n.GetBoolValue(); } },
                {"edgeBlockPasswordManager", n => { EdgeBlockPasswordManager = n.GetBoolValue(); } },
                {"edgeBlockPopups", n => { EdgeBlockPopups = n.GetBoolValue(); } },
                {"edgeBlockPrelaunch", n => { EdgeBlockPrelaunch = n.GetBoolValue(); } },
                {"edgeBlockPrinting", n => { EdgeBlockPrinting = n.GetBoolValue(); } },
                {"edgeBlockSavingHistory", n => { EdgeBlockSavingHistory = n.GetBoolValue(); } },
                {"edgeBlockSearchEngineCustomization", n => { EdgeBlockSearchEngineCustomization = n.GetBoolValue(); } },
                {"edgeBlockSearchSuggestions", n => { EdgeBlockSearchSuggestions = n.GetBoolValue(); } },
                {"edgeBlockSendingDoNotTrackHeader", n => { EdgeBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                {"edgeBlockSendingIntranetTrafficToInternetExplorer", n => { EdgeBlockSendingIntranetTrafficToInternetExplorer = n.GetBoolValue(); } },
                {"edgeBlockSideloadingExtensions", n => { EdgeBlockSideloadingExtensions = n.GetBoolValue(); } },
                {"edgeBlockTabPreloading", n => { EdgeBlockTabPreloading = n.GetBoolValue(); } },
                {"edgeBlockWebContentOnNewTabPage", n => { EdgeBlockWebContentOnNewTabPage = n.GetBoolValue(); } },
                {"edgeClearBrowsingDataOnExit", n => { EdgeClearBrowsingDataOnExit = n.GetBoolValue(); } },
                {"edgeCookiePolicy", n => { EdgeCookiePolicy = n.GetEnumValue<EdgeCookiePolicy>(); } },
                {"edgeDisableFirstRunPage", n => { EdgeDisableFirstRunPage = n.GetBoolValue(); } },
                {"edgeEnterpriseModeSiteListLocation", n => { EdgeEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                {"edgeFavoritesBarVisibility", n => { EdgeFavoritesBarVisibility = n.GetEnumValue<VisibilitySetting>(); } },
                {"edgeFavoritesListLocation", n => { EdgeFavoritesListLocation = n.GetStringValue(); } },
                {"edgeFirstRunUrl", n => { EdgeFirstRunUrl = n.GetStringValue(); } },
                {"edgeHomeButtonConfiguration", n => { EdgeHomeButtonConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>(Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration.CreateFromDiscriminatorValue); } },
                {"edgeHomeButtonConfigurationEnabled", n => { EdgeHomeButtonConfigurationEnabled = n.GetBoolValue(); } },
                {"edgeHomepageUrls", n => { EdgeHomepageUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"edgeKioskModeRestriction", n => { EdgeKioskModeRestriction = n.GetEnumValue<EdgeKioskModeRestrictionType>(); } },
                {"edgeKioskResetAfterIdleTimeInMinutes", n => { EdgeKioskResetAfterIdleTimeInMinutes = n.GetIntValue(); } },
                {"edgeNewTabPageURL", n => { EdgeNewTabPageURL = n.GetStringValue(); } },
                {"edgeOpensWith", n => { EdgeOpensWith = n.GetEnumValue<EdgeOpenOptions>(); } },
                {"edgePreventCertificateErrorOverride", n => { EdgePreventCertificateErrorOverride = n.GetBoolValue(); } },
                {"edgeRequiredExtensionPackageFamilyNames", n => { EdgeRequiredExtensionPackageFamilyNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"edgeRequireSmartScreen", n => { EdgeRequireSmartScreen = n.GetBoolValue(); } },
                {"edgeSearchEngine", n => { EdgeSearchEngine = n.GetObjectValue<EdgeSearchEngineBase>(EdgeSearchEngineBase.CreateFromDiscriminatorValue); } },
                {"edgeSendIntranetTrafficToInternetExplorer", n => { EdgeSendIntranetTrafficToInternetExplorer = n.GetBoolValue(); } },
                {"edgeShowMessageWhenOpeningInternetExplorerSites", n => { EdgeShowMessageWhenOpeningInternetExplorerSites = n.GetEnumValue<InternetExplorerMessageSetting>(); } },
                {"edgeSyncFavoritesWithInternetExplorer", n => { EdgeSyncFavoritesWithInternetExplorer = n.GetBoolValue(); } },
                {"edgeTelemetryForMicrosoft365Analytics", n => { EdgeTelemetryForMicrosoft365Analytics = n.GetEnumValue<EdgeTelemetryMode>(); } },
                {"enableAutomaticRedeployment", n => { EnableAutomaticRedeployment = n.GetBoolValue(); } },
                {"energySaverOnBatteryThresholdPercentage", n => { EnergySaverOnBatteryThresholdPercentage = n.GetIntValue(); } },
                {"energySaverPluggedInThresholdPercentage", n => { EnergySaverPluggedInThresholdPercentage = n.GetIntValue(); } },
                {"enterpriseCloudPrintDiscoveryEndPoint", n => { EnterpriseCloudPrintDiscoveryEndPoint = n.GetStringValue(); } },
                {"enterpriseCloudPrintDiscoveryMaxLimit", n => { EnterpriseCloudPrintDiscoveryMaxLimit = n.GetIntValue(); } },
                {"enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", n => { EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier = n.GetStringValue(); } },
                {"enterpriseCloudPrintOAuthAuthority", n => { EnterpriseCloudPrintOAuthAuthority = n.GetStringValue(); } },
                {"enterpriseCloudPrintOAuthClientIdentifier", n => { EnterpriseCloudPrintOAuthClientIdentifier = n.GetStringValue(); } },
                {"enterpriseCloudPrintResourceIdentifier", n => { EnterpriseCloudPrintResourceIdentifier = n.GetStringValue(); } },
                {"experienceBlockDeviceDiscovery", n => { ExperienceBlockDeviceDiscovery = n.GetBoolValue(); } },
                {"experienceBlockErrorDialogWhenNoSIM", n => { ExperienceBlockErrorDialogWhenNoSIM = n.GetBoolValue(); } },
                {"experienceBlockTaskSwitcher", n => { ExperienceBlockTaskSwitcher = n.GetBoolValue(); } },
                {"experienceDoNotSyncBrowserSettings", n => { ExperienceDoNotSyncBrowserSettings = n.GetEnumValue<BrowserSyncSetting>(); } },
                {"findMyFiles", n => { FindMyFiles = n.GetEnumValue<Enablement>(); } },
                {"gameDvrBlocked", n => { GameDvrBlocked = n.GetBoolValue(); } },
                {"inkWorkspaceAccess", n => { InkWorkspaceAccess = n.GetEnumValue<InkAccessSetting>(); } },
                {"inkWorkspaceAccessState", n => { InkWorkspaceAccessState = n.GetEnumValue<StateManagementSetting>(); } },
                {"inkWorkspaceBlockSuggestedApps", n => { InkWorkspaceBlockSuggestedApps = n.GetBoolValue(); } },
                {"internetSharingBlocked", n => { InternetSharingBlocked = n.GetBoolValue(); } },
                {"locationServicesBlocked", n => { LocationServicesBlocked = n.GetBoolValue(); } },
                {"lockScreenActivateAppsWithVoice", n => { LockScreenActivateAppsWithVoice = n.GetEnumValue<Enablement>(); } },
                {"lockScreenAllowTimeoutConfiguration", n => { LockScreenAllowTimeoutConfiguration = n.GetBoolValue(); } },
                {"lockScreenBlockActionCenterNotifications", n => { LockScreenBlockActionCenterNotifications = n.GetBoolValue(); } },
                {"lockScreenBlockCortana", n => { LockScreenBlockCortana = n.GetBoolValue(); } },
                {"lockScreenBlockToastNotifications", n => { LockScreenBlockToastNotifications = n.GetBoolValue(); } },
                {"lockScreenTimeoutInSeconds", n => { LockScreenTimeoutInSeconds = n.GetIntValue(); } },
                {"logonBlockFastUserSwitching", n => { LogonBlockFastUserSwitching = n.GetBoolValue(); } },
                {"messagingBlockMMS", n => { MessagingBlockMMS = n.GetBoolValue(); } },
                {"messagingBlockRichCommunicationServices", n => { MessagingBlockRichCommunicationServices = n.GetBoolValue(); } },
                {"messagingBlockSync", n => { MessagingBlockSync = n.GetBoolValue(); } },
                {"microsoftAccountBlocked", n => { MicrosoftAccountBlocked = n.GetBoolValue(); } },
                {"microsoftAccountBlockSettingsSync", n => { MicrosoftAccountBlockSettingsSync = n.GetBoolValue(); } },
                {"microsoftAccountSignInAssistantSettings", n => { MicrosoftAccountSignInAssistantSettings = n.GetEnumValue<SignInAssistantOptions>(); } },
                {"networkProxyApplySettingsDeviceWide", n => { NetworkProxyApplySettingsDeviceWide = n.GetBoolValue(); } },
                {"networkProxyAutomaticConfigurationUrl", n => { NetworkProxyAutomaticConfigurationUrl = n.GetStringValue(); } },
                {"networkProxyDisableAutoDetect", n => { NetworkProxyDisableAutoDetect = n.GetBoolValue(); } },
                {"networkProxyServer", n => { NetworkProxyServer = n.GetObjectValue<Windows10NetworkProxyServer>(Windows10NetworkProxyServer.CreateFromDiscriminatorValue); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"oneDriveDisableFileSync", n => { OneDriveDisableFileSync = n.GetBoolValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumAgeInDays", n => { PasswordMinimumAgeInDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordRequireWhenResumeFromIdleState", n => { PasswordRequireWhenResumeFromIdleState = n.GetBoolValue(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"personalizationDesktopImageUrl", n => { PersonalizationDesktopImageUrl = n.GetStringValue(); } },
                {"personalizationLockScreenImageUrl", n => { PersonalizationLockScreenImageUrl = n.GetStringValue(); } },
                {"powerButtonActionOnBattery", n => { PowerButtonActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerButtonActionPluggedIn", n => { PowerButtonActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"powerHybridSleepOnBattery", n => { PowerHybridSleepOnBattery = n.GetEnumValue<Enablement>(); } },
                {"powerHybridSleepPluggedIn", n => { PowerHybridSleepPluggedIn = n.GetEnumValue<Enablement>(); } },
                {"powerLidCloseActionOnBattery", n => { PowerLidCloseActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerLidCloseActionPluggedIn", n => { PowerLidCloseActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"powerSleepButtonActionOnBattery", n => { PowerSleepButtonActionOnBattery = n.GetEnumValue<PowerActionType>(); } },
                {"powerSleepButtonActionPluggedIn", n => { PowerSleepButtonActionPluggedIn = n.GetEnumValue<PowerActionType>(); } },
                {"printerBlockAddition", n => { PrinterBlockAddition = n.GetBoolValue(); } },
                {"printerDefaultName", n => { PrinterDefaultName = n.GetStringValue(); } },
                {"printerNames", n => { PrinterNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"privacyAccessControls", n => { PrivacyAccessControls = n.GetCollectionOfObjectValues<WindowsPrivacyDataAccessControlItem>(WindowsPrivacyDataAccessControlItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"privacyAdvertisingId", n => { PrivacyAdvertisingId = n.GetEnumValue<StateManagementSetting>(); } },
                {"privacyAutoAcceptPairingAndConsentPrompts", n => { PrivacyAutoAcceptPairingAndConsentPrompts = n.GetBoolValue(); } },
                {"privacyBlockActivityFeed", n => { PrivacyBlockActivityFeed = n.GetBoolValue(); } },
                {"privacyBlockInputPersonalization", n => { PrivacyBlockInputPersonalization = n.GetBoolValue(); } },
                {"privacyBlockPublishUserActivities", n => { PrivacyBlockPublishUserActivities = n.GetBoolValue(); } },
                {"privacyDisableLaunchExperience", n => { PrivacyDisableLaunchExperience = n.GetBoolValue(); } },
                {"resetProtectionModeBlocked", n => { ResetProtectionModeBlocked = n.GetBoolValue(); } },
                {"safeSearchFilter", n => { SafeSearchFilter = n.GetEnumValue<SafeSearchFilterType>(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"searchBlockDiacritics", n => { SearchBlockDiacritics = n.GetBoolValue(); } },
                {"searchBlockWebResults", n => { SearchBlockWebResults = n.GetBoolValue(); } },
                {"searchDisableAutoLanguageDetection", n => { SearchDisableAutoLanguageDetection = n.GetBoolValue(); } },
                {"searchDisableIndexerBackoff", n => { SearchDisableIndexerBackoff = n.GetBoolValue(); } },
                {"searchDisableIndexingEncryptedItems", n => { SearchDisableIndexingEncryptedItems = n.GetBoolValue(); } },
                {"searchDisableIndexingRemovableDrive", n => { SearchDisableIndexingRemovableDrive = n.GetBoolValue(); } },
                {"searchDisableLocation", n => { SearchDisableLocation = n.GetBoolValue(); } },
                {"searchDisableUseLocation", n => { SearchDisableUseLocation = n.GetBoolValue(); } },
                {"searchEnableAutomaticIndexSizeManangement", n => { SearchEnableAutomaticIndexSizeManangement = n.GetBoolValue(); } },
                {"searchEnableRemoteQueries", n => { SearchEnableRemoteQueries = n.GetBoolValue(); } },
                {"securityBlockAzureADJoinedDevicesAutoEncryption", n => { SecurityBlockAzureADJoinedDevicesAutoEncryption = n.GetBoolValue(); } },
                {"settingsBlockAccountsPage", n => { SettingsBlockAccountsPage = n.GetBoolValue(); } },
                {"settingsBlockAddProvisioningPackage", n => { SettingsBlockAddProvisioningPackage = n.GetBoolValue(); } },
                {"settingsBlockAppsPage", n => { SettingsBlockAppsPage = n.GetBoolValue(); } },
                {"settingsBlockChangeLanguage", n => { SettingsBlockChangeLanguage = n.GetBoolValue(); } },
                {"settingsBlockChangePowerSleep", n => { SettingsBlockChangePowerSleep = n.GetBoolValue(); } },
                {"settingsBlockChangeRegion", n => { SettingsBlockChangeRegion = n.GetBoolValue(); } },
                {"settingsBlockChangeSystemTime", n => { SettingsBlockChangeSystemTime = n.GetBoolValue(); } },
                {"settingsBlockDevicesPage", n => { SettingsBlockDevicesPage = n.GetBoolValue(); } },
                {"settingsBlockEaseOfAccessPage", n => { SettingsBlockEaseOfAccessPage = n.GetBoolValue(); } },
                {"settingsBlockEditDeviceName", n => { SettingsBlockEditDeviceName = n.GetBoolValue(); } },
                {"settingsBlockGamingPage", n => { SettingsBlockGamingPage = n.GetBoolValue(); } },
                {"settingsBlockNetworkInternetPage", n => { SettingsBlockNetworkInternetPage = n.GetBoolValue(); } },
                {"settingsBlockPersonalizationPage", n => { SettingsBlockPersonalizationPage = n.GetBoolValue(); } },
                {"settingsBlockPrivacyPage", n => { SettingsBlockPrivacyPage = n.GetBoolValue(); } },
                {"settingsBlockRemoveProvisioningPackage", n => { SettingsBlockRemoveProvisioningPackage = n.GetBoolValue(); } },
                {"settingsBlockSettingsApp", n => { SettingsBlockSettingsApp = n.GetBoolValue(); } },
                {"settingsBlockSystemPage", n => { SettingsBlockSystemPage = n.GetBoolValue(); } },
                {"settingsBlockTimeLanguagePage", n => { SettingsBlockTimeLanguagePage = n.GetBoolValue(); } },
                {"settingsBlockUpdateSecurityPage", n => { SettingsBlockUpdateSecurityPage = n.GetBoolValue(); } },
                {"sharedUserAppDataAllowed", n => { SharedUserAppDataAllowed = n.GetBoolValue(); } },
                {"smartScreenAppInstallControl", n => { SmartScreenAppInstallControl = n.GetEnumValue<AppInstallControlType>(); } },
                {"smartScreenBlockPromptOverride", n => { SmartScreenBlockPromptOverride = n.GetBoolValue(); } },
                {"smartScreenBlockPromptOverrideForFiles", n => { SmartScreenBlockPromptOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableAppInstallControl", n => { SmartScreenEnableAppInstallControl = n.GetBoolValue(); } },
                {"startBlockUnpinningAppsFromTaskbar", n => { StartBlockUnpinningAppsFromTaskbar = n.GetBoolValue(); } },
                {"startMenuAppListVisibility", n => { StartMenuAppListVisibility = n.GetEnumValue<WindowsStartMenuAppListVisibilityType>(); } },
                {"startMenuHideChangeAccountSettings", n => { StartMenuHideChangeAccountSettings = n.GetBoolValue(); } },
                {"startMenuHideFrequentlyUsedApps", n => { StartMenuHideFrequentlyUsedApps = n.GetBoolValue(); } },
                {"startMenuHideHibernate", n => { StartMenuHideHibernate = n.GetBoolValue(); } },
                {"startMenuHideLock", n => { StartMenuHideLock = n.GetBoolValue(); } },
                {"startMenuHidePowerButton", n => { StartMenuHidePowerButton = n.GetBoolValue(); } },
                {"startMenuHideRecentJumpLists", n => { StartMenuHideRecentJumpLists = n.GetBoolValue(); } },
                {"startMenuHideRecentlyAddedApps", n => { StartMenuHideRecentlyAddedApps = n.GetBoolValue(); } },
                {"startMenuHideRestartOptions", n => { StartMenuHideRestartOptions = n.GetBoolValue(); } },
                {"startMenuHideShutDown", n => { StartMenuHideShutDown = n.GetBoolValue(); } },
                {"startMenuHideSignOut", n => { StartMenuHideSignOut = n.GetBoolValue(); } },
                {"startMenuHideSleep", n => { StartMenuHideSleep = n.GetBoolValue(); } },
                {"startMenuHideSwitchAccount", n => { StartMenuHideSwitchAccount = n.GetBoolValue(); } },
                {"startMenuHideUserTile", n => { StartMenuHideUserTile = n.GetBoolValue(); } },
                {"startMenuLayoutEdgeAssetsXml", n => { StartMenuLayoutEdgeAssetsXml = n.GetByteArrayValue(); } },
                {"startMenuLayoutXml", n => { StartMenuLayoutXml = n.GetByteArrayValue(); } },
                {"startMenuMode", n => { StartMenuMode = n.GetEnumValue<WindowsStartMenuModeType>(); } },
                {"startMenuPinnedFolderDocuments", n => { StartMenuPinnedFolderDocuments = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderDownloads", n => { StartMenuPinnedFolderDownloads = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderFileExplorer", n => { StartMenuPinnedFolderFileExplorer = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderHomeGroup", n => { StartMenuPinnedFolderHomeGroup = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderMusic", n => { StartMenuPinnedFolderMusic = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderNetwork", n => { StartMenuPinnedFolderNetwork = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderPersonalFolder", n => { StartMenuPinnedFolderPersonalFolder = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderPictures", n => { StartMenuPinnedFolderPictures = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderSettings", n => { StartMenuPinnedFolderSettings = n.GetEnumValue<VisibilitySetting>(); } },
                {"startMenuPinnedFolderVideos", n => { StartMenuPinnedFolderVideos = n.GetEnumValue<VisibilitySetting>(); } },
                {"storageBlockRemovableStorage", n => { StorageBlockRemovableStorage = n.GetBoolValue(); } },
                {"storageRequireMobileDeviceEncryption", n => { StorageRequireMobileDeviceEncryption = n.GetBoolValue(); } },
                {"storageRestrictAppDataToSystemVolume", n => { StorageRestrictAppDataToSystemVolume = n.GetBoolValue(); } },
                {"storageRestrictAppInstallToSystemVolume", n => { StorageRestrictAppInstallToSystemVolume = n.GetBoolValue(); } },
                {"systemTelemetryProxyServer", n => { SystemTelemetryProxyServer = n.GetStringValue(); } },
                {"taskManagerBlockEndTask", n => { TaskManagerBlockEndTask = n.GetBoolValue(); } },
                {"tenantLockdownRequireNetworkDuringOutOfBoxExperience", n => { TenantLockdownRequireNetworkDuringOutOfBoxExperience = n.GetBoolValue(); } },
                {"uninstallBuiltInApps", n => { UninstallBuiltInApps = n.GetBoolValue(); } },
                {"usbBlocked", n => { UsbBlocked = n.GetBoolValue(); } },
                {"voiceRecordingBlocked", n => { VoiceRecordingBlocked = n.GetBoolValue(); } },
                {"webRtcBlockLocalhostIpAddress", n => { WebRtcBlockLocalhostIpAddress = n.GetBoolValue(); } },
                {"wiFiBlockAutomaticConnectHotspots", n => { WiFiBlockAutomaticConnectHotspots = n.GetBoolValue(); } },
                {"wiFiBlocked", n => { WiFiBlocked = n.GetBoolValue(); } },
                {"wiFiBlockManualConfiguration", n => { WiFiBlockManualConfiguration = n.GetBoolValue(); } },
                {"wiFiScanInterval", n => { WiFiScanInterval = n.GetIntValue(); } },
                {"windows10AppsForceUpdateSchedule", n => { Windows10AppsForceUpdateSchedule = n.GetObjectValue<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>(Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule.CreateFromDiscriminatorValue); } },
                {"windowsSpotlightBlockConsumerSpecificFeatures", n => { WindowsSpotlightBlockConsumerSpecificFeatures = n.GetBoolValue(); } },
                {"windowsSpotlightBlocked", n => { WindowsSpotlightBlocked = n.GetBoolValue(); } },
                {"windowsSpotlightBlockOnActionCenter", n => { WindowsSpotlightBlockOnActionCenter = n.GetBoolValue(); } },
                {"windowsSpotlightBlockTailoredExperiences", n => { WindowsSpotlightBlockTailoredExperiences = n.GetBoolValue(); } },
                {"windowsSpotlightBlockThirdPartyNotifications", n => { WindowsSpotlightBlockThirdPartyNotifications = n.GetBoolValue(); } },
                {"windowsSpotlightBlockWelcomeExperience", n => { WindowsSpotlightBlockWelcomeExperience = n.GetBoolValue(); } },
                {"windowsSpotlightBlockWindowsTips", n => { WindowsSpotlightBlockWindowsTips = n.GetBoolValue(); } },
                {"windowsSpotlightConfigureOnLockScreen", n => { WindowsSpotlightConfigureOnLockScreen = n.GetEnumValue<WindowsSpotlightEnablementSettings>(); } },
                {"windowsStoreBlockAutoUpdate", n => { WindowsStoreBlockAutoUpdate = n.GetBoolValue(); } },
                {"windowsStoreBlocked", n => { WindowsStoreBlocked = n.GetBoolValue(); } },
                {"windowsStoreEnablePrivateStoreOnly", n => { WindowsStoreEnablePrivateStoreOnly = n.GetBoolValue(); } },
                {"wirelessDisplayBlockProjectionToThisDevice", n => { WirelessDisplayBlockProjectionToThisDevice = n.GetBoolValue(); } },
                {"wirelessDisplayBlockUserInputFromReceiver", n => { WirelessDisplayBlockUserInputFromReceiver = n.GetBoolValue(); } },
                {"wirelessDisplayRequirePinForPairing", n => { WirelessDisplayRequirePinForPairing = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockAddingNonMicrosoftAccountEmail", AccountsBlockAddingNonMicrosoftAccountEmail);
            writer.WriteEnumValue<Enablement>("activateAppsWithVoice", ActivateAppsWithVoice);
            writer.WriteBoolValue("antiTheftModeBlocked", AntiTheftModeBlocked);
            writer.WriteBoolValue("appManagementMSIAllowUserControlOverInstall", AppManagementMSIAllowUserControlOverInstall);
            writer.WriteBoolValue("appManagementMSIAlwaysInstallWithElevatedPrivileges", AppManagementMSIAlwaysInstallWithElevatedPrivileges);
            writer.WriteCollectionOfPrimitiveValues<string>("appManagementPackageFamilyNamesToLaunchAfterLogOn", AppManagementPackageFamilyNamesToLaunchAfterLogOn);
            writer.WriteEnumValue<StateManagementSetting>("appsAllowTrustedAppsSideloading", AppsAllowTrustedAppsSideloading);
            writer.WriteBoolValue("appsBlockWindowsStoreOriginatedApps", AppsBlockWindowsStoreOriginatedApps);
            writer.WriteBoolValue("authenticationAllowSecondaryDevice", AuthenticationAllowSecondaryDevice);
            writer.WriteStringValue("authenticationPreferredAzureADTenantDomainName", AuthenticationPreferredAzureADTenantDomainName);
            writer.WriteEnumValue<Enablement>("authenticationWebSignIn", AuthenticationWebSignIn);
            writer.WriteCollectionOfPrimitiveValues<string>("bluetoothAllowedServices", BluetoothAllowedServices);
            writer.WriteBoolValue("bluetoothBlockAdvertising", BluetoothBlockAdvertising);
            writer.WriteBoolValue("bluetoothBlockDiscoverableMode", BluetoothBlockDiscoverableMode);
            writer.WriteBoolValue("bluetoothBlocked", BluetoothBlocked);
            writer.WriteBoolValue("bluetoothBlockPrePairing", BluetoothBlockPrePairing);
            writer.WriteBoolValue("bluetoothBlockPromptedProximalConnections", BluetoothBlockPromptedProximalConnections);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataWhenRoaming", CellularBlockDataWhenRoaming);
            writer.WriteBoolValue("cellularBlockVpn", CellularBlockVpn);
            writer.WriteBoolValue("cellularBlockVpnWhenRoaming", CellularBlockVpnWhenRoaming);
            writer.WriteEnumValue<ConfigurationUsage>("cellularData", CellularData);
            writer.WriteBoolValue("certificatesBlockManualRootCertificateInstallation", CertificatesBlockManualRootCertificateInstallation);
            writer.WriteStringValue("configureTimeZone", ConfigureTimeZone);
            writer.WriteBoolValue("connectedDevicesServiceBlocked", ConnectedDevicesServiceBlocked);
            writer.WriteBoolValue("copyPasteBlocked", CopyPasteBlocked);
            writer.WriteBoolValue("cortanaBlocked", CortanaBlocked);
            writer.WriteBoolValue("cryptographyAllowFipsAlgorithmPolicy", CryptographyAllowFipsAlgorithmPolicy);
            writer.WriteBoolValue("dataProtectionBlockDirectMemoryAccess", DataProtectionBlockDirectMemoryAccess);
            writer.WriteBoolValue("defenderBlockEndUserAccess", DefenderBlockEndUserAccess);
            writer.WriteBoolValue("defenderBlockOnAccessProtection", DefenderBlockOnAccessProtection);
            writer.WriteEnumValue<DefenderCloudBlockLevelType>("defenderCloudBlockLevel", DefenderCloudBlockLevel);
            writer.WriteIntValue("defenderCloudExtendedTimeout", DefenderCloudExtendedTimeout);
            writer.WriteIntValue("defenderCloudExtendedTimeoutInSeconds", DefenderCloudExtendedTimeoutInSeconds);
            writer.WriteIntValue("defenderDaysBeforeDeletingQuarantinedMalware", DefenderDaysBeforeDeletingQuarantinedMalware);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>("defenderDetectedMalwareActions", DefenderDetectedMalwareActions);
            writer.WriteBoolValue("defenderDisableCatchupFullScan", DefenderDisableCatchupFullScan);
            writer.WriteBoolValue("defenderDisableCatchupQuickScan", DefenderDisableCatchupQuickScan);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFileExtensionsToExclude", DefenderFileExtensionsToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFilesAndFoldersToExclude", DefenderFilesAndFoldersToExclude);
            writer.WriteEnumValue<DefenderMonitorFileActivity>("defenderMonitorFileActivity", DefenderMonitorFileActivity);
            writer.WriteEnumValue<DefenderPotentiallyUnwantedAppAction>("defenderPotentiallyUnwantedAppAction", DefenderPotentiallyUnwantedAppAction);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPotentiallyUnwantedAppActionSetting", DefenderPotentiallyUnwantedAppActionSetting);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderProcessesToExclude", DefenderProcessesToExclude);
            writer.WriteEnumValue<DefenderPromptForSampleSubmission>("defenderPromptForSampleSubmission", DefenderPromptForSampleSubmission);
            writer.WriteBoolValue("defenderRequireBehaviorMonitoring", DefenderRequireBehaviorMonitoring);
            writer.WriteBoolValue("defenderRequireCloudProtection", DefenderRequireCloudProtection);
            writer.WriteBoolValue("defenderRequireNetworkInspectionSystem", DefenderRequireNetworkInspectionSystem);
            writer.WriteBoolValue("defenderRequireRealTimeMonitoring", DefenderRequireRealTimeMonitoring);
            writer.WriteBoolValue("defenderScanArchiveFiles", DefenderScanArchiveFiles);
            writer.WriteBoolValue("defenderScanDownloads", DefenderScanDownloads);
            writer.WriteBoolValue("defenderScanIncomingMail", DefenderScanIncomingMail);
            writer.WriteBoolValue("defenderScanMappedNetworkDrivesDuringFullScan", DefenderScanMappedNetworkDrivesDuringFullScan);
            writer.WriteIntValue("defenderScanMaxCpu", DefenderScanMaxCpu);
            writer.WriteBoolValue("defenderScanNetworkFiles", DefenderScanNetworkFiles);
            writer.WriteBoolValue("defenderScanRemovableDrivesDuringFullScan", DefenderScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderScanScriptsLoadedInInternetExplorer", DefenderScanScriptsLoadedInInternetExplorer);
            writer.WriteEnumValue<DefenderScanType>("defenderScanType", DefenderScanType);
            writer.WriteTimeValue("defenderScheduledQuickScanTime", DefenderScheduledQuickScanTime);
            writer.WriteTimeValue("defenderScheduledScanTime", DefenderScheduledScanTime);
            writer.WriteBoolValue("defenderScheduleScanEnableLowCpuPriority", DefenderScheduleScanEnableLowCpuPriority);
            writer.WriteIntValue("defenderSignatureUpdateIntervalInHours", DefenderSignatureUpdateIntervalInHours);
            writer.WriteEnumValue<DefenderSubmitSamplesConsentType>("defenderSubmitSamplesConsentType", DefenderSubmitSamplesConsentType);
            writer.WriteEnumValue<WeeklySchedule>("defenderSystemScanSchedule", DefenderSystemScanSchedule);
            writer.WriteEnumValue<StateManagementSetting>("developerUnlockSetting", DeveloperUnlockSetting);
            writer.WriteBoolValue("deviceManagementBlockFactoryResetOnMobile", DeviceManagementBlockFactoryResetOnMobile);
            writer.WriteBoolValue("deviceManagementBlockManualUnenroll", DeviceManagementBlockManualUnenroll);
            writer.WriteEnumValue<DiagnosticDataSubmissionMode>("diagnosticsDataSubmissionMode", DiagnosticsDataSubmissionMode);
            writer.WriteCollectionOfPrimitiveValues<string>("displayAppListWithGdiDPIScalingTurnedOff", DisplayAppListWithGdiDPIScalingTurnedOff);
            writer.WriteCollectionOfPrimitiveValues<string>("displayAppListWithGdiDPIScalingTurnedOn", DisplayAppListWithGdiDPIScalingTurnedOn);
            writer.WriteBoolValue("edgeAllowStartPagesModification", EdgeAllowStartPagesModification);
            writer.WriteBoolValue("edgeBlockAccessToAboutFlags", EdgeBlockAccessToAboutFlags);
            writer.WriteBoolValue("edgeBlockAddressBarDropdown", EdgeBlockAddressBarDropdown);
            writer.WriteBoolValue("edgeBlockAutofill", EdgeBlockAutofill);
            writer.WriteBoolValue("edgeBlockCompatibilityList", EdgeBlockCompatibilityList);
            writer.WriteBoolValue("edgeBlockDeveloperTools", EdgeBlockDeveloperTools);
            writer.WriteBoolValue("edgeBlocked", EdgeBlocked);
            writer.WriteBoolValue("edgeBlockEditFavorites", EdgeBlockEditFavorites);
            writer.WriteBoolValue("edgeBlockExtensions", EdgeBlockExtensions);
            writer.WriteBoolValue("edgeBlockFullScreenMode", EdgeBlockFullScreenMode);
            writer.WriteBoolValue("edgeBlockInPrivateBrowsing", EdgeBlockInPrivateBrowsing);
            writer.WriteBoolValue("edgeBlockJavaScript", EdgeBlockJavaScript);
            writer.WriteBoolValue("edgeBlockLiveTileDataCollection", EdgeBlockLiveTileDataCollection);
            writer.WriteBoolValue("edgeBlockPasswordManager", EdgeBlockPasswordManager);
            writer.WriteBoolValue("edgeBlockPopups", EdgeBlockPopups);
            writer.WriteBoolValue("edgeBlockPrelaunch", EdgeBlockPrelaunch);
            writer.WriteBoolValue("edgeBlockPrinting", EdgeBlockPrinting);
            writer.WriteBoolValue("edgeBlockSavingHistory", EdgeBlockSavingHistory);
            writer.WriteBoolValue("edgeBlockSearchEngineCustomization", EdgeBlockSearchEngineCustomization);
            writer.WriteBoolValue("edgeBlockSearchSuggestions", EdgeBlockSearchSuggestions);
            writer.WriteBoolValue("edgeBlockSendingDoNotTrackHeader", EdgeBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("edgeBlockSendingIntranetTrafficToInternetExplorer", EdgeBlockSendingIntranetTrafficToInternetExplorer);
            writer.WriteBoolValue("edgeBlockSideloadingExtensions", EdgeBlockSideloadingExtensions);
            writer.WriteBoolValue("edgeBlockTabPreloading", EdgeBlockTabPreloading);
            writer.WriteBoolValue("edgeBlockWebContentOnNewTabPage", EdgeBlockWebContentOnNewTabPage);
            writer.WriteBoolValue("edgeClearBrowsingDataOnExit", EdgeClearBrowsingDataOnExit);
            writer.WriteEnumValue<EdgeCookiePolicy>("edgeCookiePolicy", EdgeCookiePolicy);
            writer.WriteBoolValue("edgeDisableFirstRunPage", EdgeDisableFirstRunPage);
            writer.WriteStringValue("edgeEnterpriseModeSiteListLocation", EdgeEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<VisibilitySetting>("edgeFavoritesBarVisibility", EdgeFavoritesBarVisibility);
            writer.WriteStringValue("edgeFavoritesListLocation", EdgeFavoritesListLocation);
            writer.WriteStringValue("edgeFirstRunUrl", EdgeFirstRunUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EdgeHomeButtonConfiguration>("edgeHomeButtonConfiguration", EdgeHomeButtonConfiguration);
            writer.WriteBoolValue("edgeHomeButtonConfigurationEnabled", EdgeHomeButtonConfigurationEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("edgeHomepageUrls", EdgeHomepageUrls);
            writer.WriteEnumValue<EdgeKioskModeRestrictionType>("edgeKioskModeRestriction", EdgeKioskModeRestriction);
            writer.WriteIntValue("edgeKioskResetAfterIdleTimeInMinutes", EdgeKioskResetAfterIdleTimeInMinutes);
            writer.WriteStringValue("edgeNewTabPageURL", EdgeNewTabPageURL);
            writer.WriteEnumValue<EdgeOpenOptions>("edgeOpensWith", EdgeOpensWith);
            writer.WriteBoolValue("edgePreventCertificateErrorOverride", EdgePreventCertificateErrorOverride);
            writer.WriteCollectionOfPrimitiveValues<string>("edgeRequiredExtensionPackageFamilyNames", EdgeRequiredExtensionPackageFamilyNames);
            writer.WriteBoolValue("edgeRequireSmartScreen", EdgeRequireSmartScreen);
            writer.WriteObjectValue<EdgeSearchEngineBase>("edgeSearchEngine", EdgeSearchEngine);
            writer.WriteBoolValue("edgeSendIntranetTrafficToInternetExplorer", EdgeSendIntranetTrafficToInternetExplorer);
            writer.WriteEnumValue<InternetExplorerMessageSetting>("edgeShowMessageWhenOpeningInternetExplorerSites", EdgeShowMessageWhenOpeningInternetExplorerSites);
            writer.WriteBoolValue("edgeSyncFavoritesWithInternetExplorer", EdgeSyncFavoritesWithInternetExplorer);
            writer.WriteEnumValue<EdgeTelemetryMode>("edgeTelemetryForMicrosoft365Analytics", EdgeTelemetryForMicrosoft365Analytics);
            writer.WriteBoolValue("enableAutomaticRedeployment", EnableAutomaticRedeployment);
            writer.WriteIntValue("energySaverOnBatteryThresholdPercentage", EnergySaverOnBatteryThresholdPercentage);
            writer.WriteIntValue("energySaverPluggedInThresholdPercentage", EnergySaverPluggedInThresholdPercentage);
            writer.WriteStringValue("enterpriseCloudPrintDiscoveryEndPoint", EnterpriseCloudPrintDiscoveryEndPoint);
            writer.WriteIntValue("enterpriseCloudPrintDiscoveryMaxLimit", EnterpriseCloudPrintDiscoveryMaxLimit);
            writer.WriteStringValue("enterpriseCloudPrintMopriaDiscoveryResourceIdentifier", EnterpriseCloudPrintMopriaDiscoveryResourceIdentifier);
            writer.WriteStringValue("enterpriseCloudPrintOAuthAuthority", EnterpriseCloudPrintOAuthAuthority);
            writer.WriteStringValue("enterpriseCloudPrintOAuthClientIdentifier", EnterpriseCloudPrintOAuthClientIdentifier);
            writer.WriteStringValue("enterpriseCloudPrintResourceIdentifier", EnterpriseCloudPrintResourceIdentifier);
            writer.WriteBoolValue("experienceBlockDeviceDiscovery", ExperienceBlockDeviceDiscovery);
            writer.WriteBoolValue("experienceBlockErrorDialogWhenNoSIM", ExperienceBlockErrorDialogWhenNoSIM);
            writer.WriteBoolValue("experienceBlockTaskSwitcher", ExperienceBlockTaskSwitcher);
            writer.WriteEnumValue<BrowserSyncSetting>("experienceDoNotSyncBrowserSettings", ExperienceDoNotSyncBrowserSettings);
            writer.WriteEnumValue<Enablement>("findMyFiles", FindMyFiles);
            writer.WriteBoolValue("gameDvrBlocked", GameDvrBlocked);
            writer.WriteEnumValue<InkAccessSetting>("inkWorkspaceAccess", InkWorkspaceAccess);
            writer.WriteEnumValue<StateManagementSetting>("inkWorkspaceAccessState", InkWorkspaceAccessState);
            writer.WriteBoolValue("inkWorkspaceBlockSuggestedApps", InkWorkspaceBlockSuggestedApps);
            writer.WriteBoolValue("internetSharingBlocked", InternetSharingBlocked);
            writer.WriteBoolValue("locationServicesBlocked", LocationServicesBlocked);
            writer.WriteEnumValue<Enablement>("lockScreenActivateAppsWithVoice", LockScreenActivateAppsWithVoice);
            writer.WriteBoolValue("lockScreenAllowTimeoutConfiguration", LockScreenAllowTimeoutConfiguration);
            writer.WriteBoolValue("lockScreenBlockActionCenterNotifications", LockScreenBlockActionCenterNotifications);
            writer.WriteBoolValue("lockScreenBlockCortana", LockScreenBlockCortana);
            writer.WriteBoolValue("lockScreenBlockToastNotifications", LockScreenBlockToastNotifications);
            writer.WriteIntValue("lockScreenTimeoutInSeconds", LockScreenTimeoutInSeconds);
            writer.WriteBoolValue("logonBlockFastUserSwitching", LogonBlockFastUserSwitching);
            writer.WriteBoolValue("messagingBlockMMS", MessagingBlockMMS);
            writer.WriteBoolValue("messagingBlockRichCommunicationServices", MessagingBlockRichCommunicationServices);
            writer.WriteBoolValue("messagingBlockSync", MessagingBlockSync);
            writer.WriteBoolValue("microsoftAccountBlocked", MicrosoftAccountBlocked);
            writer.WriteBoolValue("microsoftAccountBlockSettingsSync", MicrosoftAccountBlockSettingsSync);
            writer.WriteEnumValue<SignInAssistantOptions>("microsoftAccountSignInAssistantSettings", MicrosoftAccountSignInAssistantSettings);
            writer.WriteBoolValue("networkProxyApplySettingsDeviceWide", NetworkProxyApplySettingsDeviceWide);
            writer.WriteStringValue("networkProxyAutomaticConfigurationUrl", NetworkProxyAutomaticConfigurationUrl);
            writer.WriteBoolValue("networkProxyDisableAutoDetect", NetworkProxyDisableAutoDetect);
            writer.WriteObjectValue<Windows10NetworkProxyServer>("networkProxyServer", NetworkProxyServer);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("oneDriveDisableFileSync", OneDriveDisableFileSync);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumAgeInDays", PasswordMinimumAgeInDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("passwordRequireWhenResumeFromIdleState", PasswordRequireWhenResumeFromIdleState);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteStringValue("personalizationDesktopImageUrl", PersonalizationDesktopImageUrl);
            writer.WriteStringValue("personalizationLockScreenImageUrl", PersonalizationLockScreenImageUrl);
            writer.WriteEnumValue<PowerActionType>("powerButtonActionOnBattery", PowerButtonActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerButtonActionPluggedIn", PowerButtonActionPluggedIn);
            writer.WriteEnumValue<Enablement>("powerHybridSleepOnBattery", PowerHybridSleepOnBattery);
            writer.WriteEnumValue<Enablement>("powerHybridSleepPluggedIn", PowerHybridSleepPluggedIn);
            writer.WriteEnumValue<PowerActionType>("powerLidCloseActionOnBattery", PowerLidCloseActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerLidCloseActionPluggedIn", PowerLidCloseActionPluggedIn);
            writer.WriteEnumValue<PowerActionType>("powerSleepButtonActionOnBattery", PowerSleepButtonActionOnBattery);
            writer.WriteEnumValue<PowerActionType>("powerSleepButtonActionPluggedIn", PowerSleepButtonActionPluggedIn);
            writer.WriteBoolValue("printerBlockAddition", PrinterBlockAddition);
            writer.WriteStringValue("printerDefaultName", PrinterDefaultName);
            writer.WriteCollectionOfPrimitiveValues<string>("printerNames", PrinterNames);
            writer.WriteCollectionOfObjectValues<WindowsPrivacyDataAccessControlItem>("privacyAccessControls", PrivacyAccessControls);
            writer.WriteEnumValue<StateManagementSetting>("privacyAdvertisingId", PrivacyAdvertisingId);
            writer.WriteBoolValue("privacyAutoAcceptPairingAndConsentPrompts", PrivacyAutoAcceptPairingAndConsentPrompts);
            writer.WriteBoolValue("privacyBlockActivityFeed", PrivacyBlockActivityFeed);
            writer.WriteBoolValue("privacyBlockInputPersonalization", PrivacyBlockInputPersonalization);
            writer.WriteBoolValue("privacyBlockPublishUserActivities", PrivacyBlockPublishUserActivities);
            writer.WriteBoolValue("privacyDisableLaunchExperience", PrivacyDisableLaunchExperience);
            writer.WriteBoolValue("resetProtectionModeBlocked", ResetProtectionModeBlocked);
            writer.WriteEnumValue<SafeSearchFilterType>("safeSearchFilter", SafeSearchFilter);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("searchBlockDiacritics", SearchBlockDiacritics);
            writer.WriteBoolValue("searchBlockWebResults", SearchBlockWebResults);
            writer.WriteBoolValue("searchDisableAutoLanguageDetection", SearchDisableAutoLanguageDetection);
            writer.WriteBoolValue("searchDisableIndexerBackoff", SearchDisableIndexerBackoff);
            writer.WriteBoolValue("searchDisableIndexingEncryptedItems", SearchDisableIndexingEncryptedItems);
            writer.WriteBoolValue("searchDisableIndexingRemovableDrive", SearchDisableIndexingRemovableDrive);
            writer.WriteBoolValue("searchDisableLocation", SearchDisableLocation);
            writer.WriteBoolValue("searchDisableUseLocation", SearchDisableUseLocation);
            writer.WriteBoolValue("searchEnableAutomaticIndexSizeManangement", SearchEnableAutomaticIndexSizeManangement);
            writer.WriteBoolValue("searchEnableRemoteQueries", SearchEnableRemoteQueries);
            writer.WriteBoolValue("securityBlockAzureADJoinedDevicesAutoEncryption", SecurityBlockAzureADJoinedDevicesAutoEncryption);
            writer.WriteBoolValue("settingsBlockAccountsPage", SettingsBlockAccountsPage);
            writer.WriteBoolValue("settingsBlockAddProvisioningPackage", SettingsBlockAddProvisioningPackage);
            writer.WriteBoolValue("settingsBlockAppsPage", SettingsBlockAppsPage);
            writer.WriteBoolValue("settingsBlockChangeLanguage", SettingsBlockChangeLanguage);
            writer.WriteBoolValue("settingsBlockChangePowerSleep", SettingsBlockChangePowerSleep);
            writer.WriteBoolValue("settingsBlockChangeRegion", SettingsBlockChangeRegion);
            writer.WriteBoolValue("settingsBlockChangeSystemTime", SettingsBlockChangeSystemTime);
            writer.WriteBoolValue("settingsBlockDevicesPage", SettingsBlockDevicesPage);
            writer.WriteBoolValue("settingsBlockEaseOfAccessPage", SettingsBlockEaseOfAccessPage);
            writer.WriteBoolValue("settingsBlockEditDeviceName", SettingsBlockEditDeviceName);
            writer.WriteBoolValue("settingsBlockGamingPage", SettingsBlockGamingPage);
            writer.WriteBoolValue("settingsBlockNetworkInternetPage", SettingsBlockNetworkInternetPage);
            writer.WriteBoolValue("settingsBlockPersonalizationPage", SettingsBlockPersonalizationPage);
            writer.WriteBoolValue("settingsBlockPrivacyPage", SettingsBlockPrivacyPage);
            writer.WriteBoolValue("settingsBlockRemoveProvisioningPackage", SettingsBlockRemoveProvisioningPackage);
            writer.WriteBoolValue("settingsBlockSettingsApp", SettingsBlockSettingsApp);
            writer.WriteBoolValue("settingsBlockSystemPage", SettingsBlockSystemPage);
            writer.WriteBoolValue("settingsBlockTimeLanguagePage", SettingsBlockTimeLanguagePage);
            writer.WriteBoolValue("settingsBlockUpdateSecurityPage", SettingsBlockUpdateSecurityPage);
            writer.WriteBoolValue("sharedUserAppDataAllowed", SharedUserAppDataAllowed);
            writer.WriteEnumValue<AppInstallControlType>("smartScreenAppInstallControl", SmartScreenAppInstallControl);
            writer.WriteBoolValue("smartScreenBlockPromptOverride", SmartScreenBlockPromptOverride);
            writer.WriteBoolValue("smartScreenBlockPromptOverrideForFiles", SmartScreenBlockPromptOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableAppInstallControl", SmartScreenEnableAppInstallControl);
            writer.WriteBoolValue("startBlockUnpinningAppsFromTaskbar", StartBlockUnpinningAppsFromTaskbar);
            writer.WriteEnumValue<WindowsStartMenuAppListVisibilityType>("startMenuAppListVisibility", StartMenuAppListVisibility);
            writer.WriteBoolValue("startMenuHideChangeAccountSettings", StartMenuHideChangeAccountSettings);
            writer.WriteBoolValue("startMenuHideFrequentlyUsedApps", StartMenuHideFrequentlyUsedApps);
            writer.WriteBoolValue("startMenuHideHibernate", StartMenuHideHibernate);
            writer.WriteBoolValue("startMenuHideLock", StartMenuHideLock);
            writer.WriteBoolValue("startMenuHidePowerButton", StartMenuHidePowerButton);
            writer.WriteBoolValue("startMenuHideRecentJumpLists", StartMenuHideRecentJumpLists);
            writer.WriteBoolValue("startMenuHideRecentlyAddedApps", StartMenuHideRecentlyAddedApps);
            writer.WriteBoolValue("startMenuHideRestartOptions", StartMenuHideRestartOptions);
            writer.WriteBoolValue("startMenuHideShutDown", StartMenuHideShutDown);
            writer.WriteBoolValue("startMenuHideSignOut", StartMenuHideSignOut);
            writer.WriteBoolValue("startMenuHideSleep", StartMenuHideSleep);
            writer.WriteBoolValue("startMenuHideSwitchAccount", StartMenuHideSwitchAccount);
            writer.WriteBoolValue("startMenuHideUserTile", StartMenuHideUserTile);
            writer.WriteByteArrayValue("startMenuLayoutEdgeAssetsXml", StartMenuLayoutEdgeAssetsXml);
            writer.WriteByteArrayValue("startMenuLayoutXml", StartMenuLayoutXml);
            writer.WriteEnumValue<WindowsStartMenuModeType>("startMenuMode", StartMenuMode);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderDocuments", StartMenuPinnedFolderDocuments);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderDownloads", StartMenuPinnedFolderDownloads);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderFileExplorer", StartMenuPinnedFolderFileExplorer);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderHomeGroup", StartMenuPinnedFolderHomeGroup);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderMusic", StartMenuPinnedFolderMusic);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderNetwork", StartMenuPinnedFolderNetwork);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderPersonalFolder", StartMenuPinnedFolderPersonalFolder);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderPictures", StartMenuPinnedFolderPictures);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderSettings", StartMenuPinnedFolderSettings);
            writer.WriteEnumValue<VisibilitySetting>("startMenuPinnedFolderVideos", StartMenuPinnedFolderVideos);
            writer.WriteBoolValue("storageBlockRemovableStorage", StorageBlockRemovableStorage);
            writer.WriteBoolValue("storageRequireMobileDeviceEncryption", StorageRequireMobileDeviceEncryption);
            writer.WriteBoolValue("storageRestrictAppDataToSystemVolume", StorageRestrictAppDataToSystemVolume);
            writer.WriteBoolValue("storageRestrictAppInstallToSystemVolume", StorageRestrictAppInstallToSystemVolume);
            writer.WriteStringValue("systemTelemetryProxyServer", SystemTelemetryProxyServer);
            writer.WriteBoolValue("taskManagerBlockEndTask", TaskManagerBlockEndTask);
            writer.WriteBoolValue("tenantLockdownRequireNetworkDuringOutOfBoxExperience", TenantLockdownRequireNetworkDuringOutOfBoxExperience);
            writer.WriteBoolValue("uninstallBuiltInApps", UninstallBuiltInApps);
            writer.WriteBoolValue("usbBlocked", UsbBlocked);
            writer.WriteBoolValue("voiceRecordingBlocked", VoiceRecordingBlocked);
            writer.WriteBoolValue("webRtcBlockLocalhostIpAddress", WebRtcBlockLocalhostIpAddress);
            writer.WriteBoolValue("wiFiBlockAutomaticConnectHotspots", WiFiBlockAutomaticConnectHotspots);
            writer.WriteBoolValue("wiFiBlocked", WiFiBlocked);
            writer.WriteBoolValue("wiFiBlockManualConfiguration", WiFiBlockManualConfiguration);
            writer.WriteIntValue("wiFiScanInterval", WiFiScanInterval);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Windows10AppsForceUpdateSchedule>("windows10AppsForceUpdateSchedule", Windows10AppsForceUpdateSchedule);
            writer.WriteBoolValue("windowsSpotlightBlockConsumerSpecificFeatures", WindowsSpotlightBlockConsumerSpecificFeatures);
            writer.WriteBoolValue("windowsSpotlightBlocked", WindowsSpotlightBlocked);
            writer.WriteBoolValue("windowsSpotlightBlockOnActionCenter", WindowsSpotlightBlockOnActionCenter);
            writer.WriteBoolValue("windowsSpotlightBlockTailoredExperiences", WindowsSpotlightBlockTailoredExperiences);
            writer.WriteBoolValue("windowsSpotlightBlockThirdPartyNotifications", WindowsSpotlightBlockThirdPartyNotifications);
            writer.WriteBoolValue("windowsSpotlightBlockWelcomeExperience", WindowsSpotlightBlockWelcomeExperience);
            writer.WriteBoolValue("windowsSpotlightBlockWindowsTips", WindowsSpotlightBlockWindowsTips);
            writer.WriteEnumValue<WindowsSpotlightEnablementSettings>("windowsSpotlightConfigureOnLockScreen", WindowsSpotlightConfigureOnLockScreen);
            writer.WriteBoolValue("windowsStoreBlockAutoUpdate", WindowsStoreBlockAutoUpdate);
            writer.WriteBoolValue("windowsStoreBlocked", WindowsStoreBlocked);
            writer.WriteBoolValue("windowsStoreEnablePrivateStoreOnly", WindowsStoreEnablePrivateStoreOnly);
            writer.WriteBoolValue("wirelessDisplayBlockProjectionToThisDevice", WirelessDisplayBlockProjectionToThisDevice);
            writer.WriteBoolValue("wirelessDisplayBlockUserInputFromReceiver", WirelessDisplayBlockUserInputFromReceiver);
            writer.WriteBoolValue("wirelessDisplayRequirePinForPairing", WirelessDisplayRequirePinForPairing);
        }
    }
}
