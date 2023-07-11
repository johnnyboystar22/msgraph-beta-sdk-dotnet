using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WebSegmentConfiguration : SegmentConfiguration, IParsable {
        /// <summary>The applicationSegments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebApplicationSegment>? ApplicationSegments {
            get { return BackingStore?.Get<List<WebApplicationSegment>?>("applicationSegments"); }
            set { BackingStore?.Set("applicationSegments", value); }
        }
#nullable restore
#else
        public List<WebApplicationSegment> ApplicationSegments {
            get { return BackingStore?.Get<List<WebApplicationSegment>>("applicationSegments"); }
            set { BackingStore?.Set("applicationSegments", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new webSegmentConfiguration and sets the default values.
        /// </summary>
        public WebSegmentConfiguration() : base() {
            OdataType = "#microsoft.graph.webSegmentConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WebSegmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebSegmentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationSegments", n => { ApplicationSegments = n.GetCollectionOfObjectValues<WebApplicationSegment>(WebApplicationSegment.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WebApplicationSegment>("applicationSegments", ApplicationSegments);
        }
    }
}
