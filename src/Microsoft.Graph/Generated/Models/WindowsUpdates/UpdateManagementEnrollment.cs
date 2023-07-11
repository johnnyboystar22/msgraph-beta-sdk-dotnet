using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class UpdateManagementEnrollment : UpdatableAssetEnrollment, IParsable {
        /// <summary>The updateCategory property</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategory? UpdateCategory {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdateCategory?>("updateCategory"); }
            set { BackingStore?.Set("updateCategory", value); }
        }
        /// <summary>
        /// Instantiates a new updateManagementEnrollment and sets the default values.
        /// </summary>
        public UpdateManagementEnrollment() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.updateManagementEnrollment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UpdateManagementEnrollment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateManagementEnrollment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"updateCategory", n => { UpdateCategory = n.GetEnumValue<UpdateCategory>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UpdateCategory>("updateCategory", UpdateCategory);
        }
    }
}
