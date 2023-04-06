using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerTaskRecurrence : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextInSeriesTaskId {
            get { return BackingStore?.Get<string?>("nextInSeriesTaskId"); }
            set { BackingStore?.Set("nextInSeriesTaskId", value); }
        }
#nullable restore
#else
        public string NextInSeriesTaskId {
            get { return BackingStore?.Get<string>("nextInSeriesTaskId"); }
            set { BackingStore?.Set("nextInSeriesTaskId", value); }
        }
#endif
        /// <summary>The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.</summary>
        public int? OccurrenceId {
            get { return BackingStore?.Get<int?>("occurrenceId"); }
            set { BackingStore?.Set("occurrenceId", value); }
        }
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
        /// <summary>The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviousInSeriesTaskId {
            get { return BackingStore?.Get<string?>("previousInSeriesTaskId"); }
            set { BackingStore?.Set("previousInSeriesTaskId", value); }
        }
#nullable restore
#else
        public string PreviousInSeriesTaskId {
            get { return BackingStore?.Get<string>("previousInSeriesTaskId"); }
            set { BackingStore?.Set("previousInSeriesTaskId", value); }
        }
#endif
        /// <summary>The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId &gt;= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RecurrenceStartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("recurrenceStartDateTime"); }
            set { BackingStore?.Set("recurrenceStartDateTime", value); }
        }
        /// <summary>The schedule for recurrence. Clients define and edit recurrence by specifying the schedule. If nextInSeriesTaskId isn&apos;t assigned, clients may terminate the series by assigning null to this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerRecurrenceSchedule? Schedule {
            get { return BackingStore?.Get<PlannerRecurrenceSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public PlannerRecurrenceSchedule Schedule {
            get { return BackingStore?.Get<PlannerRecurrenceSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeriesId {
            get { return BackingStore?.Get<string?>("seriesId"); }
            set { BackingStore?.Set("seriesId", value); }
        }
#nullable restore
#else
        public string SeriesId {
            get { return BackingStore?.Get<string>("seriesId"); }
            set { BackingStore?.Set("seriesId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new plannerTaskRecurrence and sets the default values.
        /// </summary>
        public PlannerTaskRecurrence() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlannerTaskRecurrence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerTaskRecurrence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"nextInSeriesTaskId", n => { NextInSeriesTaskId = n.GetStringValue(); } },
                {"occurrenceId", n => { OccurrenceId = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"previousInSeriesTaskId", n => { PreviousInSeriesTaskId = n.GetStringValue(); } },
                {"recurrenceStartDateTime", n => { RecurrenceStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<PlannerRecurrenceSchedule>(PlannerRecurrenceSchedule.CreateFromDiscriminatorValue); } },
                {"seriesId", n => { SeriesId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("nextInSeriesTaskId", NextInSeriesTaskId);
            writer.WriteIntValue("occurrenceId", OccurrenceId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("previousInSeriesTaskId", PreviousInSeriesTaskId);
            writer.WriteDateTimeOffsetValue("recurrenceStartDateTime", RecurrenceStartDateTime);
            writer.WriteObjectValue<PlannerRecurrenceSchedule>("schedule", Schedule);
            writer.WriteStringValue("seriesId", SeriesId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
