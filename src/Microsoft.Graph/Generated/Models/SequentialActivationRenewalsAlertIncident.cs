using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SequentialActivationRenewalsAlertIncident : UnifiedRoleManagementAlertIncident, IParsable {
        /// <summary>The activationCount property</summary>
        public int? ActivationCount {
            get { return BackingStore?.Get<int?>("activationCount"); }
            set { BackingStore?.Set("activationCount", value); }
        }
        /// <summary>The assigneeDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeDisplayName {
            get { return BackingStore?.Get<string?>("assigneeDisplayName"); }
            set { BackingStore?.Set("assigneeDisplayName", value); }
        }
#nullable restore
#else
        public string AssigneeDisplayName {
            get { return BackingStore?.Get<string>("assigneeDisplayName"); }
            set { BackingStore?.Set("assigneeDisplayName", value); }
        }
#endif
        /// <summary>The assigneeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeId {
            get { return BackingStore?.Get<string?>("assigneeId"); }
            set { BackingStore?.Set("assigneeId", value); }
        }
#nullable restore
#else
        public string AssigneeId {
            get { return BackingStore?.Get<string>("assigneeId"); }
            set { BackingStore?.Set("assigneeId", value); }
        }
#endif
        /// <summary>The assigneeUserPrincipalName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneeUserPrincipalName {
            get { return BackingStore?.Get<string?>("assigneeUserPrincipalName"); }
            set { BackingStore?.Set("assigneeUserPrincipalName", value); }
        }
#nullable restore
#else
        public string AssigneeUserPrincipalName {
            get { return BackingStore?.Get<string>("assigneeUserPrincipalName"); }
            set { BackingStore?.Set("assigneeUserPrincipalName", value); }
        }
#endif
        /// <summary>The roleDefinitionId property</summary>
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
        /// <summary>The roleDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDisplayName {
            get { return BackingStore?.Get<string?>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#nullable restore
#else
        public string RoleDisplayName {
            get { return BackingStore?.Get<string>("roleDisplayName"); }
            set { BackingStore?.Set("roleDisplayName", value); }
        }
#endif
        /// <summary>The roleTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId {
            get { return BackingStore?.Get<string?>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#nullable restore
#else
        public string RoleTemplateId {
            get { return BackingStore?.Get<string>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#endif
        /// <summary>The sequenceEndDateTime property</summary>
        public DateTimeOffset? SequenceEndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sequenceEndDateTime"); }
            set { BackingStore?.Set("sequenceEndDateTime", value); }
        }
        /// <summary>The sequenceStartDateTime property</summary>
        public DateTimeOffset? SequenceStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("sequenceStartDateTime"); }
            set { BackingStore?.Set("sequenceStartDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new SequentialActivationRenewalsAlertIncident and sets the default values.
        /// </summary>
        public SequentialActivationRenewalsAlertIncident() : base() {
            OdataType = "#microsoft.graph.sequentialActivationRenewalsAlertIncident";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SequentialActivationRenewalsAlertIncident CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SequentialActivationRenewalsAlertIncident();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationCount", n => { ActivationCount = n.GetIntValue(); } },
                {"assigneeDisplayName", n => { AssigneeDisplayName = n.GetStringValue(); } },
                {"assigneeId", n => { AssigneeId = n.GetStringValue(); } },
                {"assigneeUserPrincipalName", n => { AssigneeUserPrincipalName = n.GetStringValue(); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"roleDisplayName", n => { RoleDisplayName = n.GetStringValue(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
                {"sequenceEndDateTime", n => { SequenceEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"sequenceStartDateTime", n => { SequenceStartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activationCount", ActivationCount);
            writer.WriteStringValue("assigneeDisplayName", AssigneeDisplayName);
            writer.WriteStringValue("assigneeId", AssigneeId);
            writer.WriteStringValue("assigneeUserPrincipalName", AssigneeUserPrincipalName);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteStringValue("roleDisplayName", RoleDisplayName);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
            writer.WriteDateTimeOffsetValue("sequenceEndDateTime", SequenceEndDateTime);
            writer.WriteDateTimeOffsetValue("sequenceStartDateTime", SequenceStartDateTime);
        }
    }
}
