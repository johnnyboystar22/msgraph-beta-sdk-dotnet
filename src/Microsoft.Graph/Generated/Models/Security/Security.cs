using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class Security : Entity, IParsable {
        /// <summary>The informationProtection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.InformationProtection? InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.InformationProtection?>("informationProtection"); }
            set { BackingStore?.Set("informationProtection", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.InformationProtection InformationProtection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.InformationProtection>("informationProtection"); }
            set { BackingStore?.Set("informationProtection", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"informationProtection", n => { InformationProtection = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtection>(Microsoft.Graph.Beta.Models.Security.InformationProtection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtection>("informationProtection", InformationProtection);
        }
    }
}
