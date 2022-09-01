using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class CustomTaskExtensionCallbackData : CustomExtensionData, IParsable {
        /// <summary>The operationStatus property</summary>
        public CustomTaskExtensionOperationStatus? OperationStatus {
            get { return BackingStore?.Get<CustomTaskExtensionOperationStatus?>("operationStatus"); }
            set { BackingStore?.Set("operationStatus", value); }
        }
        /// <summary>
        /// Instantiates a new CustomTaskExtensionCallbackData and sets the default values.
        /// </summary>
        public CustomTaskExtensionCallbackData() : base() {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtensionCallbackData";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CustomTaskExtensionCallbackData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTaskExtensionCallbackData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"operationStatus", n => { OperationStatus = n.GetEnumValue<CustomTaskExtensionOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CustomTaskExtensionOperationStatus>("operationStatus", OperationStatus);
        }
    }
}
