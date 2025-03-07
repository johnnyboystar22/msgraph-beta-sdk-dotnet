// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class MetadataAction : Microsoft.Graph.Beta.Models.Security.InformationProtectionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of key-value pairs that should be added to the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.KeyValuePair>? MetadataToAdd
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.KeyValuePair>?>("metadataToAdd"); }
            set { BackingStore?.Set("metadataToAdd", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.KeyValuePair> MetadataToAdd
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.KeyValuePair>>("metadataToAdd"); }
            set { BackingStore?.Set("metadataToAdd", value); }
        }
#endif
        /// <summary>A collection of strings that indicate which keys to remove from the file metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MetadataToRemove
        {
            get { return BackingStore?.Get<List<string>?>("metadataToRemove"); }
            set { BackingStore?.Set("metadataToRemove", value); }
        }
#nullable restore
#else
        public List<string> MetadataToRemove
        {
            get { return BackingStore?.Get<List<string>>("metadataToRemove"); }
            set { BackingStore?.Set("metadataToRemove", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.MetadataAction"/> and sets the default values.
        /// </summary>
        public MetadataAction() : base()
        {
            OdataType = "#microsoft.graph.security.metadataAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.MetadataAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.MetadataAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.MetadataAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "metadataToAdd", n => { MetadataToAdd = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.KeyValuePair>(Microsoft.Graph.Beta.Models.Security.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "metadataToRemove", n => { MetadataToRemove = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.KeyValuePair>("metadataToAdd", MetadataToAdd);
            writer.WriteCollectionOfPrimitiveValues<string>("metadataToRemove", MetadataToRemove);
        }
    }
}
