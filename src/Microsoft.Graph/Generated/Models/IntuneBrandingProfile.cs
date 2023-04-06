using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This entity contains data which is used in customizing the tenant level appearance of the Company Portal applications as well as the end user web portal.
    /// </summary>
    public class IntuneBrandingProfile : Entity, IParsable {
        /// <summary>The list of group assignments for the branding profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IntuneBrandingProfileAssignment>? Assignments {
            get { return BackingStore?.Get<List<IntuneBrandingProfileAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<IntuneBrandingProfileAssignment> Assignments {
            get { return BackingStore?.Get<List<IntuneBrandingProfileAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Collection of blocked actions on the company portal as per platform and device ownership types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CompanyPortalBlockedAction>? CompanyPortalBlockedActions {
            get { return BackingStore?.Get<List<CompanyPortalBlockedAction>?>("companyPortalBlockedActions"); }
            set { BackingStore?.Set("companyPortalBlockedActions", value); }
        }
#nullable restore
#else
        public List<CompanyPortalBlockedAction> CompanyPortalBlockedActions {
            get { return BackingStore?.Get<List<CompanyPortalBlockedAction>>("companyPortalBlockedActions"); }
            set { BackingStore?.Set("companyPortalBlockedActions", value); }
        }
#endif
        /// <summary>E-mail address of the person/organization responsible for IT support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITEmailAddress {
            get { return BackingStore?.Get<string?>("contactITEmailAddress"); }
            set { BackingStore?.Set("contactITEmailAddress", value); }
        }
#nullable restore
#else
        public string ContactITEmailAddress {
            get { return BackingStore?.Get<string>("contactITEmailAddress"); }
            set { BackingStore?.Set("contactITEmailAddress", value); }
        }
#endif
        /// <summary>Name of the person/organization responsible for IT support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITName {
            get { return BackingStore?.Get<string?>("contactITName"); }
            set { BackingStore?.Set("contactITName", value); }
        }
#nullable restore
#else
        public string ContactITName {
            get { return BackingStore?.Get<string>("contactITName"); }
            set { BackingStore?.Set("contactITName", value); }
        }
#endif
        /// <summary>Text comments regarding the person/organization responsible for IT support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITNotes {
            get { return BackingStore?.Get<string?>("contactITNotes"); }
            set { BackingStore?.Set("contactITNotes", value); }
        }
#nullable restore
#else
        public string ContactITNotes {
            get { return BackingStore?.Get<string>("contactITNotes"); }
            set { BackingStore?.Set("contactITNotes", value); }
        }
#endif
        /// <summary>Phone number of the person/organization responsible for IT support</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITPhoneNumber {
            get { return BackingStore?.Get<string?>("contactITPhoneNumber"); }
            set { BackingStore?.Set("contactITPhoneNumber", value); }
        }
#nullable restore
#else
        public string ContactITPhoneNumber {
            get { return BackingStore?.Get<string>("contactITPhoneNumber"); }
            set { BackingStore?.Set("contactITPhoneNumber", value); }
        }
#endif
        /// <summary>Time when the BrandingProfile was created</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Text comments regarding what the admin has access to on the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCanSeePrivacyMessage {
            get { return BackingStore?.Get<string?>("customCanSeePrivacyMessage"); }
            set { BackingStore?.Set("customCanSeePrivacyMessage", value); }
        }
#nullable restore
#else
        public string CustomCanSeePrivacyMessage {
            get { return BackingStore?.Get<string>("customCanSeePrivacyMessage"); }
            set { BackingStore?.Set("customCanSeePrivacyMessage", value); }
        }
#endif
        /// <summary>Text comments regarding what the admin doesn&apos;t have access to on the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomCantSeePrivacyMessage {
            get { return BackingStore?.Get<string?>("customCantSeePrivacyMessage"); }
            set { BackingStore?.Set("customCantSeePrivacyMessage", value); }
        }
#nullable restore
#else
        public string CustomCantSeePrivacyMessage {
            get { return BackingStore?.Get<string>("customCantSeePrivacyMessage"); }
            set { BackingStore?.Set("customCantSeePrivacyMessage", value); }
        }
#endif
        /// <summary>Text comments regarding what the admin doesn&apos;t have access to on the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomPrivacyMessage {
            get { return BackingStore?.Get<string?>("customPrivacyMessage"); }
            set { BackingStore?.Set("customPrivacyMessage", value); }
        }
#nullable restore
#else
        public string CustomPrivacyMessage {
            get { return BackingStore?.Get<string>("customPrivacyMessage"); }
            set { BackingStore?.Set("customPrivacyMessage", value); }
        }
#endif
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry {
            get { return BackingStore?.Get<bool?>("disableClientTelemetry"); }
            set { BackingStore?.Set("disableClientTelemetry", value); }
        }
        /// <summary>Boolean that indicates if Device Category Selection will be shown in Company Portal</summary>
        public bool? DisableDeviceCategorySelection {
            get { return BackingStore?.Get<bool?>("disableDeviceCategorySelection"); }
            set { BackingStore?.Set("disableDeviceCategorySelection", value); }
        }
        /// <summary>Company/organization name that is displayed to end users</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Options available for enrollment flow customization</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability {
            get { return BackingStore?.Get<EnrollmentAvailabilityOptions?>("enrollmentAvailability"); }
            set { BackingStore?.Set("enrollmentAvailability", value); }
        }
        /// <summary>Boolean that represents whether the profile is used as default or not</summary>
        public bool? IsDefaultProfile {
            get { return BackingStore?.Get<bool?>("isDefaultProfile"); }
            set { BackingStore?.Set("isDefaultProfile", value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Factory Reset&apos; action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled {
            get { return BackingStore?.Get<bool?>("isFactoryResetDisabled"); }
            set { BackingStore?.Set("isFactoryResetDisabled", value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Remove Device&apos; action on corporate owned devices.</summary>
        public bool? IsRemoveDeviceDisabled {
            get { return BackingStore?.Get<bool?>("isRemoveDeviceDisabled"); }
            set { BackingStore?.Set("isRemoveDeviceDisabled", value); }
        }
        /// <summary>Customized image displayed in Company Portal apps landing page</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LandingPageCustomizedImage {
            get { return BackingStore?.Get<MimeContent?>("landingPageCustomizedImage"); }
            set { BackingStore?.Set("landingPageCustomizedImage", value); }
        }
#nullable restore
#else
        public MimeContent LandingPageCustomizedImage {
            get { return BackingStore?.Get<MimeContent>("landingPageCustomizedImage"); }
            set { BackingStore?.Set("landingPageCustomizedImage", value); }
        }
#endif
        /// <summary>Time when the BrandingProfile was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent?>("lightBackgroundLogo"); }
            set { BackingStore?.Set("lightBackgroundLogo", value); }
        }
#nullable restore
#else
        public MimeContent LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>("lightBackgroundLogo"); }
            set { BackingStore?.Set("lightBackgroundLogo", value); }
        }
#endif
        /// <summary>Display name of the company/organization’s IT helpdesk site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteName {
            get { return BackingStore?.Get<string?>("onlineSupportSiteName"); }
            set { BackingStore?.Set("onlineSupportSiteName", value); }
        }
#nullable restore
#else
        public string OnlineSupportSiteName {
            get { return BackingStore?.Get<string>("onlineSupportSiteName"); }
            set { BackingStore?.Set("onlineSupportSiteName", value); }
        }
#endif
        /// <summary>URL to the company/organization’s IT helpdesk site</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string?>("onlineSupportSiteUrl"); }
            set { BackingStore?.Set("onlineSupportSiteUrl", value); }
        }
#nullable restore
#else
        public string OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string>("onlineSupportSiteUrl"); }
            set { BackingStore?.Set("onlineSupportSiteUrl", value); }
        }
#endif
        /// <summary>URL to the company/organization’s privacy policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyUrl {
            get { return BackingStore?.Get<string?>("privacyUrl"); }
            set { BackingStore?.Set("privacyUrl", value); }
        }
#nullable restore
#else
        public string PrivacyUrl {
            get { return BackingStore?.Get<string>("privacyUrl"); }
            set { BackingStore?.Set("privacyUrl", value); }
        }
#endif
        /// <summary>Description of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileDescription {
            get { return BackingStore?.Get<string?>("profileDescription"); }
            set { BackingStore?.Set("profileDescription", value); }
        }
#nullable restore
#else
        public string ProfileDescription {
            get { return BackingStore?.Get<string>("profileDescription"); }
            set { BackingStore?.Set("profileDescription", value); }
        }
#endif
        /// <summary>Name of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileName {
            get { return BackingStore?.Get<string?>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#nullable restore
#else
        public string ProfileName {
            get { return BackingStore?.Get<string>("profileName"); }
            set { BackingStore?.Set("profileName", value); }
        }
#endif
        /// <summary>List of scope tags assigned to the branding profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate</summary>
        public bool? SendDeviceOwnershipChangePushNotification {
            get { return BackingStore?.Get<bool?>("sendDeviceOwnershipChangePushNotification"); }
            set { BackingStore?.Set("sendDeviceOwnershipChangePushNotification", value); }
        }
        /// <summary>Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal</summary>
        public bool? ShowAzureADEnterpriseApps {
            get { return BackingStore?.Get<bool?>("showAzureADEnterpriseApps"); }
            set { BackingStore?.Set("showAzureADEnterpriseApps", value); }
        }
        /// <summary>Boolean that indicates if Configuration Manager Apps will be shown in Company Portal</summary>
        public bool? ShowConfigurationManagerApps {
            get { return BackingStore?.Get<bool?>("showConfigurationManagerApps"); }
            set { BackingStore?.Set("showConfigurationManagerApps", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not</summary>
        public bool? ShowDisplayNameNextToLogo {
            get { return BackingStore?.Get<bool?>("showDisplayNameNextToLogo"); }
            set { BackingStore?.Set("showDisplayNameNextToLogo", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not</summary>
        public bool? ShowLogo {
            get { return BackingStore?.Get<bool?>("showLogo"); }
            set { BackingStore?.Set("showLogo", value); }
        }
        /// <summary>Boolean that indicates if Office WebApps will be shown in Company Portal</summary>
        public bool? ShowOfficeWebApps {
            get { return BackingStore?.Get<bool?>("showOfficeWebApps"); }
            set { BackingStore?.Set("showOfficeWebApps", value); }
        }
        /// <summary>Primary theme color used in the Company Portal applications and web portal</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RgbColor? ThemeColor {
            get { return BackingStore?.Get<RgbColor?>("themeColor"); }
            set { BackingStore?.Set("themeColor", value); }
        }
#nullable restore
#else
        public RgbColor ThemeColor {
            get { return BackingStore?.Get<RgbColor>("themeColor"); }
            set { BackingStore?.Set("themeColor", value); }
        }
#endif
        /// <summary>Logo image displayed in Company Portal apps which have a theme color background behind the logo</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? ThemeColorLogo {
            get { return BackingStore?.Get<MimeContent?>("themeColorLogo"); }
            set { BackingStore?.Set("themeColorLogo", value); }
        }
#nullable restore
#else
        public MimeContent ThemeColorLogo {
            get { return BackingStore?.Get<MimeContent>("themeColorLogo"); }
            set { BackingStore?.Set("themeColorLogo", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IntuneBrandingProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrandingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<IntuneBrandingProfileAssignment>(IntuneBrandingProfileAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"companyPortalBlockedActions", n => { CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>(CompanyPortalBlockedAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"customCanSeePrivacyMessage", n => { CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", n => { CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", n => { CustomPrivacyMessage = n.GetStringValue(); } },
                {"disableClientTelemetry", n => { DisableClientTelemetry = n.GetBoolValue(); } },
                {"disableDeviceCategorySelection", n => { DisableDeviceCategorySelection = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", n => { EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isDefaultProfile", n => { IsDefaultProfile = n.GetBoolValue(); } },
                {"isFactoryResetDisabled", n => { IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", n => { IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", n => { LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"profileDescription", n => { ProfileDescription = n.GetStringValue(); } },
                {"profileName", n => { ProfileName = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", n => { SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", n => { ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showConfigurationManagerApps", n => { ShowConfigurationManagerApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", n => { ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
                {"themeColorLogo", n => { ThemeColorLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IntuneBrandingProfileAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<CompanyPortalBlockedAction>("companyPortalBlockedActions", CompanyPortalBlockedActions);
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customCanSeePrivacyMessage", CustomCanSeePrivacyMessage);
            writer.WriteStringValue("customCantSeePrivacyMessage", CustomCantSeePrivacyMessage);
            writer.WriteStringValue("customPrivacyMessage", CustomPrivacyMessage);
            writer.WriteBoolValue("disableClientTelemetry", DisableClientTelemetry);
            writer.WriteBoolValue("disableDeviceCategorySelection", DisableDeviceCategorySelection);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentAvailabilityOptions>("enrollmentAvailability", EnrollmentAvailability);
            writer.WriteBoolValue("isDefaultProfile", IsDefaultProfile);
            writer.WriteBoolValue("isFactoryResetDisabled", IsFactoryResetDisabled);
            writer.WriteBoolValue("isRemoveDeviceDisabled", IsRemoveDeviceDisabled);
            writer.WriteObjectValue<MimeContent>("landingPageCustomizedImage", LandingPageCustomizedImage);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteStringValue("profileDescription", ProfileDescription);
            writer.WriteStringValue("profileName", ProfileName);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("sendDeviceOwnershipChangePushNotification", SendDeviceOwnershipChangePushNotification);
            writer.WriteBoolValue("showAzureADEnterpriseApps", ShowAzureADEnterpriseApps);
            writer.WriteBoolValue("showConfigurationManagerApps", ShowConfigurationManagerApps);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showOfficeWebApps", ShowOfficeWebApps);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteObjectValue<MimeContent>("themeColorLogo", ThemeColorLogo);
        }
    }
}
