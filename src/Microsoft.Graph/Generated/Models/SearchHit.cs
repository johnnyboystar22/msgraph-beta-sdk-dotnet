using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SearchHit : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The _summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? _summary {
            get { return BackingStore?.Get<string?>("_summary"); }
            set { BackingStore?.Set("_summary", value); }
        }
#nullable restore
#else
        public string _summary {
            get { return BackingStore?.Get<string>("_summary"); }
            set { BackingStore?.Set("_summary", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the content source that the externalItem is part of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentSource {
            get { return BackingStore?.Get<string?>("contentSource"); }
            set { BackingStore?.Set("contentSource", value); }
        }
#nullable restore
#else
        public string ContentSource {
            get { return BackingStore?.Get<string>("contentSource"); }
            set { BackingStore?.Set("contentSource", value); }
        }
#endif
        /// <summary>The internal identifier for the item. The format of the identifier varies based on the entity type. For details, see hitId format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HitId {
            get { return BackingStore?.Get<string?>("hitId"); }
            set { BackingStore?.Set("hitId", value); }
        }
#nullable restore
#else
        public string HitId {
            get { return BackingStore?.Get<string>("hitId"); }
            set { BackingStore?.Set("hitId", value); }
        }
#endif
        /// <summary>The _id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("_id"); }
            set { BackingStore?.Set("_id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("_id"); }
            set { BackingStore?.Set("_id", value); }
        }
#endif
        /// <summary>Indicates whether the current result is collapses when the collapseProperties property is used.</summary>
        public bool? IsCollapsed {
            get { return BackingStore?.Get<bool?>("isCollapsed"); }
            set { BackingStore?.Set("isCollapsed", value); }
        }
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
        /// <summary>The rank or the order of the result.</summary>
        public int? Rank {
            get { return BackingStore?.Get<int?>("rank"); }
            set { BackingStore?.Set("rank", value); }
        }
        /// <summary>The resource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource {
            get { return BackingStore?.Get<Entity?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Entity Resource {
            get { return BackingStore?.Get<Entity>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>ID of the result template for rendering the search result. This ID must map to a display layout in the resultTemplates dictionary, included in the searchresponse as well.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultTemplateId {
            get { return BackingStore?.Get<string?>("resultTemplateId"); }
            set { BackingStore?.Set("resultTemplateId", value); }
        }
#nullable restore
#else
        public string ResultTemplateId {
            get { return BackingStore?.Get<string>("resultTemplateId"); }
            set { BackingStore?.Set("resultTemplateId", value); }
        }
#endif
        /// <summary>The _score property</summary>
        public int? Score {
            get { return BackingStore?.Get<int?>("_score"); }
            set { BackingStore?.Set("_score", value); }
        }
        /// <summary>The _source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Source {
            get { return BackingStore?.Get<Entity?>("_source"); }
            set { BackingStore?.Set("_source", value); }
        }
#nullable restore
#else
        public Entity Source {
            get { return BackingStore?.Get<Entity>("_source"); }
            set { BackingStore?.Set("_source", value); }
        }
#endif
        /// <summary>A summary of the result, if a summary is available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary {
            get { return BackingStore?.Get<string?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public string Summary {
            get { return BackingStore?.Get<string>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new searchHit and sets the default values.
        /// </summary>
        public SearchHit() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchHit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"_summary", n => { _summary = n.GetStringValue(); } },
                {"contentSource", n => { ContentSource = n.GetStringValue(); } },
                {"hitId", n => { HitId = n.GetStringValue(); } },
                {"_id", n => { Id = n.GetStringValue(); } },
                {"isCollapsed", n => { IsCollapsed = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resultTemplateId", n => { ResultTemplateId = n.GetStringValue(); } },
                {"_score", n => { Score = n.GetIntValue(); } },
                {"_source", n => { Source = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("_summary", _summary);
            writer.WriteStringValue("contentSource", ContentSource);
            writer.WriteStringValue("hitId", HitId);
            writer.WriteStringValue("_id", Id);
            writer.WriteBoolValue("isCollapsed", IsCollapsed);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("rank", Rank);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteStringValue("resultTemplateId", ResultTemplateId);
            writer.WriteIntValue("_score", Score);
            writer.WriteObjectValue<Entity>("_source", Source);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
