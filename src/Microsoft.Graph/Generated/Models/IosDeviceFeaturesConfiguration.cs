using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// iOS Device Features Configuration Profile.
    /// </summary>
    public class IosDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase, IParsable {
        /// <summary>Asset tag information for the device, displayed on the login window and lock screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssetTagTemplate {
            get { return BackingStore?.Get<string?>("assetTagTemplate"); }
            set { BackingStore?.Set("assetTagTemplate", value); }
        }
#nullable restore
#else
        public string AssetTagTemplate {
            get { return BackingStore?.Get<string>("assetTagTemplate"); }
            set { BackingStore?.Set("assetTagTemplate", value); }
        }
#endif
        /// <summary>Gets or sets iOS Web Content Filter settings, supervised mode only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosWebContentFilterBase? ContentFilterSettings {
            get { return BackingStore?.Get<IosWebContentFilterBase?>("contentFilterSettings"); }
            set { BackingStore?.Set("contentFilterSettings", value); }
        }
#nullable restore
#else
        public IosWebContentFilterBase ContentFilterSettings {
            get { return BackingStore?.Get<IosWebContentFilterBase>("contentFilterSettings"); }
            set { BackingStore?.Set("contentFilterSettings", value); }
        }
#endif
        /// <summary>A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosHomeScreenItem>? HomeScreenDockIcons {
            get { return BackingStore?.Get<List<IosHomeScreenItem>?>("homeScreenDockIcons"); }
            set { BackingStore?.Set("homeScreenDockIcons", value); }
        }
#nullable restore
#else
        public List<IosHomeScreenItem> HomeScreenDockIcons {
            get { return BackingStore?.Get<List<IosHomeScreenItem>>("homeScreenDockIcons"); }
            set { BackingStore?.Set("homeScreenDockIcons", value); }
        }
#endif
        /// <summary>Gets or sets the number of rows to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridWidth must be configured as well.</summary>
        public int? HomeScreenGridHeight {
            get { return BackingStore?.Get<int?>("homeScreenGridHeight"); }
            set { BackingStore?.Set("homeScreenGridHeight", value); }
        }
        /// <summary>Gets or sets the number of columns to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridHeight must be configured as well.</summary>
        public int? HomeScreenGridWidth {
            get { return BackingStore?.Get<int?>("homeScreenGridWidth"); }
            set { BackingStore?.Set("homeScreenGridWidth", value); }
        }
        /// <summary>A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosHomeScreenPage>? HomeScreenPages {
            get { return BackingStore?.Get<List<IosHomeScreenPage>?>("homeScreenPages"); }
            set { BackingStore?.Set("homeScreenPages", value); }
        }
#nullable restore
#else
        public List<IosHomeScreenPage> HomeScreenPages {
            get { return BackingStore?.Get<List<IosHomeScreenPage>>("homeScreenPages"); }
            set { BackingStore?.Set("homeScreenPages", value); }
        }
#endif
        /// <summary>Identity Certificate for the renewal of Kerberos ticket used in single sign-on settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosCertificateProfileBase? IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<IosCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public IosCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<IosCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Gets or sets a single sign-on extension profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosSingleSignOnExtension? IosSingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension?>("iosSingleSignOnExtension"); }
            set { BackingStore?.Set("iosSingleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosSingleSignOnExtension IosSingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>("iosSingleSignOnExtension"); }
            set { BackingStore?.Set("iosSingleSignOnExtension", value); }
        }
#endif
        /// <summary>A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockScreenFootnote {
            get { return BackingStore?.Get<string?>("lockScreenFootnote"); }
            set { BackingStore?.Set("lockScreenFootnote", value); }
        }
#nullable restore
#else
        public string LockScreenFootnote {
            get { return BackingStore?.Get<string>("lockScreenFootnote"); }
            set { BackingStore?.Set("lockScreenFootnote", value); }
        }
#endif
        /// <summary>Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosNotificationSettings>? NotificationSettings {
            get { return BackingStore?.Get<List<IosNotificationSettings>?>("notificationSettings"); }
            set { BackingStore?.Set("notificationSettings", value); }
        }
#nullable restore
#else
        public List<IosNotificationSettings> NotificationSettings {
            get { return BackingStore?.Get<List<IosNotificationSettings>>("notificationSettings"); }
            set { BackingStore?.Set("notificationSettings", value); }
        }
#endif
        /// <summary>Gets or sets a single sign-on extension profile. Deprecated: use IOSSingleSignOnExtension instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension? SingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension?>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension SingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#endif
        /// <summary>PKINIT Certificate for the authentication with single sign-on extension settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosCertificateProfileBase? SingleSignOnExtensionPkinitCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase?>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#nullable restore
#else
        public IosCertificateProfileBase SingleSignOnExtensionPkinitCertificate {
            get { return BackingStore?.Get<IosCertificateProfileBase>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#endif
        /// <summary>The Kerberos login settings that enable apps on receiving devices to authenticate smoothly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IosSingleSignOnSettings? SingleSignOnSettings {
            get { return BackingStore?.Get<IosSingleSignOnSettings?>("singleSignOnSettings"); }
            set { BackingStore?.Set("singleSignOnSettings", value); }
        }
#nullable restore
#else
        public IosSingleSignOnSettings SingleSignOnSettings {
            get { return BackingStore?.Get<IosSingleSignOnSettings>("singleSignOnSettings"); }
            set { BackingStore?.Set("singleSignOnSettings", value); }
        }
#endif
        /// <summary>An enum type for wallpaper display location specifier.</summary>
        public IosWallpaperDisplayLocation? WallpaperDisplayLocation {
            get { return BackingStore?.Get<IosWallpaperDisplayLocation?>("wallpaperDisplayLocation"); }
            set { BackingStore?.Set("wallpaperDisplayLocation", value); }
        }
        /// <summary>A wallpaper image must be in either PNG or JPEG format. It requires a supervised device with iOS 8 or later version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? WallpaperImage {
            get { return BackingStore?.Get<MimeContent?>("wallpaperImage"); }
            set { BackingStore?.Set("wallpaperImage", value); }
        }
#nullable restore
#else
        public MimeContent WallpaperImage {
            get { return BackingStore?.Get<MimeContent>("wallpaperImage"); }
            set { BackingStore?.Set("wallpaperImage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new iosDeviceFeaturesConfiguration and sets the default values.
        /// </summary>
        public IosDeviceFeaturesConfiguration() : base() {
            OdataType = "#microsoft.graph.iosDeviceFeaturesConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosDeviceFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosDeviceFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assetTagTemplate", n => { AssetTagTemplate = n.GetStringValue(); } },
                {"contentFilterSettings", n => { ContentFilterSettings = n.GetObjectValue<IosWebContentFilterBase>(IosWebContentFilterBase.CreateFromDiscriminatorValue); } },
                {"homeScreenDockIcons", n => { HomeScreenDockIcons = n.GetCollectionOfObjectValues<IosHomeScreenItem>(IosHomeScreenItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"homeScreenGridHeight", n => { HomeScreenGridHeight = n.GetIntValue(); } },
                {"homeScreenGridWidth", n => { HomeScreenGridWidth = n.GetIntValue(); } },
                {"homeScreenPages", n => { HomeScreenPages = n.GetCollectionOfObjectValues<IosHomeScreenPage>(IosHomeScreenPage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"iosSingleSignOnExtension", n => { IosSingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>(Microsoft.Graph.Beta.Models.IosSingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"lockScreenFootnote", n => { LockScreenFootnote = n.GetStringValue(); } },
                {"notificationSettings", n => { NotificationSettings = n.GetCollectionOfObjectValues<IosNotificationSettings>(IosNotificationSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                {"singleSignOnExtension", n => { SingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>(Microsoft.Graph.Beta.Models.SingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"singleSignOnExtensionPkinitCertificate", n => { SingleSignOnExtensionPkinitCertificate = n.GetObjectValue<IosCertificateProfileBase>(IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"singleSignOnSettings", n => { SingleSignOnSettings = n.GetObjectValue<IosSingleSignOnSettings>(IosSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                {"wallpaperDisplayLocation", n => { WallpaperDisplayLocation = n.GetEnumValue<IosWallpaperDisplayLocation>(); } },
                {"wallpaperImage", n => { WallpaperImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assetTagTemplate", AssetTagTemplate);
            writer.WriteObjectValue<IosWebContentFilterBase>("contentFilterSettings", ContentFilterSettings);
            writer.WriteCollectionOfObjectValues<IosHomeScreenItem>("homeScreenDockIcons", HomeScreenDockIcons);
            writer.WriteIntValue("homeScreenGridHeight", HomeScreenGridHeight);
            writer.WriteIntValue("homeScreenGridWidth", HomeScreenGridWidth);
            writer.WriteCollectionOfObjectValues<IosHomeScreenPage>("homeScreenPages", HomeScreenPages);
            writer.WriteObjectValue<IosCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>("iosSingleSignOnExtension", IosSingleSignOnExtension);
            writer.WriteStringValue("lockScreenFootnote", LockScreenFootnote);
            writer.WriteCollectionOfObjectValues<IosNotificationSettings>("notificationSettings", NotificationSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension", SingleSignOnExtension);
            writer.WriteObjectValue<IosCertificateProfileBase>("singleSignOnExtensionPkinitCertificate", SingleSignOnExtensionPkinitCertificate);
            writer.WriteObjectValue<IosSingleSignOnSettings>("singleSignOnSettings", SingleSignOnSettings);
            writer.WriteEnumValue<IosWallpaperDisplayLocation>("wallpaperDisplayLocation", WallpaperDisplayLocation);
            writer.WriteObjectValue<MimeContent>("wallpaperImage", WallpaperImage);
        }
    }
}
