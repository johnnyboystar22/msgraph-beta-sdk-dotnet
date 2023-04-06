using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TimeCard : ChangeTrackedEntity, IParsable {
        /// <summary>The list of breaks associated with the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TimeCardBreak>? Breaks {
            get { return BackingStore?.Get<List<TimeCardBreak>?>("breaks"); }
            set { BackingStore?.Set("breaks", value); }
        }
#nullable restore
#else
        public List<TimeCardBreak> Breaks {
            get { return BackingStore?.Get<List<TimeCardBreak>>("breaks"); }
            set { BackingStore?.Set("breaks", value); }
        }
#endif
        /// <summary>The clock-in event of the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeCardEvent? ClockInEvent {
            get { return BackingStore?.Get<TimeCardEvent?>("clockInEvent"); }
            set { BackingStore?.Set("clockInEvent", value); }
        }
#nullable restore
#else
        public TimeCardEvent ClockInEvent {
            get { return BackingStore?.Get<TimeCardEvent>("clockInEvent"); }
            set { BackingStore?.Set("clockInEvent", value); }
        }
#endif
        /// <summary>The clock-out event of the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeCardEvent? ClockOutEvent {
            get { return BackingStore?.Get<TimeCardEvent?>("clockOutEvent"); }
            set { BackingStore?.Set("clockOutEvent", value); }
        }
#nullable restore
#else
        public TimeCardEvent ClockOutEvent {
            get { return BackingStore?.Get<TimeCardEvent>("clockOutEvent"); }
            set { BackingStore?.Set("clockOutEvent", value); }
        }
#endif
        /// <summary>Indicate if this timeCard entry is confirmed. Possible values are none, user, manager, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.ConfirmedBy? ConfirmedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConfirmedBy?>("confirmedBy"); }
            set { BackingStore?.Set("confirmedBy", value); }
        }
        /// <summary>Notes about the timeCard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Notes {
            get { return BackingStore?.Get<ItemBody?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public ItemBody Notes {
            get { return BackingStore?.Get<ItemBody>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The original timeCardEntry of the timeCard, before user edits.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeCardEntry? OriginalEntry {
            get { return BackingStore?.Get<TimeCardEntry?>("originalEntry"); }
            set { BackingStore?.Set("originalEntry", value); }
        }
#nullable restore
#else
        public TimeCardEntry OriginalEntry {
            get { return BackingStore?.Get<TimeCardEntry>("originalEntry"); }
            set { BackingStore?.Set("originalEntry", value); }
        }
#endif
        /// <summary>The current state of the timeCard during its life cycle.Possible values are: clockedIn, onBreak, clockedOut, unknownFutureValue.</summary>
        public TimeCardState? State {
            get { return BackingStore?.Get<TimeCardState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>User ID to which  the timeCard belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new TimeCard and sets the default values.
        /// </summary>
        public TimeCard() : base() {
            OdataType = "#microsoft.graph.timeCard";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TimeCard CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCard();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"breaks", n => { Breaks = n.GetCollectionOfObjectValues<TimeCardBreak>(TimeCardBreak.CreateFromDiscriminatorValue)?.ToList(); } },
                {"clockInEvent", n => { ClockInEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"clockOutEvent", n => { ClockOutEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"confirmedBy", n => { ConfirmedBy = n.GetEnumValue<ConfirmedBy>(); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"originalEntry", n => { OriginalEntry = n.GetObjectValue<TimeCardEntry>(TimeCardEntry.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<TimeCardState>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TimeCardBreak>("breaks", Breaks);
            writer.WriteObjectValue<TimeCardEvent>("clockInEvent", ClockInEvent);
            writer.WriteObjectValue<TimeCardEvent>("clockOutEvent", ClockOutEvent);
            writer.WriteEnumValue<ConfirmedBy>("confirmedBy", ConfirmedBy);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
            writer.WriteObjectValue<TimeCardEntry>("originalEntry", OriginalEntry);
            writer.WriteEnumValue<TimeCardState>("state", State);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
