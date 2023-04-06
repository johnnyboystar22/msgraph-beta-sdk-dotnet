using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRoleEligibilityScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>Time that the roleEligibilityScheduleInstance will expire.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>Membership type of the assignment. It can either be Inherited, Direct, or Group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType {
            get { return BackingStore?.Get<string?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#nullable restore
#else
        public string MemberType {
            get { return BackingStore?.Get<string>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
#endif
        /// <summary>Identifier of the parent roleEligibilitySchedule for this instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleEligibilityScheduleId {
            get { return BackingStore?.Get<string?>("roleEligibilityScheduleId"); }
            set { BackingStore?.Set("roleEligibilityScheduleId", value); }
        }
#nullable restore
#else
        public string RoleEligibilityScheduleId {
            get { return BackingStore?.Get<string>("roleEligibilityScheduleId"); }
            set { BackingStore?.Set("roleEligibilityScheduleId", value); }
        }
#endif
        /// <summary>Time that the roleEligibilityScheduleInstance will start.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"roleEligibilityScheduleId", n => { RoleEligibilityScheduleId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteStringValue("roleEligibilityScheduleId", RoleEligibilityScheduleId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
