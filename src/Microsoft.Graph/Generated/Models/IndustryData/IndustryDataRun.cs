using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData {
    public class IndustryDataRun : Entity, IParsable {
        /// <summary>The set of activities performed during the run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IndustryDataRunActivity>? Activities {
            get { return BackingStore?.Get<List<IndustryDataRunActivity>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<IndustryDataRunActivity> Activities {
            get { return BackingStore?.Get<List<IndustryDataRunActivity>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>An error object to diagnose critical failures in the run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PublicError? BlockingError {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError?>("blockingError"); }
            set { BackingStore?.Set("blockingError", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PublicError BlockingError {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PublicError>("blockingError"); }
            set { BackingStore?.Set("blockingError", value); }
        }
#endif
        /// <summary>The name of the run for rendering in a user interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date and time when the run finished or null if the run is still in-progress. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The date and time when the run started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The status property</summary>
        public IndustryDataRunStatus? Status {
            get { return BackingStore?.Get<IndustryDataRunStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IndustryDataRun CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IndustryDataRun();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<IndustryDataRunActivity>(IndustryDataRunActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"blockingError", n => { BlockingError = n.GetObjectValue<Microsoft.Graph.Beta.Models.PublicError>(Microsoft.Graph.Beta.Models.PublicError.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<IndustryDataRunStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IndustryDataRunActivity>("activities", Activities);
            writer.WriteEnumValue<IndustryDataRunStatus>("status", Status);
        }
    }
}
