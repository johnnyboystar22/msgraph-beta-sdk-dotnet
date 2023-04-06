using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EncryptContent : LabelActionBase, IParsable {
        /// <summary>The encryptWith property</summary>
        public Microsoft.Graph.Beta.Models.EncryptWith? EncryptWith {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptWith?>("encryptWith"); }
            set { BackingStore?.Set("encryptWith", value); }
        }
        /// <summary>
        /// Instantiates a new EncryptContent and sets the default values.
        /// </summary>
        public EncryptContent() : base() {
            OdataType = "#microsoft.graph.encryptContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EncryptContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.encryptWithTemplate" => new EncryptWithTemplate(),
                "#microsoft.graph.encryptWithUserDefinedRights" => new EncryptWithUserDefinedRights(),
                _ => new EncryptContent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"encryptWith", n => { EncryptWith = n.GetEnumValue<EncryptWith>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EncryptWith>("encryptWith", EncryptWith);
        }
    }
}
