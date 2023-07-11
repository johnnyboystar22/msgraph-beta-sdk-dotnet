using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SubjectRightsRequestEnumeratedSiteLocation : SubjectRightsRequestSiteLocation, IParsable {
        /// <summary>Collection of site URLs that should be included. Includes the URL of each site, for example, https://www.contoso.com/site1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Urls {
            get { return BackingStore?.Get<List<string>?>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#nullable restore
#else
        public List<string> Urls {
            get { return BackingStore?.Get<List<string>>("urls"); }
            set { BackingStore?.Set("urls", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new subjectRightsRequestEnumeratedSiteLocation and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedSiteLocation() : base() {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedSiteLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubjectRightsRequestEnumeratedSiteLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestEnumeratedSiteLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"urls", n => { Urls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("urls", Urls);
        }
    }
}
