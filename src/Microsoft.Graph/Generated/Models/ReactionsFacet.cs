using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ReactionsFacet : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of comments.</summary>
        public int? CommentCount {
            get { return BackingStore?.Get<int?>("commentCount"); }
            set { BackingStore?.Set("commentCount", value); }
        }
        /// <summary>Count of likes.</summary>
        public int? LikeCount {
            get { return BackingStore?.Get<int?>("likeCount"); }
            set { BackingStore?.Set("likeCount", value); }
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
        /// <summary>Count of shares.</summary>
        public int? ShareCount {
            get { return BackingStore?.Get<int?>("shareCount"); }
            set { BackingStore?.Set("shareCount", value); }
        }
        /// <summary>
        /// Instantiates a new reactionsFacet and sets the default values.
        /// </summary>
        public ReactionsFacet() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReactionsFacet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReactionsFacet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"commentCount", n => { CommentCount = n.GetIntValue(); } },
                {"likeCount", n => { LikeCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"shareCount", n => { ShareCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("commentCount", CommentCount);
            writer.WriteIntValue("likeCount", LikeCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("shareCount", ShareCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
