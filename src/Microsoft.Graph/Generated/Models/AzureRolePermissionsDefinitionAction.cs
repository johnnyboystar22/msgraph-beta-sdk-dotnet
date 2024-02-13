// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AzureRolePermissionsDefinitionAction : AzurePermissionsDefinitionAction, IParsable {
        /// <summary>The roles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionsDefinitionAzureRole>? Roles {
            get { return BackingStore?.Get<List<PermissionsDefinitionAzureRole>?>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#nullable restore
#else
        public List<PermissionsDefinitionAzureRole> Roles {
            get { return BackingStore?.Get<List<PermissionsDefinitionAzureRole>>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AzureRolePermissionsDefinitionAction"/> and sets the default values.
        /// </summary>
        public AzureRolePermissionsDefinitionAction() : base() {
            OdataType = "#microsoft.graph.azureRolePermissionsDefinitionAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AzureRolePermissionsDefinitionAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AzureRolePermissionsDefinitionAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AzureRolePermissionsDefinitionAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"roles", n => { Roles = n.GetCollectionOfObjectValues<PermissionsDefinitionAzureRole>(PermissionsDefinitionAzureRole.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PermissionsDefinitionAzureRole>("roles", Roles);
        }
    }
}
