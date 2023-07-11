using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class RateDrivenRolloutSettings : GradualRolloutSettings, IParsable {
        /// <summary>Specifies the number of devices that are offered at the same time. When not set, all devices in the deployment are offered content at the same time.</summary>
        public int? DevicesPerOffer {
            get { return BackingStore?.Get<int?>("devicesPerOffer"); }
            set { BackingStore?.Set("devicesPerOffer", value); }
        }
        /// <summary>
        /// Instantiates a new rateDrivenRolloutSettings and sets the default values.
        /// </summary>
        public RateDrivenRolloutSettings() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.rateDrivenRolloutSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RateDrivenRolloutSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RateDrivenRolloutSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"devicesPerOffer", n => { DevicesPerOffer = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("devicesPerOffer", DevicesPerOffer);
        }
    }
}
