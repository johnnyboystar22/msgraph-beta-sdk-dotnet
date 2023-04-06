using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class CatalogContent : DeployableContent, IParsable {
        /// <summary>The catalogEntry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry? CatalogEntry {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry?>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry CatalogEntry {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CatalogContent and sets the default values.
        /// </summary>
        public CatalogContent() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.catalogContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CatalogContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CatalogContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"catalogEntry", n => { CatalogEntry = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>(Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry", CatalogEntry);
        }
    }
}
