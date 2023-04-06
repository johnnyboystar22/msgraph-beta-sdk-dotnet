using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSSingleSignOnExtension : SingleSignOnExtension, IParsable {
        /// <summary>
        /// Instantiates a new MacOSSingleSignOnExtension and sets the default values.
        /// </summary>
        public MacOSSingleSignOnExtension() : base() {
            OdataType = "#microsoft.graph.macOSSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.macOSAzureAdSingleSignOnExtension" => new MacOSAzureAdSingleSignOnExtension(),
                "#microsoft.graph.macOSCredentialSingleSignOnExtension" => new MacOSCredentialSingleSignOnExtension(),
                "#microsoft.graph.macOSKerberosSingleSignOnExtension" => new MacOSKerberosSingleSignOnExtension(),
                "#microsoft.graph.macOSRedirectSingleSignOnExtension" => new MacOSRedirectSingleSignOnExtension(),
                _ => new MacOSSingleSignOnExtension(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
