// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    #pragma warning disable CS1591
    public class InboundActivityResults : Microsoft.Graph.Beta.Models.IndustryData.IndustryDataActivityStatistics, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of errors encountered while processing the inbound flow.</summary>
        public int? Errors
        {
            get { return BackingStore?.Get<int?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
        /// <summary>Counts of active and inactive groups processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric? Groups
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric Groups
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>Number of people matched to a Microsoft Entra user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>? MatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>?>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric> MatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>>("matchedPeopleByRole"); }
            set { BackingStore?.Set("matchedPeopleByRole", value); }
        }
#endif
        /// <summary>Counts of active and inactive memberships processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric? Memberships
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric?>("memberships"); }
            set { BackingStore?.Set("memberships", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric Memberships
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>("memberships"); }
            set { BackingStore?.Set("memberships", value); }
        }
#endif
        /// <summary>Counts of active and inactive organizations processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric? Organizations
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric?>("organizations"); }
            set { BackingStore?.Set("organizations", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric Organizations
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>("organizations"); }
            set { BackingStore?.Set("organizations", value); }
        }
#endif
        /// <summary>Counts of active and inactive people processed by the inbound flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric? People
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric?>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric People
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>("people"); }
            set { BackingStore?.Set("people", value); }
        }
#endif
        /// <summary>Number of people not matched to a Microsoft Entra user, by role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>? UnmatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>?>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric> UnmatchedPeopleByRole
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>>("unmatchedPeopleByRole"); }
            set { BackingStore?.Set("unmatchedPeopleByRole", value); }
        }
#endif
        /// <summary>Number of warnings encountered while processing the inbound flow.</summary>
        public int? Warnings
        {
            get { return BackingStore?.Get<int?>("warnings"); }
            set { BackingStore?.Set("warnings", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.IndustryData.InboundActivityResults"/> and sets the default values.
        /// </summary>
        public InboundActivityResults() : base()
        {
            OdataType = "#microsoft.graph.industryData.inboundActivityResults";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IndustryData.InboundActivityResults"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IndustryData.InboundActivityResults CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IndustryData.InboundActivityResults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "errors", n => { Errors = n.GetIntValue(); } },
                { "groups", n => { Groups = n.GetObjectValue<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                { "matchedPeopleByRole", n => { MatchedPeopleByRole = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                { "memberships", n => { Memberships = n.GetObjectValue<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                { "organizations", n => { Organizations = n.GetObjectValue<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                { "people", n => { People = n.GetObjectValue<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunEntityCountMetric.CreateFromDiscriminatorValue); } },
                { "unmatchedPeopleByRole", n => { UnmatchedPeopleByRole = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric>(Microsoft.Graph.Beta.Models.IndustryData.IndustryDataRunRoleCountMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                { "warnings", n => { Warnings = n.GetIntValue(); } },
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
        }
    }
}
