using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AccessPackageResourceAttributeQuestion : AccessPackageResourceAttributeSource, IParsable {
        /// <summary>The question asked in order to get the value of the attribute</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageQuestion? Question {
            get { return BackingStore?.Get<AccessPackageQuestion?>("question"); }
            set { BackingStore?.Set("question", value); }
        }
#nullable restore
#else
        public AccessPackageQuestion Question {
            get { return BackingStore?.Get<AccessPackageQuestion>("question"); }
            set { BackingStore?.Set("question", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new AccessPackageResourceAttributeQuestion and sets the default values.
        /// </summary>
        public AccessPackageResourceAttributeQuestion() : base() {
            OdataType = "#microsoft.graph.accessPackageResourceAttributeQuestion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResourceAttributeQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceAttributeQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"question", n => { Question = n.GetObjectValue<AccessPackageQuestion>(AccessPackageQuestion.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AccessPackageQuestion>("question", Question);
        }
    }
}
