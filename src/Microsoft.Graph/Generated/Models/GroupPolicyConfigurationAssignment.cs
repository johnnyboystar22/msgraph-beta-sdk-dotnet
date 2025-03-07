// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The group policy configuration assignment entity assigns one or more AAD groups to a specific group policy configuration.
    /// </summary>
    public class GroupPolicyConfigurationAssignment : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The type of groups targeted the group policy configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget? Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget Target
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.GroupPolicyConfigurationAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.GroupPolicyConfigurationAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.GroupPolicyConfigurationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "target", n => { Target = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>(Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
