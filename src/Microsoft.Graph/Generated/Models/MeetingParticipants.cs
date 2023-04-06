using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingParticipants : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Information of the meeting attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Attendees {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>?>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#nullable restore
#else
        public List<MeetingParticipantInfo> Attendees {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>>("attendees"); }
            set { BackingStore?.Set("attendees", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The contributors property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Contributors {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>?>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
        }
#nullable restore
#else
        public List<MeetingParticipantInfo> Contributors {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>>("contributors"); }
            set { BackingStore?.Set("contributors", value); }
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
        /// <summary>Information of the meeting organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingParticipantInfo? Organizer {
            get { return BackingStore?.Get<MeetingParticipantInfo?>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#nullable restore
#else
        public MeetingParticipantInfo Organizer {
            get { return BackingStore?.Get<MeetingParticipantInfo>("organizer"); }
            set { BackingStore?.Set("organizer", value); }
        }
#endif
        /// <summary>The producers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingParticipantInfo>? Producers {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>?>("producers"); }
            set { BackingStore?.Set("producers", value); }
        }
#nullable restore
#else
        public List<MeetingParticipantInfo> Producers {
            get { return BackingStore?.Get<List<MeetingParticipantInfo>>("producers"); }
            set { BackingStore?.Set("producers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new meetingParticipants and sets the default values.
        /// </summary>
        public MeetingParticipants() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MeetingParticipants CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingParticipants();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contributors", n => { Contributors = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organizer", n => { Organizer = n.GetObjectValue<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue); } },
                {"producers", n => { Producers = n.GetCollectionOfObjectValues<MeetingParticipantInfo>(MeetingParticipantInfo.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("attendees", Attendees);
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("contributors", Contributors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<MeetingParticipantInfo>("organizer", Organizer);
            writer.WriteCollectionOfObjectValues<MeetingParticipantInfo>("producers", Producers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
