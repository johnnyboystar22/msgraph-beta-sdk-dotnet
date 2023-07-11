using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkConversationIdentity : Identity, IParsable {
        /// <summary>Type of conversation. Possible values are: team, channel, and chat.</summary>
        public TeamworkConversationIdentityType? ConversationIdentityType {
            get { return BackingStore?.Get<TeamworkConversationIdentityType?>("conversationIdentityType"); }
            set { BackingStore?.Set("conversationIdentityType", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkConversationIdentity and sets the default values.
        /// </summary>
        public TeamworkConversationIdentity() : base() {
            OdataType = "#microsoft.graph.teamworkConversationIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamworkConversationIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkConversationIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conversationIdentityType", n => { ConversationIdentityType = n.GetEnumValue<TeamworkConversationIdentityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<TeamworkConversationIdentityType>("conversationIdentityType", ConversationIdentityType);
        }
    }
}
