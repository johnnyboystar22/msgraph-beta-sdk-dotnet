using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Policy used to configure detailed management settings targeted to specific security groups and for a specified set of apps on an iOS device
    /// </summary>
    public class IosManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>Semicolon seperated list of device models allowed, as a string, for the managed app to work.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AllowedIosDeviceModels {
            get { return BackingStore?.Get<string?>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#nullable restore
#else
        public string AllowedIosDeviceModels {
            get { return BackingStore?.Get<string>("allowedIosDeviceModels"); }
            set { BackingStore?.Set("allowedIosDeviceModels", value); }
        }
#endif
        /// <summary>An admin initiated action to be applied on a managed app.</summary>
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed {
            get { return BackingStore?.Get<ManagedAppRemediationAction?>("appActionIfIosDeviceModelNotAllowed"); }
            set { BackingStore?.Set("appActionIfIosDeviceModelNotAllowed", value); }
        }
        /// <summary>Represents the level to which app data is encrypted for managed apps</summary>
        public ManagedAppDataEncryptionType? AppDataEncryptionType {
            get { return BackingStore?.Get<ManagedAppDataEncryptionType?>("appDataEncryptionType"); }
            set { BackingStore?.Set("appDataEncryptionType", value); }
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
        /// <summary>A custom browser protocol to open weblink on iOS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserProtocol {
            get { return BackingStore?.Get<string?>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#nullable restore
#else
        public string CustomBrowserProtocol {
            get { return BackingStore?.Get<string>("customBrowserProtocol"); }
            set { BackingStore?.Set("customBrowserProtocol", value); }
        }
#endif
        /// <summary>Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDialerAppProtocol {
            get { return BackingStore?.Get<string?>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#nullable restore
#else
        public string CustomDialerAppProtocol {
            get { return BackingStore?.Get<string>("customDialerAppProtocol"); }
            set { BackingStore?.Set("customDialerAppProtocol", value); }
        }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount {
            get { return BackingStore?.Get<int?>("deployedAppCount"); }
            set { BackingStore?.Set("deployedAppCount", value); }
        }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary?>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary {
            get { return BackingStore?.Get<ManagedAppPolicyDeploymentSummary>("deploymentSummary"); }
            set { BackingStore?.Set("deploymentSummary", value); }
        }
#endif
        /// <summary>Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.</summary>
        public bool? DisableProtectionOfManagedOutboundOpenInData {
            get { return BackingStore?.Get<bool?>("disableProtectionOfManagedOutboundOpenInData"); }
            set { BackingStore?.Set("disableProtectionOfManagedOutboundOpenInData", value); }
        }
        /// <summary>Apps in this list will be exempt from the policy and will be able to receive data from managed apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>?>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> ExemptedAppProtocols {
            get { return BackingStore?.Get<List<KeyValuePair>>("exemptedAppProtocols"); }
            set { BackingStore?.Set("exemptedAppProtocols", value); }
        }
#endif
        /// <summary>A list of custom urls that are allowed to invocate an unmanaged app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExemptedUniversalLinks {
            get { return BackingStore?.Get<List<string>?>("exemptedUniversalLinks"); }
            set { BackingStore?.Set("exemptedUniversalLinks", value); }
        }
#nullable restore
#else
        public List<string> ExemptedUniversalLinks {
            get { return BackingStore?.Get<List<string>>("exemptedUniversalLinks"); }
            set { BackingStore?.Set("exemptedUniversalLinks", value); }
        }
#endif
        /// <summary>Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.</summary>
        public bool? FaceIdBlocked {
            get { return BackingStore?.Get<bool?>("faceIdBlocked"); }
            set { BackingStore?.Set("faceIdBlocked", value); }
        }
        /// <summary>Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.</summary>
        public bool? FilterOpenInToOnlyManagedApps {
            get { return BackingStore?.Get<bool?>("filterOpenInToOnlyManagedApps"); }
            set { BackingStore?.Set("filterOpenInToOnlyManagedApps", value); }
        }
        /// <summary>A list of custom urls that are allowed to invocate a managed app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedUniversalLinks {
            get { return BackingStore?.Get<List<string>?>("managedUniversalLinks"); }
            set { BackingStore?.Set("managedUniversalLinks", value); }
        }
#nullable restore
#else
        public List<string> ManagedUniversalLinks {
            get { return BackingStore?.Get<List<string>>("managedUniversalLinks"); }
            set { BackingStore?.Set("managedUniversalLinks", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
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
        /// <summary>Versions less than the specified version will result in warning message on the managed app from accessing company data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningSdkVersion {
            get { return BackingStore?.Get<string?>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#nullable restore
#else
        public string MinimumWarningSdkVersion {
            get { return BackingStore?.Get<string>("minimumWarningSdkVersion"); }
            set { BackingStore?.Set("minimumWarningSdkVersion", value); }
        }
#endif
        /// <summary>Versions less than the specified version will block the managed app from accessing company data.</summary>
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
        /// <summary>Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.</summary>
        public bool? ProtectInboundDataFromUnknownSources {
            get { return BackingStore?.Get<bool?>("protectInboundDataFromUnknownSources"); }
            set { BackingStore?.Set("protectInboundDataFromUnknownSources", value); }
        }
        /// <summary>Defines if third party keyboards are allowed while accessing a managed app</summary>
        public bool? ThirdPartyKeyboardsBlocked {
            get { return BackingStore?.Get<bool?>("thirdPartyKeyboardsBlocked"); }
            set { BackingStore?.Set("thirdPartyKeyboardsBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new iosManagedAppProtection and sets the default values.
        /// </summary>
        public IosManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.iosManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedIosDeviceModels", n => { AllowedIosDeviceModels = n.GetStringValue(); } },
                {"appActionIfIosDeviceModelNotAllowed", n => { AppActionIfIosDeviceModelNotAllowed = n.GetEnumValue<ManagedAppRemediationAction>(); } },
                {"appDataEncryptionType", n => { AppDataEncryptionType = n.GetEnumValue<ManagedAppDataEncryptionType>(); } },
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customBrowserProtocol", n => { CustomBrowserProtocol = n.GetStringValue(); } },
                {"customDialerAppProtocol", n => { CustomDialerAppProtocol = n.GetStringValue(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"disableProtectionOfManagedOutboundOpenInData", n => { DisableProtectionOfManagedOutboundOpenInData = n.GetBoolValue(); } },
                {"exemptedAppProtocols", n => { ExemptedAppProtocols = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exemptedUniversalLinks", n => { ExemptedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"faceIdBlocked", n => { FaceIdBlocked = n.GetBoolValue(); } },
                {"filterOpenInToOnlyManagedApps", n => { FilterOpenInToOnlyManagedApps = n.GetBoolValue(); } },
                {"managedUniversalLinks", n => { ManagedUniversalLinks = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"minimumRequiredSdkVersion", n => { MinimumRequiredSdkVersion = n.GetStringValue(); } },
                {"minimumWarningSdkVersion", n => { MinimumWarningSdkVersion = n.GetStringValue(); } },
                {"minimumWipeSdkVersion", n => { MinimumWipeSdkVersion = n.GetStringValue(); } },
                {"protectInboundDataFromUnknownSources", n => { ProtectInboundDataFromUnknownSources = n.GetBoolValue(); } },
                {"thirdPartyKeyboardsBlocked", n => { ThirdPartyKeyboardsBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("allowedIosDeviceModels", AllowedIosDeviceModels);
            writer.WriteEnumValue<ManagedAppRemediationAction>("appActionIfIosDeviceModelNotAllowed", AppActionIfIosDeviceModelNotAllowed);
            writer.WriteEnumValue<ManagedAppDataEncryptionType>("appDataEncryptionType", AppDataEncryptionType);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserProtocol", CustomBrowserProtocol);
            writer.WriteStringValue("customDialerAppProtocol", CustomDialerAppProtocol);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableProtectionOfManagedOutboundOpenInData", DisableProtectionOfManagedOutboundOpenInData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("exemptedAppProtocols", ExemptedAppProtocols);
            writer.WriteCollectionOfPrimitiveValues<string>("exemptedUniversalLinks", ExemptedUniversalLinks);
            writer.WriteBoolValue("faceIdBlocked", FaceIdBlocked);
            writer.WriteBoolValue("filterOpenInToOnlyManagedApps", FilterOpenInToOnlyManagedApps);
            writer.WriteCollectionOfPrimitiveValues<string>("managedUniversalLinks", ManagedUniversalLinks);
            writer.WriteStringValue("minimumRequiredSdkVersion", MinimumRequiredSdkVersion);
            writer.WriteStringValue("minimumWarningSdkVersion", MinimumWarningSdkVersion);
            writer.WriteStringValue("minimumWipeSdkVersion", MinimumWipeSdkVersion);
            writer.WriteBoolValue("protectInboundDataFromUnknownSources", ProtectInboundDataFromUnknownSources);
            writer.WriteBoolValue("thirdPartyKeyboardsBlocked", ThirdPartyKeyboardsBlocked);
        }
    }
}
