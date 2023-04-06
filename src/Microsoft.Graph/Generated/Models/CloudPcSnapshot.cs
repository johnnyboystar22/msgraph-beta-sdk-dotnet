using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcSnapshot : Entity, IParsable {
        /// <summary>The unique identifier for the Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudPcId {
            get { return BackingStore?.Get<string?>("cloudPcId"); }
            set { BackingStore?.Set("cloudPcId", value); }
        }
#nullable restore
#else
        public string CloudPcId {
            get { return BackingStore?.Get<string>("cloudPcId"); }
            set { BackingStore?.Set("cloudPcId", value); }
        }
#endif
        /// <summary>The date and time at which the snapshot was taken. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The date and time when the snapshot expires. The time is shown in ISO 8601 format and Coordinated Universal Time (UTC) time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The date and time at which the snapshot was last used to restore the Cloud PC device. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastRestoredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRestoredDateTime"); }
            set { BackingStore?.Set("lastRestoredDateTime", value); }
        }
        /// <summary>The type of snapshot that indicates how to create the snapshot. Possible values are automatic, manual. Default value is automatic.</summary>
        public CloudPcSnapshotType? SnapshotType {
            get { return BackingStore?.Get<CloudPcSnapshotType?>("snapshotType"); }
            set { BackingStore?.Set("snapshotType", value); }
        }
        /// <summary>The status of the Cloud PC snapshot. The possible values are: ready, unknownFutureValue.</summary>
        public CloudPcSnapshotStatus? Status {
            get { return BackingStore?.Get<CloudPcSnapshotStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcSnapshot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcSnapshot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudPcId", n => { CloudPcId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRestoredDateTime", n => { LastRestoredDateTime = n.GetDateTimeOffsetValue(); } },
                {"snapshotType", n => { SnapshotType = n.GetEnumValue<CloudPcSnapshotType>(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcSnapshotStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("cloudPcId", CloudPcId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastRestoredDateTime", LastRestoredDateTime);
            writer.WriteEnumValue<CloudPcSnapshotType>("snapshotType", SnapshotType);
            writer.WriteEnumValue<CloudPcSnapshotStatus>("status", Status);
        }
    }
}
