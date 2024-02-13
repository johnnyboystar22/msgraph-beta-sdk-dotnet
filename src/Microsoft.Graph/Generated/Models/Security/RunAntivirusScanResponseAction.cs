// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RunAntivirusScanResponseAction : ResponseAction, IParsable {
        /// <summary>The identifier property</summary>
        public DeviceIdEntityIdentifier? Identifier {
            get { return BackingStore?.Get<DeviceIdEntityIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="RunAntivirusScanResponseAction"/> and sets the default values.
        /// </summary>
        public RunAntivirusScanResponseAction() : base() {
            OdataType = "#microsoft.graph.security.runAntivirusScanResponseAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RunAntivirusScanResponseAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RunAntivirusScanResponseAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RunAntivirusScanResponseAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identifier", n => { Identifier = n.GetEnumValue<DeviceIdEntityIdentifier>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceIdEntityIdentifier>("identifier", Identifier);
        }
    }
}
