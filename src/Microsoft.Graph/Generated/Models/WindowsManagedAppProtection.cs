using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsManagedAppProtection : ManagedAppPolicy, IParsable {
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public WindowsManagedAppDataTransferLevel? AllowedInboundDataTransferSources {
            get { return BackingStore?.Get<WindowsManagedAppDataTransferLevel?>("allowedInboundDataTransferSources"); }
            set { BackingStore?.Set("allowedInboundDataTransferSources", value); }
        }
        /// <summary>Represents the level to which the device&apos;s clipboard may be shared between apps</summary>
        public WindowsManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel {
            get { return BackingStore?.Get<WindowsManagedAppClipboardSharingLevel?>("allowedOutboundClipboardSharingLevel"); }
            set { BackingStore?.Set("allowedOutboundClipboardSharingLevel", value); }
        }
        /// <summary>Data can be transferred from/to these classes of apps</summary>
        public WindowsManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations {
            get { return BackingStore?.Get<WindowsManagedAppDataTransferLevel?>("allowedOutboundDataTransferDestinations"); }
            set { BackingStore?.Set("allowedOutboundDataTransferDestinations", value); }
        }
        /// <summary>If set, it will specify what action to take in the case where the user is unable to checkin because their authentication token is invalid. This happens when the user is deleted or disabled in AAD. Some possible values are block or wipe. If this property is not set, no action will be taken. Possible values are: block, wipe, warn.</summary>
        public ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfUnableToAuthenticateUser"); }
            set { BackingStore?.Set("appActionIfUnableToAuthenticateUser", value); }
        }
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>?>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#nullable restore
#else
        public List<ManagedMobileApp> Apps {
            get { return BackingStore?.Get<List<ManagedMobileApp>>("apps"); }
            set { BackingStore?.Set("apps", value); }
        }
#endif
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetedManagedAppPolicyAssignment>? Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<TargetedManagedAppPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<TargetedManagedAppPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Indicates the total number of applications for which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>When TRUE, indicates that the policy is deployed to some inclusion groups. When FALSE, indicates that the policy is not deployed to any inclusion groups. Default value is FALSE.</summary>
        public bool? IsAssigned {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>The maxium threat level allowed for an app to be compliant.</summary>
        public ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel {
            get { return BackingStore?.Get<ManagedAppDeviceThreatLevel?>("maximumAllowedDeviceThreatLevel"); }
            set { BackingStore?.Set("maximumAllowedDeviceThreatLevel", value); }
        }
        /// <summary>Versions bigger than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaximumRequiredOsVersion {
            get { return BackingStore?.Get<string?>("maximumRequiredOsVersion"); }
            set { BackingStore?.Set("maximumRequiredOsVersion", value); }
        }
#nullable restore
#else
        public string MaximumRequiredOsVersion {
            get { return BackingStore?.Get<string>("maximumRequiredOsVersion"); }
            set { BackingStore?.Set("maximumRequiredOsVersion", value); }
        }
#endif
        /// <summary>Versions bigger than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaximumWarningOsVersion {
            get { return BackingStore?.Get<string?>("maximumWarningOsVersion"); }
            set { BackingStore?.Set("maximumWarningOsVersion", value); }
        }
#nullable restore
#else
        public string MaximumWarningOsVersion {
            get { return BackingStore?.Get<string>("maximumWarningOsVersion"); }
            set { BackingStore?.Set("maximumWarningOsVersion", value); }
        }
#endif
        /// <summary>Versions bigger than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaximumWipeOsVersion {
            get { return BackingStore?.Get<string?>("maximumWipeOsVersion"); }
            set { BackingStore?.Set("maximumWipeOsVersion", value); }
        }
#nullable restore
#else
        public string MaximumWipeOsVersion {
            get { return BackingStore?.Get<string>("maximumWipeOsVersion"); }
            set { BackingStore?.Set("maximumWipeOsVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredAppVersion"); }
            set { BackingStore?.Set("minimumRequiredAppVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredAppVersion {
            get { return BackingStore?.Get<string>("minimumRequiredAppVersion"); }
            set { BackingStore?.Set("minimumRequiredAppVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredOsVersion"); }
            set { BackingStore?.Set("minimumRequiredOsVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredOsVersion {
            get { return BackingStore?.Get<string>("minimumRequiredOsVersion"); }
            set { BackingStore?.Set("minimumRequiredOsVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string?>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumRequiredSdkVersion {
            get { return BackingStore?.Get<string>("minimumRequiredSdkVersion"); }
            set { BackingStore?.Set("minimumRequiredSdkVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningAppVersion {
            get { return BackingStore?.Get<string?>("minimumWarningAppVersion"); }
            set { BackingStore?.Set("minimumWarningAppVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningAppVersion {
            get { return BackingStore?.Get<string>("minimumWarningAppVersion"); }
            set { BackingStore?.Set("minimumWarningAppVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningOsVersion {
            get { return BackingStore?.Get<string?>("minimumWarningOsVersion"); }
            set { BackingStore?.Set("minimumWarningOsVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningOsVersion {
            get { return BackingStore?.Get<string>("minimumWarningOsVersion"); }
            set { BackingStore?.Set("minimumWarningOsVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeAppVersion {
            get { return BackingStore?.Get<string?>("minimumWipeAppVersion"); }
            set { BackingStore?.Set("minimumWipeAppVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeAppVersion {
            get { return BackingStore?.Get<string>("minimumWipeAppVersion"); }
            set { BackingStore?.Set("minimumWipeAppVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeOsVersion {
            get { return BackingStore?.Get<string?>("minimumWipeOsVersion"); }
            set { BackingStore?.Set("minimumWipeOsVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeOsVersion {
            get { return BackingStore?.Get<string>("minimumWipeOsVersion"); }
            set { BackingStore?.Set("minimumWipeOsVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will wipe the managed app and the associated company data. For example: &apos;8.1.0&apos; or &apos;13.1.1&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string?>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWipeSdkVersion {
            get { return BackingStore?.Get<string>("minimumWipeSdkVersion"); }
            set { BackingStore?.Set("minimumWipeSdkVersion", value); }
        }
#endif
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? MobileThreatDefenseRemediationAction {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("mobileThreatDefenseRemediationAction"); }
            set { BackingStore?.Set("mobileThreatDefenseRemediationAction", value); }
        }
        /// <summary>The period after which access is checked when the device is not connected to the internet. For example, PT5M indicates that the interval is 5 minutes in duration. A timespan value of PT0S indicates that access will be blocked immediately when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeAccessCheck {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeAccessCheck"); }
            set { BackingStore?.Set("periodOfflineBeforeAccessCheck", value); }
        }
        /// <summary>The amount of time an app is allowed to remain disconnected from the internet before all managed data it is wiped. For example, P5D indicates that the interval is 5 days in duration. A timespan value of PT0S indicates that managed data will never be wiped when the device is not connected to the internet.</summary>
        public TimeSpan? PeriodOfflineBeforeWipeIsEnforced {
            get { return BackingStore?.Get<TimeSpan?>("periodOfflineBeforeWipeIsEnforced"); }
            set { BackingStore?.Set("periodOfflineBeforeWipeIsEnforced", value); }
        }
        /// <summary>When TRUE, indicates that printing is blocked from managed apps. When FALSE, indicates that printing is allowed from managed apps. Default value is FALSE.</summary>
        public bool? PrintBlocked {
            get { return BackingStore?.Get<bool?>("printBlocked"); }
            set { BackingStore?.Set("printBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsManagedAppProtection and sets the default values.
        /// </summary>
        public WindowsManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.windowsManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedInboundDataTransferSources", n => { AllowedInboundDataTransferSources = n.GetEnumValue<WindowsManagedAppDataTransferLevel>(); } },
                {"allowedOutboundClipboardSharingLevel", n => { AllowedOutboundClipboardSharingLevel = n.GetEnumValue<WindowsManagedAppClipboardSharingLevel>(); } },
                {"allowedOutboundDataTransferDestinations", n => { AllowedOutboundDataTransferDestinations = n.GetEnumValue<WindowsManagedAppDataTransferLevel>(); } },
                {"appActionIfUnableToAuthenticateUser", n => { AppActionIfUnableToAuthenticateUser = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                {"maximumAllowedDeviceThreatLevel", n => { MaximumAllowedDeviceThreatLevel = n.GetEnumValue<ManagedAppDeviceThreatLevel>(); } },
                {"maximumRequiredOsVersion", n => { MaximumRequiredOsVersion = n.GetStringValue(); } },
                {"maximumWarningOsVersion", n => { MaximumWarningOsVersion = n.GetStringValue(); } },
                {"maximumWipeOsVersion", n => { MaximumWipeOsVersion = n.GetStringValue(); } },
                {"minimumRequiredAppVersion", n => { MinimumRequiredAppVersion = n.GetStringValue(); } },
                {"minimumRequiredOsVersion", n => { MinimumRequiredOsVersion = n.GetStringValue(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningAppVersion", n => { MinimumWarningAppVersion = n.GetStringValue(); } },
                {"minimumWarningOsVersion", n => { MinimumWarningOsVersion = n.GetStringValue(); } },
                {"minimumWipeAppVersion", n => { MinimumWipeAppVersion = n.GetStringValue(); } },
                {"minimumWipeOsVersion", n => { MinimumWipeOsVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"mobileThreatDefenseRemediationAction", n => { MobileThreatDefenseRemediationAction = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"periodOfflineBeforeAccessCheck", n => { PeriodOfflineBeforeAccessCheck = n.GetTimeSpanValue(); } },
                {"periodOfflineBeforeWipeIsEnforced", n => { PeriodOfflineBeforeWipeIsEnforced = n.GetTimeSpanValue(); } },
                {"printBlocked", n => { PrintBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsManagedAppDataTransferLevel>("allowedInboundDataTransferSources", AllowedInboundDataTransferSources);
            writer.WriteEnumValue<WindowsManagedAppClipboardSharingLevel>("allowedOutboundClipboardSharingLevel", AllowedOutboundClipboardSharingLevel);
            writer.WriteEnumValue<WindowsManagedAppDataTransferLevel>("allowedOutboundDataTransferDestinations", AllowedOutboundDataTransferDestinations);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfUnableToAuthenticateUser", AppActionIfUnableToAuthenticateUser);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteEnumValue<ManagedAppDeviceThreatLevel>("maximumAllowedDeviceThreatLevel", MaximumAllowedDeviceThreatLevel);
            writer.WriteStringValue("maximumRequiredOsVersion", MaximumRequiredOsVersion);
            writer.WriteStringValue("maximumWarningOsVersion", MaximumWarningOsVersion);
            writer.WriteStringValue("maximumWipeOsVersion", MaximumWipeOsVersion);
            writer.WriteStringValue("minimumRequiredAppVersion", MinimumRequiredAppVersion);
            writer.WriteStringValue("minimumRequiredOsVersion", MinimumRequiredOsVersion);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningAppVersion", MinimumWarningAppVersion);
            writer.WriteStringValue("minimumWarningOsVersion", MinimumWarningOsVersion);
            writer.WriteStringValue("minimumWipeAppVersion", MinimumWipeAppVersion);
            writer.WriteStringValue("minimumWipeOsVersion", MinimumWipeOsVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteEnumValue<ManagedAppRemediationAction>("mobileThreatDefenseRemediationAction", MobileThreatDefenseRemediationAction);
            writer.WriteTimeSpanValue("periodOfflineBeforeAccessCheck", PeriodOfflineBeforeAccessCheck);
            writer.WriteTimeSpanValue("periodOfflineBeforeWipeIsEnforced", PeriodOfflineBeforeWipeIsEnforced);
            writer.WriteBoolValue("printBlocked", PrintBlocked);
        }
    }
}
