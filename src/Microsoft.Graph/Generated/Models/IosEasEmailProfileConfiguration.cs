using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class IosEasEmailProfileConfiguration : EasEmailProfileConfigurationBase, IParsable {
        /// <summary>Account name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName {
            get { return BackingStore?.Get<string?>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#nullable restore
#else
        public string AccountName {
            get { return BackingStore?.Get<string>("accountName"); }
            set { BackingStore?.Set("accountName", value); }
        }
#endif
        /// <summary>Authentication method for this Email profile. Possible values are: usernameAndPassword, certificate, derivedCredential.</summary>
        public EasAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<EasAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Indicates whether or not to block moving messages to other email accounts.</summary>
        public bool? BlockMovingMessagesToOtherEmailAccounts {
            get { return BackingStore?.Get<bool?>("blockMovingMessagesToOtherEmailAccounts"); }
            set { BackingStore?.Set("blockMovingMessagesToOtherEmailAccounts", value); }
        }
        /// <summary>Indicates whether or not to block sending email from third party apps.</summary>
        public bool? BlockSendingEmailFromThirdPartyApps {
            get { return BackingStore?.Get<bool?>("blockSendingEmailFromThirdPartyApps"); }
            set { BackingStore?.Set("blockSendingEmailFromThirdPartyApps", value); }
        }
        /// <summary>Indicates whether or not to block syncing recently used email addresses, for instance - when composing new email.</summary>
        public bool? BlockSyncingRecentlyUsedEmailAddresses {
            get { return BackingStore?.Get<bool?>("blockSyncingRecentlyUsedEmailAddresses"); }
            set { BackingStore?.Set("blockSyncingRecentlyUsedEmailAddresses", value); }
        }
        /// <summary>Tenant level settings for the Derived Credentials to be used for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementDerivedCredentialSettings? DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings?>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#nullable restore
#else
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings"); }
            set { BackingStore?.Set("derivedCredentialSettings", value); }
        }
#endif
        /// <summary>Possible values for email sync duration.</summary>
        public EmailSyncDuration? DurationOfEmailToSync {
            get { return BackingStore?.Get<EmailSyncDuration?>("durationOfEmailToSync"); }
            set { BackingStore?.Set("durationOfEmailToSync", value); }
        }
        /// <summary>Exchange data to sync. Possible values are: none, calendars, contacts, email, notes, reminders.</summary>
        public Microsoft.Graph.Beta.Models.EasServices? EasServices {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EasServices?>("easServices"); }
            set { BackingStore?.Set("easServices", value); }
        }
        /// <summary>Allow users to change sync settings.</summary>
        public bool? EasServicesUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>("easServicesUserOverrideEnabled"); }
            set { BackingStore?.Set("easServicesUserOverrideEnabled", value); }
        }
        /// <summary>Possible values for username source or email source.</summary>
        public UserEmailSource? EmailAddressSource {
            get { return BackingStore?.Get<UserEmailSource?>("emailAddressSource"); }
            set { BackingStore?.Set("emailAddressSource", value); }
        }
        /// <summary>Encryption Certificate type for this Email profile. Possible values are: none, certificate, derivedCredential.</summary>
        public EmailCertificateType? EncryptionCertificateType {
            get { return BackingStore?.Get<EmailCertificateType?>("encryptionCertificateType"); }
            set { BackingStore?.Set("encryptionCertificateType", value); }
        }
        /// <summary>Exchange location that (URL) that the native mail app connects to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostName {
            get { return BackingStore?.Get<string?>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#nullable restore
#else
        public string HostName {
            get { return BackingStore?.Get<string>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#endif
        /// <summary>Identity certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosCertificateProfileBase? IdentityCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase?>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#nullable restore
#else
        public IosCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
#endif
        /// <summary>Profile ID of the Per-App VPN policy to be used to access emails from the native Mail client</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PerAppVPNProfileId {
            get { return BackingStore?.Get<string?>("perAppVPNProfileId"); }
            set { BackingStore?.Set("perAppVPNProfileId", value); }
        }
#nullable restore
#else
        public string PerAppVPNProfileId {
            get { return BackingStore?.Get<string>("perAppVPNProfileId"); }
            set { BackingStore?.Set("perAppVPNProfileId", value); }
        }
#endif
        /// <summary>Indicates whether or not to use S/MIME certificate.</summary>
        public bool? RequireSmime {
            get { return BackingStore?.Get<bool?>("requireSmime"); }
            set { BackingStore?.Set("requireSmime", value); }
        }
        /// <summary>Indicates whether or not to use SSL.</summary>
        public bool? RequireSsl {
            get { return BackingStore?.Get<bool?>("requireSsl"); }
            set { BackingStore?.Set("requireSsl", value); }
        }
        /// <summary>Signing Certificate type for this Email profile. Possible values are: none, certificate, derivedCredential.</summary>
        public EmailCertificateType? SigningCertificateType {
            get { return BackingStore?.Get<EmailCertificateType?>("signingCertificateType"); }
            set { BackingStore?.Set("signingCertificateType", value); }
        }
        /// <summary>Indicates whether or not to allow unencrypted emails.</summary>
        public bool? SmimeEnablePerMessageSwitch {
            get { return BackingStore?.Get<bool?>("smimeEnablePerMessageSwitch"); }
            set { BackingStore?.Set("smimeEnablePerMessageSwitch", value); }
        }
        /// <summary>If set to true S/MIME encryption is enabled by default.</summary>
        public bool? SmimeEncryptByDefaultEnabled {
            get { return BackingStore?.Get<bool?>("smimeEncryptByDefaultEnabled"); }
            set { BackingStore?.Set("smimeEncryptByDefaultEnabled", value); }
        }
        /// <summary>If set to true, the user can toggle the encryption by default setting.</summary>
        public bool? SmimeEncryptByDefaultUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>("smimeEncryptByDefaultUserOverrideEnabled"); }
            set { BackingStore?.Set("smimeEncryptByDefaultUserOverrideEnabled", value); }
        }
        /// <summary>S/MIME encryption certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosCertificateProfile? SmimeEncryptionCertificate {
            get { return BackingStore?.Get<IosCertificateProfile?>("smimeEncryptionCertificate"); }
            set { BackingStore?.Set("smimeEncryptionCertificate", value); }
        }
#nullable restore
#else
        public IosCertificateProfile SmimeEncryptionCertificate {
            get { return BackingStore?.Get<IosCertificateProfile>("smimeEncryptionCertificate"); }
            set { BackingStore?.Set("smimeEncryptionCertificate", value); }
        }
#endif
        /// <summary>If set to true the user can select the S/MIME encryption identity.</summary>
        public bool? SmimeEncryptionCertificateUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>("smimeEncryptionCertificateUserOverrideEnabled"); }
            set { BackingStore?.Set("smimeEncryptionCertificateUserOverrideEnabled", value); }
        }
        /// <summary>S/MIME signing certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosCertificateProfile? SmimeSigningCertificate {
            get { return BackingStore?.Get<IosCertificateProfile?>("smimeSigningCertificate"); }
            set { BackingStore?.Set("smimeSigningCertificate", value); }
        }
#nullable restore
#else
        public IosCertificateProfile SmimeSigningCertificate {
            get { return BackingStore?.Get<IosCertificateProfile>("smimeSigningCertificate"); }
            set { BackingStore?.Set("smimeSigningCertificate", value); }
        }
#endif
        /// <summary>If set to true, the user can select the signing identity.</summary>
        public bool? SmimeSigningCertificateUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>("smimeSigningCertificateUserOverrideEnabled"); }
            set { BackingStore?.Set("smimeSigningCertificateUserOverrideEnabled", value); }
        }
        /// <summary>If set to true S/MIME signing is enabled for this account</summary>
        public bool? SmimeSigningEnabled {
            get { return BackingStore?.Get<bool?>("smimeSigningEnabled"); }
            set { BackingStore?.Set("smimeSigningEnabled", value); }
        }
        /// <summary>If set to true, the user can toggle S/MIME signing on or off.</summary>
        public bool? SmimeSigningUserOverrideEnabled {
            get { return BackingStore?.Get<bool?>("smimeSigningUserOverrideEnabled"); }
            set { BackingStore?.Set("smimeSigningUserOverrideEnabled", value); }
        }
        /// <summary>Specifies whether the connection should use OAuth for authentication.</summary>
        public bool? UseOAuth {
            get { return BackingStore?.Get<bool?>("useOAuth"); }
            set { BackingStore?.Set("useOAuth", value); }
        }
        /// <summary>
        /// Instantiates a new IosEasEmailProfileConfiguration and sets the default values.
        /// </summary>
        public IosEasEmailProfileConfiguration() : base() {
            OdataType = "#microsoft.graph.iosEasEmailProfileConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosEasEmailProfileConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosEasEmailProfileConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<EasAuthenticationMethod>(); } },
                {"blockMovingMessagesToOtherEmailAccounts", n => { BlockMovingMessagesToOtherEmailAccounts = n.GetBoolValue(); } },
                {"blockSendingEmailFromThirdPartyApps", n => { BlockSendingEmailFromThirdPartyApps = n.GetBoolValue(); } },
                {"blockSyncingRecentlyUsedEmailAddresses", n => { BlockSyncingRecentlyUsedEmailAddresses = n.GetBoolValue(); } },
                {"derivedCredentialSettings", n => { DerivedCredentialSettings = n.GetObjectValue<DeviceManagementDerivedCredentialSettings>(DeviceManagementDerivedCredentialSettings.CreateFromDiscriminatorValue); } },
                {"durationOfEmailToSync", n => { DurationOfEmailToSync = n.GetEnumValue<EmailSyncDuration>(); } },
                {"easServices", n => { EasServices = n.GetEnumValue<EasServices>(); } },
                {"easServicesUserOverrideEnabled", n => { EasServicesUserOverrideEnabled = n.GetBoolValue(); } },
                {"emailAddressSource", n => { EmailAddressSource = n.GetEnumValue<UserEmailSource>(); } },
                {"encryptionCertificateType", n => { EncryptionCertificateType = n.GetEnumValue<EmailCertificateType>(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"perAppVPNProfileId", n => { PerAppVPNProfileId = n.GetStringValue(); } },
                {"requireSmime", n => { RequireSmime = n.GetBoolValue(); } },
                {"requireSsl", n => { RequireSsl = n.GetBoolValue(); } },
                {"signingCertificateType", n => { SigningCertificateType = n.GetEnumValue<EmailCertificateType>(); } },
                {"smimeEnablePerMessageSwitch", n => { SmimeEnablePerMessageSwitch = n.GetBoolValue(); } },
                {"smimeEncryptByDefaultEnabled", n => { SmimeEncryptByDefaultEnabled = n.GetBoolValue(); } },
                {"smimeEncryptByDefaultUserOverrideEnabled", n => { SmimeEncryptByDefaultUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeEncryptionCertificate", n => { SmimeEncryptionCertificate = n.GetObjectValue<IosCertificateProfile>(IosCertificateProfile.CreateFromDiscriminatorValue); } },
                {"smimeEncryptionCertificateUserOverrideEnabled", n => { SmimeEncryptionCertificateUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeSigningCertificate", n => { SmimeSigningCertificate = n.GetObjectValue<IosCertificateProfile>(IosCertificateProfile.CreateFromDiscriminatorValue); } },
                {"smimeSigningCertificateUserOverrideEnabled", n => { SmimeSigningCertificateUserOverrideEnabled = n.GetBoolValue(); } },
                {"smimeSigningEnabled", n => { SmimeSigningEnabled = n.GetBoolValue(); } },
                {"smimeSigningUserOverrideEnabled", n => { SmimeSigningUserOverrideEnabled = n.GetBoolValue(); } },
                {"useOAuth", n => { UseOAuth = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteEnumValue<EasAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteBoolValue("blockMovingMessagesToOtherEmailAccounts", BlockMovingMessagesToOtherEmailAccounts);
            writer.WriteBoolValue("blockSendingEmailFromThirdPartyApps", BlockSendingEmailFromThirdPartyApps);
            writer.WriteBoolValue("blockSyncingRecentlyUsedEmailAddresses", BlockSyncingRecentlyUsedEmailAddresses);
            writer.WriteObjectValue<DeviceManagementDerivedCredentialSettings>("derivedCredentialSettings", DerivedCredentialSettings);
            writer.WriteEnumValue<EmailSyncDuration>("durationOfEmailToSync", DurationOfEmailToSync);
            writer.WriteEnumValue<EasServices>("easServices", EasServices);
            writer.WriteBoolValue("easServicesUserOverrideEnabled", EasServicesUserOverrideEnabled);
            writer.WriteEnumValue<UserEmailSource>("emailAddressSource", EmailAddressSource);
            writer.WriteEnumValue<EmailCertificateType>("encryptionCertificateType", EncryptionCertificateType);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("perAppVPNProfileId", PerAppVPNProfileId);
            writer.WriteBoolValue("requireSmime", RequireSmime);
            writer.WriteBoolValue("requireSsl", RequireSsl);
            writer.WriteEnumValue<EmailCertificateType>("signingCertificateType", SigningCertificateType);
            writer.WriteBoolValue("smimeEnablePerMessageSwitch", SmimeEnablePerMessageSwitch);
            writer.WriteBoolValue("smimeEncryptByDefaultEnabled", SmimeEncryptByDefaultEnabled);
            writer.WriteBoolValue("smimeEncryptByDefaultUserOverrideEnabled", SmimeEncryptByDefaultUserOverrideEnabled);
            writer.WriteObjectValue<IosCertificateProfile>("smimeEncryptionCertificate", SmimeEncryptionCertificate);
            writer.WriteBoolValue("smimeEncryptionCertificateUserOverrideEnabled", SmimeEncryptionCertificateUserOverrideEnabled);
            writer.WriteObjectValue<IosCertificateProfile>("smimeSigningCertificate", SmimeSigningCertificate);
            writer.WriteBoolValue("smimeSigningCertificateUserOverrideEnabled", SmimeSigningCertificateUserOverrideEnabled);
            writer.WriteBoolValue("smimeSigningEnabled", SmimeSigningEnabled);
            writer.WriteBoolValue("smimeSigningUserOverrideEnabled", SmimeSigningUserOverrideEnabled);
            writer.WriteBoolValue("useOAuth", UseOAuth);
        }
    }
}
