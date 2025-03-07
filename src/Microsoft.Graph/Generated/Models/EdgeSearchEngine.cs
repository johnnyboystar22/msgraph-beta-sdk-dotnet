// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Allows IT admins to set a predefined default search engine for MDM-Controlled devices.
    /// </summary>
    public class EdgeSearchEngine : Microsoft.Graph.Beta.Models.EdgeSearchEngineBase, IParsable
    {
        /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
        public Microsoft.Graph.Beta.Models.EdgeSearchEngineType? EdgeSearchEngineType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EdgeSearchEngineType?>("edgeSearchEngineType"); }
            set { BackingStore?.Set("edgeSearchEngineType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.EdgeSearchEngine"/> and sets the default values.
        /// </summary>
        public EdgeSearchEngine() : base()
        {
            OdataType = "#microsoft.graph.edgeSearchEngine";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EdgeSearchEngine"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EdgeSearchEngine CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.EdgeSearchEngine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "edgeSearchEngineType", n => { EdgeSearchEngineType = n.GetEnumValue<Microsoft.Graph.Beta.Models.EdgeSearchEngineType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.EdgeSearchEngineType>("edgeSearchEngineType", EdgeSearchEngineType);
        }
    }
}
