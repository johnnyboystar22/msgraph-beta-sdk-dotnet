using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CallEndedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Duration of the call.</summary>
        public TimeSpan? CallDuration {
            get { return BackingStore?.Get<TimeSpan?>("callDuration"); }
            set { BackingStore?.Set("callDuration", value); }
        }
        /// <summary>Represents the call event type. Possible values are: call, meeting, screenShare, unknownFutureValue.</summary>
        public TeamworkCallEventType? CallEventType {
            get { return BackingStore?.Get<TeamworkCallEventType?>("callEventType"); }
            set { BackingStore?.Set("callEventType", value); }
        }
        /// <summary>Unique identifier of the call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>List of call participants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallParticipantInfo>? CallParticipants {
            get { return BackingStore?.Get<List<CallParticipantInfo>?>("callParticipants"); }
            set { BackingStore?.Set("callParticipants", value); }
        }
#nullable restore
#else
        public List<CallParticipantInfo> CallParticipants {
            get { return BackingStore?.Get<List<CallParticipantInfo>>("callParticipants"); }
            set { BackingStore?.Set("callParticipants", value); }
        }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator {
            get { return BackingStore?.Get<IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new CallEndedEventMessageDetail and sets the default values.
        /// </summary>
        public CallEndedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.callEndedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CallEndedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallEndedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callDuration", n => { CallDuration = n.GetTimeSpanValue(); } },
                {"callEventType", n => { CallEventType = n.GetEnumValue<TeamworkCallEventType>(); } },
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callParticipants", n => { CallParticipants = n.GetCollectionOfObjectValues<CallParticipantInfo>(CallParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("callDuration", CallDuration);
            writer.WriteEnumValue<TeamworkCallEventType>("callEventType", CallEventType);
            writer.WriteStringValue("callId", CallId);
            writer.WriteCollectionOfObjectValues<CallParticipantInfo>("callParticipants", CallParticipants);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
