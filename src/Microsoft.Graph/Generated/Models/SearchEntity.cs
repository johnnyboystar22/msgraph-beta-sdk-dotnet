// <auto-generated/>
using Microsoft.Graph.Beta.Models.Search;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SearchEntity : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Administrative answer in Microsoft Search results to define common acronyms in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Search.Acronym>? Acronyms
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Acronym>?>("acronyms"); }
            set { BackingStore?.Set("acronyms", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Search.Acronym> Acronyms
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Acronym>>("acronyms"); }
            set { BackingStore?.Set("acronyms", value); }
        }
#endif
        /// <summary>Administrative answer in Microsoft Search results for common search queries in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Search.Bookmark>? Bookmarks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Bookmark>?>("bookmarks"); }
            set { BackingStore?.Set("bookmarks", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Search.Bookmark> Bookmarks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Bookmark>>("bookmarks"); }
            set { BackingStore?.Set("bookmarks", value); }
        }
#endif
        /// <summary>Administrative answer in Microsoft Search results that provide answers for specific search keywords in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Search.Qna>? Qnas
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Qna>?>("qnas"); }
            set { BackingStore?.Set("qnas", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Search.Qna> Qnas
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Search.Qna>>("qnas"); }
            set { BackingStore?.Set("qnas", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SearchEntity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.SearchEntity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SearchEntity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "acronyms", n => { Acronyms = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Acronym>(Microsoft.Graph.Beta.Models.Search.Acronym.CreateFromDiscriminatorValue)?.ToList(); } },
                { "bookmarks", n => { Bookmarks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Bookmark>(Microsoft.Graph.Beta.Models.Search.Bookmark.CreateFromDiscriminatorValue)?.ToList(); } },
                { "qnas", n => { Qnas = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Qna>(Microsoft.Graph.Beta.Models.Search.Qna.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Acronym>("acronyms", Acronyms);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Bookmark>("bookmarks", Bookmarks);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Search.Qna>("qnas", Qnas);
        }
    }
}
