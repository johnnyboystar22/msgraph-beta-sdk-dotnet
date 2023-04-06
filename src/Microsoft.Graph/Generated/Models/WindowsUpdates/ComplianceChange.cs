using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class ComplianceChange : Entity, IParsable {
        /// <summary>The date and time when a compliance change was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>True indicates that a compliance change is revoked, preventing further application. Revoking a compliance change is a final action.</summary>
        public bool? IsRevoked {
            get { return BackingStore?.Get<bool?>("isRevoked"); }
            set { BackingStore?.Set("isRevoked", value); }
        }
        /// <summary>The date and time when the compliance change was revoked.</summary>
        public DateTimeOffset? RevokedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("revokedDateTime"); }
            set { BackingStore?.Set("revokedDateTime", value); }
        }
        /// <summary>The policy this compliance change is a member of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy? UpdatePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy?>("updatePolicy"); }
            set { BackingStore?.Set("updatePolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy UpdatePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>("updatePolicy"); }
            set { BackingStore?.Set("updatePolicy", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ComplianceChange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsUpdates.contentApproval" => new ContentApproval(),
                _ => new ComplianceChange(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isRevoked", n => { IsRevoked = n.GetBoolValue(); } },
                {"revokedDateTime", n => { RevokedDateTime = n.GetDateTimeOffsetValue(); } },
                {"updatePolicy", n => { UpdatePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isRevoked", IsRevoked);
            writer.WriteDateTimeOffsetValue("revokedDateTime", RevokedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>("updatePolicy", UpdatePolicy);
        }
    }
}
