using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This topic provides descriptions of the declared methods, properties and relationships exposed by the Windows10EndpointProtectionConfiguration resource.
    /// </summary>
    public class Windows10EndpointProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Gets or sets whether applications inside Microsoft Defender Application Guard can access the device’s camera and microphone.</summary>
        public bool? ApplicationGuardAllowCameraMicrophoneRedirection {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowCameraMicrophoneRedirection"); }
            set { BackingStore?.Set("applicationGuardAllowCameraMicrophoneRedirection", value); }
        }
        /// <summary>Allow users to download files from Edge in the application guard container and save them on the host file system</summary>
        public bool? ApplicationGuardAllowFileSaveOnHost {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowFileSaveOnHost"); }
            set { BackingStore?.Set("applicationGuardAllowFileSaveOnHost", value); }
        }
        /// <summary>Allow persisting user generated data inside the App Guard Containter (favorites, cookies, web passwords, etc.)</summary>
        public bool? ApplicationGuardAllowPersistence {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowPersistence"); }
            set { BackingStore?.Set("applicationGuardAllowPersistence", value); }
        }
        /// <summary>Allow printing to Local Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToLocalPrinters {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowPrintToLocalPrinters"); }
            set { BackingStore?.Set("applicationGuardAllowPrintToLocalPrinters", value); }
        }
        /// <summary>Allow printing to Network Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToNetworkPrinters {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowPrintToNetworkPrinters"); }
            set { BackingStore?.Set("applicationGuardAllowPrintToNetworkPrinters", value); }
        }
        /// <summary>Allow printing to PDF from Container</summary>
        public bool? ApplicationGuardAllowPrintToPDF {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowPrintToPDF"); }
            set { BackingStore?.Set("applicationGuardAllowPrintToPDF", value); }
        }
        /// <summary>Allow printing to XPS from Container</summary>
        public bool? ApplicationGuardAllowPrintToXPS {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowPrintToXPS"); }
            set { BackingStore?.Set("applicationGuardAllowPrintToXPS", value); }
        }
        /// <summary>Allow application guard to use virtual GPU</summary>
        public bool? ApplicationGuardAllowVirtualGPU {
            get { return BackingStore?.Get<bool?>("applicationGuardAllowVirtualGPU"); }
            set { BackingStore?.Set("applicationGuardAllowVirtualGPU", value); }
        }
        /// <summary>Possible values for applicationGuardBlockClipboardSharingType</summary>
        public ApplicationGuardBlockClipboardSharingType? ApplicationGuardBlockClipboardSharing {
            get { return BackingStore?.Get<ApplicationGuardBlockClipboardSharingType?>("applicationGuardBlockClipboardSharing"); }
            set { BackingStore?.Set("applicationGuardBlockClipboardSharing", value); }
        }
        /// <summary>Possible values for applicationGuardBlockFileTransfer</summary>
        public ApplicationGuardBlockFileTransferType? ApplicationGuardBlockFileTransfer {
            get { return BackingStore?.Get<ApplicationGuardBlockFileTransferType?>("applicationGuardBlockFileTransfer"); }
            set { BackingStore?.Set("applicationGuardBlockFileTransfer", value); }
        }
        /// <summary>Block enterprise sites to load non-enterprise content, such as third party plug-ins</summary>
        public bool? ApplicationGuardBlockNonEnterpriseContent {
            get { return BackingStore?.Get<bool?>("applicationGuardBlockNonEnterpriseContent"); }
            set { BackingStore?.Set("applicationGuardBlockNonEnterpriseContent", value); }
        }
        /// <summary>Allows certain device level Root Certificates to be shared with the Microsoft Defender Application Guard container.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ApplicationGuardCertificateThumbprints {
            get { return BackingStore?.Get<List<string>?>("applicationGuardCertificateThumbprints"); }
            set { BackingStore?.Set("applicationGuardCertificateThumbprints", value); }
        }
#nullable restore
#else
        public List<string> ApplicationGuardCertificateThumbprints {
            get { return BackingStore?.Get<List<string>>("applicationGuardCertificateThumbprints"); }
            set { BackingStore?.Set("applicationGuardCertificateThumbprints", value); }
        }
#endif
        /// <summary>Enable Windows Defender Application Guard</summary>
        public bool? ApplicationGuardEnabled {
            get { return BackingStore?.Get<bool?>("applicationGuardEnabled"); }
            set { BackingStore?.Set("applicationGuardEnabled", value); }
        }
        /// <summary>Possible values for ApplicationGuardEnabledOptions</summary>
        public Microsoft.Graph.Beta.Models.ApplicationGuardEnabledOptions? ApplicationGuardEnabledOptions {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ApplicationGuardEnabledOptions?>("applicationGuardEnabledOptions"); }
            set { BackingStore?.Set("applicationGuardEnabledOptions", value); }
        }
        /// <summary>Force auditing will persist Windows logs and events to meet security/compliance criteria (sample events are user login-logoff, use of privilege rights, software installation, system changes, etc.)</summary>
        public bool? ApplicationGuardForceAuditing {
            get { return BackingStore?.Get<bool?>("applicationGuardForceAuditing"); }
            set { BackingStore?.Set("applicationGuardForceAuditing", value); }
        }
        /// <summary>Possible values of AppLocker Application Control Types</summary>
        public AppLockerApplicationControlType? AppLockerApplicationControl {
            get { return BackingStore?.Get<AppLockerApplicationControlType?>("appLockerApplicationControl"); }
            set { BackingStore?.Set("appLockerApplicationControl", value); }
        }
        /// <summary>Allows the admin to allow standard users to enable encrpytion during Azure AD Join.</summary>
        public bool? BitLockerAllowStandardUserEncryption {
            get { return BackingStore?.Get<bool?>("bitLockerAllowStandardUserEncryption"); }
            set { BackingStore?.Set("bitLockerAllowStandardUserEncryption", value); }
        }
        /// <summary>Allows the Admin to disable the warning prompt for other disk encryption on the user machines.</summary>
        public bool? BitLockerDisableWarningForOtherDiskEncryption {
            get { return BackingStore?.Get<bool?>("bitLockerDisableWarningForOtherDiskEncryption"); }
            set { BackingStore?.Set("bitLockerDisableWarningForOtherDiskEncryption", value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker. This policy is valid only for a mobile SKU.</summary>
        public bool? BitLockerEnableStorageCardEncryptionOnMobile {
            get { return BackingStore?.Get<bool?>("bitLockerEnableStorageCardEncryptionOnMobile"); }
            set { BackingStore?.Set("bitLockerEnableStorageCardEncryptionOnMobile", value); }
        }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker.</summary>
        public bool? BitLockerEncryptDevice {
            get { return BackingStore?.Get<bool?>("bitLockerEncryptDevice"); }
            set { BackingStore?.Set("bitLockerEncryptDevice", value); }
        }
        /// <summary>BitLocker Fixed Drive Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy? BitLockerFixedDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy?>("bitLockerFixedDrivePolicy"); }
            set { BackingStore?.Set("bitLockerFixedDrivePolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy BitLockerFixedDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>("bitLockerFixedDrivePolicy"); }
            set { BackingStore?.Set("bitLockerFixedDrivePolicy", value); }
        }
#endif
        /// <summary>BitLocker recovery password rotation type</summary>
        public BitLockerRecoveryPasswordRotationType? BitLockerRecoveryPasswordRotation {
            get { return BackingStore?.Get<BitLockerRecoveryPasswordRotationType?>("bitLockerRecoveryPasswordRotation"); }
            set { BackingStore?.Set("bitLockerRecoveryPasswordRotation", value); }
        }
        /// <summary>BitLocker Removable Drive Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy? BitLockerRemovableDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy?>("bitLockerRemovableDrivePolicy"); }
            set { BackingStore?.Set("bitLockerRemovableDrivePolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy BitLockerRemovableDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>("bitLockerRemovableDrivePolicy"); }
            set { BackingStore?.Set("bitLockerRemovableDrivePolicy", value); }
        }
#endif
        /// <summary>BitLocker System Drive Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy? BitLockerSystemDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy?>("bitLockerSystemDrivePolicy"); }
            set { BackingStore?.Set("bitLockerSystemDrivePolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy BitLockerSystemDrivePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>("bitLockerSystemDrivePolicy"); }
            set { BackingStore?.Set("bitLockerSystemDrivePolicy", value); }
        }
#endif
        /// <summary>List of folder paths to be added to the list of protected folders</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderAdditionalGuardedFolders {
            get { return BackingStore?.Get<List<string>?>("defenderAdditionalGuardedFolders"); }
            set { BackingStore?.Set("defenderAdditionalGuardedFolders", value); }
        }
#nullable restore
#else
        public List<string> DefenderAdditionalGuardedFolders {
            get { return BackingStore?.Get<List<string>>("defenderAdditionalGuardedFolders"); }
            set { BackingStore?.Set("defenderAdditionalGuardedFolders", value); }
        }
#endif
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderAdobeReaderLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderAdobeReaderLaunchChildProcess"); }
            set { BackingStore?.Set("defenderAdobeReaderLaunchChildProcess", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderAdvancedRansomewareProtectionType {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderAdvancedRansomewareProtectionType"); }
            set { BackingStore?.Set("defenderAdvancedRansomewareProtectionType", value); }
        }
        /// <summary>Allows or disallows Windows Defender Behavior Monitoring functionality.</summary>
        public bool? DefenderAllowBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>("defenderAllowBehaviorMonitoring"); }
            set { BackingStore?.Set("defenderAllowBehaviorMonitoring", value); }
        }
        /// <summary>To best protect your PC, Windows Defender will send information to Microsoft about any problems it finds. Microsoft will analyze that information, learn more about problems affecting you and other customers, and offer improved solutions.</summary>
        public bool? DefenderAllowCloudProtection {
            get { return BackingStore?.Get<bool?>("defenderAllowCloudProtection"); }
            set { BackingStore?.Set("defenderAllowCloudProtection", value); }
        }
        /// <summary>Allows or disallows user access to the Windows Defender UI. If disallowed, all Windows Defender notifications will also be suppressed.</summary>
        public bool? DefenderAllowEndUserAccess {
            get { return BackingStore?.Get<bool?>("defenderAllowEndUserAccess"); }
            set { BackingStore?.Set("defenderAllowEndUserAccess", value); }
        }
        /// <summary>Allows or disallows Windows Defender Intrusion Prevention functionality.</summary>
        public bool? DefenderAllowIntrusionPreventionSystem {
            get { return BackingStore?.Get<bool?>("defenderAllowIntrusionPreventionSystem"); }
            set { BackingStore?.Set("defenderAllowIntrusionPreventionSystem", value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderAllowOnAccessProtection {
            get { return BackingStore?.Get<bool?>("defenderAllowOnAccessProtection"); }
            set { BackingStore?.Set("defenderAllowOnAccessProtection", value); }
        }
        /// <summary>Allows or disallows Windows Defender Realtime Monitoring functionality.</summary>
        public bool? DefenderAllowRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>("defenderAllowRealTimeMonitoring"); }
            set { BackingStore?.Set("defenderAllowRealTimeMonitoring", value); }
        }
        /// <summary>Allows or disallows scanning of archives.</summary>
        public bool? DefenderAllowScanArchiveFiles {
            get { return BackingStore?.Get<bool?>("defenderAllowScanArchiveFiles"); }
            set { BackingStore?.Set("defenderAllowScanArchiveFiles", value); }
        }
        /// <summary>Allows or disallows Windows Defender IOAVP Protection functionality.</summary>
        public bool? DefenderAllowScanDownloads {
            get { return BackingStore?.Get<bool?>("defenderAllowScanDownloads"); }
            set { BackingStore?.Set("defenderAllowScanDownloads", value); }
        }
        /// <summary>Allows or disallows a scanning of network files.</summary>
        public bool? DefenderAllowScanNetworkFiles {
            get { return BackingStore?.Get<bool?>("defenderAllowScanNetworkFiles"); }
            set { BackingStore?.Set("defenderAllowScanNetworkFiles", value); }
        }
        /// <summary>Allows or disallows a full scan of removable drives. During a quick scan, removable drives may still be scanned.</summary>
        public bool? DefenderAllowScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>("defenderAllowScanRemovableDrivesDuringFullScan"); }
            set { BackingStore?.Set("defenderAllowScanRemovableDrivesDuringFullScan", value); }
        }
        /// <summary>Allows or disallows Windows Defender Script Scanning functionality.</summary>
        public bool? DefenderAllowScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>("defenderAllowScanScriptsLoadedInInternetExplorer"); }
            set { BackingStore?.Set("defenderAllowScanScriptsLoadedInInternetExplorer", value); }
        }
        /// <summary>List of exe files and folders to be excluded from attack surface reduction rules</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderAttackSurfaceReductionExcludedPaths {
            get { return BackingStore?.Get<List<string>?>("defenderAttackSurfaceReductionExcludedPaths"); }
            set { BackingStore?.Set("defenderAttackSurfaceReductionExcludedPaths", value); }
        }
#nullable restore
#else
        public List<string> DefenderAttackSurfaceReductionExcludedPaths {
            get { return BackingStore?.Get<List<string>>("defenderAttackSurfaceReductionExcludedPaths"); }
            set { BackingStore?.Set("defenderAttackSurfaceReductionExcludedPaths", value); }
        }
#endif
        /// <summary>Allows or disallows user access to the Windows Defender UI. If disallowed, all Windows Defender notifications will also be suppressed.</summary>
        public bool? DefenderBlockEndUserAccess {
            get { return BackingStore?.Get<bool?>("defenderBlockEndUserAccess"); }
            set { BackingStore?.Set("defenderBlockEndUserAccess", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderBlockPersistenceThroughWmiType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderBlockPersistenceThroughWmiType"); }
            set { BackingStore?.Set("defenderBlockPersistenceThroughWmiType", value); }
        }
        /// <summary>This policy setting allows you to manage whether a check for new virus and spyware definitions will occur before running a scan.</summary>
        public bool? DefenderCheckForSignaturesBeforeRunningScan {
            get { return BackingStore?.Get<bool?>("defenderCheckForSignaturesBeforeRunningScan"); }
            set { BackingStore?.Set("defenderCheckForSignaturesBeforeRunningScan", value); }
        }
        /// <summary>Added in Windows 10, version 1709. This policy setting determines how aggressive Windows Defender Antivirus will be in blocking and scanning suspicious files. Value type is integer. This feature requires the &apos;Join Microsoft MAPS&apos; setting enabled in order to function. Possible values are: notConfigured, high, highPlus, zeroTolerance.</summary>
        public DefenderCloudBlockLevelType? DefenderCloudBlockLevel {
            get { return BackingStore?.Get<DefenderCloudBlockLevelType?>("defenderCloudBlockLevel"); }
            set { BackingStore?.Set("defenderCloudBlockLevel", value); }
        }
        /// <summary>Added in Windows 10, version 1709. This feature allows Windows Defender Antivirus to block a suspicious file for up to 60 seconds, and scan it in the cloud to make sure it&apos;s safe. Value type is integer, range is 0 - 50. This feature depends on three other MAPS settings the must all be enabled- &apos;Configure the &apos;Block at First Sight&apos; feature; &apos;Join Microsoft MAPS&apos;; &apos;Send file samples when further analysis is required&apos;. Valid values 0 to 50</summary>
        public int? DefenderCloudExtendedTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("defenderCloudExtendedTimeoutInSeconds"); }
            set { BackingStore?.Set("defenderCloudExtendedTimeoutInSeconds", value); }
        }
        /// <summary>Time period (in days) that quarantine items will be stored on the system. Valid values 0 to 90</summary>
        public int? DefenderDaysBeforeDeletingQuarantinedMalware {
            get { return BackingStore?.Get<int?>("defenderDaysBeforeDeletingQuarantinedMalware"); }
            set { BackingStore?.Set("defenderDaysBeforeDeletingQuarantinedMalware", value); }
        }
        /// <summary>Allows an administrator to specify any valid threat severity levels and the corresponding default action ID to take.</summary>
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
        /// <summary>Allows or disallows Windows Defender Behavior Monitoring functionality.</summary>
        public bool? DefenderDisableBehaviorMonitoring {
            get { return BackingStore?.Get<bool?>("defenderDisableBehaviorMonitoring"); }
            set { BackingStore?.Set("defenderDisableBehaviorMonitoring", value); }
        }
        /// <summary>This policy setting allows you to configure catch-up scans for scheduled full scans. A catch-up scan is a scan that is initiated because a regularly scheduled scan was missed. Usually these scheduled scans are missed because the computer was turned off at the scheduled time.</summary>
        public bool? DefenderDisableCatchupFullScan {
            get { return BackingStore?.Get<bool?>("defenderDisableCatchupFullScan"); }
            set { BackingStore?.Set("defenderDisableCatchupFullScan", value); }
        }
        /// <summary>This policy setting allows you to configure catch-up scans for scheduled quick scans. A catch-up scan is a scan that is initiated because a regularly scheduled scan was missed. Usually these scheduled scans are missed because the computer was turned off at the scheduled time.</summary>
        public bool? DefenderDisableCatchupQuickScan {
            get { return BackingStore?.Get<bool?>("defenderDisableCatchupQuickScan"); }
            set { BackingStore?.Set("defenderDisableCatchupQuickScan", value); }
        }
        /// <summary>To best protect your PC, Windows Defender will send information to Microsoft about any problems it finds. Microsoft will analyze that information, learn more about problems affecting you and other customers, and offer improved solutions.</summary>
        public bool? DefenderDisableCloudProtection {
            get { return BackingStore?.Get<bool?>("defenderDisableCloudProtection"); }
            set { BackingStore?.Set("defenderDisableCloudProtection", value); }
        }
        /// <summary>Allows or disallows Windows Defender Intrusion Prevention functionality.</summary>
        public bool? DefenderDisableIntrusionPreventionSystem {
            get { return BackingStore?.Get<bool?>("defenderDisableIntrusionPreventionSystem"); }
            set { BackingStore?.Set("defenderDisableIntrusionPreventionSystem", value); }
        }
        /// <summary>Allows or disallows Windows Defender On Access Protection functionality.</summary>
        public bool? DefenderDisableOnAccessProtection {
            get { return BackingStore?.Get<bool?>("defenderDisableOnAccessProtection"); }
            set { BackingStore?.Set("defenderDisableOnAccessProtection", value); }
        }
        /// <summary>Allows or disallows Windows Defender Realtime Monitoring functionality.</summary>
        public bool? DefenderDisableRealTimeMonitoring {
            get { return BackingStore?.Get<bool?>("defenderDisableRealTimeMonitoring"); }
            set { BackingStore?.Set("defenderDisableRealTimeMonitoring", value); }
        }
        /// <summary>Allows or disallows scanning of archives.</summary>
        public bool? DefenderDisableScanArchiveFiles {
            get { return BackingStore?.Get<bool?>("defenderDisableScanArchiveFiles"); }
            set { BackingStore?.Set("defenderDisableScanArchiveFiles", value); }
        }
        /// <summary>Allows or disallows Windows Defender IOAVP Protection functionality.</summary>
        public bool? DefenderDisableScanDownloads {
            get { return BackingStore?.Get<bool?>("defenderDisableScanDownloads"); }
            set { BackingStore?.Set("defenderDisableScanDownloads", value); }
        }
        /// <summary>Allows or disallows a scanning of network files.</summary>
        public bool? DefenderDisableScanNetworkFiles {
            get { return BackingStore?.Get<bool?>("defenderDisableScanNetworkFiles"); }
            set { BackingStore?.Set("defenderDisableScanNetworkFiles", value); }
        }
        /// <summary>Allows or disallows a full scan of removable drives. During a quick scan, removable drives may still be scanned.</summary>
        public bool? DefenderDisableScanRemovableDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>("defenderDisableScanRemovableDrivesDuringFullScan"); }
            set { BackingStore?.Set("defenderDisableScanRemovableDrivesDuringFullScan", value); }
        }
        /// <summary>Allows or disallows Windows Defender Script Scanning functionality.</summary>
        public bool? DefenderDisableScanScriptsLoadedInInternetExplorer {
            get { return BackingStore?.Get<bool?>("defenderDisableScanScriptsLoadedInInternetExplorer"); }
            set { BackingStore?.Set("defenderDisableScanScriptsLoadedInInternetExplorer", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderEmailContentExecution {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderEmailContentExecution"); }
            set { BackingStore?.Set("defenderEmailContentExecution", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderEmailContentExecutionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderEmailContentExecutionType"); }
            set { BackingStore?.Set("defenderEmailContentExecutionType", value); }
        }
        /// <summary>This policy setting allows you to enable or disable low CPU priority for scheduled scans.</summary>
        public bool? DefenderEnableLowCpuPriority {
            get { return BackingStore?.Get<bool?>("defenderEnableLowCpuPriority"); }
            set { BackingStore?.Set("defenderEnableLowCpuPriority", value); }
        }
        /// <summary>Allows or disallows scanning of email.</summary>
        public bool? DefenderEnableScanIncomingMail {
            get { return BackingStore?.Get<bool?>("defenderEnableScanIncomingMail"); }
            set { BackingStore?.Set("defenderEnableScanIncomingMail", value); }
        }
        /// <summary>Allows or disallows a full scan of mapped network drives.</summary>
        public bool? DefenderEnableScanMappedNetworkDrivesDuringFullScan {
            get { return BackingStore?.Get<bool?>("defenderEnableScanMappedNetworkDrivesDuringFullScan"); }
            set { BackingStore?.Set("defenderEnableScanMappedNetworkDrivesDuringFullScan", value); }
        }
        /// <summary>Xml content containing information regarding exploit protection details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? DefenderExploitProtectionXml {
            get { return BackingStore?.Get<byte[]?>("defenderExploitProtectionXml"); }
            set { BackingStore?.Set("defenderExploitProtectionXml", value); }
        }
#nullable restore
#else
        public byte[] DefenderExploitProtectionXml {
            get { return BackingStore?.Get<byte[]>("defenderExploitProtectionXml"); }
            set { BackingStore?.Set("defenderExploitProtectionXml", value); }
        }
#endif
        /// <summary>Name of the file from which DefenderExploitProtectionXml was obtained.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderExploitProtectionXmlFileName {
            get { return BackingStore?.Get<string?>("defenderExploitProtectionXmlFileName"); }
            set { BackingStore?.Set("defenderExploitProtectionXmlFileName", value); }
        }
#nullable restore
#else
        public string DefenderExploitProtectionXmlFileName {
            get { return BackingStore?.Get<string>("defenderExploitProtectionXmlFileName"); }
            set { BackingStore?.Set("defenderExploitProtectionXmlFileName", value); }
        }
#endif
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
        /// <summary>List of paths to exe that are allowed to access protected folders</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderGuardedFoldersAllowedAppPaths {
            get { return BackingStore?.Get<List<string>?>("defenderGuardedFoldersAllowedAppPaths"); }
            set { BackingStore?.Set("defenderGuardedFoldersAllowedAppPaths", value); }
        }
#nullable restore
#else
        public List<string> DefenderGuardedFoldersAllowedAppPaths {
            get { return BackingStore?.Get<List<string>>("defenderGuardedFoldersAllowedAppPaths"); }
            set { BackingStore?.Set("defenderGuardedFoldersAllowedAppPaths", value); }
        }
#endif
        /// <summary>Possible values of Folder Protection</summary>
        public FolderProtectionType? DefenderGuardMyFoldersType {
            get { return BackingStore?.Get<FolderProtectionType?>("defenderGuardMyFoldersType"); }
            set { BackingStore?.Set("defenderGuardMyFoldersType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderNetworkProtectionType {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderNetworkProtectionType"); }
            set { BackingStore?.Set("defenderNetworkProtectionType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderOfficeAppsExecutableContentCreationOrLaunch {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderOfficeAppsExecutableContentCreationOrLaunch"); }
            set { BackingStore?.Set("defenderOfficeAppsExecutableContentCreationOrLaunch", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsExecutableContentCreationOrLaunchType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderOfficeAppsExecutableContentCreationOrLaunchType"); }
            set { BackingStore?.Set("defenderOfficeAppsExecutableContentCreationOrLaunchType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderOfficeAppsLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderOfficeAppsLaunchChildProcess"); }
            set { BackingStore?.Set("defenderOfficeAppsLaunchChildProcess", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsLaunchChildProcessType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderOfficeAppsLaunchChildProcessType"); }
            set { BackingStore?.Set("defenderOfficeAppsLaunchChildProcessType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderOfficeAppsOtherProcessInjection {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderOfficeAppsOtherProcessInjection"); }
            set { BackingStore?.Set("defenderOfficeAppsOtherProcessInjection", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderOfficeAppsOtherProcessInjectionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderOfficeAppsOtherProcessInjectionType"); }
            set { BackingStore?.Set("defenderOfficeAppsOtherProcessInjectionType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderOfficeCommunicationAppsLaunchChildProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderOfficeCommunicationAppsLaunchChildProcess"); }
            set { BackingStore?.Set("defenderOfficeCommunicationAppsLaunchChildProcess", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderOfficeMacroCodeAllowWin32Imports {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderOfficeMacroCodeAllowWin32Imports"); }
            set { BackingStore?.Set("defenderOfficeMacroCodeAllowWin32Imports", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderOfficeMacroCodeAllowWin32ImportsType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderOfficeMacroCodeAllowWin32ImportsType"); }
            set { BackingStore?.Set("defenderOfficeMacroCodeAllowWin32ImportsType", value); }
        }
        /// <summary>Added in Windows 10, version 1607. Specifies the level of detection for potentially unwanted applications (PUAs). Windows Defender alerts you when potentially unwanted software is being downloaded or attempts to install itself on your computer. Possible values are: userDefined, enable, auditMode, warn, notConfigured.</summary>
        public DefenderProtectionType? DefenderPotentiallyUnwantedAppAction {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderPotentiallyUnwantedAppAction"); }
            set { BackingStore?.Set("defenderPotentiallyUnwantedAppAction", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderPreventCredentialStealingType {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderPreventCredentialStealingType"); }
            set { BackingStore?.Set("defenderPreventCredentialStealingType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderProcessCreation {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderProcessCreation"); }
            set { BackingStore?.Set("defenderProcessCreation", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderProcessCreationType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderProcessCreationType"); }
            set { BackingStore?.Set("defenderProcessCreationType", value); }
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
        /// <summary>Controls which sets of files should be monitored. Possible values are: monitorAllFiles, monitorIncomingFilesOnly, monitorOutgoingFilesOnly.</summary>
        public DefenderRealtimeScanDirection? DefenderScanDirection {
            get { return BackingStore?.Get<DefenderRealtimeScanDirection?>("defenderScanDirection"); }
            set { BackingStore?.Set("defenderScanDirection", value); }
        }
        /// <summary>Represents the average CPU load factor for the Windows Defender scan (in percent). The default value is 50. Valid values 0 to 100</summary>
        public int? DefenderScanMaxCpuPercentage {
            get { return BackingStore?.Get<int?>("defenderScanMaxCpuPercentage"); }
            set { BackingStore?.Set("defenderScanMaxCpuPercentage", value); }
        }
        /// <summary>Selects whether to perform a quick scan or full scan. Possible values are: userDefined, disabled, quick, full.</summary>
        public Microsoft.Graph.Beta.Models.DefenderScanType? DefenderScanType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderScanType?>("defenderScanType"); }
            set { BackingStore?.Set("defenderScanType", value); }
        }
        /// <summary>Selects the time of day that the Windows Defender quick scan should run. For example, a value of 0=12:00AM, a value of 60=1:00AM, a value of 120=2:00, and so on, up to a value of 1380=11:00PM. The default value is 120</summary>
        public Time? DefenderScheduledQuickScanTime {
            get { return BackingStore?.Get<Time?>("defenderScheduledQuickScanTime"); }
            set { BackingStore?.Set("defenderScheduledQuickScanTime", value); }
        }
        /// <summary>Selects the day that the Windows Defender scan should run. Possible values are: userDefined, everyday, sunday, monday, tuesday, wednesday, thursday, friday, saturday, noScheduledScan.</summary>
        public WeeklySchedule? DefenderScheduledScanDay {
            get { return BackingStore?.Get<WeeklySchedule?>("defenderScheduledScanDay"); }
            set { BackingStore?.Set("defenderScheduledScanDay", value); }
        }
        /// <summary>Selects the time of day that the Windows Defender scan should run.</summary>
        public Time? DefenderScheduledScanTime {
            get { return BackingStore?.Get<Time?>("defenderScheduledScanTime"); }
            set { BackingStore?.Set("defenderScheduledScanTime", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderScriptDownloadedPayloadExecution {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderScriptDownloadedPayloadExecution"); }
            set { BackingStore?.Set("defenderScriptDownloadedPayloadExecution", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderScriptDownloadedPayloadExecutionType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderScriptDownloadedPayloadExecutionType"); }
            set { BackingStore?.Set("defenderScriptDownloadedPayloadExecutionType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderScriptObfuscatedMacroCode {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderScriptObfuscatedMacroCode"); }
            set { BackingStore?.Set("defenderScriptObfuscatedMacroCode", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderScriptObfuscatedMacroCodeType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderScriptObfuscatedMacroCodeType"); }
            set { BackingStore?.Set("defenderScriptObfuscatedMacroCodeType", value); }
        }
        /// <summary>Indicates whether or not to block user from overriding Exploit Protection settings.</summary>
        public bool? DefenderSecurityCenterBlockExploitProtectionOverride {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterBlockExploitProtectionOverride"); }
            set { BackingStore?.Set("defenderSecurityCenterBlockExploitProtectionOverride", value); }
        }
        /// <summary>Used to disable the display of the account protection area.</summary>
        public bool? DefenderSecurityCenterDisableAccountUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableAccountUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableAccountUI", value); }
        }
        /// <summary>Used to disable the display of the app and browser protection area.</summary>
        public bool? DefenderSecurityCenterDisableAppBrowserUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableAppBrowserUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableAppBrowserUI", value); }
        }
        /// <summary>Used to disable the display of the Clear TPM button.</summary>
        public bool? DefenderSecurityCenterDisableClearTpmUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableClearTpmUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableClearTpmUI", value); }
        }
        /// <summary>Used to disable the display of the family options area.</summary>
        public bool? DefenderSecurityCenterDisableFamilyUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableFamilyUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableFamilyUI", value); }
        }
        /// <summary>Used to disable the display of the hardware protection area.</summary>
        public bool? DefenderSecurityCenterDisableHardwareUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableHardwareUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableHardwareUI", value); }
        }
        /// <summary>Used to disable the display of the device performance and health area.</summary>
        public bool? DefenderSecurityCenterDisableHealthUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableHealthUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableHealthUI", value); }
        }
        /// <summary>Used to disable the display of the firewall and network protection area.</summary>
        public bool? DefenderSecurityCenterDisableNetworkUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableNetworkUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableNetworkUI", value); }
        }
        /// <summary>Used to disable the display of the notification area control. The user needs to either sign out and sign in or reboot the computer for this setting to take effect.</summary>
        public bool? DefenderSecurityCenterDisableNotificationAreaUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableNotificationAreaUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableNotificationAreaUI", value); }
        }
        /// <summary>Used to disable the display of the ransomware protection area.</summary>
        public bool? DefenderSecurityCenterDisableRansomwareUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableRansomwareUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableRansomwareUI", value); }
        }
        /// <summary>Used to disable the display of the secure boot area under Device security.</summary>
        public bool? DefenderSecurityCenterDisableSecureBootUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableSecureBootUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableSecureBootUI", value); }
        }
        /// <summary>Used to disable the display of the security process troubleshooting under Device security.</summary>
        public bool? DefenderSecurityCenterDisableTroubleshootingUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableTroubleshootingUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableTroubleshootingUI", value); }
        }
        /// <summary>Used to disable the display of the virus and threat protection area.</summary>
        public bool? DefenderSecurityCenterDisableVirusUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableVirusUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableVirusUI", value); }
        }
        /// <summary>Used to disable the display of update TPM Firmware when a vulnerable firmware is detected.</summary>
        public bool? DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI {
            get { return BackingStore?.Get<bool?>("defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI"); }
            set { BackingStore?.Set("defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI", value); }
        }
        /// <summary>The email address that is displayed to users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderSecurityCenterHelpEmail {
            get { return BackingStore?.Get<string?>("defenderSecurityCenterHelpEmail"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpEmail", value); }
        }
#nullable restore
#else
        public string DefenderSecurityCenterHelpEmail {
            get { return BackingStore?.Get<string>("defenderSecurityCenterHelpEmail"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpEmail", value); }
        }
#endif
        /// <summary>The phone number or Skype ID that is displayed to users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderSecurityCenterHelpPhone {
            get { return BackingStore?.Get<string?>("defenderSecurityCenterHelpPhone"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpPhone", value); }
        }
#nullable restore
#else
        public string DefenderSecurityCenterHelpPhone {
            get { return BackingStore?.Get<string>("defenderSecurityCenterHelpPhone"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpPhone", value); }
        }
#endif
        /// <summary>The help portal URL this is displayed to users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderSecurityCenterHelpURL {
            get { return BackingStore?.Get<string?>("defenderSecurityCenterHelpURL"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpURL", value); }
        }
#nullable restore
#else
        public string DefenderSecurityCenterHelpURL {
            get { return BackingStore?.Get<string>("defenderSecurityCenterHelpURL"); }
            set { BackingStore?.Set("defenderSecurityCenterHelpURL", value); }
        }
#endif
        /// <summary>Possible values for defenderSecurityCenterITContactDisplay</summary>
        public DefenderSecurityCenterITContactDisplayType? DefenderSecurityCenterITContactDisplay {
            get { return BackingStore?.Get<DefenderSecurityCenterITContactDisplayType?>("defenderSecurityCenterITContactDisplay"); }
            set { BackingStore?.Set("defenderSecurityCenterITContactDisplay", value); }
        }
        /// <summary>Possible values for defenderSecurityCenterNotificationsFromApp</summary>
        public DefenderSecurityCenterNotificationsFromAppType? DefenderSecurityCenterNotificationsFromApp {
            get { return BackingStore?.Get<DefenderSecurityCenterNotificationsFromAppType?>("defenderSecurityCenterNotificationsFromApp"); }
            set { BackingStore?.Set("defenderSecurityCenterNotificationsFromApp", value); }
        }
        /// <summary>The company name that is displayed to the users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderSecurityCenterOrganizationDisplayName {
            get { return BackingStore?.Get<string?>("defenderSecurityCenterOrganizationDisplayName"); }
            set { BackingStore?.Set("defenderSecurityCenterOrganizationDisplayName", value); }
        }
#nullable restore
#else
        public string DefenderSecurityCenterOrganizationDisplayName {
            get { return BackingStore?.Get<string>("defenderSecurityCenterOrganizationDisplayName"); }
            set { BackingStore?.Set("defenderSecurityCenterOrganizationDisplayName", value); }
        }
#endif
        /// <summary>Specifies the interval (in hours) that will be used to check for signatures, so instead of using the ScheduleDay and ScheduleTime the check for new signatures will be set according to the interval. Valid values 0 to 24</summary>
        public int? DefenderSignatureUpdateIntervalInHours {
            get { return BackingStore?.Get<int?>("defenderSignatureUpdateIntervalInHours"); }
            set { BackingStore?.Set("defenderSignatureUpdateIntervalInHours", value); }
        }
        /// <summary>Checks for the user consent level in Windows Defender to send data. Possible values are: sendSafeSamplesAutomatically, alwaysPrompt, neverSend, sendAllSamplesAutomatically.</summary>
        public Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType? DefenderSubmitSamplesConsentType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefenderSubmitSamplesConsentType?>("defenderSubmitSamplesConsentType"); }
            set { BackingStore?.Set("defenderSubmitSamplesConsentType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderUntrustedExecutable {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderUntrustedExecutable"); }
            set { BackingStore?.Set("defenderUntrustedExecutable", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderUntrustedExecutableType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderUntrustedExecutableType"); }
            set { BackingStore?.Set("defenderUntrustedExecutableType", value); }
        }
        /// <summary>Possible values of Defender PUA Protection</summary>
        public DefenderProtectionType? DefenderUntrustedUSBProcess {
            get { return BackingStore?.Get<DefenderProtectionType?>("defenderUntrustedUSBProcess"); }
            set { BackingStore?.Set("defenderUntrustedUSBProcess", value); }
        }
        /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
        public DefenderAttackSurfaceType? DefenderUntrustedUSBProcessType {
            get { return BackingStore?.Get<DefenderAttackSurfaceType?>("defenderUntrustedUSBProcessType"); }
            set { BackingStore?.Set("defenderUntrustedUSBProcessType", value); }
        }
        /// <summary>This property will be deprecated in May 2019 and will be replaced with property DeviceGuardSecureBootWithDMA. Specifies whether Platform Security Level is enabled at next reboot.</summary>
        public bool? DeviceGuardEnableSecureBootWithDMA {
            get { return BackingStore?.Get<bool?>("deviceGuardEnableSecureBootWithDMA"); }
            set { BackingStore?.Set("deviceGuardEnableSecureBootWithDMA", value); }
        }
        /// <summary>Turns On Virtualization Based Security(VBS).</summary>
        public bool? DeviceGuardEnableVirtualizationBasedSecurity {
            get { return BackingStore?.Get<bool?>("deviceGuardEnableVirtualizationBasedSecurity"); }
            set { BackingStore?.Set("deviceGuardEnableVirtualizationBasedSecurity", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? DeviceGuardLaunchSystemGuard {
            get { return BackingStore?.Get<Enablement?>("deviceGuardLaunchSystemGuard"); }
            set { BackingStore?.Set("deviceGuardLaunchSystemGuard", value); }
        }
        /// <summary>Possible values of Credential Guard settings.</summary>
        public DeviceGuardLocalSystemAuthorityCredentialGuardType? DeviceGuardLocalSystemAuthorityCredentialGuardSettings {
            get { return BackingStore?.Get<DeviceGuardLocalSystemAuthorityCredentialGuardType?>("deviceGuardLocalSystemAuthorityCredentialGuardSettings"); }
            set { BackingStore?.Set("deviceGuardLocalSystemAuthorityCredentialGuardSettings", value); }
        }
        /// <summary>Possible values of Secure Boot with DMA</summary>
        public SecureBootWithDMAType? DeviceGuardSecureBootWithDMA {
            get { return BackingStore?.Get<SecureBootWithDMAType?>("deviceGuardSecureBootWithDMA"); }
            set { BackingStore?.Set("deviceGuardSecureBootWithDMA", value); }
        }
        /// <summary>Possible values of the DmaGuardDeviceEnumerationPolicy.</summary>
        public DmaGuardDeviceEnumerationPolicyType? DmaGuardDeviceEnumerationPolicy {
            get { return BackingStore?.Get<DmaGuardDeviceEnumerationPolicyType?>("dmaGuardDeviceEnumerationPolicy"); }
            set { BackingStore?.Set("dmaGuardDeviceEnumerationPolicy", value); }
        }
        /// <summary>Blocks stateful FTP connections to the device</summary>
        public bool? FirewallBlockStatefulFTP {
            get { return BackingStore?.Get<bool?>("firewallBlockStatefulFTP"); }
            set { BackingStore?.Set("firewallBlockStatefulFTP", value); }
        }
        /// <summary>Possible values for firewallCertificateRevocationListCheckMethod</summary>
        public FirewallCertificateRevocationListCheckMethodType? FirewallCertificateRevocationListCheckMethod {
            get { return BackingStore?.Get<FirewallCertificateRevocationListCheckMethodType?>("firewallCertificateRevocationListCheckMethod"); }
            set { BackingStore?.Set("firewallCertificateRevocationListCheckMethod", value); }
        }
        /// <summary>Configures the idle timeout for security associations, in seconds, from 300 to 3600 inclusive. This is the period after which security associations will expire and be deleted. Valid values 300 to 3600</summary>
        public int? FirewallIdleTimeoutForSecurityAssociationInSeconds {
            get { return BackingStore?.Get<int?>("firewallIdleTimeoutForSecurityAssociationInSeconds"); }
            set { BackingStore?.Set("firewallIdleTimeoutForSecurityAssociationInSeconds", value); }
        }
        /// <summary>Configures IPSec exemptions to allow both IPv4 and IPv6 DHCP traffic</summary>
        public bool? FirewallIPSecExemptionsAllowDHCP {
            get { return BackingStore?.Get<bool?>("firewallIPSecExemptionsAllowDHCP"); }
            set { BackingStore?.Set("firewallIPSecExemptionsAllowDHCP", value); }
        }
        /// <summary>Configures IPSec exemptions to allow ICMP</summary>
        public bool? FirewallIPSecExemptionsAllowICMP {
            get { return BackingStore?.Get<bool?>("firewallIPSecExemptionsAllowICMP"); }
            set { BackingStore?.Set("firewallIPSecExemptionsAllowICMP", value); }
        }
        /// <summary>Configures IPSec exemptions to allow neighbor discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowNeighborDiscovery {
            get { return BackingStore?.Get<bool?>("firewallIPSecExemptionsAllowNeighborDiscovery"); }
            set { BackingStore?.Set("firewallIPSecExemptionsAllowNeighborDiscovery", value); }
        }
        /// <summary>Configures IPSec exemptions to allow router discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowRouterDiscovery {
            get { return BackingStore?.Get<bool?>("firewallIPSecExemptionsAllowRouterDiscovery"); }
            set { BackingStore?.Set("firewallIPSecExemptionsAllowRouterDiscovery", value); }
        }
        /// <summary>Configures IPSec exemptions to no exemptions</summary>
        public bool? FirewallIPSecExemptionsNone {
            get { return BackingStore?.Get<bool?>("firewallIPSecExemptionsNone"); }
            set { BackingStore?.Set("firewallIPSecExemptionsNone", value); }
        }
        /// <summary>If an authentication set is not fully supported by a keying module, direct the module to ignore only unsupported authentication suites rather than the entire set</summary>
        public bool? FirewallMergeKeyingModuleSettings {
            get { return BackingStore?.Get<bool?>("firewallMergeKeyingModuleSettings"); }
            set { BackingStore?.Set("firewallMergeKeyingModuleSettings", value); }
        }
        /// <summary>Possible values for firewallPacketQueueingMethod</summary>
        public FirewallPacketQueueingMethodType? FirewallPacketQueueingMethod {
            get { return BackingStore?.Get<FirewallPacketQueueingMethodType?>("firewallPacketQueueingMethod"); }
            set { BackingStore?.Set("firewallPacketQueueingMethod", value); }
        }
        /// <summary>Possible values for firewallPreSharedKeyEncodingMethod</summary>
        public FirewallPreSharedKeyEncodingMethodType? FirewallPreSharedKeyEncodingMethod {
            get { return BackingStore?.Get<FirewallPreSharedKeyEncodingMethodType?>("firewallPreSharedKeyEncodingMethod"); }
            set { BackingStore?.Set("firewallPreSharedKeyEncodingMethod", value); }
        }
        /// <summary>Configures the firewall profile settings for domain networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfileDomain {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile?>("firewallProfileDomain"); }
            set { BackingStore?.Set("firewallProfileDomain", value); }
        }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfileDomain {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>("firewallProfileDomain"); }
            set { BackingStore?.Set("firewallProfileDomain", value); }
        }
#endif
        /// <summary>Configures the firewall profile settings for private networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfilePrivate {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile?>("firewallProfilePrivate"); }
            set { BackingStore?.Set("firewallProfilePrivate", value); }
        }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfilePrivate {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>("firewallProfilePrivate"); }
            set { BackingStore?.Set("firewallProfilePrivate", value); }
        }
#endif
        /// <summary>Configures the firewall profile settings for public networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfilePublic {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile?>("firewallProfilePublic"); }
            set { BackingStore?.Set("firewallProfilePublic", value); }
        }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfilePublic {
            get { return BackingStore?.Get<WindowsFirewallNetworkProfile>("firewallProfilePublic"); }
            set { BackingStore?.Set("firewallProfilePublic", value); }
        }
#endif
        /// <summary>Configures the firewall rule settings. This collection can contain a maximum of 150 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsFirewallRule>? FirewallRules {
            get { return BackingStore?.Get<List<WindowsFirewallRule>?>("firewallRules"); }
            set { BackingStore?.Set("firewallRules", value); }
        }
#nullable restore
#else
        public List<WindowsFirewallRule> FirewallRules {
            get { return BackingStore?.Get<List<WindowsFirewallRule>>("firewallRules"); }
            set { BackingStore?.Set("firewallRules", value); }
        }
#endif
        /// <summary>Possible values for LanManagerAuthenticationLevel</summary>
        public Microsoft.Graph.Beta.Models.LanManagerAuthenticationLevel? LanManagerAuthenticationLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LanManagerAuthenticationLevel?>("lanManagerAuthenticationLevel"); }
            set { BackingStore?.Set("lanManagerAuthenticationLevel", value); }
        }
        /// <summary>If enabled,the SMB client will allow insecure guest logons. If not configured, the SMB client will reject insecure guest logons.</summary>
        public bool? LanManagerWorkstationDisableInsecureGuestLogons {
            get { return BackingStore?.Get<bool?>("lanManagerWorkstationDisableInsecureGuestLogons"); }
            set { BackingStore?.Set("lanManagerWorkstationDisableInsecureGuestLogons", value); }
        }
        /// <summary>Define a different account name to be associated with the security identifier (SID) for the account &apos;Administrator&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalSecurityOptionsAdministratorAccountName {
            get { return BackingStore?.Get<string?>("localSecurityOptionsAdministratorAccountName"); }
            set { BackingStore?.Set("localSecurityOptionsAdministratorAccountName", value); }
        }
#nullable restore
#else
        public string LocalSecurityOptionsAdministratorAccountName {
            get { return BackingStore?.Get<string>("localSecurityOptionsAdministratorAccountName"); }
            set { BackingStore?.Set("localSecurityOptionsAdministratorAccountName", value); }
        }
#endif
        /// <summary>Possible values for LocalSecurityOptionsAdministratorElevationPromptBehavior</summary>
        public LocalSecurityOptionsAdministratorElevationPromptBehaviorType? LocalSecurityOptionsAdministratorElevationPromptBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsAdministratorElevationPromptBehaviorType?>("localSecurityOptionsAdministratorElevationPromptBehavior"); }
            set { BackingStore?.Set("localSecurityOptionsAdministratorElevationPromptBehavior", value); }
        }
        /// <summary>This security setting determines whether to allows anonymous users to perform certain activities, such as enumerating the names of domain accounts and network shares.</summary>
        public bool? LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares"); }
            set { BackingStore?.Set("localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares", value); }
        }
        /// <summary>Block PKU2U authentication requests to this device to use online identities.</summary>
        public bool? LocalSecurityOptionsAllowPKU2UAuthenticationRequests {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowPKU2UAuthenticationRequests"); }
            set { BackingStore?.Set("localSecurityOptionsAllowPKU2UAuthenticationRequests", value); }
        }
        /// <summary>Edit the default Security Descriptor Definition Language string to allow or deny users and groups to make remote calls to the SAM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager {
            get { return BackingStore?.Get<string?>("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager"); }
            set { BackingStore?.Set("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", value); }
        }
#nullable restore
#else
        public string LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager {
            get { return BackingStore?.Get<string>("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager"); }
            set { BackingStore?.Set("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", value); }
        }
#endif
        /// <summary>UI helper boolean for LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager entity</summary>
        public bool? LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool"); }
            set { BackingStore?.Set("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool", value); }
        }
        /// <summary>This security setting determines whether a computer can be shut down without having to log on to Windows.</summary>
        public bool? LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn"); }
            set { BackingStore?.Set("localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn", value); }
        }
        /// <summary>Allow UIAccess apps to prompt for elevation without using the secure desktop.</summary>
        public bool? LocalSecurityOptionsAllowUIAccessApplicationElevation {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowUIAccessApplicationElevation"); }
            set { BackingStore?.Set("localSecurityOptionsAllowUIAccessApplicationElevation", value); }
        }
        /// <summary>Allow UIAccess apps to prompt for elevation without using the secure desktop.Default is enabled</summary>
        public bool? LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowUIAccessApplicationsForSecureLocations"); }
            set { BackingStore?.Set("localSecurityOptionsAllowUIAccessApplicationsForSecureLocations", value); }
        }
        /// <summary>Prevent a portable computer from being undocked without having to log in.</summary>
        public bool? LocalSecurityOptionsAllowUndockWithoutHavingToLogon {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsAllowUndockWithoutHavingToLogon"); }
            set { BackingStore?.Set("localSecurityOptionsAllowUndockWithoutHavingToLogon", value); }
        }
        /// <summary>Prevent users from adding new Microsoft accounts to this computer.</summary>
        public bool? LocalSecurityOptionsBlockMicrosoftAccounts {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsBlockMicrosoftAccounts"); }
            set { BackingStore?.Set("localSecurityOptionsBlockMicrosoftAccounts", value); }
        }
        /// <summary>Enable Local accounts that are not password protected to log on from locations other than the physical device.Default is enabled</summary>
        public bool? LocalSecurityOptionsBlockRemoteLogonWithBlankPassword {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsBlockRemoteLogonWithBlankPassword"); }
            set { BackingStore?.Set("localSecurityOptionsBlockRemoteLogonWithBlankPassword", value); }
        }
        /// <summary>Enabling this settings allows only interactively logged on user to access CD-ROM media.</summary>
        public bool? LocalSecurityOptionsBlockRemoteOpticalDriveAccess {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsBlockRemoteOpticalDriveAccess"); }
            set { BackingStore?.Set("localSecurityOptionsBlockRemoteOpticalDriveAccess", value); }
        }
        /// <summary>Restrict installing printer drivers as part of connecting to a shared printer to admins only.</summary>
        public bool? LocalSecurityOptionsBlockUsersInstallingPrinterDrivers {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsBlockUsersInstallingPrinterDrivers"); }
            set { BackingStore?.Set("localSecurityOptionsBlockUsersInstallingPrinterDrivers", value); }
        }
        /// <summary>This security setting determines whether the virtual memory pagefile is cleared when the system is shut down.</summary>
        public bool? LocalSecurityOptionsClearVirtualMemoryPageFile {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsClearVirtualMemoryPageFile"); }
            set { BackingStore?.Set("localSecurityOptionsClearVirtualMemoryPageFile", value); }
        }
        /// <summary>This security setting determines whether packet signing is required by the SMB client component.</summary>
        public bool? LocalSecurityOptionsClientDigitallySignCommunicationsAlways {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsClientDigitallySignCommunicationsAlways"); }
            set { BackingStore?.Set("localSecurityOptionsClientDigitallySignCommunicationsAlways", value); }
        }
        /// <summary>If this security setting is enabled, the Server Message Block (SMB) redirector is allowed to send plaintext passwords to non-Microsoft SMB servers that do not support password encryption during authentication.</summary>
        public bool? LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers"); }
            set { BackingStore?.Set("localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers", value); }
        }
        /// <summary>App installations requiring elevated privileges will prompt for admin credentials.Default is enabled</summary>
        public bool? LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation"); }
            set { BackingStore?.Set("localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation", value); }
        }
        /// <summary>Determines whether the Local Administrator account is enabled or disabled.</summary>
        public bool? LocalSecurityOptionsDisableAdministratorAccount {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDisableAdministratorAccount"); }
            set { BackingStore?.Set("localSecurityOptionsDisableAdministratorAccount", value); }
        }
        /// <summary>This security setting determines whether the SMB client attempts to negotiate SMB packet signing.</summary>
        public bool? LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees"); }
            set { BackingStore?.Set("localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees", value); }
        }
        /// <summary>Determines if the Guest account is enabled or disabled.</summary>
        public bool? LocalSecurityOptionsDisableGuestAccount {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDisableGuestAccount"); }
            set { BackingStore?.Set("localSecurityOptionsDisableGuestAccount", value); }
        }
        /// <summary>This security setting determines whether packet signing is required by the SMB server component.</summary>
        public bool? LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDisableServerDigitallySignCommunicationsAlways"); }
            set { BackingStore?.Set("localSecurityOptionsDisableServerDigitallySignCommunicationsAlways", value); }
        }
        /// <summary>This security setting determines whether the SMB server will negotiate SMB packet signing with clients that request it.</summary>
        public bool? LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees"); }
            set { BackingStore?.Set("localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees", value); }
        }
        /// <summary>This security setting determines what additional permissions will be granted for anonymous connections to the computer.</summary>
        public bool? LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts"); }
            set { BackingStore?.Set("localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts", value); }
        }
        /// <summary>Require CTRL+ALT+DEL to be pressed before a user can log on.</summary>
        public bool? LocalSecurityOptionsDoNotRequireCtrlAltDel {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDoNotRequireCtrlAltDel"); }
            set { BackingStore?.Set("localSecurityOptionsDoNotRequireCtrlAltDel", value); }
        }
        /// <summary>This security setting determines if, at the next password change, the LAN Manager (LM) hash value for the new password is stored. It’s not stored by default.</summary>
        public bool? LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange"); }
            set { BackingStore?.Set("localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser</summary>
        public LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType? LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser {
            get { return BackingStore?.Get<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType?>("localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser"); }
            set { BackingStore?.Set("localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser", value); }
        }
        /// <summary>Define a different account name to be associated with the security identifier (SID) for the account &apos;Guest&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalSecurityOptionsGuestAccountName {
            get { return BackingStore?.Get<string?>("localSecurityOptionsGuestAccountName"); }
            set { BackingStore?.Set("localSecurityOptionsGuestAccountName", value); }
        }
#nullable restore
#else
        public string LocalSecurityOptionsGuestAccountName {
            get { return BackingStore?.Get<string>("localSecurityOptionsGuestAccountName"); }
            set { BackingStore?.Set("localSecurityOptionsGuestAccountName", value); }
        }
#endif
        /// <summary>Do not display the username of the last person who signed in on this device.</summary>
        public bool? LocalSecurityOptionsHideLastSignedInUser {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsHideLastSignedInUser"); }
            set { BackingStore?.Set("localSecurityOptionsHideLastSignedInUser", value); }
        }
        /// <summary>Do not display the username of the person signing in to this device after credentials are entered and before the device’s desktop is shown.</summary>
        public bool? LocalSecurityOptionsHideUsernameAtSignIn {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsHideUsernameAtSignIn"); }
            set { BackingStore?.Set("localSecurityOptionsHideUsernameAtSignIn", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsInformationDisplayedOnLockScreen</summary>
        public LocalSecurityOptionsInformationDisplayedOnLockScreenType? LocalSecurityOptionsInformationDisplayedOnLockScreen {
            get { return BackingStore?.Get<LocalSecurityOptionsInformationDisplayedOnLockScreenType?>("localSecurityOptionsInformationDisplayedOnLockScreen"); }
            set { BackingStore?.Set("localSecurityOptionsInformationDisplayedOnLockScreen", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsInformationShownOnLockScreenType</summary>
        public LocalSecurityOptionsInformationShownOnLockScreenType? LocalSecurityOptionsInformationShownOnLockScreen {
            get { return BackingStore?.Get<LocalSecurityOptionsInformationShownOnLockScreenType?>("localSecurityOptionsInformationShownOnLockScreen"); }
            set { BackingStore?.Set("localSecurityOptionsInformationShownOnLockScreen", value); }
        }
        /// <summary>Set message text for users attempting to log in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalSecurityOptionsLogOnMessageText {
            get { return BackingStore?.Get<string?>("localSecurityOptionsLogOnMessageText"); }
            set { BackingStore?.Set("localSecurityOptionsLogOnMessageText", value); }
        }
#nullable restore
#else
        public string LocalSecurityOptionsLogOnMessageText {
            get { return BackingStore?.Get<string>("localSecurityOptionsLogOnMessageText"); }
            set { BackingStore?.Set("localSecurityOptionsLogOnMessageText", value); }
        }
#endif
        /// <summary>Set message title for users attempting to log in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalSecurityOptionsLogOnMessageTitle {
            get { return BackingStore?.Get<string?>("localSecurityOptionsLogOnMessageTitle"); }
            set { BackingStore?.Set("localSecurityOptionsLogOnMessageTitle", value); }
        }
#nullable restore
#else
        public string LocalSecurityOptionsLogOnMessageTitle {
            get { return BackingStore?.Get<string>("localSecurityOptionsLogOnMessageTitle"); }
            set { BackingStore?.Set("localSecurityOptionsLogOnMessageTitle", value); }
        }
#endif
        /// <summary>Define maximum minutes of inactivity on the interactive desktop’s login screen until the screen saver runs. Valid values 0 to 9999</summary>
        public int? LocalSecurityOptionsMachineInactivityLimit {
            get { return BackingStore?.Get<int?>("localSecurityOptionsMachineInactivityLimit"); }
            set { BackingStore?.Set("localSecurityOptionsMachineInactivityLimit", value); }
        }
        /// <summary>Define maximum minutes of inactivity on the interactive desktop’s login screen until the screen saver runs. Valid values 0 to 9999</summary>
        public int? LocalSecurityOptionsMachineInactivityLimitInMinutes {
            get { return BackingStore?.Get<int?>("localSecurityOptionsMachineInactivityLimitInMinutes"); }
            set { BackingStore?.Set("localSecurityOptionsMachineInactivityLimitInMinutes", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsMinimumSessionSecurity</summary>
        public LocalSecurityOptionsMinimumSessionSecurity? LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients {
            get { return BackingStore?.Get<LocalSecurityOptionsMinimumSessionSecurity?>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients"); }
            set { BackingStore?.Set("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsMinimumSessionSecurity</summary>
        public LocalSecurityOptionsMinimumSessionSecurity? LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers {
            get { return BackingStore?.Get<LocalSecurityOptionsMinimumSessionSecurity?>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers"); }
            set { BackingStore?.Set("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers", value); }
        }
        /// <summary>Enforce PKI certification path validation for a given executable file before it is permitted to run.</summary>
        public bool? LocalSecurityOptionsOnlyElevateSignedExecutables {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsOnlyElevateSignedExecutables"); }
            set { BackingStore?.Set("localSecurityOptionsOnlyElevateSignedExecutables", value); }
        }
        /// <summary>By default, this security setting restricts anonymous access to shares and pipes to the settings for named pipes that can be accessed anonymously and Shares that can be accessed anonymously</summary>
        public bool? LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares"); }
            set { BackingStore?.Set("localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsSmartCardRemovalBehaviorType</summary>
        public LocalSecurityOptionsSmartCardRemovalBehaviorType? LocalSecurityOptionsSmartCardRemovalBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsSmartCardRemovalBehaviorType?>("localSecurityOptionsSmartCardRemovalBehavior"); }
            set { BackingStore?.Set("localSecurityOptionsSmartCardRemovalBehavior", value); }
        }
        /// <summary>Possible values for LocalSecurityOptionsStandardUserElevationPromptBehavior</summary>
        public LocalSecurityOptionsStandardUserElevationPromptBehaviorType? LocalSecurityOptionsStandardUserElevationPromptBehavior {
            get { return BackingStore?.Get<LocalSecurityOptionsStandardUserElevationPromptBehaviorType?>("localSecurityOptionsStandardUserElevationPromptBehavior"); }
            set { BackingStore?.Set("localSecurityOptionsStandardUserElevationPromptBehavior", value); }
        }
        /// <summary>Enable all elevation requests to go to the interactive user&apos;s desktop rather than the secure desktop. Prompt behavior policy settings for admins and standard users are used.</summary>
        public bool? LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation"); }
            set { BackingStore?.Set("localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation", value); }
        }
        /// <summary>Defines whether the built-in admin account uses Admin Approval Mode or runs all apps with full admin privileges.Default is enabled</summary>
        public bool? LocalSecurityOptionsUseAdminApprovalMode {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsUseAdminApprovalMode"); }
            set { BackingStore?.Set("localSecurityOptionsUseAdminApprovalMode", value); }
        }
        /// <summary>Define whether Admin Approval Mode and all UAC policy settings are enabled, default is enabled</summary>
        public bool? LocalSecurityOptionsUseAdminApprovalModeForAdministrators {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsUseAdminApprovalModeForAdministrators"); }
            set { BackingStore?.Set("localSecurityOptionsUseAdminApprovalModeForAdministrators", value); }
        }
        /// <summary>Virtualize file and registry write failures to per user locations</summary>
        public bool? LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations {
            get { return BackingStore?.Get<bool?>("localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations"); }
            set { BackingStore?.Set("localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations", value); }
        }
        /// <summary>Allows IT Admins to control whether users can can ignore SmartScreen warnings and run malicious files.</summary>
        public bool? SmartScreenBlockOverrideForFiles {
            get { return BackingStore?.Get<bool?>("smartScreenBlockOverrideForFiles"); }
            set { BackingStore?.Set("smartScreenBlockOverrideForFiles", value); }
        }
        /// <summary>Allows IT Admins to configure SmartScreen for Windows.</summary>
        public bool? SmartScreenEnableInShell {
            get { return BackingStore?.Get<bool?>("smartScreenEnableInShell"); }
            set { BackingStore?.Set("smartScreenEnableInShell", value); }
        }
        /// <summary>This user right is used by Credential Manager during Backup/Restore. Users&apos; saved credentials might be compromised if this privilege is given to other entities. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsAccessCredentialManagerAsTrustedCaller {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsAccessCredentialManagerAsTrustedCaller"); }
            set { BackingStore?.Set("userRightsAccessCredentialManagerAsTrustedCaller", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsAccessCredentialManagerAsTrustedCaller {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsAccessCredentialManagerAsTrustedCaller"); }
            set { BackingStore?.Set("userRightsAccessCredentialManagerAsTrustedCaller", value); }
        }
#endif
        /// <summary>This user right allows a process to impersonate any user without authentication. The process can therefore gain access to the same local resources as that user. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsActAsPartOfTheOperatingSystem {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsActAsPartOfTheOperatingSystem"); }
            set { BackingStore?.Set("userRightsActAsPartOfTheOperatingSystem", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsActAsPartOfTheOperatingSystem {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsActAsPartOfTheOperatingSystem"); }
            set { BackingStore?.Set("userRightsActAsPartOfTheOperatingSystem", value); }
        }
#endif
        /// <summary>This user right determines which users and groups are allowed to connect to the computer over the network. State Allowed is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsAllowAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsAllowAccessFromNetwork"); }
            set { BackingStore?.Set("userRightsAllowAccessFromNetwork", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsAllowAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsAllowAccessFromNetwork"); }
            set { BackingStore?.Set("userRightsAllowAccessFromNetwork", value); }
        }
#endif
        /// <summary>This user right determines which users can bypass file, directory, registry, and other persistent objects permissions when backing up files and directories. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsBackupData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsBackupData"); }
            set { BackingStore?.Set("userRightsBackupData", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsBackupData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsBackupData"); }
            set { BackingStore?.Set("userRightsBackupData", value); }
        }
#endif
        /// <summary>This user right determines which users and groups are block from connecting to the computer over the network. State Block is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsBlockAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsBlockAccessFromNetwork"); }
            set { BackingStore?.Set("userRightsBlockAccessFromNetwork", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsBlockAccessFromNetwork {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsBlockAccessFromNetwork"); }
            set { BackingStore?.Set("userRightsBlockAccessFromNetwork", value); }
        }
#endif
        /// <summary>This user right determines which users and groups can change the time and date on the internal clock of the computer. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsChangeSystemTime {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsChangeSystemTime"); }
            set { BackingStore?.Set("userRightsChangeSystemTime", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsChangeSystemTime {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsChangeSystemTime"); }
            set { BackingStore?.Set("userRightsChangeSystemTime", value); }
        }
#endif
        /// <summary>This security setting determines whether users can create global objects that are available to all sessions. Users who can create global objects could affect processes that run under other users&apos; sessions, which could lead to application failure or data corruption. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsCreateGlobalObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsCreateGlobalObjects"); }
            set { BackingStore?.Set("userRightsCreateGlobalObjects", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsCreateGlobalObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsCreateGlobalObjects"); }
            set { BackingStore?.Set("userRightsCreateGlobalObjects", value); }
        }
#endif
        /// <summary>This user right determines which users and groups can call an internal API to create and change the size of a page file. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsCreatePageFile {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsCreatePageFile"); }
            set { BackingStore?.Set("userRightsCreatePageFile", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsCreatePageFile {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsCreatePageFile"); }
            set { BackingStore?.Set("userRightsCreatePageFile", value); }
        }
#endif
        /// <summary>This user right determines which accounts can be used by processes to create a directory object using the object manager. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsCreatePermanentSharedObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsCreatePermanentSharedObjects"); }
            set { BackingStore?.Set("userRightsCreatePermanentSharedObjects", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsCreatePermanentSharedObjects {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsCreatePermanentSharedObjects"); }
            set { BackingStore?.Set("userRightsCreatePermanentSharedObjects", value); }
        }
#endif
        /// <summary>This user right determines if the user can create a symbolic link from the computer to which they are logged on. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsCreateSymbolicLinks {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsCreateSymbolicLinks"); }
            set { BackingStore?.Set("userRightsCreateSymbolicLinks", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsCreateSymbolicLinks {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsCreateSymbolicLinks"); }
            set { BackingStore?.Set("userRightsCreateSymbolicLinks", value); }
        }
#endif
        /// <summary>This user right determines which users/groups can be used by processes to create a token that can then be used to get access to any local resources when the process uses an internal API to create an access token. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsCreateToken {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsCreateToken"); }
            set { BackingStore?.Set("userRightsCreateToken", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsCreateToken {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsCreateToken"); }
            set { BackingStore?.Set("userRightsCreateToken", value); }
        }
#endif
        /// <summary>This user right determines which users can attach a debugger to any process or to the kernel. Only states NotConfigured and Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsDebugPrograms {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsDebugPrograms"); }
            set { BackingStore?.Set("userRightsDebugPrograms", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsDebugPrograms {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsDebugPrograms"); }
            set { BackingStore?.Set("userRightsDebugPrograms", value); }
        }
#endif
        /// <summary>This user right determines which users can set the Trusted for Delegation setting on a user or computer object. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsDelegation {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsDelegation"); }
            set { BackingStore?.Set("userRightsDelegation", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsDelegation {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsDelegation"); }
            set { BackingStore?.Set("userRightsDelegation", value); }
        }
#endif
        /// <summary>This user right determines which users cannot log on to the computer. States NotConfigured, Blocked are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsDenyLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsDenyLocalLogOn"); }
            set { BackingStore?.Set("userRightsDenyLocalLogOn", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsDenyLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsDenyLocalLogOn"); }
            set { BackingStore?.Set("userRightsDenyLocalLogOn", value); }
        }
#endif
        /// <summary>This user right determines which accounts can be used by a process to add entries to the security log. The security log is used to trace unauthorized system access.  Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsGenerateSecurityAudits {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsGenerateSecurityAudits"); }
            set { BackingStore?.Set("userRightsGenerateSecurityAudits", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsGenerateSecurityAudits {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsGenerateSecurityAudits"); }
            set { BackingStore?.Set("userRightsGenerateSecurityAudits", value); }
        }
#endif
        /// <summary>Assigning this user right to a user allows programs running on behalf of that user to impersonate a client. Requiring this user right for this kind of impersonation prevents an unauthorized user from convincing a client to connect to a service that they have created and then impersonating that client, which can elevate the unauthorized user&apos;s permissions to administrative or system levels. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsImpersonateClient {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsImpersonateClient"); }
            set { BackingStore?.Set("userRightsImpersonateClient", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsImpersonateClient {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsImpersonateClient"); }
            set { BackingStore?.Set("userRightsImpersonateClient", value); }
        }
#endif
        /// <summary>This user right determines which accounts can use a process with Write Property access to another process to increase the execution priority assigned to the other process. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsIncreaseSchedulingPriority {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsIncreaseSchedulingPriority"); }
            set { BackingStore?.Set("userRightsIncreaseSchedulingPriority", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsIncreaseSchedulingPriority {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsIncreaseSchedulingPriority"); }
            set { BackingStore?.Set("userRightsIncreaseSchedulingPriority", value); }
        }
#endif
        /// <summary>This user right determines which users can dynamically load and unload device drivers or other code in to kernel mode. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsLoadUnloadDrivers {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsLoadUnloadDrivers"); }
            set { BackingStore?.Set("userRightsLoadUnloadDrivers", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsLoadUnloadDrivers {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsLoadUnloadDrivers"); }
            set { BackingStore?.Set("userRightsLoadUnloadDrivers", value); }
        }
#endif
        /// <summary>This user right determines which users can log on to the computer. States NotConfigured, Allowed are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsLocalLogOn"); }
            set { BackingStore?.Set("userRightsLocalLogOn", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsLocalLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsLocalLogOn"); }
            set { BackingStore?.Set("userRightsLocalLogOn", value); }
        }
#endif
        /// <summary>This user right determines which accounts can use a process to keep data in physical memory, which prevents the system from paging the data to virtual memory on disk. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsLockMemory {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsLockMemory"); }
            set { BackingStore?.Set("userRightsLockMemory", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsLockMemory {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsLockMemory"); }
            set { BackingStore?.Set("userRightsLockMemory", value); }
        }
#endif
        /// <summary>This user right determines which users can specify object access auditing options for individual resources, such as files, Active Directory objects, and registry keys. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsManageAuditingAndSecurityLogs {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsManageAuditingAndSecurityLogs"); }
            set { BackingStore?.Set("userRightsManageAuditingAndSecurityLogs", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsManageAuditingAndSecurityLogs {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsManageAuditingAndSecurityLogs"); }
            set { BackingStore?.Set("userRightsManageAuditingAndSecurityLogs", value); }
        }
#endif
        /// <summary>This user right determines which users and groups can run maintenance tasks on a volume, such as remote defragmentation. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsManageVolumes {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsManageVolumes"); }
            set { BackingStore?.Set("userRightsManageVolumes", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsManageVolumes {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsManageVolumes"); }
            set { BackingStore?.Set("userRightsManageVolumes", value); }
        }
#endif
        /// <summary>This user right determines who can modify firmware environment values. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsModifyFirmwareEnvironment {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsModifyFirmwareEnvironment"); }
            set { BackingStore?.Set("userRightsModifyFirmwareEnvironment", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsModifyFirmwareEnvironment {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsModifyFirmwareEnvironment"); }
            set { BackingStore?.Set("userRightsModifyFirmwareEnvironment", value); }
        }
#endif
        /// <summary>This user right determines which user accounts can modify the integrity label of objects, such as files, registry keys, or processes owned by other users. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsModifyObjectLabels {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsModifyObjectLabels"); }
            set { BackingStore?.Set("userRightsModifyObjectLabels", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsModifyObjectLabels {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsModifyObjectLabels"); }
            set { BackingStore?.Set("userRightsModifyObjectLabels", value); }
        }
#endif
        /// <summary>This user right determines which users can use performance monitoring tools to monitor the performance of system processes. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsProfileSingleProcess {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsProfileSingleProcess"); }
            set { BackingStore?.Set("userRightsProfileSingleProcess", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsProfileSingleProcess {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsProfileSingleProcess"); }
            set { BackingStore?.Set("userRightsProfileSingleProcess", value); }
        }
#endif
        /// <summary>This user right determines which users and groups are prohibited from logging on as a Remote Desktop Services client. Only states NotConfigured and Blocked are supported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsRemoteDesktopServicesLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsRemoteDesktopServicesLogOn"); }
            set { BackingStore?.Set("userRightsRemoteDesktopServicesLogOn", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsRemoteDesktopServicesLogOn {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsRemoteDesktopServicesLogOn"); }
            set { BackingStore?.Set("userRightsRemoteDesktopServicesLogOn", value); }
        }
#endif
        /// <summary>This user right determines which users are allowed to shut down a computer from a remote location on the network. Misuse of this user right can result in a denial of service. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsRemoteShutdown {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsRemoteShutdown"); }
            set { BackingStore?.Set("userRightsRemoteShutdown", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsRemoteShutdown {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsRemoteShutdown"); }
            set { BackingStore?.Set("userRightsRemoteShutdown", value); }
        }
#endif
        /// <summary>This user right determines which users can bypass file, directory, registry, and other persistent objects permissions when restoring backed up files and directories, and determines which users can set any valid security principal as the owner of an object. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsRestoreData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsRestoreData"); }
            set { BackingStore?.Set("userRightsRestoreData", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsRestoreData {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsRestoreData"); }
            set { BackingStore?.Set("userRightsRestoreData", value); }
        }
#endif
        /// <summary>This user right determines which users can take ownership of any securable object in the system, including Active Directory objects, files and folders, printers, registry keys, processes, and threads. Only states NotConfigured and Allowed are supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementUserRightsSetting? UserRightsTakeOwnership {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting?>("userRightsTakeOwnership"); }
            set { BackingStore?.Set("userRightsTakeOwnership", value); }
        }
#nullable restore
#else
        public DeviceManagementUserRightsSetting UserRightsTakeOwnership {
            get { return BackingStore?.Get<DeviceManagementUserRightsSetting>("userRightsTakeOwnership"); }
            set { BackingStore?.Set("userRightsTakeOwnership", value); }
        }
#endif
        /// <summary>Defender TamperProtection setting options</summary>
        public WindowsDefenderTamperProtectionOptions? WindowsDefenderTamperProtection {
            get { return BackingStore?.Get<WindowsDefenderTamperProtectionOptions?>("windowsDefenderTamperProtection"); }
            set { BackingStore?.Set("windowsDefenderTamperProtection", value); }
        }
        /// <summary>Possible values of xbox service start type</summary>
        public ServiceStartType? XboxServicesAccessoryManagementServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>("xboxServicesAccessoryManagementServiceStartupMode"); }
            set { BackingStore?.Set("xboxServicesAccessoryManagementServiceStartupMode", value); }
        }
        /// <summary>This setting determines whether xbox game save is enabled (1) or disabled (0).</summary>
        public bool? XboxServicesEnableXboxGameSaveTask {
            get { return BackingStore?.Get<bool?>("xboxServicesEnableXboxGameSaveTask"); }
            set { BackingStore?.Set("xboxServicesEnableXboxGameSaveTask", value); }
        }
        /// <summary>Possible values of xbox service start type</summary>
        public ServiceStartType? XboxServicesLiveAuthManagerServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>("xboxServicesLiveAuthManagerServiceStartupMode"); }
            set { BackingStore?.Set("xboxServicesLiveAuthManagerServiceStartupMode", value); }
        }
        /// <summary>Possible values of xbox service start type</summary>
        public ServiceStartType? XboxServicesLiveGameSaveServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>("xboxServicesLiveGameSaveServiceStartupMode"); }
            set { BackingStore?.Set("xboxServicesLiveGameSaveServiceStartupMode", value); }
        }
        /// <summary>Possible values of xbox service start type</summary>
        public ServiceStartType? XboxServicesLiveNetworkingServiceStartupMode {
            get { return BackingStore?.Get<ServiceStartType?>("xboxServicesLiveNetworkingServiceStartupMode"); }
            set { BackingStore?.Set("xboxServicesLiveNetworkingServiceStartupMode", value); }
        }
        /// <summary>
        /// Instantiates a new windows10EndpointProtectionConfiguration and sets the default values.
        /// </summary>
        public Windows10EndpointProtectionConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10EndpointProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10EndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationGuardAllowCameraMicrophoneRedirection", n => { ApplicationGuardAllowCameraMicrophoneRedirection = n.GetBoolValue(); } },
                {"applicationGuardAllowFileSaveOnHost", n => { ApplicationGuardAllowFileSaveOnHost = n.GetBoolValue(); } },
                {"applicationGuardAllowPersistence", n => { ApplicationGuardAllowPersistence = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToLocalPrinters", n => { ApplicationGuardAllowPrintToLocalPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToNetworkPrinters", n => { ApplicationGuardAllowPrintToNetworkPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToPDF", n => { ApplicationGuardAllowPrintToPDF = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToXPS", n => { ApplicationGuardAllowPrintToXPS = n.GetBoolValue(); } },
                {"applicationGuardAllowVirtualGPU", n => { ApplicationGuardAllowVirtualGPU = n.GetBoolValue(); } },
                {"applicationGuardBlockClipboardSharing", n => { ApplicationGuardBlockClipboardSharing = n.GetEnumValue<ApplicationGuardBlockClipboardSharingType>(); } },
                {"applicationGuardBlockFileTransfer", n => { ApplicationGuardBlockFileTransfer = n.GetEnumValue<ApplicationGuardBlockFileTransferType>(); } },
                {"applicationGuardBlockNonEnterpriseContent", n => { ApplicationGuardBlockNonEnterpriseContent = n.GetBoolValue(); } },
                {"applicationGuardCertificateThumbprints", n => { ApplicationGuardCertificateThumbprints = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"applicationGuardEnabled", n => { ApplicationGuardEnabled = n.GetBoolValue(); } },
                {"applicationGuardEnabledOptions", n => { ApplicationGuardEnabledOptions = n.GetEnumValue<ApplicationGuardEnabledOptions>(); } },
                {"applicationGuardForceAuditing", n => { ApplicationGuardForceAuditing = n.GetBoolValue(); } },
                {"appLockerApplicationControl", n => { AppLockerApplicationControl = n.GetEnumValue<AppLockerApplicationControlType>(); } },
                {"bitLockerAllowStandardUserEncryption", n => { BitLockerAllowStandardUserEncryption = n.GetBoolValue(); } },
                {"bitLockerDisableWarningForOtherDiskEncryption", n => { BitLockerDisableWarningForOtherDiskEncryption = n.GetBoolValue(); } },
                {"bitLockerEnableStorageCardEncryptionOnMobile", n => { BitLockerEnableStorageCardEncryptionOnMobile = n.GetBoolValue(); } },
                {"bitLockerEncryptDevice", n => { BitLockerEncryptDevice = n.GetBoolValue(); } },
                {"bitLockerFixedDrivePolicy", n => { BitLockerFixedDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy.CreateFromDiscriminatorValue); } },
                {"bitLockerRecoveryPasswordRotation", n => { BitLockerRecoveryPasswordRotation = n.GetEnumValue<BitLockerRecoveryPasswordRotationType>(); } },
                {"bitLockerRemovableDrivePolicy", n => { BitLockerRemovableDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy.CreateFromDiscriminatorValue); } },
                {"bitLockerSystemDrivePolicy", n => { BitLockerSystemDrivePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>(Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy.CreateFromDiscriminatorValue); } },
                {"defenderAdditionalGuardedFolders", n => { DefenderAdditionalGuardedFolders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderAdobeReaderLaunchChildProcess", n => { DefenderAdobeReaderLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderAdvancedRansomewareProtectionType", n => { DefenderAdvancedRansomewareProtectionType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderAllowBehaviorMonitoring", n => { DefenderAllowBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderAllowCloudProtection", n => { DefenderAllowCloudProtection = n.GetBoolValue(); } },
                {"defenderAllowEndUserAccess", n => { DefenderAllowEndUserAccess = n.GetBoolValue(); } },
                {"defenderAllowIntrusionPreventionSystem", n => { DefenderAllowIntrusionPreventionSystem = n.GetBoolValue(); } },
                {"defenderAllowOnAccessProtection", n => { DefenderAllowOnAccessProtection = n.GetBoolValue(); } },
                {"defenderAllowRealTimeMonitoring", n => { DefenderAllowRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderAllowScanArchiveFiles", n => { DefenderAllowScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderAllowScanDownloads", n => { DefenderAllowScanDownloads = n.GetBoolValue(); } },
                {"defenderAllowScanNetworkFiles", n => { DefenderAllowScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderAllowScanRemovableDrivesDuringFullScan", n => { DefenderAllowScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderAllowScanScriptsLoadedInInternetExplorer", n => { DefenderAllowScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderAttackSurfaceReductionExcludedPaths", n => { DefenderAttackSurfaceReductionExcludedPaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderBlockEndUserAccess", n => { DefenderBlockEndUserAccess = n.GetBoolValue(); } },
                {"defenderBlockPersistenceThroughWmiType", n => { DefenderBlockPersistenceThroughWmiType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderCheckForSignaturesBeforeRunningScan", n => { DefenderCheckForSignaturesBeforeRunningScan = n.GetBoolValue(); } },
                {"defenderCloudBlockLevel", n => { DefenderCloudBlockLevel = n.GetEnumValue<DefenderCloudBlockLevelType>(); } },
                {"defenderCloudExtendedTimeoutInSeconds", n => { DefenderCloudExtendedTimeoutInSeconds = n.GetIntValue(); } },
                {"defenderDaysBeforeDeletingQuarantinedMalware", n => { DefenderDaysBeforeDeletingQuarantinedMalware = n.GetIntValue(); } },
                {"defenderDetectedMalwareActions", n => { DefenderDetectedMalwareActions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>(Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions.CreateFromDiscriminatorValue); } },
                {"defenderDisableBehaviorMonitoring", n => { DefenderDisableBehaviorMonitoring = n.GetBoolValue(); } },
                {"defenderDisableCatchupFullScan", n => { DefenderDisableCatchupFullScan = n.GetBoolValue(); } },
                {"defenderDisableCatchupQuickScan", n => { DefenderDisableCatchupQuickScan = n.GetBoolValue(); } },
                {"defenderDisableCloudProtection", n => { DefenderDisableCloudProtection = n.GetBoolValue(); } },
                {"defenderDisableIntrusionPreventionSystem", n => { DefenderDisableIntrusionPreventionSystem = n.GetBoolValue(); } },
                {"defenderDisableOnAccessProtection", n => { DefenderDisableOnAccessProtection = n.GetBoolValue(); } },
                {"defenderDisableRealTimeMonitoring", n => { DefenderDisableRealTimeMonitoring = n.GetBoolValue(); } },
                {"defenderDisableScanArchiveFiles", n => { DefenderDisableScanArchiveFiles = n.GetBoolValue(); } },
                {"defenderDisableScanDownloads", n => { DefenderDisableScanDownloads = n.GetBoolValue(); } },
                {"defenderDisableScanNetworkFiles", n => { DefenderDisableScanNetworkFiles = n.GetBoolValue(); } },
                {"defenderDisableScanRemovableDrivesDuringFullScan", n => { DefenderDisableScanRemovableDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderDisableScanScriptsLoadedInInternetExplorer", n => { DefenderDisableScanScriptsLoadedInInternetExplorer = n.GetBoolValue(); } },
                {"defenderEmailContentExecution", n => { DefenderEmailContentExecution = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderEmailContentExecutionType", n => { DefenderEmailContentExecutionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderEnableLowCpuPriority", n => { DefenderEnableLowCpuPriority = n.GetBoolValue(); } },
                {"defenderEnableScanIncomingMail", n => { DefenderEnableScanIncomingMail = n.GetBoolValue(); } },
                {"defenderEnableScanMappedNetworkDrivesDuringFullScan", n => { DefenderEnableScanMappedNetworkDrivesDuringFullScan = n.GetBoolValue(); } },
                {"defenderExploitProtectionXml", n => { DefenderExploitProtectionXml = n.GetByteArrayValue(); } },
                {"defenderExploitProtectionXmlFileName", n => { DefenderExploitProtectionXmlFileName = n.GetStringValue(); } },
                {"defenderFileExtensionsToExclude", n => { DefenderFileExtensionsToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderFilesAndFoldersToExclude", n => { DefenderFilesAndFoldersToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderGuardedFoldersAllowedAppPaths", n => { DefenderGuardedFoldersAllowedAppPaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderGuardMyFoldersType", n => { DefenderGuardMyFoldersType = n.GetEnumValue<FolderProtectionType>(); } },
                {"defenderNetworkProtectionType", n => { DefenderNetworkProtectionType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsExecutableContentCreationOrLaunch", n => { DefenderOfficeAppsExecutableContentCreationOrLaunch = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsExecutableContentCreationOrLaunchType", n => { DefenderOfficeAppsExecutableContentCreationOrLaunchType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeAppsLaunchChildProcess", n => { DefenderOfficeAppsLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsLaunchChildProcessType", n => { DefenderOfficeAppsLaunchChildProcessType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeAppsOtherProcessInjection", n => { DefenderOfficeAppsOtherProcessInjection = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeAppsOtherProcessInjectionType", n => { DefenderOfficeAppsOtherProcessInjectionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderOfficeCommunicationAppsLaunchChildProcess", n => { DefenderOfficeCommunicationAppsLaunchChildProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeMacroCodeAllowWin32Imports", n => { DefenderOfficeMacroCodeAllowWin32Imports = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderOfficeMacroCodeAllowWin32ImportsType", n => { DefenderOfficeMacroCodeAllowWin32ImportsType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderPotentiallyUnwantedAppAction", n => { DefenderPotentiallyUnwantedAppAction = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderPreventCredentialStealingType", n => { DefenderPreventCredentialStealingType = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessCreation", n => { DefenderProcessCreation = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderProcessCreationType", n => { DefenderProcessCreationType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderProcessesToExclude", n => { DefenderProcessesToExclude = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderScanDirection", n => { DefenderScanDirection = n.GetEnumValue<DefenderRealtimeScanDirection>(); } },
                {"defenderScanMaxCpuPercentage", n => { DefenderScanMaxCpuPercentage = n.GetIntValue(); } },
                {"defenderScanType", n => { DefenderScanType = n.GetEnumValue<DefenderScanType>(); } },
                {"defenderScheduledQuickScanTime", n => { DefenderScheduledQuickScanTime = n.GetTimeValue(); } },
                {"defenderScheduledScanDay", n => { DefenderScheduledScanDay = n.GetEnumValue<WeeklySchedule>(); } },
                {"defenderScheduledScanTime", n => { DefenderScheduledScanTime = n.GetTimeValue(); } },
                {"defenderScriptDownloadedPayloadExecution", n => { DefenderScriptDownloadedPayloadExecution = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderScriptDownloadedPayloadExecutionType", n => { DefenderScriptDownloadedPayloadExecutionType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderScriptObfuscatedMacroCode", n => { DefenderScriptObfuscatedMacroCode = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderScriptObfuscatedMacroCodeType", n => { DefenderScriptObfuscatedMacroCodeType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderSecurityCenterBlockExploitProtectionOverride", n => { DefenderSecurityCenterBlockExploitProtectionOverride = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableAccountUI", n => { DefenderSecurityCenterDisableAccountUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableAppBrowserUI", n => { DefenderSecurityCenterDisableAppBrowserUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableClearTpmUI", n => { DefenderSecurityCenterDisableClearTpmUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableFamilyUI", n => { DefenderSecurityCenterDisableFamilyUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableHardwareUI", n => { DefenderSecurityCenterDisableHardwareUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableHealthUI", n => { DefenderSecurityCenterDisableHealthUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableNetworkUI", n => { DefenderSecurityCenterDisableNetworkUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableNotificationAreaUI", n => { DefenderSecurityCenterDisableNotificationAreaUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableRansomwareUI", n => { DefenderSecurityCenterDisableRansomwareUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableSecureBootUI", n => { DefenderSecurityCenterDisableSecureBootUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableTroubleshootingUI", n => { DefenderSecurityCenterDisableTroubleshootingUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableVirusUI", n => { DefenderSecurityCenterDisableVirusUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI", n => { DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI = n.GetBoolValue(); } },
                {"defenderSecurityCenterHelpEmail", n => { DefenderSecurityCenterHelpEmail = n.GetStringValue(); } },
                {"defenderSecurityCenterHelpPhone", n => { DefenderSecurityCenterHelpPhone = n.GetStringValue(); } },
                {"defenderSecurityCenterHelpURL", n => { DefenderSecurityCenterHelpURL = n.GetStringValue(); } },
                {"defenderSecurityCenterITContactDisplay", n => { DefenderSecurityCenterITContactDisplay = n.GetEnumValue<DefenderSecurityCenterITContactDisplayType>(); } },
                {"defenderSecurityCenterNotificationsFromApp", n => { DefenderSecurityCenterNotificationsFromApp = n.GetEnumValue<DefenderSecurityCenterNotificationsFromAppType>(); } },
                {"defenderSecurityCenterOrganizationDisplayName", n => { DefenderSecurityCenterOrganizationDisplayName = n.GetStringValue(); } },
                {"defenderSignatureUpdateIntervalInHours", n => { DefenderSignatureUpdateIntervalInHours = n.GetIntValue(); } },
                {"defenderSubmitSamplesConsentType", n => { DefenderSubmitSamplesConsentType = n.GetEnumValue<DefenderSubmitSamplesConsentType>(); } },
                {"defenderUntrustedExecutable", n => { DefenderUntrustedExecutable = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderUntrustedExecutableType", n => { DefenderUntrustedExecutableType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"defenderUntrustedUSBProcess", n => { DefenderUntrustedUSBProcess = n.GetEnumValue<DefenderProtectionType>(); } },
                {"defenderUntrustedUSBProcessType", n => { DefenderUntrustedUSBProcessType = n.GetEnumValue<DefenderAttackSurfaceType>(); } },
                {"deviceGuardEnableSecureBootWithDMA", n => { DeviceGuardEnableSecureBootWithDMA = n.GetBoolValue(); } },
                {"deviceGuardEnableVirtualizationBasedSecurity", n => { DeviceGuardEnableVirtualizationBasedSecurity = n.GetBoolValue(); } },
                {"deviceGuardLaunchSystemGuard", n => { DeviceGuardLaunchSystemGuard = n.GetEnumValue<Enablement>(); } },
                {"deviceGuardLocalSystemAuthorityCredentialGuardSettings", n => { DeviceGuardLocalSystemAuthorityCredentialGuardSettings = n.GetEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardType>(); } },
                {"deviceGuardSecureBootWithDMA", n => { DeviceGuardSecureBootWithDMA = n.GetEnumValue<SecureBootWithDMAType>(); } },
                {"dmaGuardDeviceEnumerationPolicy", n => { DmaGuardDeviceEnumerationPolicy = n.GetEnumValue<DmaGuardDeviceEnumerationPolicyType>(); } },
                {"firewallBlockStatefulFTP", n => { FirewallBlockStatefulFTP = n.GetBoolValue(); } },
                {"firewallCertificateRevocationListCheckMethod", n => { FirewallCertificateRevocationListCheckMethod = n.GetEnumValue<FirewallCertificateRevocationListCheckMethodType>(); } },
                {"firewallIdleTimeoutForSecurityAssociationInSeconds", n => { FirewallIdleTimeoutForSecurityAssociationInSeconds = n.GetIntValue(); } },
                {"firewallIPSecExemptionsAllowDHCP", n => { FirewallIPSecExemptionsAllowDHCP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowICMP", n => { FirewallIPSecExemptionsAllowICMP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowNeighborDiscovery", n => { FirewallIPSecExemptionsAllowNeighborDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowRouterDiscovery", n => { FirewallIPSecExemptionsAllowRouterDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsNone", n => { FirewallIPSecExemptionsNone = n.GetBoolValue(); } },
                {"firewallMergeKeyingModuleSettings", n => { FirewallMergeKeyingModuleSettings = n.GetBoolValue(); } },
                {"firewallPacketQueueingMethod", n => { FirewallPacketQueueingMethod = n.GetEnumValue<FirewallPacketQueueingMethodType>(); } },
                {"firewallPreSharedKeyEncodingMethod", n => { FirewallPreSharedKeyEncodingMethod = n.GetEnumValue<FirewallPreSharedKeyEncodingMethodType>(); } },
                {"firewallProfileDomain", n => { FirewallProfileDomain = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePrivate", n => { FirewallProfilePrivate = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePublic", n => { FirewallProfilePublic = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallRules", n => { FirewallRules = n.GetCollectionOfObjectValues<WindowsFirewallRule>(WindowsFirewallRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lanManagerAuthenticationLevel", n => { LanManagerAuthenticationLevel = n.GetEnumValue<LanManagerAuthenticationLevel>(); } },
                {"lanManagerWorkstationDisableInsecureGuestLogons", n => { LanManagerWorkstationDisableInsecureGuestLogons = n.GetBoolValue(); } },
                {"localSecurityOptionsAdministratorAccountName", n => { LocalSecurityOptionsAdministratorAccountName = n.GetStringValue(); } },
                {"localSecurityOptionsAdministratorElevationPromptBehavior", n => { LocalSecurityOptionsAdministratorElevationPromptBehavior = n.GetEnumValue<LocalSecurityOptionsAdministratorElevationPromptBehaviorType>(); } },
                {"localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares", n => { LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowPKU2UAuthenticationRequests", n => { LocalSecurityOptionsAllowPKU2UAuthenticationRequests = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", n => { LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager = n.GetStringValue(); } },
                {"localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool", n => { LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn", n => { LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUIAccessApplicationElevation", n => { LocalSecurityOptionsAllowUIAccessApplicationElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUIAccessApplicationsForSecureLocations", n => { LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations = n.GetBoolValue(); } },
                {"localSecurityOptionsAllowUndockWithoutHavingToLogon", n => { LocalSecurityOptionsAllowUndockWithoutHavingToLogon = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockMicrosoftAccounts", n => { LocalSecurityOptionsBlockMicrosoftAccounts = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockRemoteLogonWithBlankPassword", n => { LocalSecurityOptionsBlockRemoteLogonWithBlankPassword = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockRemoteOpticalDriveAccess", n => { LocalSecurityOptionsBlockRemoteOpticalDriveAccess = n.GetBoolValue(); } },
                {"localSecurityOptionsBlockUsersInstallingPrinterDrivers", n => { LocalSecurityOptionsBlockUsersInstallingPrinterDrivers = n.GetBoolValue(); } },
                {"localSecurityOptionsClearVirtualMemoryPageFile", n => { LocalSecurityOptionsClearVirtualMemoryPageFile = n.GetBoolValue(); } },
                {"localSecurityOptionsClientDigitallySignCommunicationsAlways", n => { LocalSecurityOptionsClientDigitallySignCommunicationsAlways = n.GetBoolValue(); } },
                {"localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers", n => { LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers = n.GetBoolValue(); } },
                {"localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation", n => { LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableAdministratorAccount", n => { LocalSecurityOptionsDisableAdministratorAccount = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees", n => { LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableGuestAccount", n => { LocalSecurityOptionsDisableGuestAccount = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableServerDigitallySignCommunicationsAlways", n => { LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways = n.GetBoolValue(); } },
                {"localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees", n => { LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts", n => { LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotRequireCtrlAltDel", n => { LocalSecurityOptionsDoNotRequireCtrlAltDel = n.GetBoolValue(); } },
                {"localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange", n => { LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange = n.GetBoolValue(); } },
                {"localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser", n => { LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser = n.GetEnumValue<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType>(); } },
                {"localSecurityOptionsGuestAccountName", n => { LocalSecurityOptionsGuestAccountName = n.GetStringValue(); } },
                {"localSecurityOptionsHideLastSignedInUser", n => { LocalSecurityOptionsHideLastSignedInUser = n.GetBoolValue(); } },
                {"localSecurityOptionsHideUsernameAtSignIn", n => { LocalSecurityOptionsHideUsernameAtSignIn = n.GetBoolValue(); } },
                {"localSecurityOptionsInformationDisplayedOnLockScreen", n => { LocalSecurityOptionsInformationDisplayedOnLockScreen = n.GetEnumValue<LocalSecurityOptionsInformationDisplayedOnLockScreenType>(); } },
                {"localSecurityOptionsInformationShownOnLockScreen", n => { LocalSecurityOptionsInformationShownOnLockScreen = n.GetEnumValue<LocalSecurityOptionsInformationShownOnLockScreenType>(); } },
                {"localSecurityOptionsLogOnMessageText", n => { LocalSecurityOptionsLogOnMessageText = n.GetStringValue(); } },
                {"localSecurityOptionsLogOnMessageTitle", n => { LocalSecurityOptionsLogOnMessageTitle = n.GetStringValue(); } },
                {"localSecurityOptionsMachineInactivityLimit", n => { LocalSecurityOptionsMachineInactivityLimit = n.GetIntValue(); } },
                {"localSecurityOptionsMachineInactivityLimitInMinutes", n => { LocalSecurityOptionsMachineInactivityLimitInMinutes = n.GetIntValue(); } },
                {"localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients", n => { LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients = n.GetEnumValue<LocalSecurityOptionsMinimumSessionSecurity>(); } },
                {"localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers", n => { LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers = n.GetEnumValue<LocalSecurityOptionsMinimumSessionSecurity>(); } },
                {"localSecurityOptionsOnlyElevateSignedExecutables", n => { LocalSecurityOptionsOnlyElevateSignedExecutables = n.GetBoolValue(); } },
                {"localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares", n => { LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares = n.GetBoolValue(); } },
                {"localSecurityOptionsSmartCardRemovalBehavior", n => { LocalSecurityOptionsSmartCardRemovalBehavior = n.GetEnumValue<LocalSecurityOptionsSmartCardRemovalBehaviorType>(); } },
                {"localSecurityOptionsStandardUserElevationPromptBehavior", n => { LocalSecurityOptionsStandardUserElevationPromptBehavior = n.GetEnumValue<LocalSecurityOptionsStandardUserElevationPromptBehaviorType>(); } },
                {"localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation", n => { LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation = n.GetBoolValue(); } },
                {"localSecurityOptionsUseAdminApprovalMode", n => { LocalSecurityOptionsUseAdminApprovalMode = n.GetBoolValue(); } },
                {"localSecurityOptionsUseAdminApprovalModeForAdministrators", n => { LocalSecurityOptionsUseAdminApprovalModeForAdministrators = n.GetBoolValue(); } },
                {"localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations", n => { LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations = n.GetBoolValue(); } },
                {"smartScreenBlockOverrideForFiles", n => { SmartScreenBlockOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableInShell", n => { SmartScreenEnableInShell = n.GetBoolValue(); } },
                {"userRightsAccessCredentialManagerAsTrustedCaller", n => { UserRightsAccessCredentialManagerAsTrustedCaller = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsActAsPartOfTheOperatingSystem", n => { UserRightsActAsPartOfTheOperatingSystem = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsAllowAccessFromNetwork", n => { UserRightsAllowAccessFromNetwork = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsBackupData", n => { UserRightsBackupData = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsBlockAccessFromNetwork", n => { UserRightsBlockAccessFromNetwork = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsChangeSystemTime", n => { UserRightsChangeSystemTime = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateGlobalObjects", n => { UserRightsCreateGlobalObjects = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreatePageFile", n => { UserRightsCreatePageFile = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreatePermanentSharedObjects", n => { UserRightsCreatePermanentSharedObjects = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateSymbolicLinks", n => { UserRightsCreateSymbolicLinks = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsCreateToken", n => { UserRightsCreateToken = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDebugPrograms", n => { UserRightsDebugPrograms = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDelegation", n => { UserRightsDelegation = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsDenyLocalLogOn", n => { UserRightsDenyLocalLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsGenerateSecurityAudits", n => { UserRightsGenerateSecurityAudits = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsImpersonateClient", n => { UserRightsImpersonateClient = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsIncreaseSchedulingPriority", n => { UserRightsIncreaseSchedulingPriority = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLoadUnloadDrivers", n => { UserRightsLoadUnloadDrivers = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLocalLogOn", n => { UserRightsLocalLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsLockMemory", n => { UserRightsLockMemory = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsManageAuditingAndSecurityLogs", n => { UserRightsManageAuditingAndSecurityLogs = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsManageVolumes", n => { UserRightsManageVolumes = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsModifyFirmwareEnvironment", n => { UserRightsModifyFirmwareEnvironment = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsModifyObjectLabels", n => { UserRightsModifyObjectLabels = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsProfileSingleProcess", n => { UserRightsProfileSingleProcess = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRemoteDesktopServicesLogOn", n => { UserRightsRemoteDesktopServicesLogOn = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRemoteShutdown", n => { UserRightsRemoteShutdown = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsRestoreData", n => { UserRightsRestoreData = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"userRightsTakeOwnership", n => { UserRightsTakeOwnership = n.GetObjectValue<DeviceManagementUserRightsSetting>(DeviceManagementUserRightsSetting.CreateFromDiscriminatorValue); } },
                {"windowsDefenderTamperProtection", n => { WindowsDefenderTamperProtection = n.GetEnumValue<WindowsDefenderTamperProtectionOptions>(); } },
                {"xboxServicesAccessoryManagementServiceStartupMode", n => { XboxServicesAccessoryManagementServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesEnableXboxGameSaveTask", n => { XboxServicesEnableXboxGameSaveTask = n.GetBoolValue(); } },
                {"xboxServicesLiveAuthManagerServiceStartupMode", n => { XboxServicesLiveAuthManagerServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesLiveGameSaveServiceStartupMode", n => { XboxServicesLiveGameSaveServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
                {"xboxServicesLiveNetworkingServiceStartupMode", n => { XboxServicesLiveNetworkingServiceStartupMode = n.GetEnumValue<ServiceStartType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applicationGuardAllowCameraMicrophoneRedirection", ApplicationGuardAllowCameraMicrophoneRedirection);
            writer.WriteBoolValue("applicationGuardAllowFileSaveOnHost", ApplicationGuardAllowFileSaveOnHost);
            writer.WriteBoolValue("applicationGuardAllowPersistence", ApplicationGuardAllowPersistence);
            writer.WriteBoolValue("applicationGuardAllowPrintToLocalPrinters", ApplicationGuardAllowPrintToLocalPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToNetworkPrinters", ApplicationGuardAllowPrintToNetworkPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToPDF", ApplicationGuardAllowPrintToPDF);
            writer.WriteBoolValue("applicationGuardAllowPrintToXPS", ApplicationGuardAllowPrintToXPS);
            writer.WriteBoolValue("applicationGuardAllowVirtualGPU", ApplicationGuardAllowVirtualGPU);
            writer.WriteEnumValue<ApplicationGuardBlockClipboardSharingType>("applicationGuardBlockClipboardSharing", ApplicationGuardBlockClipboardSharing);
            writer.WriteEnumValue<ApplicationGuardBlockFileTransferType>("applicationGuardBlockFileTransfer", ApplicationGuardBlockFileTransfer);
            writer.WriteBoolValue("applicationGuardBlockNonEnterpriseContent", ApplicationGuardBlockNonEnterpriseContent);
            writer.WriteCollectionOfPrimitiveValues<string>("applicationGuardCertificateThumbprints", ApplicationGuardCertificateThumbprints);
            writer.WriteBoolValue("applicationGuardEnabled", ApplicationGuardEnabled);
            writer.WriteEnumValue<ApplicationGuardEnabledOptions>("applicationGuardEnabledOptions", ApplicationGuardEnabledOptions);
            writer.WriteBoolValue("applicationGuardForceAuditing", ApplicationGuardForceAuditing);
            writer.WriteEnumValue<AppLockerApplicationControlType>("appLockerApplicationControl", AppLockerApplicationControl);
            writer.WriteBoolValue("bitLockerAllowStandardUserEncryption", BitLockerAllowStandardUserEncryption);
            writer.WriteBoolValue("bitLockerDisableWarningForOtherDiskEncryption", BitLockerDisableWarningForOtherDiskEncryption);
            writer.WriteBoolValue("bitLockerEnableStorageCardEncryptionOnMobile", BitLockerEnableStorageCardEncryptionOnMobile);
            writer.WriteBoolValue("bitLockerEncryptDevice", BitLockerEncryptDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerFixedDrivePolicy>("bitLockerFixedDrivePolicy", BitLockerFixedDrivePolicy);
            writer.WriteEnumValue<BitLockerRecoveryPasswordRotationType>("bitLockerRecoveryPasswordRotation", BitLockerRecoveryPasswordRotation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerRemovableDrivePolicy>("bitLockerRemovableDrivePolicy", BitLockerRemovableDrivePolicy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BitLockerSystemDrivePolicy>("bitLockerSystemDrivePolicy", BitLockerSystemDrivePolicy);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAdditionalGuardedFolders", DefenderAdditionalGuardedFolders);
            writer.WriteEnumValue<DefenderProtectionType>("defenderAdobeReaderLaunchChildProcess", DefenderAdobeReaderLaunchChildProcess);
            writer.WriteEnumValue<DefenderProtectionType>("defenderAdvancedRansomewareProtectionType", DefenderAdvancedRansomewareProtectionType);
            writer.WriteBoolValue("defenderAllowBehaviorMonitoring", DefenderAllowBehaviorMonitoring);
            writer.WriteBoolValue("defenderAllowCloudProtection", DefenderAllowCloudProtection);
            writer.WriteBoolValue("defenderAllowEndUserAccess", DefenderAllowEndUserAccess);
            writer.WriteBoolValue("defenderAllowIntrusionPreventionSystem", DefenderAllowIntrusionPreventionSystem);
            writer.WriteBoolValue("defenderAllowOnAccessProtection", DefenderAllowOnAccessProtection);
            writer.WriteBoolValue("defenderAllowRealTimeMonitoring", DefenderAllowRealTimeMonitoring);
            writer.WriteBoolValue("defenderAllowScanArchiveFiles", DefenderAllowScanArchiveFiles);
            writer.WriteBoolValue("defenderAllowScanDownloads", DefenderAllowScanDownloads);
            writer.WriteBoolValue("defenderAllowScanNetworkFiles", DefenderAllowScanNetworkFiles);
            writer.WriteBoolValue("defenderAllowScanRemovableDrivesDuringFullScan", DefenderAllowScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderAllowScanScriptsLoadedInInternetExplorer", DefenderAllowScanScriptsLoadedInInternetExplorer);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAttackSurfaceReductionExcludedPaths", DefenderAttackSurfaceReductionExcludedPaths);
            writer.WriteBoolValue("defenderBlockEndUserAccess", DefenderBlockEndUserAccess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderBlockPersistenceThroughWmiType", DefenderBlockPersistenceThroughWmiType);
            writer.WriteBoolValue("defenderCheckForSignaturesBeforeRunningScan", DefenderCheckForSignaturesBeforeRunningScan);
            writer.WriteEnumValue<DefenderCloudBlockLevelType>("defenderCloudBlockLevel", DefenderCloudBlockLevel);
            writer.WriteIntValue("defenderCloudExtendedTimeoutInSeconds", DefenderCloudExtendedTimeoutInSeconds);
            writer.WriteIntValue("defenderDaysBeforeDeletingQuarantinedMalware", DefenderDaysBeforeDeletingQuarantinedMalware);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefenderDetectedMalwareActions>("defenderDetectedMalwareActions", DefenderDetectedMalwareActions);
            writer.WriteBoolValue("defenderDisableBehaviorMonitoring", DefenderDisableBehaviorMonitoring);
            writer.WriteBoolValue("defenderDisableCatchupFullScan", DefenderDisableCatchupFullScan);
            writer.WriteBoolValue("defenderDisableCatchupQuickScan", DefenderDisableCatchupQuickScan);
            writer.WriteBoolValue("defenderDisableCloudProtection", DefenderDisableCloudProtection);
            writer.WriteBoolValue("defenderDisableIntrusionPreventionSystem", DefenderDisableIntrusionPreventionSystem);
            writer.WriteBoolValue("defenderDisableOnAccessProtection", DefenderDisableOnAccessProtection);
            writer.WriteBoolValue("defenderDisableRealTimeMonitoring", DefenderDisableRealTimeMonitoring);
            writer.WriteBoolValue("defenderDisableScanArchiveFiles", DefenderDisableScanArchiveFiles);
            writer.WriteBoolValue("defenderDisableScanDownloads", DefenderDisableScanDownloads);
            writer.WriteBoolValue("defenderDisableScanNetworkFiles", DefenderDisableScanNetworkFiles);
            writer.WriteBoolValue("defenderDisableScanRemovableDrivesDuringFullScan", DefenderDisableScanRemovableDrivesDuringFullScan);
            writer.WriteBoolValue("defenderDisableScanScriptsLoadedInInternetExplorer", DefenderDisableScanScriptsLoadedInInternetExplorer);
            writer.WriteEnumValue<DefenderProtectionType>("defenderEmailContentExecution", DefenderEmailContentExecution);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderEmailContentExecutionType", DefenderEmailContentExecutionType);
            writer.WriteBoolValue("defenderEnableLowCpuPriority", DefenderEnableLowCpuPriority);
            writer.WriteBoolValue("defenderEnableScanIncomingMail", DefenderEnableScanIncomingMail);
            writer.WriteBoolValue("defenderEnableScanMappedNetworkDrivesDuringFullScan", DefenderEnableScanMappedNetworkDrivesDuringFullScan);
            writer.WriteByteArrayValue("defenderExploitProtectionXml", DefenderExploitProtectionXml);
            writer.WriteStringValue("defenderExploitProtectionXmlFileName", DefenderExploitProtectionXmlFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFileExtensionsToExclude", DefenderFileExtensionsToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderFilesAndFoldersToExclude", DefenderFilesAndFoldersToExclude);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderGuardedFoldersAllowedAppPaths", DefenderGuardedFoldersAllowedAppPaths);
            writer.WriteEnumValue<FolderProtectionType>("defenderGuardMyFoldersType", DefenderGuardMyFoldersType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderNetworkProtectionType", DefenderNetworkProtectionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsExecutableContentCreationOrLaunch", DefenderOfficeAppsExecutableContentCreationOrLaunch);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsExecutableContentCreationOrLaunchType", DefenderOfficeAppsExecutableContentCreationOrLaunchType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsLaunchChildProcess", DefenderOfficeAppsLaunchChildProcess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsLaunchChildProcessType", DefenderOfficeAppsLaunchChildProcessType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeAppsOtherProcessInjection", DefenderOfficeAppsOtherProcessInjection);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeAppsOtherProcessInjectionType", DefenderOfficeAppsOtherProcessInjectionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeCommunicationAppsLaunchChildProcess", DefenderOfficeCommunicationAppsLaunchChildProcess);
            writer.WriteEnumValue<DefenderProtectionType>("defenderOfficeMacroCodeAllowWin32Imports", DefenderOfficeMacroCodeAllowWin32Imports);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderOfficeMacroCodeAllowWin32ImportsType", DefenderOfficeMacroCodeAllowWin32ImportsType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPotentiallyUnwantedAppAction", DefenderPotentiallyUnwantedAppAction);
            writer.WriteEnumValue<DefenderProtectionType>("defenderPreventCredentialStealingType", DefenderPreventCredentialStealingType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderProcessCreation", DefenderProcessCreation);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderProcessCreationType", DefenderProcessCreationType);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderProcessesToExclude", DefenderProcessesToExclude);
            writer.WriteEnumValue<DefenderRealtimeScanDirection>("defenderScanDirection", DefenderScanDirection);
            writer.WriteIntValue("defenderScanMaxCpuPercentage", DefenderScanMaxCpuPercentage);
            writer.WriteEnumValue<DefenderScanType>("defenderScanType", DefenderScanType);
            writer.WriteTimeValue("defenderScheduledQuickScanTime", DefenderScheduledQuickScanTime);
            writer.WriteEnumValue<WeeklySchedule>("defenderScheduledScanDay", DefenderScheduledScanDay);
            writer.WriteTimeValue("defenderScheduledScanTime", DefenderScheduledScanTime);
            writer.WriteEnumValue<DefenderProtectionType>("defenderScriptDownloadedPayloadExecution", DefenderScriptDownloadedPayloadExecution);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderScriptDownloadedPayloadExecutionType", DefenderScriptDownloadedPayloadExecutionType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderScriptObfuscatedMacroCode", DefenderScriptObfuscatedMacroCode);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderScriptObfuscatedMacroCodeType", DefenderScriptObfuscatedMacroCodeType);
            writer.WriteBoolValue("defenderSecurityCenterBlockExploitProtectionOverride", DefenderSecurityCenterBlockExploitProtectionOverride);
            writer.WriteBoolValue("defenderSecurityCenterDisableAccountUI", DefenderSecurityCenterDisableAccountUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableAppBrowserUI", DefenderSecurityCenterDisableAppBrowserUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableClearTpmUI", DefenderSecurityCenterDisableClearTpmUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableFamilyUI", DefenderSecurityCenterDisableFamilyUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableHardwareUI", DefenderSecurityCenterDisableHardwareUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableHealthUI", DefenderSecurityCenterDisableHealthUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableNetworkUI", DefenderSecurityCenterDisableNetworkUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableNotificationAreaUI", DefenderSecurityCenterDisableNotificationAreaUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableRansomwareUI", DefenderSecurityCenterDisableRansomwareUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableSecureBootUI", DefenderSecurityCenterDisableSecureBootUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableTroubleshootingUI", DefenderSecurityCenterDisableTroubleshootingUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableVirusUI", DefenderSecurityCenterDisableVirusUI);
            writer.WriteBoolValue("defenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI", DefenderSecurityCenterDisableVulnerableTpmFirmwareUpdateUI);
            writer.WriteStringValue("defenderSecurityCenterHelpEmail", DefenderSecurityCenterHelpEmail);
            writer.WriteStringValue("defenderSecurityCenterHelpPhone", DefenderSecurityCenterHelpPhone);
            writer.WriteStringValue("defenderSecurityCenterHelpURL", DefenderSecurityCenterHelpURL);
            writer.WriteEnumValue<DefenderSecurityCenterITContactDisplayType>("defenderSecurityCenterITContactDisplay", DefenderSecurityCenterITContactDisplay);
            writer.WriteEnumValue<DefenderSecurityCenterNotificationsFromAppType>("defenderSecurityCenterNotificationsFromApp", DefenderSecurityCenterNotificationsFromApp);
            writer.WriteStringValue("defenderSecurityCenterOrganizationDisplayName", DefenderSecurityCenterOrganizationDisplayName);
            writer.WriteIntValue("defenderSignatureUpdateIntervalInHours", DefenderSignatureUpdateIntervalInHours);
            writer.WriteEnumValue<DefenderSubmitSamplesConsentType>("defenderSubmitSamplesConsentType", DefenderSubmitSamplesConsentType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderUntrustedExecutable", DefenderUntrustedExecutable);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderUntrustedExecutableType", DefenderUntrustedExecutableType);
            writer.WriteEnumValue<DefenderProtectionType>("defenderUntrustedUSBProcess", DefenderUntrustedUSBProcess);
            writer.WriteEnumValue<DefenderAttackSurfaceType>("defenderUntrustedUSBProcessType", DefenderUntrustedUSBProcessType);
            writer.WriteBoolValue("deviceGuardEnableSecureBootWithDMA", DeviceGuardEnableSecureBootWithDMA);
            writer.WriteBoolValue("deviceGuardEnableVirtualizationBasedSecurity", DeviceGuardEnableVirtualizationBasedSecurity);
            writer.WriteEnumValue<Enablement>("deviceGuardLaunchSystemGuard", DeviceGuardLaunchSystemGuard);
            writer.WriteEnumValue<DeviceGuardLocalSystemAuthorityCredentialGuardType>("deviceGuardLocalSystemAuthorityCredentialGuardSettings", DeviceGuardLocalSystemAuthorityCredentialGuardSettings);
            writer.WriteEnumValue<SecureBootWithDMAType>("deviceGuardSecureBootWithDMA", DeviceGuardSecureBootWithDMA);
            writer.WriteEnumValue<DmaGuardDeviceEnumerationPolicyType>("dmaGuardDeviceEnumerationPolicy", DmaGuardDeviceEnumerationPolicy);
            writer.WriteBoolValue("firewallBlockStatefulFTP", FirewallBlockStatefulFTP);
            writer.WriteEnumValue<FirewallCertificateRevocationListCheckMethodType>("firewallCertificateRevocationListCheckMethod", FirewallCertificateRevocationListCheckMethod);
            writer.WriteIntValue("firewallIdleTimeoutForSecurityAssociationInSeconds", FirewallIdleTimeoutForSecurityAssociationInSeconds);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowDHCP", FirewallIPSecExemptionsAllowDHCP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowICMP", FirewallIPSecExemptionsAllowICMP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowNeighborDiscovery", FirewallIPSecExemptionsAllowNeighborDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowRouterDiscovery", FirewallIPSecExemptionsAllowRouterDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsNone", FirewallIPSecExemptionsNone);
            writer.WriteBoolValue("firewallMergeKeyingModuleSettings", FirewallMergeKeyingModuleSettings);
            writer.WriteEnumValue<FirewallPacketQueueingMethodType>("firewallPacketQueueingMethod", FirewallPacketQueueingMethod);
            writer.WriteEnumValue<FirewallPreSharedKeyEncodingMethodType>("firewallPreSharedKeyEncodingMethod", FirewallPreSharedKeyEncodingMethod);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfileDomain", FirewallProfileDomain);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePrivate", FirewallProfilePrivate);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePublic", FirewallProfilePublic);
            writer.WriteCollectionOfObjectValues<WindowsFirewallRule>("firewallRules", FirewallRules);
            writer.WriteEnumValue<LanManagerAuthenticationLevel>("lanManagerAuthenticationLevel", LanManagerAuthenticationLevel);
            writer.WriteBoolValue("lanManagerWorkstationDisableInsecureGuestLogons", LanManagerWorkstationDisableInsecureGuestLogons);
            writer.WriteStringValue("localSecurityOptionsAdministratorAccountName", LocalSecurityOptionsAdministratorAccountName);
            writer.WriteEnumValue<LocalSecurityOptionsAdministratorElevationPromptBehaviorType>("localSecurityOptionsAdministratorElevationPromptBehavior", LocalSecurityOptionsAdministratorElevationPromptBehavior);
            writer.WriteBoolValue("localSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares", LocalSecurityOptionsAllowAnonymousEnumerationOfSAMAccountsAndShares);
            writer.WriteBoolValue("localSecurityOptionsAllowPKU2UAuthenticationRequests", LocalSecurityOptionsAllowPKU2UAuthenticationRequests);
            writer.WriteStringValue("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManager", LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManager);
            writer.WriteBoolValue("localSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool", LocalSecurityOptionsAllowRemoteCallsToSecurityAccountsManagerHelperBool);
            writer.WriteBoolValue("localSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn", LocalSecurityOptionsAllowSystemToBeShutDownWithoutHavingToLogOn);
            writer.WriteBoolValue("localSecurityOptionsAllowUIAccessApplicationElevation", LocalSecurityOptionsAllowUIAccessApplicationElevation);
            writer.WriteBoolValue("localSecurityOptionsAllowUIAccessApplicationsForSecureLocations", LocalSecurityOptionsAllowUIAccessApplicationsForSecureLocations);
            writer.WriteBoolValue("localSecurityOptionsAllowUndockWithoutHavingToLogon", LocalSecurityOptionsAllowUndockWithoutHavingToLogon);
            writer.WriteBoolValue("localSecurityOptionsBlockMicrosoftAccounts", LocalSecurityOptionsBlockMicrosoftAccounts);
            writer.WriteBoolValue("localSecurityOptionsBlockRemoteLogonWithBlankPassword", LocalSecurityOptionsBlockRemoteLogonWithBlankPassword);
            writer.WriteBoolValue("localSecurityOptionsBlockRemoteOpticalDriveAccess", LocalSecurityOptionsBlockRemoteOpticalDriveAccess);
            writer.WriteBoolValue("localSecurityOptionsBlockUsersInstallingPrinterDrivers", LocalSecurityOptionsBlockUsersInstallingPrinterDrivers);
            writer.WriteBoolValue("localSecurityOptionsClearVirtualMemoryPageFile", LocalSecurityOptionsClearVirtualMemoryPageFile);
            writer.WriteBoolValue("localSecurityOptionsClientDigitallySignCommunicationsAlways", LocalSecurityOptionsClientDigitallySignCommunicationsAlways);
            writer.WriteBoolValue("localSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers", LocalSecurityOptionsClientSendUnencryptedPasswordToThirdPartySMBServers);
            writer.WriteBoolValue("localSecurityOptionsDetectApplicationInstallationsAndPromptForElevation", LocalSecurityOptionsDetectApplicationInstallationsAndPromptForElevation);
            writer.WriteBoolValue("localSecurityOptionsDisableAdministratorAccount", LocalSecurityOptionsDisableAdministratorAccount);
            writer.WriteBoolValue("localSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees", LocalSecurityOptionsDisableClientDigitallySignCommunicationsIfServerAgrees);
            writer.WriteBoolValue("localSecurityOptionsDisableGuestAccount", LocalSecurityOptionsDisableGuestAccount);
            writer.WriteBoolValue("localSecurityOptionsDisableServerDigitallySignCommunicationsAlways", LocalSecurityOptionsDisableServerDigitallySignCommunicationsAlways);
            writer.WriteBoolValue("localSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees", LocalSecurityOptionsDisableServerDigitallySignCommunicationsIfClientAgrees);
            writer.WriteBoolValue("localSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts", LocalSecurityOptionsDoNotAllowAnonymousEnumerationOfSAMAccounts);
            writer.WriteBoolValue("localSecurityOptionsDoNotRequireCtrlAltDel", LocalSecurityOptionsDoNotRequireCtrlAltDel);
            writer.WriteBoolValue("localSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange", LocalSecurityOptionsDoNotStoreLANManagerHashValueOnNextPasswordChange);
            writer.WriteEnumValue<LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUserType>("localSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser", LocalSecurityOptionsFormatAndEjectOfRemovableMediaAllowedUser);
            writer.WriteStringValue("localSecurityOptionsGuestAccountName", LocalSecurityOptionsGuestAccountName);
            writer.WriteBoolValue("localSecurityOptionsHideLastSignedInUser", LocalSecurityOptionsHideLastSignedInUser);
            writer.WriteBoolValue("localSecurityOptionsHideUsernameAtSignIn", LocalSecurityOptionsHideUsernameAtSignIn);
            writer.WriteEnumValue<LocalSecurityOptionsInformationDisplayedOnLockScreenType>("localSecurityOptionsInformationDisplayedOnLockScreen", LocalSecurityOptionsInformationDisplayedOnLockScreen);
            writer.WriteEnumValue<LocalSecurityOptionsInformationShownOnLockScreenType>("localSecurityOptionsInformationShownOnLockScreen", LocalSecurityOptionsInformationShownOnLockScreen);
            writer.WriteStringValue("localSecurityOptionsLogOnMessageText", LocalSecurityOptionsLogOnMessageText);
            writer.WriteStringValue("localSecurityOptionsLogOnMessageTitle", LocalSecurityOptionsLogOnMessageTitle);
            writer.WriteIntValue("localSecurityOptionsMachineInactivityLimit", LocalSecurityOptionsMachineInactivityLimit);
            writer.WriteIntValue("localSecurityOptionsMachineInactivityLimitInMinutes", LocalSecurityOptionsMachineInactivityLimitInMinutes);
            writer.WriteEnumValue<LocalSecurityOptionsMinimumSessionSecurity>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients", LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedClients);
            writer.WriteEnumValue<LocalSecurityOptionsMinimumSessionSecurity>("localSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers", LocalSecurityOptionsMinimumSessionSecurityForNtlmSspBasedServers);
            writer.WriteBoolValue("localSecurityOptionsOnlyElevateSignedExecutables", LocalSecurityOptionsOnlyElevateSignedExecutables);
            writer.WriteBoolValue("localSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares", LocalSecurityOptionsRestrictAnonymousAccessToNamedPipesAndShares);
            writer.WriteEnumValue<LocalSecurityOptionsSmartCardRemovalBehaviorType>("localSecurityOptionsSmartCardRemovalBehavior", LocalSecurityOptionsSmartCardRemovalBehavior);
            writer.WriteEnumValue<LocalSecurityOptionsStandardUserElevationPromptBehaviorType>("localSecurityOptionsStandardUserElevationPromptBehavior", LocalSecurityOptionsStandardUserElevationPromptBehavior);
            writer.WriteBoolValue("localSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation", LocalSecurityOptionsSwitchToSecureDesktopWhenPromptingForElevation);
            writer.WriteBoolValue("localSecurityOptionsUseAdminApprovalMode", LocalSecurityOptionsUseAdminApprovalMode);
            writer.WriteBoolValue("localSecurityOptionsUseAdminApprovalModeForAdministrators", LocalSecurityOptionsUseAdminApprovalModeForAdministrators);
            writer.WriteBoolValue("localSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations", LocalSecurityOptionsVirtualizeFileAndRegistryWriteFailuresToPerUserLocations);
            writer.WriteBoolValue("smartScreenBlockOverrideForFiles", SmartScreenBlockOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableInShell", SmartScreenEnableInShell);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsAccessCredentialManagerAsTrustedCaller", UserRightsAccessCredentialManagerAsTrustedCaller);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsActAsPartOfTheOperatingSystem", UserRightsActAsPartOfTheOperatingSystem);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsAllowAccessFromNetwork", UserRightsAllowAccessFromNetwork);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsBackupData", UserRightsBackupData);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsBlockAccessFromNetwork", UserRightsBlockAccessFromNetwork);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsChangeSystemTime", UserRightsChangeSystemTime);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateGlobalObjects", UserRightsCreateGlobalObjects);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreatePageFile", UserRightsCreatePageFile);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreatePermanentSharedObjects", UserRightsCreatePermanentSharedObjects);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateSymbolicLinks", UserRightsCreateSymbolicLinks);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsCreateToken", UserRightsCreateToken);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDebugPrograms", UserRightsDebugPrograms);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDelegation", UserRightsDelegation);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsDenyLocalLogOn", UserRightsDenyLocalLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsGenerateSecurityAudits", UserRightsGenerateSecurityAudits);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsImpersonateClient", UserRightsImpersonateClient);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsIncreaseSchedulingPriority", UserRightsIncreaseSchedulingPriority);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLoadUnloadDrivers", UserRightsLoadUnloadDrivers);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLocalLogOn", UserRightsLocalLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsLockMemory", UserRightsLockMemory);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsManageAuditingAndSecurityLogs", UserRightsManageAuditingAndSecurityLogs);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsManageVolumes", UserRightsManageVolumes);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsModifyFirmwareEnvironment", UserRightsModifyFirmwareEnvironment);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsModifyObjectLabels", UserRightsModifyObjectLabels);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsProfileSingleProcess", UserRightsProfileSingleProcess);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRemoteDesktopServicesLogOn", UserRightsRemoteDesktopServicesLogOn);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRemoteShutdown", UserRightsRemoteShutdown);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsRestoreData", UserRightsRestoreData);
            writer.WriteObjectValue<DeviceManagementUserRightsSetting>("userRightsTakeOwnership", UserRightsTakeOwnership);
            writer.WriteEnumValue<WindowsDefenderTamperProtectionOptions>("windowsDefenderTamperProtection", WindowsDefenderTamperProtection);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesAccessoryManagementServiceStartupMode", XboxServicesAccessoryManagementServiceStartupMode);
            writer.WriteBoolValue("xboxServicesEnableXboxGameSaveTask", XboxServicesEnableXboxGameSaveTask);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveAuthManagerServiceStartupMode", XboxServicesLiveAuthManagerServiceStartupMode);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveGameSaveServiceStartupMode", XboxServicesLiveGameSaveServiceStartupMode);
            writer.WriteEnumValue<ServiceStartType>("xboxServicesLiveNetworkingServiceStartupMode", XboxServicesLiveNetworkingServiceStartupMode);
        }
    }
}
