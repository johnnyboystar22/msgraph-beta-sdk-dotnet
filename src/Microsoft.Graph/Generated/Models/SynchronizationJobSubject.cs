// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SynchronizationJobSubject : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Principals that you would like to provision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects? Links
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects Links
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#endif
        /// <summary>The identifier of an object to which a synchronizationJob is to be applied. Can be one of the following: An onPremisesDistinguishedName for synchronization from Active Directory to Azure AD.The user ID for synchronization from Microsoft Entra ID to a third-party.The Worker ID of the Workday worker for synchronization from Workday to either Active Directory or Azure AD.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId
        {
            get { return BackingStore?.Get<string?>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#nullable restore
#else
        public string ObjectId
        {
            get { return BackingStore?.Get<string>("objectId"); }
            set { BackingStore?.Set("objectId", value); }
        }
#endif
        /// <summary>The type of the object to which a synchronizationJob is to be applied. Can be one of the following: user for synchronizing between Active Directory and Azure AD.User for synchronizing a user between Microsoft Entra ID and a third-party application. Worker for synchronization a user between Workday and either Active Directory or Azure AD.Group for synchronizing a group between Microsoft Entra ID and a third-party application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectTypeName
        {
            get { return BackingStore?.Get<string?>("objectTypeName"); }
            set { BackingStore?.Set("objectTypeName", value); }
        }
#nullable restore
#else
        public string ObjectTypeName
        {
            get { return BackingStore?.Get<string>("objectTypeName"); }
            set { BackingStore?.Set("objectTypeName", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.SynchronizationJobSubject"/> and sets the default values.
        /// </summary>
        public SynchronizationJobSubject()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SynchronizationJobSubject"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.SynchronizationJobSubject CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SynchronizationJobSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "links", n => { Links = n.GetObjectValue<Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects>(Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects.CreateFromDiscriminatorValue); } },
                { "objectId", n => { ObjectId = n.GetStringValue(); } },
                { "objectTypeName", n => { ObjectTypeName = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SynchronizationLinkedObjects>("links", Links);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("objectTypeName", ObjectTypeName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
