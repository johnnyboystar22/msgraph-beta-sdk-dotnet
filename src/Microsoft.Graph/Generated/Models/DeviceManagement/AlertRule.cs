using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.DeviceManagement {
    public class AlertRule : Entity, IParsable {
        /// <summary>The rule template of the alert event. The possible values are: cloudPcProvisionScenario, cloudPcImageUploadScenario, cloudPcOnPremiseNetworkConnectionCheckScenario, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate? AlertRuleTemplate {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagement.AlertRuleTemplate?>("alertRuleTemplate"); }
            set { BackingStore?.Set("alertRuleTemplate", value); }
        }
        /// <summary>The rule description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the rule.</summary>
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
        /// <summary>The status of the rule that indicates whether the rule is enabled or disabled. If true, the rule is enabled; otherwise, the rule is disabled.</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>Indicates whether the rule is a system rule. If true, the rule is a system rule; otherwise, the rule is a custom defined rule and can be edited. System rules are built-in and only a few properties can be edited.</summary>
        public bool? IsSystemRule {
            get { return BackingStore?.Get<bool?>("isSystemRule"); }
            set { BackingStore?.Set("isSystemRule", value); }
        }
        /// <summary>The notification channels of the rule selected by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationChannel>? NotificationChannels {
            get { return BackingStore?.Get<List<NotificationChannel>?>("notificationChannels"); }
            set { BackingStore?.Set("notificationChannels", value); }
        }
#nullable restore
#else
        public List<NotificationChannel> NotificationChannels {
            get { return BackingStore?.Get<List<NotificationChannel>>("notificationChannels"); }
            set { BackingStore?.Set("notificationChannels", value); }
        }
#endif
        /// <summary>The severity of the rule. The possible values are: unknown, informational, warning, critical, unknownFutureValue.</summary>
        public RuleSeverityType? Severity {
            get { return BackingStore?.Get<RuleSeverityType?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The conditions to send alerts. For example, send alert when provisioning has failed for greater than or equal to 6 Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RuleThreshold? Threshold {
            get { return BackingStore?.Get<RuleThreshold?>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
#nullable restore
#else
        public RuleThreshold Threshold {
            get { return BackingStore?.Get<RuleThreshold>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AlertRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertRuleTemplate", n => { AlertRuleTemplate = n.GetEnumValue<AlertRuleTemplate>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"isSystemRule", n => { IsSystemRule = n.GetBoolValue(); } },
                {"notificationChannels", n => { NotificationChannels = n.GetCollectionOfObjectValues<NotificationChannel>(NotificationChannel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"severity", n => { Severity = n.GetEnumValue<RuleSeverityType>(); } },
                {"threshold", n => { Threshold = n.GetObjectValue<RuleThreshold>(RuleThreshold.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AlertRuleTemplate>("alertRuleTemplate", AlertRuleTemplate);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteBoolValue("isSystemRule", IsSystemRule);
            writer.WriteCollectionOfObjectValues<NotificationChannel>("notificationChannels", NotificationChannels);
            writer.WriteEnumValue<RuleSeverityType>("severity", Severity);
            writer.WriteObjectValue<RuleThreshold>("threshold", Threshold);
        }
    }
}
