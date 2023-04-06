using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DurationDrivenRolloutSettings : GradualRolloutSettings, IParsable {
        /// <summary>The target duration of the rollout. Given durationBetweenOffers and durationUntilDeploymentEnd, the system will automatically calculate how many devices are in each offering.</summary>
        public TimeSpan? DurationUntilDeploymentEnd {
            get { return BackingStore?.Get<TimeSpan?>("durationUntilDeploymentEnd"); }
            set { BackingStore?.Set("durationUntilDeploymentEnd", value); }
        }
        /// <summary>
        /// Instantiates a new DurationDrivenRolloutSettings and sets the default values.
        /// </summary>
        public DurationDrivenRolloutSettings() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.durationDrivenRolloutSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DurationDrivenRolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DurationDrivenRolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"durationUntilDeploymentEnd", n => { DurationUntilDeploymentEnd = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("durationUntilDeploymentEnd", DurationUntilDeploymentEnd);
        }
    }
}
