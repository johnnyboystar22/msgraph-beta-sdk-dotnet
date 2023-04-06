using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class UpdatePolicy : Entity, IParsable {
        /// <summary>Specifies the audience to target.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentAudience? Audience {
            get { return BackingStore?.Get<DeploymentAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#nullable restore
#else
        public DeploymentAudience Audience {
            get { return BackingStore?.Get<DeploymentAudience>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
#endif
        /// <summary>Rules for governing the automatic creation of compliance changes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ComplianceChangeRule>? ComplianceChangeRules {
            get { return BackingStore?.Get<List<ComplianceChangeRule>?>("complianceChangeRules"); }
            set { BackingStore?.Set("complianceChangeRules", value); }
        }
#nullable restore
#else
        public List<ComplianceChangeRule> ComplianceChangeRules {
            get { return BackingStore?.Get<List<ComplianceChangeRule>>("complianceChangeRules"); }
            set { BackingStore?.Set("complianceChangeRules", value); }
        }
#endif
        /// <summary>Compliance changes like content approvals which result in the automatic creation of deployments using the audience and deploymentSettings of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ComplianceChange>? ComplianceChanges {
            get { return BackingStore?.Get<List<ComplianceChange>?>("complianceChanges"); }
            set { BackingStore?.Set("complianceChanges", value); }
        }
#nullable restore
#else
        public List<ComplianceChange> ComplianceChanges {
            get { return BackingStore?.Get<List<ComplianceChange>>("complianceChanges"); }
            set { BackingStore?.Set("complianceChanges", value); }
        }
#endif
        /// <summary>The date and time when the update policy was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Settings for governing how to deploy content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings? DeploymentSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings?>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings DeploymentSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings"); }
            set { BackingStore?.Set("deploymentSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UpdatePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdatePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audience", n => { Audience = n.GetObjectValue<DeploymentAudience>(DeploymentAudience.CreateFromDiscriminatorValue); } },
                {"complianceChangeRules", n => { ComplianceChangeRules = n.GetCollectionOfObjectValues<ComplianceChangeRule>(ComplianceChangeRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceChanges", n => { ComplianceChanges = n.GetCollectionOfObjectValues<ComplianceChange>(ComplianceChange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentSettings", n => { DeploymentSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>(Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeploymentAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<ComplianceChangeRule>("complianceChangeRules", ComplianceChangeRules);
            writer.WriteCollectionOfObjectValues<ComplianceChange>("complianceChanges", ComplianceChanges);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentSettings>("deploymentSettings", DeploymentSettings);
        }
    }
}
