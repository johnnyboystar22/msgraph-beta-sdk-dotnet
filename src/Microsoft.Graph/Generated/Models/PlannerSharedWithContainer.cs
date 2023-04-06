using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerSharedWithContainer : PlannerPlanContainer, IParsable {
        /// <summary>The accessLevel property</summary>
        public PlannerPlanAccessLevel? AccessLevel {
            get { return BackingStore?.Get<PlannerPlanAccessLevel?>("accessLevel"); }
            set { BackingStore?.Set("accessLevel", value); }
        }
        /// <summary>
        /// Instantiates a new PlannerSharedWithContainer and sets the default values.
        /// </summary>
        public PlannerSharedWithContainer() : base() {
            OdataType = "#microsoft.graph.plannerSharedWithContainer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerSharedWithContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerSharedWithContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessLevel", n => { AccessLevel = n.GetEnumValue<PlannerPlanAccessLevel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PlannerPlanAccessLevel>("accessLevel", AccessLevel);
        }
    }
}
