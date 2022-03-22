using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
    public class IntuneBrand : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Collection of blocked actions on the company portal as per platform and device ownership types.</summary>
        public List<CompanyPortalBlockedAction> CompanyPortalBlockedActions { get; set; }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
        public string ContactITEmailAddress { get; set; }
        /// <summary>Name of the person/organization responsible for IT support.</summary>
        public string ContactITName { get; set; }
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
        public string ContactITNotes { get; set; }
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
        public string ContactITPhoneNumber { get; set; }
        /// <summary>The custom privacy message used to explain what the organization can see and do on managed devices.</summary>
        public string CustomCanSeePrivacyMessage { get; set; }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomCantSeePrivacyMessage { get; set; }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomPrivacyMessage { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
        public MimeContent DarkBackgroundLogo { get; set; }
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry { get; set; }
        /// <summary>Company/organization name that is displayed to end users.</summary>
        public string DisplayName { get; set; }
        /// <summary>Customized device enrollment flow displayed to the end user . Possible values are: availableWithPrompts, availableWithoutPrompts, unavailable.</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the 'Factory Reset' action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled { get; set; }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the 'Remove Device' action on corporate owned devices.</summary>
        public bool? IsRemoveDeviceDisabled { get; set; }
        /// <summary>Customized image displayed in Company Portal app landing page</summary>
        public MimeContent LandingPageCustomizedImage { get; set; }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
        public MimeContent LightBackgroundLogo { get; set; }
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteName { get; set; }
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteUrl { get; set; }
        /// <summary>URL to the company/organization’s privacy policy.</summary>
        public string PrivacyUrl { get; set; }
        /// <summary>List of scope tags assigned to the default branding profile</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate</summary>
        public bool? SendDeviceOwnershipChangePushNotification { get; set; }
        /// <summary>Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal</summary>
        public bool? ShowAzureADEnterpriseApps { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo { get; set; }
        /// <summary>Boolean that indicates if Office WebApps will be shown in Company Portal</summary>
        public bool? ShowOfficeWebApps { get; set; }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
        public RgbColor ThemeColor { get; set; }
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static IntuneBrand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"companyPortalBlockedActions", (o,n) => { (o as IntuneBrand).CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>(CompanyPortalBlockedAction.CreateFromDiscriminatorValue).ToList(); } },
                {"contactITEmailAddress", (o,n) => { (o as IntuneBrand).ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", (o,n) => { (o as IntuneBrand).ContactITName = n.GetStringValue(); } },
                {"contactITNotes", (o,n) => { (o as IntuneBrand).ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", (o,n) => { (o as IntuneBrand).ContactITPhoneNumber = n.GetStringValue(); } },
                {"customCanSeePrivacyMessage", (o,n) => { (o as IntuneBrand).CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", (o,n) => { (o as IntuneBrand).CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", (o,n) => { (o as IntuneBrand).CustomPrivacyMessage = n.GetStringValue(); } },
                {"darkBackgroundLogo", (o,n) => { (o as IntuneBrand).DarkBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"disableClientTelemetry", (o,n) => { (o as IntuneBrand).DisableClientTelemetry = n.GetBoolValue(); } },
                {"displayName", (o,n) => { (o as IntuneBrand).DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", (o,n) => { (o as IntuneBrand).EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isFactoryResetDisabled", (o,n) => { (o as IntuneBrand).IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", (o,n) => { (o as IntuneBrand).IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", (o,n) => { (o as IntuneBrand).LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lightBackgroundLogo", (o,n) => { (o as IntuneBrand).LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"onlineSupportSiteName", (o,n) => { (o as IntuneBrand).OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", (o,n) => { (o as IntuneBrand).OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", (o,n) => { (o as IntuneBrand).PrivacyUrl = n.GetStringValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as IntuneBrand).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", (o,n) => { (o as IntuneBrand).SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", (o,n) => { (o as IntuneBrand).ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", (o,n) => { (o as IntuneBrand).ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", (o,n) => { (o as IntuneBrand).ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", (o,n) => { (o as IntuneBrand).ShowNameNextToLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", (o,n) => { (o as IntuneBrand).ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", (o,n) => { (o as IntuneBrand).ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CompanyPortalBlockedAction>("companyPortalBlockedActions", CompanyPortalBlockedActions);
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteStringValue("customCanSeePrivacyMessage", CustomCanSeePrivacyMessage);
            writer.WriteStringValue("customCantSeePrivacyMessage", CustomCantSeePrivacyMessage);
            writer.WriteStringValue("customPrivacyMessage", CustomPrivacyMessage);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteBoolValue("disableClientTelemetry", DisableClientTelemetry);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentAvailabilityOptions>("enrollmentAvailability", EnrollmentAvailability);
            writer.WriteBoolValue("isFactoryResetDisabled", IsFactoryResetDisabled);
            writer.WriteBoolValue("isRemoveDeviceDisabled", IsRemoveDeviceDisabled);
            writer.WriteObjectValue<MimeContent>("landingPageCustomizedImage", LandingPageCustomizedImage);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("sendDeviceOwnershipChangePushNotification", SendDeviceOwnershipChangePushNotification);
            writer.WriteBoolValue("showAzureADEnterpriseApps", ShowAzureADEnterpriseApps);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteBoolValue("showOfficeWebApps", ShowOfficeWebApps);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
