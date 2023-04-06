using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SharepointIds : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique identifier (guid) for the item&apos;s list in SharePoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListId {
            get { return BackingStore?.Get<string?>("listId"); }
            set { BackingStore?.Set("listId", value); }
        }
#nullable restore
#else
        public string ListId {
            get { return BackingStore?.Get<string>("listId"); }
            set { BackingStore?.Set("listId", value); }
        }
#endif
        /// <summary>An integer identifier for the item within the containing list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListItemId {
            get { return BackingStore?.Get<string?>("listItemId"); }
            set { BackingStore?.Set("listItemId", value); }
        }
#nullable restore
#else
        public string ListItemId {
            get { return BackingStore?.Get<string>("listItemId"); }
            set { BackingStore?.Set("listItemId", value); }
        }
#endif
        /// <summary>The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListItemUniqueId {
            get { return BackingStore?.Get<string?>("listItemUniqueId"); }
            set { BackingStore?.Set("listItemUniqueId", value); }
        }
#nullable restore
#else
        public string ListItemUniqueId {
            get { return BackingStore?.Get<string>("listItemUniqueId"); }
            set { BackingStore?.Set("listItemUniqueId", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The unique identifier (guid) for the item&apos;s site collection (SPSite).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteId {
            get { return BackingStore?.Get<string?>("siteId"); }
            set { BackingStore?.Set("siteId", value); }
        }
#nullable restore
#else
        public string SiteId {
            get { return BackingStore?.Get<string>("siteId"); }
            set { BackingStore?.Set("siteId", value); }
        }
#endif
        /// <summary>The SharePoint URL for the site that contains the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteUrl {
            get { return BackingStore?.Get<string?>("siteUrl"); }
            set { BackingStore?.Set("siteUrl", value); }
        }
#nullable restore
#else
        public string SiteUrl {
            get { return BackingStore?.Get<string>("siteUrl"); }
            set { BackingStore?.Set("siteUrl", value); }
        }
#endif
        /// <summary>The unique identifier (guid) for the tenancy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The unique identifier (guid) for the item&apos;s site (SPWeb).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebId {
            get { return BackingStore?.Get<string?>("webId"); }
            set { BackingStore?.Set("webId", value); }
        }
#nullable restore
#else
        public string WebId {
            get { return BackingStore?.Get<string>("webId"); }
            set { BackingStore?.Set("webId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new sharepointIds and sets the default values.
        /// </summary>
        public SharepointIds() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SharepointIds CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharepointIds();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"listId", n => { ListId = n.GetStringValue(); } },
                {"listItemId", n => { ListItemId = n.GetStringValue(); } },
                {"listItemUniqueId", n => { ListItemUniqueId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"siteId", n => { SiteId = n.GetStringValue(); } },
                {"siteUrl", n => { SiteUrl = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"webId", n => { WebId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("listId", ListId);
            writer.WriteStringValue("listItemId", ListItemId);
            writer.WriteStringValue("listItemUniqueId", ListItemUniqueId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteStringValue("siteUrl", SiteUrl);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("webId", WebId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
