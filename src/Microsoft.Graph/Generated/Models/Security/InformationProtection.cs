using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class InformationProtection : Entity, IParsable {
        /// <summary>Read the Microsoft Purview Information Protection policy settings for the user or organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InformationProtectionPolicySetting? LabelPolicySettings {
            get { return BackingStore?.Get<InformationProtectionPolicySetting?>("labelPolicySettings"); }
            set { BackingStore?.Set("labelPolicySettings", value); }
        }
#nullable restore
#else
        public InformationProtectionPolicySetting LabelPolicySettings {
            get { return BackingStore?.Get<InformationProtectionPolicySetting>("labelPolicySettings"); }
            set { BackingStore?.Set("labelPolicySettings", value); }
        }
#endif
        /// <summary>Read the Microsoft Purview Information Protection labels for the user or organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitivityLabel>? SensitivityLabels {
            get { return BackingStore?.Get<List<SensitivityLabel>?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public List<SensitivityLabel> SensitivityLabels {
            get { return BackingStore?.Get<List<SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"labelPolicySettings", n => { LabelPolicySettings = n.GetObjectValue<InformationProtectionPolicySetting>(InformationProtectionPolicySetting.CreateFromDiscriminatorValue); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<InformationProtectionPolicySetting>("labelPolicySettings", LabelPolicySettings);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}
