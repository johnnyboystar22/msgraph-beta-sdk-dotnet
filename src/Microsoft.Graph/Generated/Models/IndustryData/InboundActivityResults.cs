using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class InboundActivityResults : IndustryDataActivityStatistics, IParsable {
        /// <summary>Number of errors encountered while processing the inbound flow.</summary>
        public int? Errors {
            get { return BackingStore?.Get<int?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
        /// <summary>Counts of active and inactive groups processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataRunEntityCountMetric? Groups {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public IndustryDataRunEntityCountMetric Groups {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>Number of people matched to an Azure Active Directory user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataRunRoleCountMetric>? MatchedPeopleByRole {
            get { return BackingStore?.Get<List<IndustryDataRunRoleCountMetric>?>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<IndustryDataRunRoleCountMetric> MatchedPeopleByRole {
            get { return BackingStore?.Get<List<IndustryDataRunRoleCountMetric>>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#endif
        /// <summary>Counts of active and inactive memberships processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataRunEntityCountMetric? Memberships {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric?>("memberships"); }
            set { BackingStore?.Set("memberships", value); }
        }
#nullable restore
#else
        public IndustryDataRunEntityCountMetric Memberships {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric>("memberships"); }
            set { BackingStore?.Set("memberships", value); }
        }
#endif
        /// <summary>Counts of active and inactive organizations processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataRunEntityCountMetric? Organizations {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric?>("organizations"); }
            set { BackingStore?.Set("organizations", value); }
        }
#nullable restore
#else
        public IndustryDataRunEntityCountMetric Organizations {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric>("organizations"); }
            set { BackingStore?.Set("organizations", value); }
        }
#endif
        /// <summary>Counts of active and inactive people processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IndustryDataRunEntityCountMetric? People {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric?>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#nullable restore
#else
        public IndustryDataRunEntityCountMetric People {
            get { return BackingStore?.Get<IndustryDataRunEntityCountMetric>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#endif
        /// <summary>Number of people not matched to an Azure Active Directory user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataRunRoleCountMetric>? UnmatchedPeopleByRole {
            get { return BackingStore?.Get<List<IndustryDataRunRoleCountMetric>?>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<IndustryDataRunRoleCountMetric> UnmatchedPeopleByRole {
            get { return BackingStore?.Get<List<IndustryDataRunRoleCountMetric>>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#endif
        /// <summary>Number of warnings encountered while processing the inbound flow.</summary>
        public int? Warnings {
            get { return BackingStore?.Get<int?>("warnings"); }
            set { BackingStore?.Set("warnings", value); }
        }
        /// <summary>
        /// Instantiates a new InboundActivityResults and sets the default values.
        /// </summary>
        public InboundActivityResults() : base() {
            OdataType = "#microsoft.graph.industryData.inboundActivityResults";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InboundActivityResults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InboundActivityResults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"errors", n => { Errors = n.GetIntValue(); } },
                {"groups", n => { Groups = n.GetObjectValue<IndustryDataRunEntityCountMetric>(IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                {"matchedPeopleByRole", n => { MatchedPeopleByRole = n.GetCollectionOfObjectValues<IndustryDataRunRoleCountMetric>(IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"memberships", n => { Memberships = n.GetObjectValue<IndustryDataRunEntityCountMetric>(IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                {"organizations", n => { Organizations = n.GetObjectValue<IndustryDataRunEntityCountMetric>(IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                {"people", n => { People = n.GetObjectValue<IndustryDataRunEntityCountMetric>(IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                {"unmatchedPeopleByRole", n => { UnmatchedPeopleByRole = n.GetCollectionOfObjectValues<IndustryDataRunRoleCountMetric>(IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"warnings", n => { Warnings = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
