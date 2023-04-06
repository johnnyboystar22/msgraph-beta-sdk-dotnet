using Microsoft.Graph.Beta.Models.Search;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SearchEntity : Entity, IParsable {
        /// <summary>Administrative answer in Microsoft Search results to define common acronyms in a organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Acronym>? Acronyms {
            get { return BackingStore?.Get<List<Acronym>?>("acronyms"); }
            set { BackingStore?.Set("acronyms", value); }
        }
#nullable restore
#else
        public List<Acronym> Acronyms {
            get { return BackingStore?.Get<List<Acronym>>("acronyms"); }
            set { BackingStore?.Set("acronyms", value); }
        }
#endif
        /// <summary>Administrative answer in Microsoft Search results for common search queries in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Bookmark>? Bookmarks {
            get { return BackingStore?.Get<List<Bookmark>?>("bookmarks"); }
            set { BackingStore?.Set("bookmarks", value); }
        }
#nullable restore
#else
        public List<Bookmark> Bookmarks {
            get { return BackingStore?.Get<List<Bookmark>>("bookmarks"); }
            set { BackingStore?.Set("bookmarks", value); }
        }
#endif
        /// <summary>Administrative answer in Microsoft Search results which provide answers for specific search keywords in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Qna>? Qnas {
            get { return BackingStore?.Get<List<Qna>?>("qnas"); }
            set { BackingStore?.Set("qnas", value); }
        }
#nullable restore
#else
        public List<Qna> Qnas {
            get { return BackingStore?.Get<List<Qna>>("qnas"); }
            set { BackingStore?.Set("qnas", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SearchEntity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acronyms", n => { Acronyms = n.GetCollectionOfObjectValues<Acronym>(Acronym.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bookmarks", n => { Bookmarks = n.GetCollectionOfObjectValues<Bookmark>(Bookmark.CreateFromDiscriminatorValue)?.ToList(); } },
                {"qnas", n => { Qnas = n.GetCollectionOfObjectValues<Qna>(Qna.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Acronym>("acronyms", Acronyms);
            writer.WriteCollectionOfObjectValues<Bookmark>("bookmarks", Bookmarks);
            writer.WriteCollectionOfObjectValues<Qna>("qnas", Qnas);
        }
    }
}
