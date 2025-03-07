// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AzureActionPermissionsDefinitionAction : Microsoft.Graph.Beta.Models.AzurePermissionsDefinitionAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of actions relating to the Azure permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Actions
        {
            get { return BackingStore?.Get<List<string>?>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#nullable restore
#else
        public List<string> Actions
        {
            get { return BackingStore?.Get<List<string>>("actions"); }
            set { BackingStore?.Set("actions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AzureActionPermissionsDefinitionAction"/> and sets the default values.
        /// </summary>
        public AzureActionPermissionsDefinitionAction() : base()
        {
            OdataType = "#microsoft.graph.azureActionPermissionsDefinitionAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AzureActionPermissionsDefinitionAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AzureActionPermissionsDefinitionAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AzureActionPermissionsDefinitionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actions", n => { Actions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("actions", Actions);
        }
    }
}
