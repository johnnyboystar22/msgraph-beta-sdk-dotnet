// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AccessReviewInstanceDecisionItem : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier of the accessReviewInstance parent. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessReviewId
        {
            get { return BackingStore?.Get<string?>("accessReviewId"); }
            set { BackingStore?.Set("accessReviewId", value); }
        }
#nullable restore
#else
        public string AccessReviewId
        {
            get { return BackingStore?.Get<string>("accessReviewId"); }
            set { BackingStore?.Set("accessReviewId", value); }
        }
#endif
        /// <summary>The identifier of the user who applied the decision. 00000000-0000-0000-0000-000000000000 if the assigned reviewer hasn&apos;t applied the decision or it was automatically applied. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UserIdentity? AppliedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserIdentity?>("appliedBy"); }
            set { BackingStore?.Set("appliedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UserIdentity AppliedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserIdentity>("appliedBy"); }
            set { BackingStore?.Set("appliedBy", value); }
        }
#endif
        /// <summary>The timestamp when the approval decision was applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $select. Read-only.</summary>
        public DateTimeOffset? AppliedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("appliedDateTime"); }
            set { BackingStore?.Set("appliedDateTime", value); }
        }
        /// <summary>The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound, and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplyResult
        {
            get { return BackingStore?.Get<string?>("applyResult"); }
            set { BackingStore?.Set("applyResult", value); }
        }
#nullable restore
#else
        public string ApplyResult
        {
            get { return BackingStore?.Get<string>("applyResult"); }
            set { BackingStore?.Set("applyResult", value); }
        }
#endif
        /// <summary>Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Decision
        {
            get { return BackingStore?.Get<string?>("decision"); }
            set { BackingStore?.Set("decision", value); }
        }
#nullable restore
#else
        public string Decision
        {
            get { return BackingStore?.Get<string>("decision"); }
            set { BackingStore?.Set("decision", value); }
        }
#endif
        /// <summary>Insights are recommendations to reviewers on whether to approve or deny a decision. There can be multiple insights associated with an accessReviewInstanceDecisionItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.GovernanceInsight>? Insights
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceInsight>?>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.GovernanceInsight> Insights
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.GovernanceInsight>>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#endif
        /// <summary>There&apos;s exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessReviewInstance? Instance
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstance?>("instance"); }
            set { BackingStore?.Set("instance", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessReviewInstance Instance
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstance>("instance"); }
            set { BackingStore?.Set("instance", value); }
        }
#endif
        /// <summary>Justification left by the reviewer when they made the decision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification
        {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification
        {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the principal. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is &apos;Bob&apos; and the resource is &apos;Sales&apos;. Principals can be of two types - userIdentity and servicePrincipalIdentity. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Identity? Principal
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Identity?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Identity Principal
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Identity>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>Link to the principal object. For example: https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalLink
        {
            get { return BackingStore?.Get<string?>("principalLink"); }
            set { BackingStore?.Set("principalLink", value); }
        }
#nullable restore
#else
        public string PrincipalLink
        {
            get { return BackingStore?.Get<string>("principalLink"); }
            set { BackingStore?.Set("principalLink", value); }
        }
#endif
        /// <summary>Every decision item in an access review represents a principal&apos;s membership to a resource. This property provides the details of the membership. For example, whether the principal has direct access or indirect access to the resource. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership? PrincipalResourceMembership
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership?>("principalResourceMembership"); }
            set { BackingStore?.Set("principalResourceMembership", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership PrincipalResourceMembership
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership>("principalResourceMembership"); }
            set { BackingStore?.Set("principalResourceMembership", value); }
        }
#endif
        /// <summary>A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within 30 days of start of review. Recommend deny if sign-in is greater than 30 days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Recommendation
        {
            get { return BackingStore?.Get<string?>("recommendation"); }
            set { BackingStore?.Set("recommendation", value); }
        }
#nullable restore
#else
        public string Recommendation
        {
            get { return BackingStore?.Get<string>("recommendation"); }
            set { BackingStore?.Set("recommendation", value); }
        }
#endif
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the resource. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is Bob and the resource is &apos;Sales&apos;. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource? Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource Resource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLink
        {
            get { return BackingStore?.Get<string?>("resourceLink"); }
            set { BackingStore?.Set("resourceLink", value); }
        }
#nullable restore
#else
        public string ResourceLink
        {
            get { return BackingStore?.Get<string>("resourceLink"); }
            set { BackingStore?.Set("resourceLink", value); }
        }
#endif
        /// <summary>The identifier of the reviewer. 00000000-0000-0000-0000-000000000000 if the assigned reviewer hasn&apos;t reviewed. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UserIdentity? ReviewedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserIdentity?>("reviewedBy"); }
            set { BackingStore?.Set("reviewedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UserIdentity ReviewedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserIdentity>("reviewedBy"); }
            set { BackingStore?.Set("reviewedBy", value); }
        }
#endif
        /// <summary>The timestamp when the review decision occurred. Supports $select. Read-only.</summary>
        public DateTimeOffset? ReviewedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("reviewedDateTime"); }
            set { BackingStore?.Set("reviewedDateTime", value); }
        }
        /// <summary>The target of this specific decision. Decision targets can be of different types – each one with its own specific properties. See accessReviewInstanceDecisionItemTarget. Read-only.  This property is replaced by the principal and resource properties in v1.0.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget? Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessReviewId", n => { AccessReviewId = n.GetStringValue(); } },
                { "appliedBy", n => { AppliedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserIdentity>(Microsoft.Graph.Beta.Models.UserIdentity.CreateFromDiscriminatorValue); } },
                { "appliedDateTime", n => { AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                { "applyResult", n => { ApplyResult = n.GetStringValue(); } },
                { "decision", n => { Decision = n.GetStringValue(); } },
                { "insights", n => { Insights = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceInsight>(Microsoft.Graph.Beta.Models.GovernanceInsight.CreateFromDiscriminatorValue)?.ToList(); } },
                { "instance", n => { Instance = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstance>(Microsoft.Graph.Beta.Models.AccessReviewInstance.CreateFromDiscriminatorValue); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "principal", n => { Principal = n.GetObjectValue<Microsoft.Graph.Beta.Models.Identity>(Microsoft.Graph.Beta.Models.Identity.CreateFromDiscriminatorValue); } },
                { "principalLink", n => { PrincipalLink = n.GetStringValue(); } },
                { "principalResourceMembership", n => { PrincipalResourceMembership = n.GetObjectValue<Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership>(Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership.CreateFromDiscriminatorValue); } },
                { "recommendation", n => { Recommendation = n.GetStringValue(); } },
                { "resource", n => { Resource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource>(Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource.CreateFromDiscriminatorValue); } },
                { "resourceLink", n => { ResourceLink = n.GetStringValue(); } },
                { "reviewedBy", n => { ReviewedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserIdentity>(Microsoft.Graph.Beta.Models.UserIdentity.CreateFromDiscriminatorValue); } },
                { "reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
                { "target", n => { Target = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget>(Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("accessReviewId", AccessReviewId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserIdentity>("appliedBy", AppliedBy);
            writer.WriteDateTimeOffsetValue("appliedDateTime", AppliedDateTime);
            writer.WriteStringValue("applyResult", ApplyResult);
            writer.WriteStringValue("decision", Decision);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.GovernanceInsight>("insights", Insights);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstance>("instance", Instance);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Identity>("principal", Principal);
            writer.WriteStringValue("principalLink", PrincipalLink);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DecisionItemPrincipalResourceMembership>("principalResourceMembership", PrincipalResourceMembership);
            writer.WriteStringValue("recommendation", Recommendation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemResource>("resource", Resource);
            writer.WriteStringValue("resourceLink", ResourceLink);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserIdentity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItemTarget>("target", Target);
        }
    }
}
