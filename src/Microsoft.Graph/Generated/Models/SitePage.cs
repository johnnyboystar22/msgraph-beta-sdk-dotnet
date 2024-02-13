// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SitePage : BaseSitePage, IParsable {
        /// <summary>Indicates the layout of the content in a given SharePoint page, including horizontal sections and vertical sections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CanvasLayout? CanvasLayout {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CanvasLayout?>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CanvasLayout CanvasLayout {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout"); }
            set { BackingStore?.Set("canvasLayout", value); }
        }
#endif
        /// <summary>Indicates the promotion kind of the sitePage. The possible values are: microsoftReserved, page, newsPost, unknownFutureValue.</summary>
        public PagePromotionType? PromotionKind {
            get { return BackingStore?.Get<PagePromotionType?>("promotionKind"); }
            set { BackingStore?.Set("promotionKind", value); }
        }
        /// <summary>Reactions information for the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReactionsFacet? Reactions {
            get { return BackingStore?.Get<ReactionsFacet?>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#nullable restore
#else
        public ReactionsFacet Reactions {
            get { return BackingStore?.Get<ReactionsFacet>("reactions"); }
            set { BackingStore?.Set("reactions", value); }
        }
#endif
        /// <summary>Determines whether or not to show comments at the bottom of the page.</summary>
        public bool? ShowComments {
            get { return BackingStore?.Get<bool?>("showComments"); }
            set { BackingStore?.Set("showComments", value); }
        }
        /// <summary>Determines whether or not to show recommended pages at the bottom of the page.</summary>
        public bool? ShowRecommendedPages {
            get { return BackingStore?.Get<bool?>("showRecommendedPages"); }
            set { BackingStore?.Set("showRecommendedPages", value); }
        }
        /// <summary>Url of the sitePage&apos;s thumbnail image</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailWebUrl {
            get { return BackingStore?.Get<string?>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailWebUrl {
            get { return BackingStore?.Get<string>("thumbnailWebUrl"); }
            set { BackingStore?.Set("thumbnailWebUrl", value); }
        }
#endif
        /// <summary>Title area on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TitleArea? TitleArea {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TitleArea?>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TitleArea TitleArea {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TitleArea>("titleArea"); }
            set { BackingStore?.Set("titleArea", value); }
        }
#endif
        /// <summary>Collection of webparts on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WebPart>? WebParts {
            get { return BackingStore?.Get<List<WebPart>?>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#nullable restore
#else
        public List<WebPart> WebParts {
            get { return BackingStore?.Get<List<WebPart>>("webParts"); }
            set { BackingStore?.Set("webParts", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SitePage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SitePage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SitePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"canvasLayout", n => { CanvasLayout = n.GetObjectValue<Microsoft.Graph.Beta.Models.CanvasLayout>(Microsoft.Graph.Beta.Models.CanvasLayout.CreateFromDiscriminatorValue); } },
                {"promotionKind", n => { PromotionKind = n.GetEnumValue<PagePromotionType>(); } },
                {"reactions", n => { Reactions = n.GetObjectValue<ReactionsFacet>(ReactionsFacet.CreateFromDiscriminatorValue); } },
                {"showComments", n => { ShowComments = n.GetBoolValue(); } },
                {"showRecommendedPages", n => { ShowRecommendedPages = n.GetBoolValue(); } },
                {"thumbnailWebUrl", n => { ThumbnailWebUrl = n.GetStringValue(); } },
                {"titleArea", n => { TitleArea = n.GetObjectValue<Microsoft.Graph.Beta.Models.TitleArea>(Microsoft.Graph.Beta.Models.TitleArea.CreateFromDiscriminatorValue); } },
                {"webParts", n => { WebParts = n.GetCollectionOfObjectValues<WebPart>(WebPart.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CanvasLayout>("canvasLayout", CanvasLayout);
            writer.WriteEnumValue<PagePromotionType>("promotionKind", PromotionKind);
            writer.WriteObjectValue<ReactionsFacet>("reactions", Reactions);
            writer.WriteBoolValue("showComments", ShowComments);
            writer.WriteBoolValue("showRecommendedPages", ShowRecommendedPages);
            writer.WriteStringValue("thumbnailWebUrl", ThumbnailWebUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TitleArea>("titleArea", TitleArea);
            writer.WriteCollectionOfObjectValues<WebPart>("webParts", WebParts);
        }
    }
}
