using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class FileValidateOperation : ValidateOperation, IParsable {
        /// <summary>Set of files validated by the validate operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ValidatedFiles {
            get { return BackingStore?.Get<List<string>?>("validatedFiles"); }
            set { BackingStore?.Set("validatedFiles", value); }
        }
#nullable restore
#else
        public List<string> ValidatedFiles {
            get { return BackingStore?.Get<List<string>>("validatedFiles"); }
            set { BackingStore?.Set("validatedFiles", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new fileValidateOperation and sets the default values.
        /// </summary>
        public FileValidateOperation() : base() {
            OdataType = "#microsoft.graph.industryData.fileValidateOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileValidateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileValidateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"validatedFiles", n => { ValidatedFiles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
