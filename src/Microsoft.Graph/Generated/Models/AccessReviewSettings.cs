using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReviewSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Indicates whether showing recommendations to reviewers is enabled.</summary>
        public bool? AccessRecommendationsEnabled {
            get { return BackingStore?.Get<bool?>("accessRecommendationsEnabled"); }
            set { BackingStore?.Set("accessRecommendationsEnabled", value); }
        }
        /// <summary>The number of days of user activities to show to reviewers.</summary>
        public int? ActivityDurationInDays {
            get { return BackingStore?.Get<int?>("activityDurationInDays"); }
            set { BackingStore?.Set("activityDurationInDays", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Indicates whether the auto-apply capability, to automatically change the target object access resource, is enabled.  If not enabled, a user must, after the review completes, apply the access review.</summary>
        public bool? AutoApplyReviewResultsEnabled {
            get { return BackingStore?.Get<bool?>("autoApplyReviewResultsEnabled"); }
            set { BackingStore?.Set("autoApplyReviewResultsEnabled", value); }
        }
        /// <summary>Indicates whether a decision should be set if the reviewer did not supply one. For use when auto-apply is enabled. If you don&apos;t want to have a review decision recorded unless the reviewer makes an explicit choice, set it to false.</summary>
        public bool? AutoReviewEnabled {
            get { return BackingStore?.Get<bool?>("autoReviewEnabled"); }
            set { BackingStore?.Set("autoReviewEnabled", value); }
        }
        /// <summary>Detailed settings for how the feature should set the review decision. For use when auto-apply is enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AutoReviewSettings? AutoReviewSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutoReviewSettings?>("autoReviewSettings"); }
            set { BackingStore?.Set("autoReviewSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AutoReviewSettings AutoReviewSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AutoReviewSettings>("autoReviewSettings"); }
            set { BackingStore?.Set("autoReviewSettings", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Indicates whether reviewers are required to provide a justification when reviewing access.</summary>
        public bool? JustificationRequiredOnApproval {
            get { return BackingStore?.Get<bool?>("justificationRequiredOnApproval"); }
            set { BackingStore?.Set("justificationRequiredOnApproval", value); }
        }
        /// <summary>Indicates whether sending mails to reviewers and the review creator is enabled.</summary>
        public bool? MailNotificationsEnabled {
            get { return BackingStore?.Get<bool?>("mailNotificationsEnabled"); }
            set { BackingStore?.Set("mailNotificationsEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Detailed settings for recurrence.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessReviewRecurrenceSettings? RecurrenceSettings {
            get { return BackingStore?.Get<AccessReviewRecurrenceSettings?>("recurrenceSettings"); }
            set { BackingStore?.Set("recurrenceSettings", value); }
        }
#nullable restore
#else
        public AccessReviewRecurrenceSettings RecurrenceSettings {
            get { return BackingStore?.Get<AccessReviewRecurrenceSettings>("recurrenceSettings"); }
            set { BackingStore?.Set("recurrenceSettings", value); }
        }
#endif
        /// <summary>Indicates whether sending reminder emails to reviewers is enabled.</summary>
        public bool? RemindersEnabled {
            get { return BackingStore?.Get<bool?>("remindersEnabled"); }
            set { BackingStore?.Set("remindersEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new accessReviewSettings and sets the default values.
        /// </summary>
        public AccessReviewSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessReviewSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.businessFlowSettings" => new BusinessFlowSettings(),
                _ => new AccessReviewSettings(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessRecommendationsEnabled", n => { AccessRecommendationsEnabled = n.GetBoolValue(); } },
                {"activityDurationInDays", n => { ActivityDurationInDays = n.GetIntValue(); } },
                {"autoApplyReviewResultsEnabled", n => { AutoApplyReviewResultsEnabled = n.GetBoolValue(); } },
                {"autoReviewEnabled", n => { AutoReviewEnabled = n.GetBoolValue(); } },
                {"autoReviewSettings", n => { AutoReviewSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.AutoReviewSettings>(Microsoft.Graph.Beta.Models.AutoReviewSettings.CreateFromDiscriminatorValue); } },
                {"justificationRequiredOnApproval", n => { JustificationRequiredOnApproval = n.GetBoolValue(); } },
                {"mailNotificationsEnabled", n => { MailNotificationsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recurrenceSettings", n => { RecurrenceSettings = n.GetObjectValue<AccessReviewRecurrenceSettings>(AccessReviewRecurrenceSettings.CreateFromDiscriminatorValue); } },
                {"remindersEnabled", n => { RemindersEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("accessRecommendationsEnabled", AccessRecommendationsEnabled);
            writer.WriteIntValue("activityDurationInDays", ActivityDurationInDays);
            writer.WriteBoolValue("autoApplyReviewResultsEnabled", AutoApplyReviewResultsEnabled);
            writer.WriteBoolValue("autoReviewEnabled", AutoReviewEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AutoReviewSettings>("autoReviewSettings", AutoReviewSettings);
            writer.WriteBoolValue("justificationRequiredOnApproval", JustificationRequiredOnApproval);
            writer.WriteBoolValue("mailNotificationsEnabled", MailNotificationsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AccessReviewRecurrenceSettings>("recurrenceSettings", RecurrenceSettings);
            writer.WriteBoolValue("remindersEnabled", RemindersEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
