using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Encryption report per device
    /// </summary>
    public class ManagedDeviceEncryptionState : Entity, IParsable {
        /// <summary>Advanced BitLocker State. Possible values are: success, noUserConsent, osVolumeUnprotected, osVolumeTpmRequired, osVolumeTpmOnlyRequired, osVolumeTpmPinRequired, osVolumeTpmStartupKeyRequired, osVolumeTpmPinStartupKeyRequired, osVolumeEncryptionMethodMismatch, recoveryKeyBackupFailed, fixedDriveNotEncrypted, fixedDriveEncryptionMethodMismatch, loggedOnUserNonAdmin, windowsRecoveryEnvironmentNotConfigured, tpmNotAvailable, tpmNotReady, networkError.</summary>
        public AdvancedBitLockerState? AdvancedBitLockerStates {
            get { return BackingStore?.Get<AdvancedBitLockerState?>("advancedBitLockerStates"); }
            set { BackingStore?.Set("advancedBitLockerStates", value); }
        }
        /// <summary>Device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>Device type.</summary>
        public DeviceTypes? DeviceType {
            get { return BackingStore?.Get<DeviceTypes?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
        /// <summary>The encryptionPolicySettingState property</summary>
        public ComplianceStatus? EncryptionPolicySettingState {
            get { return BackingStore?.Get<ComplianceStatus?>("encryptionPolicySettingState"); }
            set { BackingStore?.Set("encryptionPolicySettingState", value); }
        }
        /// <summary>Encryption readiness state</summary>
        public Microsoft.Graph.Beta.Models.EncryptionReadinessState? EncryptionReadinessState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptionReadinessState?>("encryptionReadinessState"); }
            set { BackingStore?.Set("encryptionReadinessState", value); }
        }
        /// <summary>Encryption state</summary>
        public Microsoft.Graph.Beta.Models.EncryptionState? EncryptionState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptionState?>("encryptionState"); }
            set { BackingStore?.Set("encryptionState", value); }
        }
        /// <summary>FileVault State. Possible values are: success, driveEncryptedByUser, userDeferredEncryption, escrowNotEnabled.</summary>
        public FileVaultState? FileVaultStates {
            get { return BackingStore?.Get<FileVaultState?>("fileVaultStates"); }
            set { BackingStore?.Set("fileVaultStates", value); }
        }
        /// <summary>Operating system version of the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>Policy Details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EncryptionReportPolicyDetails>? PolicyDetails {
            get { return BackingStore?.Get<List<EncryptionReportPolicyDetails>?>("policyDetails"); }
            set { BackingStore?.Set("policyDetails", value); }
        }
#nullable restore
#else
        public List<EncryptionReportPolicyDetails> PolicyDetails {
            get { return BackingStore?.Get<List<EncryptionReportPolicyDetails>>("policyDetails"); }
            set { BackingStore?.Set("policyDetails", value); }
        }
#endif
        /// <summary>Device TPM Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TpmSpecificationVersion {
            get { return BackingStore?.Get<string?>("tpmSpecificationVersion"); }
            set { BackingStore?.Set("tpmSpecificationVersion", value); }
        }
#nullable restore
#else
        public string TpmSpecificationVersion {
            get { return BackingStore?.Get<string>("tpmSpecificationVersion"); }
            set { BackingStore?.Set("tpmSpecificationVersion", value); }
        }
#endif
        /// <summary>User name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDeviceEncryptionState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceEncryptionState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedBitLockerStates", n => { AdvancedBitLockerStates = n.GetEnumValue<AdvancedBitLockerState>(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetEnumValue<DeviceTypes>(); } },
                {"encryptionPolicySettingState", n => { EncryptionPolicySettingState = n.GetEnumValue<ComplianceStatus>(); } },
                {"encryptionReadinessState", n => { EncryptionReadinessState = n.GetEnumValue<EncryptionReadinessState>(); } },
                {"encryptionState", n => { EncryptionState = n.GetEnumValue<EncryptionState>(); } },
                {"fileVaultStates", n => { FileVaultStates = n.GetEnumValue<FileVaultState>(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"policyDetails", n => { PolicyDetails = n.GetCollectionOfObjectValues<EncryptionReportPolicyDetails>(EncryptionReportPolicyDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tpmSpecificationVersion", n => { TpmSpecificationVersion = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AdvancedBitLockerState>("advancedBitLockerStates", AdvancedBitLockerStates);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DeviceTypes>("deviceType", DeviceType);
            writer.WriteEnumValue<ComplianceStatus>("encryptionPolicySettingState", EncryptionPolicySettingState);
            writer.WriteEnumValue<EncryptionReadinessState>("encryptionReadinessState", EncryptionReadinessState);
            writer.WriteEnumValue<EncryptionState>("encryptionState", EncryptionState);
            writer.WriteEnumValue<FileVaultState>("fileVaultStates", FileVaultStates);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteCollectionOfObjectValues<EncryptionReportPolicyDetails>("policyDetails", PolicyDetails);
            writer.WriteStringValue("tpmSpecificationVersion", TpmSpecificationVersion);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
