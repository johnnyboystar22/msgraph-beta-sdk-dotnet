using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTeamsPublicationInfo : PlannerTaskCreation, IParsable {
        /// <summary>The date and time when this task was last modified by the publication process. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The identifier of the publication. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicationId {
            get { return BackingStore?.Get<string?>("publicationId"); }
            set { BackingStore?.Set("publicationId", value); }
        }
#nullable restore
#else
        public string PublicationId {
            get { return BackingStore?.Get<string>("publicationId"); }
            set { BackingStore?.Set("publicationId", value); }
        }
#endif
        /// <summary>The identifier of the plannerPlan this task was originally placed in. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublishedToPlanId {
            get { return BackingStore?.Get<string?>("publishedToPlanId"); }
            set { BackingStore?.Set("publishedToPlanId", value); }
        }
#nullable restore
#else
        public string PublishedToPlanId {
            get { return BackingStore?.Get<string>("publishedToPlanId"); }
            set { BackingStore?.Set("publishedToPlanId", value); }
        }
#endif
        /// <summary>The identifier of the team that initiated the publication process. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublishingTeamId {
            get { return BackingStore?.Get<string?>("publishingTeamId"); }
            set { BackingStore?.Set("publishingTeamId", value); }
        }
#nullable restore
#else
        public string PublishingTeamId {
            get { return BackingStore?.Get<string>("publishingTeamId"); }
            set { BackingStore?.Set("publishingTeamId", value); }
        }
#endif
        /// <summary>The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublishingTeamName {
            get { return BackingStore?.Get<string?>("publishingTeamName"); }
            set { BackingStore?.Set("publishingTeamName", value); }
        }
#nullable restore
#else
        public string PublishingTeamName {
            get { return BackingStore?.Get<string>("publishingTeamName"); }
            set { BackingStore?.Set("publishingTeamName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerTeamsPublicationInfo and sets the default values.
        /// </summary>
        public PlannerTeamsPublicationInfo() : base() {
            OdataType = "#microsoft.graph.plannerTeamsPublicationInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerTeamsPublicationInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTeamsPublicationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publicationId", n => { PublicationId = n.GetStringValue(); } },
                {"publishedToPlanId", n => { PublishedToPlanId = n.GetStringValue(); } },
                {"publishingTeamId", n => { PublishingTeamId = n.GetStringValue(); } },
                {"publishingTeamName", n => { PublishingTeamName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("publicationId", PublicationId);
            writer.WriteStringValue("publishedToPlanId", PublishedToPlanId);
            writer.WriteStringValue("publishingTeamId", PublishingTeamId);
            writer.WriteStringValue("publishingTeamName", PublishingTeamName);
        }
    }
}
