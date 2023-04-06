using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class GovernanceRoleAssignmentRequest : Entity, IParsable {
        /// <summary>Required. The state of the assignment. The possible values are: Eligible (for eligible assignment),  Active (if it is directly assigned), Active (by administrators, or activated on an eligible assignment by the users).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentState {
            get { return BackingStore?.Get<string?>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#nullable restore
#else
        public string AssignmentState {
            get { return BackingStore?.Get<string>("assignmentState"); }
            set { BackingStore?.Set("assignmentState", value); }
        }
#endif
        /// <summary>If this is a request for role activation, it represents the id of the eligible assignment being referred; Otherwise, the value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedEligibleRoleAssignmentId {
            get { return BackingStore?.Get<string?>("linkedEligibleRoleAssignmentId"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignmentId", value); }
        }
#nullable restore
#else
        public string LinkedEligibleRoleAssignmentId {
            get { return BackingStore?.Get<string>("linkedEligibleRoleAssignmentId"); }
            set { BackingStore?.Set("linkedEligibleRoleAssignmentId", value); }
        }
#endif
        /// <summary>A message provided by users and administrators when create the request about why it is needed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>Read-only. The request create time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? RequestedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestedDateTime"); }
            set { BackingStore?.Set("requestedDateTime", value); }
        }
        /// <summary>Read-only. The resource that the request aims to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceResource? Resource {
            get { return BackingStore?.Get<GovernanceResource?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public GovernanceResource Resource {
            get { return BackingStore?.Get<GovernanceResource>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>Required. The unique identifier of the Azure resource that is associated with the role assignment request. Azure resources can include subscriptions, resource groups, virtual machines, and SQL databases.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>Read-only. The role definition that the request aims to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceRoleDefinition? RoleDefinition {
            get { return BackingStore?.Get<GovernanceRoleDefinition?>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#nullable restore
#else
        public GovernanceRoleDefinition RoleDefinition {
            get { return BackingStore?.Get<GovernanceRoleDefinition>("roleDefinition"); }
            set { BackingStore?.Set("roleDefinition", value); }
        }
#endif
        /// <summary>Required. The identifier of the Azure role definition that the role assignment request is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId {
            get { return BackingStore?.Get<string?>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#nullable restore
#else
        public string RoleDefinitionId {
            get { return BackingStore?.Get<string>("roleDefinitionId"); }
            set { BackingStore?.Set("roleDefinitionId", value); }
        }
#endif
        /// <summary>The schedule object of the role assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceSchedule? Schedule {
            get { return BackingStore?.Get<GovernanceSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public GovernanceSchedule Schedule {
            get { return BackingStore?.Get<GovernanceSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The status of the role assignment request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceRoleAssignmentRequestStatus? Status {
            get { return BackingStore?.Get<GovernanceRoleAssignmentRequestStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public GovernanceRoleAssignmentRequestStatus Status {
            get { return BackingStore?.Get<GovernanceRoleAssignmentRequestStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>Read-only. The user/group principal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GovernanceSubject? Subject {
            get { return BackingStore?.Get<GovernanceSubject?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public GovernanceSubject Subject {
            get { return BackingStore?.Get<GovernanceSubject>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>Required. The unique identifier of the principal or subject that the role assignment request is associated with. Principals can be users, groups, or service principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId {
            get { return BackingStore?.Get<string?>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#nullable restore
#else
        public string SubjectId {
            get { return BackingStore?.Get<string>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#endif
        /// <summary>Required. Representing the type of the operation on the role assignment. The possible values are: AdminAdd , UserAdd , AdminUpdate , AdminRemove , UserRemove , UserExtend , AdminExtend , UserRenew , AdminRenew.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GovernanceRoleAssignmentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GovernanceRoleAssignmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignmentState", n => { AssignmentState = n.GetStringValue(); } },
                {"linkedEligibleRoleAssignmentId", n => { LinkedEligibleRoleAssignmentId = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"requestedDateTime", n => { RequestedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<GovernanceResource>(GovernanceResource.CreateFromDiscriminatorValue); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<GovernanceRoleDefinition>(GovernanceRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<GovernanceSchedule>(GovernanceSchedule.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetObjectValue<GovernanceRoleAssignmentRequestStatus>(GovernanceRoleAssignmentRequestStatus.CreateFromDiscriminatorValue); } },
                {"subject", n => { Subject = n.GetObjectValue<GovernanceSubject>(GovernanceSubject.CreateFromDiscriminatorValue); } },
                {"subjectId", n => { SubjectId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("assignmentState", AssignmentState);
            writer.WriteStringValue("linkedEligibleRoleAssignmentId", LinkedEligibleRoleAssignmentId);
            writer.WriteStringValue("reason", Reason);
            writer.WriteDateTimeOffsetValue("requestedDateTime", RequestedDateTime);
            writer.WriteObjectValue<GovernanceResource>("resource", Resource);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteObjectValue<GovernanceRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<GovernanceSchedule>("schedule", Schedule);
            writer.WriteObjectValue<GovernanceRoleAssignmentRequestStatus>("status", Status);
            writer.WriteObjectValue<GovernanceSubject>("subject", Subject);
            writer.WriteStringValue("subjectId", SubjectId);
            writer.WriteStringValue("type", Type);
        }
    }
}
