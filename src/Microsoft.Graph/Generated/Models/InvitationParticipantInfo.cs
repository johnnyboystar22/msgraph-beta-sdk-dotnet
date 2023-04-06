using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InvitationParticipantInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of endpoint. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>("endpointType"); }
            set { BackingStore?.Set("endpointType", value); }
        }
        /// <summary>Optional. Whether to hide the participant from the roster.</summary>
        public bool? Hidden {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Identity {
            get { return BackingStore?.Get<IdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public IdentitySet Identity {
            get { return BackingStore?.Get<IdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
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
        /// <summary>Optional. The ID of the target participant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParticipantId {
            get { return BackingStore?.Get<string?>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#nullable restore
#else
        public string ParticipantId {
            get { return BackingStore?.Get<string>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#endif
        /// <summary>Optional. Whether to remove them from the main mixer.</summary>
        public bool? RemoveFromDefaultAudioRoutingGroup {
            get { return BackingStore?.Get<bool?>("removeFromDefaultAudioRoutingGroup"); }
            set { BackingStore?.Set("removeFromDefaultAudioRoutingGroup", value); }
        }
        /// <summary>Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplacesCallId {
            get { return BackingStore?.Get<string?>("replacesCallId"); }
            set { BackingStore?.Set("replacesCallId", value); }
        }
#nullable restore
#else
        public string ReplacesCallId {
            get { return BackingStore?.Get<string>("replacesCallId"); }
            set { BackingStore?.Set("replacesCallId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InvitationParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitationParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"removeFromDefaultAudioRoutingGroup", n => { RemoveFromDefaultAudioRoutingGroup = n.GetBoolValue(); } },
                {"replacesCallId", n => { ReplacesCallId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteBoolValue("removeFromDefaultAudioRoutingGroup", RemoveFromDefaultAudioRoutingGroup);
            writer.WriteStringValue("replacesCallId", ReplacesCallId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
