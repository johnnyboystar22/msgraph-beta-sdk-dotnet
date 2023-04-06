using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TimeCardEntry : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>
        /// Instantiates a new timeCardEntry and sets the default values.
        /// </summary>
        public TimeCardEntry() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeCardEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeCardEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"breaks", n => { Breaks = n.GetCollectionOfObjectValues<TimeCardBreak>(TimeCardBreak.CreateFromDiscriminatorValue)?.ToList(); } },
                {"clockInEvent", n => { ClockInEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"clockOutEvent", n => { ClockOutEvent = n.GetObjectValue<TimeCardEvent>(TimeCardEvent.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TimeCardBreak>("breaks", Breaks);
            writer.WriteObjectValue<TimeCardEvent>("clockInEvent", ClockInEvent);
            writer.WriteObjectValue<TimeCardEvent>("clockOutEvent", ClockOutEvent);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
