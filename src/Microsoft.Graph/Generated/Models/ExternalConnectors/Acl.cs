// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors
{
    #pragma warning disable CS1591
    public class Acl : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessType property</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.AccessType? AccessType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.AccessType?>("accessType"); }
            set { BackingStore?.Set("accessType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The source of identity. Possible values are azureActiveDirectory or external.</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.IdentitySourceType? IdentitySource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.IdentitySourceType?>("identitySource"); }
            set { BackingStore?.Set("identitySource", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The type property</summary>
        public Microsoft.Graph.Beta.Models.ExternalConnectors.AclType? Type
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.AclType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>The unique identifer of the identity. For Microsoft Entra identities, value is set to the object identifier of the user, group or tenant for types user, group and everyone (and everyoneExceptGuests) respectively. For external groups, value is set to the ID of the externalGroup.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value
        {
            get { return BackingStore?.Get<string?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public string Value
        {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ExternalConnectors.Acl"/> and sets the default values.
        /// </summary>
        public Acl()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ExternalConnectors.Acl"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ExternalConnectors.Acl CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ExternalConnectors.Acl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessType", n => { AccessType = n.GetEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.AccessType>(); } },
                { "identitySource", n => { IdentitySource = n.GetEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.IdentitySourceType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "type", n => { Type = n.GetEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.AclType>(); } },
                { "value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.AccessType>("accessType", AccessType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.IdentitySourceType>("identitySource", IdentitySource);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ExternalConnectors.AclType>("type", Type);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
