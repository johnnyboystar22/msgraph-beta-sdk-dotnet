// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SkillProficiency : Microsoft.Graph.Beta.Models.ItemFacet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains categories a user has associated with the skill (for example, personal, professional, hobby).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories
        {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories
        {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CollaborationTags
        {
            get { return BackingStore?.Get<List<string>?>("collaborationTags"); }
            set { BackingStore?.Set("collaborationTags", value); }
        }
#nullable restore
#else
        public List<string> CollaborationTags
        {
            get { return BackingStore?.Get<List<string>>("collaborationTags"); }
            set { BackingStore?.Set("collaborationTags", value); }
        }
#endif
        /// <summary>Contains a friendly name for the skill.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Detail of the users proficiency with this skill. Possible values are: elementary, limitedWorking, generalProfessional, advancedProfessional, expert, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.SkillProficiencyLevel? Proficiency
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SkillProficiencyLevel?>("proficiency"); }
            set { BackingStore?.Set("proficiency", value); }
        }
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl
        {
            get { return BackingStore?.Get<string?>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailUrl
        {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#endif
        /// <summary>Contains a link to an information source about the skill.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.SkillProficiency"/> and sets the default values.
        /// </summary>
        public SkillProficiency() : base()
        {
            OdataType = "#microsoft.graph.skillProficiency";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SkillProficiency"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.SkillProficiency CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SkillProficiency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "collaborationTags", n => { CollaborationTags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "proficiency", n => { Proficiency = n.GetEnumValue<Microsoft.Graph.Beta.Models.SkillProficiencyLevel>(); } },
                { "thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SkillProficiencyLevel>("proficiency", Proficiency);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
