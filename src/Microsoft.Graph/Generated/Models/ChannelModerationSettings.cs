using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ChannelModerationSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Indicates whether bots are allowed to post messages.</summary>
        public bool? AllowNewMessageFromBots {
            get { return BackingStore?.Get<bool?>("allowNewMessageFromBots"); }
            set { BackingStore?.Set("allowNewMessageFromBots", value); }
        }
        /// <summary>Indicates whether connectors are allowed to post messages.</summary>
        public bool? AllowNewMessageFromConnectors {
            get { return BackingStore?.Get<bool?>("allowNewMessageFromConnectors"); }
            set { BackingStore?.Set("allowNewMessageFromConnectors", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates who is allowed to reply to the teams channel. Possible values are: everyone, authorAndModerators, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.ReplyRestriction? ReplyRestriction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ReplyRestriction?>("replyRestriction"); }
            set { BackingStore?.Set("replyRestriction", value); }
        }
        /// <summary>Indicates who is allowed to post messages to teams channel. Possible values are: everyone, everyoneExceptGuests, moderators, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.UserNewMessageRestriction? UserNewMessageRestriction {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserNewMessageRestriction?>("userNewMessageRestriction"); }
            set { BackingStore?.Set("userNewMessageRestriction", value); }
        }
        /// <summary>
        /// Instantiates a new channelModerationSettings and sets the default values.
        /// </summary>
        public ChannelModerationSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ChannelModerationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelModerationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowNewMessageFromBots", n => { AllowNewMessageFromBots = n.GetBoolValue(); } },
                {"allowNewMessageFromConnectors", n => { AllowNewMessageFromConnectors = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"replyRestriction", n => { ReplyRestriction = n.GetEnumValue<ReplyRestriction>(); } },
                {"userNewMessageRestriction", n => { UserNewMessageRestriction = n.GetEnumValue<UserNewMessageRestriction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowNewMessageFromBots", AllowNewMessageFromBots);
            writer.WriteBoolValue("allowNewMessageFromConnectors", AllowNewMessageFromConnectors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ReplyRestriction>("replyRestriction", ReplyRestriction);
            writer.WriteEnumValue<UserNewMessageRestriction>("userNewMessageRestriction", UserNewMessageRestriction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
