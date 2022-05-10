using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.JoinedGroups.Item.Sites.Item.ContentTypes.Item.CopyToDefaultContentLocation {
    /// <summary>Provides operations to call the copyToDefaultContentLocation method.</summary>
    public class CopyToDefaultContentLocationRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The destinationFileName property</summary>
        public string DestinationFileName { get; set; }
        /// <summary>The sourceFile property</summary>
        public ItemReference SourceFile { get; set; }
        /// <summary>
        /// Instantiates a new copyToDefaultContentLocationRequestBody and sets the default values.
        /// </summary>
        public CopyToDefaultContentLocationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyToDefaultContentLocationRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToDefaultContentLocationRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"destinationFileName", n => { DestinationFileName = n.GetStringValue(); } },
                {"sourceFile", n => { SourceFile = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("destinationFileName", DestinationFileName);
            writer.WriteObjectValue<ItemReference>("sourceFile", SourceFile);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
