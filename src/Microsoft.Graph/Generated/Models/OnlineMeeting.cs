// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class OnlineMeeting : OnlineMeetingBase, IParsable {
        /// <summary>The alternativeRecording property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AlternativeRecording {
            get { return BackingStore?.Get<byte[]?>("alternativeRecording"); }
            set { BackingStore?.Set("alternativeRecording", value); }
        }
#nullable restore
#else
        public byte[] AlternativeRecording {
            get { return BackingStore?.Get<byte[]>("alternativeRecording"); }
            set { BackingStore?.Set("alternativeRecording", value); }
        }
#endif
        /// <summary>The attendeeReport property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttendeeReport {
            get { return BackingStore?.Get<byte[]?>("attendeeReport"); }
            set { BackingStore?.Set("attendeeReport", value); }
        }
#nullable restore
#else
        public byte[] AttendeeReport {
            get { return BackingStore?.Get<byte[]>("attendeeReport"); }
            set { BackingStore?.Set("attendeeReport", value); }
        }
#endif
        /// <summary>The broadcastRecording property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? BroadcastRecording {
            get { return BackingStore?.Get<byte[]?>("broadcastRecording"); }
            set { BackingStore?.Set("broadcastRecording", value); }
        }
#nullable restore
#else
        public byte[] BroadcastRecording {
            get { return BackingStore?.Get<byte[]>("broadcastRecording"); }
            set { BackingStore?.Set("broadcastRecording", value); }
        }
#endif
        /// <summary>The broadcastSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BroadcastMeetingSettings? BroadcastSettings {
            get { return BackingStore?.Get<BroadcastMeetingSettings?>("broadcastSettings"); }
            set { BackingStore?.Set("broadcastSettings", value); }
        }
#nullable restore
#else
        public BroadcastMeetingSettings BroadcastSettings {
            get { return BackingStore?.Get<BroadcastMeetingSettings>("broadcastSettings"); }
            set { BackingStore?.Set("broadcastSettings", value); }
        }
#endif
        /// <summary>The capabilities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingCapabilities?>? Capabilities {
            get { return BackingStore?.Get<List<MeetingCapabilities?>?>("capabilities"); }
            set { BackingStore?.Set("capabilities", value); }
        }
#nullable restore
#else
        public List<MeetingCapabilities?> Capabilities {
            get { return BackingStore?.Get<List<MeetingCapabilities?>>("capabilities"); }
            set { BackingStore?.Set("capabilities", value); }
        }
#endif
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The external ID. A custom ID. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>The isBroadcast property</summary>
        public bool? IsBroadcast {
            get { return BackingStore?.Get<bool?>("isBroadcast"); }
            set { BackingStore?.Set("isBroadcast", value); }
        }
        /// <summary>The joinUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinUrl {
            get { return BackingStore?.Get<string?>("joinUrl"); }
            set { BackingStore?.Set("joinUrl", value); }
        }
#nullable restore
#else
        public string JoinUrl {
            get { return BackingStore?.Get<string>("joinUrl"); }
            set { BackingStore?.Set("joinUrl", value); }
        }
#endif
        /// <summary>The meetingAttendanceReport property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MeetingAttendanceReport? MeetingAttendanceReport {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingAttendanceReport?>("meetingAttendanceReport"); }
            set { BackingStore?.Set("meetingAttendanceReport", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MeetingAttendanceReport MeetingAttendanceReport {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>("meetingAttendanceReport"); }
            set { BackingStore?.Set("meetingAttendanceReport", value); }
        }
#endif
        /// <summary>The participants associated with the online meeting, including the organizer and the attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingParticipants? Participants {
            get { return BackingStore?.Get<MeetingParticipants?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public MeetingParticipants Participants {
            get { return BackingStore?.Get<MeetingParticipants>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>The recording property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Recording {
            get { return BackingStore?.Get<byte[]?>("recording"); }
            set { BackingStore?.Set("recording", value); }
        }
#nullable restore
#else
        public byte[] Recording {
            get { return BackingStore?.Get<byte[]>("recording"); }
            set { BackingStore?.Set("recording", value); }
        }
#endif
        /// <summary>The recordings of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallRecording>? Recordings {
            get { return BackingStore?.Get<List<CallRecording>?>("recordings"); }
            set { BackingStore?.Set("recordings", value); }
        }
#nullable restore
#else
        public List<CallRecording> Recordings {
            get { return BackingStore?.Get<List<CallRecording>>("recordings"); }
            set { BackingStore?.Set("recordings", value); }
        }
#endif
        /// <summary>The registration that is enabled for an online meeting. One online meeting can only have one registration enabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingRegistration? Registration {
            get { return BackingStore?.Get<MeetingRegistration?>("registration"); }
            set { BackingStore?.Set("registration", value); }
        }
#nullable restore
#else
        public MeetingRegistration Registration {
            get { return BackingStore?.Get<MeetingRegistration>("registration"); }
            set { BackingStore?.Set("registration", value); }
        }
#endif
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The transcripts of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CallTranscript>? Transcripts {
            get { return BackingStore?.Get<List<CallTranscript>?>("transcripts"); }
            set { BackingStore?.Set("transcripts", value); }
        }
#nullable restore
#else
        public List<CallTranscript> Transcripts {
            get { return BackingStore?.Get<List<CallTranscript>>("transcripts"); }
            set { BackingStore?.Set("transcripts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OnlineMeeting"/> and sets the default values.
        /// </summary>
        public OnlineMeeting() : base() {
            OdataType = "#microsoft.graph.onlineMeeting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OnlineMeeting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnlineMeeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alternativeRecording", n => { AlternativeRecording = n.GetByteArrayValue(); } },
                {"attendeeReport", n => { AttendeeReport = n.GetByteArrayValue(); } },
                {"broadcastRecording", n => { BroadcastRecording = n.GetByteArrayValue(); } },
                {"broadcastSettings", n => { BroadcastSettings = n.GetObjectValue<BroadcastMeetingSettings>(BroadcastMeetingSettings.CreateFromDiscriminatorValue); } },
                {"capabilities", n => { Capabilities = n.GetCollectionOfEnumValues<MeetingCapabilities>()?.ToList(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"isBroadcast", n => { IsBroadcast = n.GetBoolValue(); } },
                {"joinUrl", n => { JoinUrl = n.GetStringValue(); } },
                {"meetingAttendanceReport", n => { MeetingAttendanceReport = n.GetObjectValue<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>(Microsoft.Graph.Beta.Models.MeetingAttendanceReport.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetObjectValue<MeetingParticipants>(MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"recording", n => { Recording = n.GetByteArrayValue(); } },
                {"recordings", n => { Recordings = n.GetCollectionOfObjectValues<CallRecording>(CallRecording.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registration", n => { Registration = n.GetObjectValue<MeetingRegistration>(MeetingRegistration.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"transcripts", n => { Transcripts = n.GetCollectionOfObjectValues<CallTranscript>(CallTranscript.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("alternativeRecording", AlternativeRecording);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteByteArrayValue("broadcastRecording", BroadcastRecording);
            writer.WriteObjectValue<BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteCollectionOfEnumValues<MeetingCapabilities>("capabilities", Capabilities);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MeetingAttendanceReport>("meetingAttendanceReport", MeetingAttendanceReport);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteByteArrayValue("recording", Recording);
            writer.WriteCollectionOfObjectValues<CallRecording>("recordings", Recordings);
            writer.WriteObjectValue<MeetingRegistration>("registration", Registration);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteCollectionOfObjectValues<CallTranscript>("transcripts", Transcripts);
        }
    }
}
