// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class ForwardingPolicy : Policy, IParsable {
        /// <summary>The trafficForwardingType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.TrafficForwardingType? TrafficForwardingType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TrafficForwardingType?>("trafficForwardingType"); }
            set { BackingStore?.Set("trafficForwardingType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="ForwardingPolicy"/> and sets the default values.
        /// </summary>
        public ForwardingPolicy() : base() {
            OdataType = "#microsoft.graph.networkaccess.forwardingPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ForwardingPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ForwardingPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ForwardingPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"trafficForwardingType", n => { TrafficForwardingType = n.GetEnumValue<TrafficForwardingType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TrafficForwardingType>("trafficForwardingType", TrafficForwardingType);
        }
    }
}
