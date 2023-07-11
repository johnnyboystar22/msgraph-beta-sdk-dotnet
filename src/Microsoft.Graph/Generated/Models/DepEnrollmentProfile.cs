using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The depEnrollmentProfile resource represents an Apple Device Enrollment Program (DEP) enrollment profile. This type of profile must be assigned to Apple DEP serial numbers before the corresponding devices can enroll via DEP.
    /// </summary>
    public class DepEnrollmentProfile : EnrollmentProfile, IParsable {
        /// <summary>Indicates if Apple id setup pane is disabled</summary>
        public bool? AppleIdDisabled {
            get { return BackingStore?.Get<bool?>("appleIdDisabled"); }
            set { BackingStore?.Set("appleIdDisabled", value); }
        }
        /// <summary>Indicates if Apple pay setup pane is disabled</summary>
        public bool? ApplePayDisabled {
            get { return BackingStore?.Get<bool?>("applePayDisabled"); }
            set { BackingStore?.Set("applePayDisabled", value); }
        }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation {
            get { return BackingStore?.Get<bool?>("awaitDeviceConfiguredConfirmation"); }
            set { BackingStore?.Set("awaitDeviceConfiguredConfirmation", value); }
        }
        /// <summary>Indicates if diagnostics setup pane is disabled</summary>
        public bool? DiagnosticsDisabled {
            get { return BackingStore?.Get<bool?>("diagnosticsDisabled"); }
            set { BackingStore?.Set("diagnosticsDisabled", value); }
        }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad {
            get { return BackingStore?.Get<bool?>("enableSharedIPad"); }
            set { BackingStore?.Set("enableSharedIPad", value); }
        }
        /// <summary>Indicates if this is the default profile</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Indicates if the profile is mandatory</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>("isMandatory"); }
            set { BackingStore?.Set("isMandatory", value); }
        }
        /// <summary>The iTunesPairingMode property</summary>
        public Microsoft.Graph.Beta.Models.ITunesPairingMode? ITunesPairingMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ITunesPairingMode?>("iTunesPairingMode"); }
            set { BackingStore?.Set("iTunesPairingMode", value); }
        }
        /// <summary>Indicates if Location service setup pane is disabled</summary>
        public bool? LocationDisabled {
            get { return BackingStore?.Get<bool?>("locationDisabled"); }
            set { BackingStore?.Set("locationDisabled", value); }
        }
        /// <summary>Indicates if Mac OS file vault is disabled</summary>
        public bool? MacOSFileVaultDisabled {
            get { return BackingStore?.Get<bool?>("macOSFileVaultDisabled"); }
            set { BackingStore?.Set("macOSFileVaultDisabled", value); }
        }
        /// <summary>Indicates if Mac OS registration is disabled</summary>
        public bool? MacOSRegistrationDisabled {
            get { return BackingStore?.Get<bool?>("macOSRegistrationDisabled"); }
            set { BackingStore?.Set("macOSRegistrationDisabled", value); }
        }
        /// <summary>Management certificates for Apple Configurator</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementCertificateWithThumbprint>? ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>?>("managementCertificates"); }
            set { BackingStore?.Set("managementCertificates", value); }
        }
#nullable restore
#else
        public List<ManagementCertificateWithThumbprint> ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>>("managementCertificates"); }
            set { BackingStore?.Set("managementCertificates", value); }
        }
#endif
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>("passCodeDisabled"); }
            set { BackingStore?.Set("passCodeDisabled", value); }
        }
        /// <summary>Indicates if the profile removal option is disabled</summary>
        public bool? ProfileRemovalDisabled {
            get { return BackingStore?.Get<bool?>("profileRemovalDisabled"); }
            set { BackingStore?.Set("profileRemovalDisabled", value); }
        }
        /// <summary>Indicates if Restore setup pane is blocked</summary>
        public bool? RestoreBlocked {
            get { return BackingStore?.Get<bool?>("restoreBlocked"); }
            set { BackingStore?.Set("restoreBlocked", value); }
        }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled {
            get { return BackingStore?.Get<bool?>("restoreFromAndroidDisabled"); }
            set { BackingStore?.Set("restoreFromAndroidDisabled", value); }
        }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount {
            get { return BackingStore?.Get<int?>("sharedIPadMaximumUserCount"); }
            set { BackingStore?.Set("sharedIPadMaximumUserCount", value); }
        }
        /// <summary>Indicates if siri setup pane is disabled</summary>
        public bool? SiriDisabled {
            get { return BackingStore?.Get<bool?>("siriDisabled"); }
            set { BackingStore?.Set("siriDisabled", value); }
        }
        /// <summary>Supervised mode, True to enable, false otherwise. See https://learn.microsoft.com/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.</summary>
        public bool? SupervisedModeEnabled {
            get { return BackingStore?.Get<bool?>("supervisedModeEnabled"); }
            set { BackingStore?.Set("supervisedModeEnabled", value); }
        }
        /// <summary>Support department information</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportDepartment {
            get { return BackingStore?.Get<string?>("supportDepartment"); }
            set { BackingStore?.Set("supportDepartment", value); }
        }
#nullable restore
#else
        public string SupportDepartment {
            get { return BackingStore?.Get<string>("supportDepartment"); }
            set { BackingStore?.Set("supportDepartment", value); }
        }
#endif
        /// <summary>Support phone number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupportPhoneNumber {
            get { return BackingStore?.Get<string?>("supportPhoneNumber"); }
            set { BackingStore?.Set("supportPhoneNumber", value); }
        }
#nullable restore
#else
        public string SupportPhoneNumber {
            get { return BackingStore?.Get<string>("supportPhoneNumber"); }
            set { BackingStore?.Set("supportPhoneNumber", value); }
        }
#endif
        /// <summary>Indicates if &apos;Terms and Conditions&apos; setup pane is disabled</summary>
        public bool? TermsAndConditionsDisabled {
            get { return BackingStore?.Get<bool?>("termsAndConditionsDisabled"); }
            set { BackingStore?.Set("termsAndConditionsDisabled", value); }
        }
        /// <summary>Indicates if touch id setup pane is disabled</summary>
        public bool? TouchIdDisabled {
            get { return BackingStore?.Get<bool?>("touchIdDisabled"); }
            set { BackingStore?.Set("touchIdDisabled", value); }
        }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled {
            get { return BackingStore?.Get<bool?>("zoomDisabled"); }
            set { BackingStore?.Set("zoomDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new depEnrollmentProfile and sets the default values.
        /// </summary>
        public DepEnrollmentProfile() : base() {
            OdataType = "#microsoft.graph.depEnrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DepEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleIdDisabled", n => { AppleIdDisabled = n.GetBoolValue(); } },
                {"applePayDisabled", n => { ApplePayDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"diagnosticsDisabled", n => { DiagnosticsDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"locationDisabled", n => { LocationDisabled = n.GetBoolValue(); } },
                {"macOSFileVaultDisabled", n => { MacOSFileVaultDisabled = n.GetBoolValue(); } },
                {"macOSRegistrationDisabled", n => { MacOSRegistrationDisabled = n.GetBoolValue(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"profileRemovalDisabled", n => { ProfileRemovalDisabled = n.GetBoolValue(); } },
                {"restoreBlocked", n => { RestoreBlocked = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"siriDisabled", n => { SiriDisabled = n.GetBoolValue(); } },
                {"supervisedModeEnabled", n => { SupervisedModeEnabled = n.GetBoolValue(); } },
                {"supportDepartment", n => { SupportDepartment = n.GetStringValue(); } },
                {"supportPhoneNumber", n => { SupportPhoneNumber = n.GetStringValue(); } },
                {"termsAndConditionsDisabled", n => { TermsAndConditionsDisabled = n.GetBoolValue(); } },
                {"touchIdDisabled", n => { TouchIdDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appleIdDisabled", AppleIdDisabled);
            writer.WriteBoolValue("applePayDisabled", ApplePayDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteBoolValue("diagnosticsDisabled", DiagnosticsDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMandatory", IsMandatory);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteBoolValue("locationDisabled", LocationDisabled);
            writer.WriteBoolValue("macOSFileVaultDisabled", MacOSFileVaultDisabled);
            writer.WriteBoolValue("macOSRegistrationDisabled", MacOSRegistrationDisabled);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteBoolValue("profileRemovalDisabled", ProfileRemovalDisabled);
            writer.WriteBoolValue("restoreBlocked", RestoreBlocked);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("siriDisabled", SiriDisabled);
            writer.WriteBoolValue("supervisedModeEnabled", SupervisedModeEnabled);
            writer.WriteStringValue("supportDepartment", SupportDepartment);
            writer.WriteStringValue("supportPhoneNumber", SupportPhoneNumber);
            writer.WriteBoolValue("termsAndConditionsDisabled", TermsAndConditionsDisabled);
            writer.WriteBoolValue("touchIdDisabled", TouchIdDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
