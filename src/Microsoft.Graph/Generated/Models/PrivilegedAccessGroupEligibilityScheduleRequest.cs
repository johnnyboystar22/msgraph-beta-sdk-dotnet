using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedAccessGroupEligibilityScheduleRequest : PrivilegedAccessScheduleRequest, IParsable {
        /// <summary>The identifier of membership or ownership eligibility relationship to the group. Required. The possible values are: owner, member, unknownFutureValue.</summary>
        public PrivilegedAccessGroupRelationships? AccessId {
            get { return BackingStore?.Get<PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>References the group that is the scope of the membership or ownership eligibility request through PIM for groups. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Group? Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The identifier of the group representing the scope of the membership and ownership eligibility through PIM for groups. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>References the principal that&apos;s in the scope of the membership or ownership eligibility request through the group that&apos;s governed by PIM. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal {
            get { return BackingStore?.Get<DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>The identifier of the principal whose membership or ownership eligibility to the group is managed through PIM for groups. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>Schedule created by this request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedAccessGroupEligibilitySchedule? TargetSchedule {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilitySchedule?>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#nullable restore
#else
        public PrivilegedAccessGroupEligibilitySchedule TargetSchedule {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilitySchedule>("targetSchedule"); }
            set { BackingStore?.Set("targetSchedule", value); }
        }
#endif
        /// <summary>The identifier of the schedule that&apos;s created from the eligibility request. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetScheduleId {
            get { return BackingStore?.Get<string?>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#nullable restore
#else
        public string TargetScheduleId {
            get { return BackingStore?.Get<string>("targetScheduleId"); }
            set { BackingStore?.Set("targetScheduleId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new privilegedAccessGroupEligibilityScheduleRequest and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupEligibilityScheduleRequest() : base() {
            OdataType = "#microsoft.graph.privilegedAccessGroupEligibilityScheduleRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroupEligibilityScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroupEligibilityScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessId", n => { AccessId = n.GetEnumValue<PrivilegedAccessGroupRelationships>(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Beta.Models.Group>(Microsoft.Graph.Beta.Models.Group.CreateFromDiscriminatorValue); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<PrivilegedAccessGroupEligibilitySchedule>(PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<PrivilegedAccessGroupEligibilitySchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
        }
    }
}
