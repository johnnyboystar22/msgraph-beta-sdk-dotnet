using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class EntitlementManagementSettings : Entity, IParsable {
        /// <summary>If externalUserLifecycleAction is BlockSignInAndDelete, the number of days after an external user is blocked from sign in before their account is deleted.</summary>
        public int? DaysUntilExternalUserDeletedAfterBlocked {
            get { return BackingStore?.Get<int?>("daysUntilExternalUserDeletedAfterBlocked"); }
            set { BackingStore?.Set("daysUntilExternalUserDeletedAfterBlocked", value); }
        }
        /// <summary>One of None, BlockSignIn, or BlockSignInAndDelete.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalUserLifecycleAction {
            get { return BackingStore?.Get<string?>("externalUserLifecycleAction"); }
            set { BackingStore?.Set("externalUserLifecycleAction", value); }
        }
#nullable restore
#else
        public string ExternalUserLifecycleAction {
            get { return BackingStore?.Get<string>("externalUserLifecycleAction"); }
            set { BackingStore?.Set("externalUserLifecycleAction", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EntitlementManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitlementManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"daysUntilExternalUserDeletedAfterBlocked", n => { DaysUntilExternalUserDeletedAfterBlocked = n.GetIntValue(); } },
                {"externalUserLifecycleAction", n => { ExternalUserLifecycleAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("daysUntilExternalUserDeletedAfterBlocked", DaysUntilExternalUserDeletedAfterBlocked);
            writer.WriteStringValue("externalUserLifecycleAction", ExternalUserLifecycleAction);
        }
    }
}
