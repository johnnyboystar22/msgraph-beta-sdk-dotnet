using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class NoTrainingNotificationSetting : EndUserNotificationSetting, IParsable {
        /// <summary>The simulationNotification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SimulationNotification? SimulationNotification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SimulationNotification?>("simulationNotification"); }
            set { BackingStore?.Set("simulationNotification", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SimulationNotification SimulationNotification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SimulationNotification>("simulationNotification"); }
            set { BackingStore?.Set("simulationNotification", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new noTrainingNotificationSetting and sets the default values.
        /// </summary>
        public NoTrainingNotificationSetting() : base() {
            OdataType = "#microsoft.graph.noTrainingNotificationSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NoTrainingNotificationSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NoTrainingNotificationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"simulationNotification", n => { SimulationNotification = n.GetObjectValue<Microsoft.Graph.Beta.Models.SimulationNotification>(Microsoft.Graph.Beta.Models.SimulationNotification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SimulationNotification>("simulationNotification", SimulationNotification);
        }
    }
}
