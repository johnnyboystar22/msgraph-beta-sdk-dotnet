using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EmailThreatSubmissionPolicy : Entity, IParsable {
        /// <summary>Specifies the email address of the sender from which email notifications will be sent to end users to inform them whether an email is spam, phish or clean. The default value is null. Optional for creation.</summary>
        public string CustomizedNotificationSenderEmailAddress {
            get { return BackingStore?.Get<string>("customizedNotificationSenderEmailAddress"); }
            set { BackingStore?.Set("customizedNotificationSenderEmailAddress", value); }
        }
        /// <summary>Specifies the destination where the reported messages from end users will land whenever they report something as phish, junk or not junk. The default value is null. Optional for creation.</summary>
        public string CustomizedReportRecipientEmailAddress {
            get { return BackingStore?.Get<string>("customizedReportRecipientEmailAddress"); }
            set { BackingStore?.Set("customizedReportRecipientEmailAddress", value); }
        }
        /// <summary>Indicates whether end users can report a message as spam, phish or junk directly without a confirmation(popup). The default value is true.  Optional for creation.</summary>
        public bool? IsAlwaysReportEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isAlwaysReportEnabledForUsers"); }
            set { BackingStore?.Set("isAlwaysReportEnabledForUsers", value); }
        }
        /// <summary>Indicates whether end users can confirm using a popup before reporting messages as spam, phish or not junk. The default value is true.  Optional for creation.</summary>
        public bool? IsAskMeEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isAskMeEnabledForUsers"); }
            set { BackingStore?.Set("isAskMeEnabledForUsers", value); }
        }
        /// <summary>Indicates whether the email notifications sent to end users to inform them if an email is phish, spam or junk is customized or not. The default value is false. Optional for creation.</summary>
        public bool? IsCustomizedMessageEnabled {
            get { return BackingStore?.Get<bool?>("isCustomizedMessageEnabled"); }
            set { BackingStore?.Set("isCustomizedMessageEnabled", value); }
        }
        /// <summary>If enabled, customized message only shows when email is reported as phishing. The default value is false. Optional for creation.</summary>
        public bool? IsCustomizedMessageEnabledForPhishing {
            get { return BackingStore?.Get<bool?>("isCustomizedMessageEnabledForPhishing"); }
            set { BackingStore?.Set("isCustomizedMessageEnabledForPhishing", value); }
        }
        /// <summary>Indicates whether to use the sender email address set using customizedNotificationSenderEmailAddress for sending email notifications to end users. The default value is false. Optional for creation.</summary>
        public bool? IsCustomizedNotificationSenderEnabled {
            get { return BackingStore?.Get<bool?>("isCustomizedNotificationSenderEnabled"); }
            set { BackingStore?.Set("isCustomizedNotificationSenderEnabled", value); }
        }
        /// <summary>Indicates whether end users can simply move the message from one folder to another based on the action of spam, phish or not junk without actually reporting it. The default value is true. Optional for creation.</summary>
        public bool? IsNeverReportEnabledForUsers {
            get { return BackingStore?.Get<bool?>("isNeverReportEnabledForUsers"); }
            set { BackingStore?.Set("isNeverReportEnabledForUsers", value); }
        }
        /// <summary>Indicates whether the branding logo should be used in the email notifications sent to end users. The default value is false. Optional for creation.</summary>
        public bool? IsOrganizationBrandingEnabled {
            get { return BackingStore?.Get<bool?>("isOrganizationBrandingEnabled"); }
            set { BackingStore?.Set("isOrganizationBrandingEnabled", value); }
        }
        /// <summary>Indicates whether end users can submit from the quarantine page. The default value is true. Optional for creation.</summary>
        public bool? IsReportFromQuarantineEnabled {
            get { return BackingStore?.Get<bool?>("isReportFromQuarantineEnabled"); }
            set { BackingStore?.Set("isReportFromQuarantineEnabled", value); }
        }
        /// <summary>Indicates whether emails reported by end users should be send to the custom mailbox configured using customizedReportRecipientEmailAddress.  The default value is false. Optional for creation.</summary>
        public bool? IsReportToCustomizedEmailAddressEnabled {
            get { return BackingStore?.Get<bool?>("isReportToCustomizedEmailAddressEnabled"); }
            set { BackingStore?.Set("isReportToCustomizedEmailAddressEnabled", value); }
        }
        /// <summary>If enabled, the email will be sent to Microsoft for analysis. The default value is false. Required for creation.</summary>
        public bool? IsReportToMicrosoftEnabled {
            get { return BackingStore?.Get<bool?>("isReportToMicrosoftEnabled"); }
            set { BackingStore?.Set("isReportToMicrosoftEnabled", value); }
        }
        /// <summary>Indicates whether an email notification is sent to the end user who reported the email when it has been reviewed by the admin. The default value is false. Optional for creation.</summary>
        public bool? IsReviewEmailNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isReviewEmailNotificationEnabled"); }
            set { BackingStore?.Set("isReviewEmailNotificationEnabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailThreatSubmissionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailThreatSubmissionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customizedNotificationSenderEmailAddress", n => { CustomizedNotificationSenderEmailAddress = n.GetStringValue(); } },
                {"customizedReportRecipientEmailAddress", n => { CustomizedReportRecipientEmailAddress = n.GetStringValue(); } },
                {"isAlwaysReportEnabledForUsers", n => { IsAlwaysReportEnabledForUsers = n.GetBoolValue(); } },
                {"isAskMeEnabledForUsers", n => { IsAskMeEnabledForUsers = n.GetBoolValue(); } },
                {"isCustomizedMessageEnabled", n => { IsCustomizedMessageEnabled = n.GetBoolValue(); } },
                {"isCustomizedMessageEnabledForPhishing", n => { IsCustomizedMessageEnabledForPhishing = n.GetBoolValue(); } },
                {"isCustomizedNotificationSenderEnabled", n => { IsCustomizedNotificationSenderEnabled = n.GetBoolValue(); } },
                {"isNeverReportEnabledForUsers", n => { IsNeverReportEnabledForUsers = n.GetBoolValue(); } },
                {"isOrganizationBrandingEnabled", n => { IsOrganizationBrandingEnabled = n.GetBoolValue(); } },
                {"isReportFromQuarantineEnabled", n => { IsReportFromQuarantineEnabled = n.GetBoolValue(); } },
                {"isReportToCustomizedEmailAddressEnabled", n => { IsReportToCustomizedEmailAddressEnabled = n.GetBoolValue(); } },
                {"isReportToMicrosoftEnabled", n => { IsReportToMicrosoftEnabled = n.GetBoolValue(); } },
                {"isReviewEmailNotificationEnabled", n => { IsReviewEmailNotificationEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customizedNotificationSenderEmailAddress", CustomizedNotificationSenderEmailAddress);
            writer.WriteStringValue("customizedReportRecipientEmailAddress", CustomizedReportRecipientEmailAddress);
            writer.WriteBoolValue("isAlwaysReportEnabledForUsers", IsAlwaysReportEnabledForUsers);
            writer.WriteBoolValue("isAskMeEnabledForUsers", IsAskMeEnabledForUsers);
            writer.WriteBoolValue("isCustomizedMessageEnabled", IsCustomizedMessageEnabled);
            writer.WriteBoolValue("isCustomizedMessageEnabledForPhishing", IsCustomizedMessageEnabledForPhishing);
            writer.WriteBoolValue("isCustomizedNotificationSenderEnabled", IsCustomizedNotificationSenderEnabled);
            writer.WriteBoolValue("isNeverReportEnabledForUsers", IsNeverReportEnabledForUsers);
            writer.WriteBoolValue("isOrganizationBrandingEnabled", IsOrganizationBrandingEnabled);
            writer.WriteBoolValue("isReportFromQuarantineEnabled", IsReportFromQuarantineEnabled);
            writer.WriteBoolValue("isReportToCustomizedEmailAddressEnabled", IsReportToCustomizedEmailAddressEnabled);
            writer.WriteBoolValue("isReportToMicrosoftEnabled", IsReportToMicrosoftEnabled);
            writer.WriteBoolValue("isReviewEmailNotificationEnabled", IsReviewEmailNotificationEnabled);
        }
    }
}
