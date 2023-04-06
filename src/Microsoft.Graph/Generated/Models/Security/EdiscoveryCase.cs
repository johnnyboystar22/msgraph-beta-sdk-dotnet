using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryCase : Case, IParsable {
        /// <summary>The user who closed the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentitySet? ClosedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet?>("closedBy"); }
            set { BackingStore?.Set("closedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentitySet ClosedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>("closedBy"); }
            set { BackingStore?.Set("closedBy", value); }
        }
#endif
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("closedDateTime"); }
            set { BackingStore?.Set("closedDateTime", value); }
        }
        /// <summary>Returns a list of case ediscoveryCustodian objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryCustodian>? Custodians {
            get { return BackingStore?.Get<List<EdiscoveryCustodian>?>("custodians"); }
            set { BackingStore?.Set("custodians", value); }
        }
#nullable restore
#else
        public List<EdiscoveryCustodian> Custodians {
            get { return BackingStore?.Get<List<EdiscoveryCustodian>>("custodians"); }
            set { BackingStore?.Set("custodians", value); }
        }
#endif
        /// <summary>The external case number for customer reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>Returns a list of case eDiscoveryHoldPolicy objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryHoldPolicy>? LegalHolds {
            get { return BackingStore?.Get<List<EdiscoveryHoldPolicy>?>("legalHolds"); }
            set { BackingStore?.Set("legalHolds", value); }
        }
#nullable restore
#else
        public List<EdiscoveryHoldPolicy> LegalHolds {
            get { return BackingStore?.Get<List<EdiscoveryHoldPolicy>>("legalHolds"); }
            set { BackingStore?.Set("legalHolds", value); }
        }
#endif
        /// <summary>Returns a list of case ediscoveryNoncustodialDataSource objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryNoncustodialDataSource>? NoncustodialDataSources {
            get { return BackingStore?.Get<List<EdiscoveryNoncustodialDataSource>?>("noncustodialDataSources"); }
            set { BackingStore?.Set("noncustodialDataSources", value); }
        }
#nullable restore
#else
        public List<EdiscoveryNoncustodialDataSource> NoncustodialDataSources {
            get { return BackingStore?.Get<List<EdiscoveryNoncustodialDataSource>>("noncustodialDataSources"); }
            set { BackingStore?.Set("noncustodialDataSources", value); }
        }
#endif
        /// <summary>Returns a list of case caseOperation objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CaseOperation>? Operations {
            get { return BackingStore?.Get<List<CaseOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<CaseOperation> Operations {
            get { return BackingStore?.Get<List<CaseOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Returns a list of eDiscoveryReviewSet objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewSet>? ReviewSets {
            get { return BackingStore?.Get<List<EdiscoveryReviewSet>?>("reviewSets"); }
            set { BackingStore?.Set("reviewSets", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewSet> ReviewSets {
            get { return BackingStore?.Get<List<EdiscoveryReviewSet>>("reviewSets"); }
            set { BackingStore?.Set("reviewSets", value); }
        }
#endif
        /// <summary>Returns a list of eDiscoverySearch objects associated with this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoverySearch>? Searches {
            get { return BackingStore?.Get<List<EdiscoverySearch>?>("searches"); }
            set { BackingStore?.Set("searches", value); }
        }
#nullable restore
#else
        public List<EdiscoverySearch> Searches {
            get { return BackingStore?.Get<List<EdiscoverySearch>>("searches"); }
            set { BackingStore?.Set("searches", value); }
        }
#endif
        /// <summary>Returns a list of eDIscoverySettings objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryCaseSettings? Settings {
            get { return BackingStore?.Get<EdiscoveryCaseSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public EdiscoveryCaseSettings Settings {
            get { return BackingStore?.Get<EdiscoveryCaseSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Returns a list of ediscoveryReviewTag objects associated to this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? Tags {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewTag> Tags {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new EdiscoveryCase and sets the default values.
        /// </summary>
        public EdiscoveryCase() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryCase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryCase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryCase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"closedBy", n => { ClosedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodians", n => { Custodians = n.GetCollectionOfObjectValues<EdiscoveryCustodian>(EdiscoveryCustodian.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"legalHolds", n => { LegalHolds = n.GetCollectionOfObjectValues<EdiscoveryHoldPolicy>(EdiscoveryHoldPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>(EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<EdiscoveryReviewSet>(EdiscoveryReviewSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"searches", n => { Searches = n.GetCollectionOfObjectValues<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EdiscoveryCaseSettings>(EdiscoveryCaseSettings.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<EdiscoveryCustodian>("custodians", Custodians);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<EdiscoveryHoldPolicy>("legalHolds", LegalHolds);
            writer.WriteCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewSet>("reviewSets", ReviewSets);
            writer.WriteCollectionOfObjectValues<EdiscoverySearch>("searches", Searches);
            writer.WriteObjectValue<EdiscoveryCaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
