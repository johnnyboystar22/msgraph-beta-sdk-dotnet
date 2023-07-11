using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A class containing the properties used for Windows10EnrollmentCompletionPageConfiguration PolicySetItem.
    /// </summary>
    public class Windows10EnrollmentCompletionPageConfigurationPolicySetItem : PolicySetItem, IParsable {
        /// <summary>Priority of the Windows10EnrollmentCompletionPageConfigurationPolicySetItem.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>
        /// Instantiates a new windows10EnrollmentCompletionPageConfigurationPolicySetItem and sets the default values.
        /// </summary>
        public Windows10EnrollmentCompletionPageConfigurationPolicySetItem() : base() {
            OdataType = "#microsoft.graph.windows10EnrollmentCompletionPageConfigurationPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10EnrollmentCompletionPageConfigurationPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EnrollmentCompletionPageConfigurationPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"priority", n => { Priority = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("priority", Priority);
        }
    }
}
