using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Admin.Edge.InternetExplorerMode.SiteLists.Item.Publish {
    public class PublishPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The revision property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Revision {
            get { return BackingStore?.Get<string?>("revision"); }
            set { BackingStore?.Set("revision", value); }
        }
#nullable restore
#else
        public string Revision {
            get { return BackingStore?.Get<string>("revision"); }
            set { BackingStore?.Set("revision", value); }
        }
#endif
        /// <summary>The sharedCookies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSharedCookie>? SharedCookies {
            get { return BackingStore?.Get<List<BrowserSharedCookie>?>("sharedCookies"); }
            set { BackingStore?.Set("sharedCookies", value); }
        }
#nullable restore
#else
        public List<BrowserSharedCookie> SharedCookies {
            get { return BackingStore?.Get<List<BrowserSharedCookie>>("sharedCookies"); }
            set { BackingStore?.Set("sharedCookies", value); }
        }
#endif
        /// <summary>The sites property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSite>? Sites {
            get { return BackingStore?.Get<List<BrowserSite>?>("sites"); }
            set { BackingStore?.Set("sites", value); }
        }
#nullable restore
#else
        public List<BrowserSite> Sites {
            get { return BackingStore?.Get<List<BrowserSite>>("sites"); }
            set { BackingStore?.Set("sites", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new publishPostRequestBody and sets the default values.
        /// </summary>
        public PublishPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PublishPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublishPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"revision", n => { Revision = n.GetStringValue(); } },
                {"sharedCookies", n => { SharedCookies = n.GetCollectionOfObjectValues<BrowserSharedCookie>(BrowserSharedCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<BrowserSite>(BrowserSite.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("revision", Revision);
            writer.WriteCollectionOfObjectValues<BrowserSharedCookie>("sharedCookies", SharedCookies);
            writer.WriteCollectionOfObjectValues<BrowserSite>("sites", Sites);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
