using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NotificationMessageTemplate : Entity, IParsable {
        /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
        public NotificationTemplateBrandingOptions? BrandingOptions {
            get { return BackingStore?.Get<NotificationTemplateBrandingOptions?>("brandingOptions"); }
            set { BackingStore?.Set("brandingOptions", value); }
        }
        /// <summary>The default locale to fallback onto when the requested locale is not available.</summary>
        public string DefaultLocale {
            get { return BackingStore?.Get<string>("defaultLocale"); }
            set { BackingStore?.Set("defaultLocale", value); }
        }
        /// <summary>Display name for the Notification Message Template.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The list of localized messages for this Notification Message Template.</summary>
        public List<LocalizedNotificationMessage> LocalizedNotificationMessages {
            get { return BackingStore?.Get<List<LocalizedNotificationMessage>>("localizedNotificationMessages"); }
            set { BackingStore?.Set("localizedNotificationMessages", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>
        /// Instantiates a new NotificationMessageTemplate and sets the default values.
        /// </summary>
        public NotificationMessageTemplate() : base() {
            OdataType = "#microsoft.graph.notificationMessageTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new NotificationMessageTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotificationMessageTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"brandingOptions", n => { BrandingOptions = n.GetEnumValue<NotificationTemplateBrandingOptions>(); } },
                {"defaultLocale", n => { DefaultLocale = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localizedNotificationMessages", n => { LocalizedNotificationMessages = n.GetCollectionOfObjectValues<LocalizedNotificationMessage>(LocalizedNotificationMessage.CreateFromDiscriminatorValue).ToList(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<NotificationTemplateBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LocalizedNotificationMessage>("localizedNotificationMessages", LocalizedNotificationMessages);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
