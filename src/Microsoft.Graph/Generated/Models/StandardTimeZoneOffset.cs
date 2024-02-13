// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class StandardTimeZoneOffset : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the nth occurrence of the day of week that the transition from daylight saving time to standard time occurs.</summary>
        public int? DayOccurrence {
            get { return BackingStore?.Get<int?>("dayOccurrence"); }
            set { BackingStore?.Set("dayOccurrence", value); }
        }
        /// <summary>Represents the day of the week when the transition from daylight saving time to standard time.</summary>
        public DayOfWeekObject? DayOfWeek {
            get { return BackingStore?.Get<DayOfWeekObject?>("dayOfWeek"); }
            set { BackingStore?.Set("dayOfWeek", value); }
        }
        /// <summary>Represents the month of the year when the transition from daylight saving time to standard time occurs.</summary>
        public int? Month {
            get { return BackingStore?.Get<int?>("month"); }
            set { BackingStore?.Set("month", value); }
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
        /// <summary>Represents the time of day when the transition from daylight saving time to standard time occurs.</summary>
        public Time? Time {
            get { return BackingStore?.Get<Time?>("time"); }
            set { BackingStore?.Set("time", value); }
        }
        /// <summary>Represents how frequently in terms of years the change from daylight saving time to standard time occurs. For example, a value of 0 means every year.</summary>
        public int? Year {
            get { return BackingStore?.Get<int?>("year"); }
            set { BackingStore?.Set("year", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="StandardTimeZoneOffset"/> and sets the default values.
        /// </summary>
        public StandardTimeZoneOffset() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="StandardTimeZoneOffset"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StandardTimeZoneOffset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.daylightTimeZoneOffset" => new DaylightTimeZoneOffset(),
                _ => new StandardTimeZoneOffset(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dayOccurrence", n => { DayOccurrence = n.GetIntValue(); } },
                {"dayOfWeek", n => { DayOfWeek = n.GetEnumValue<DayOfWeekObject>(); } },
                {"month", n => { Month = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"time", n => { Time = n.GetTimeValue(); } },
                {"year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("dayOccurrence", DayOccurrence);
            writer.WriteEnumValue<DayOfWeekObject>("dayOfWeek", DayOfWeek);
            writer.WriteIntValue("month", Month);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeValue("time", Time);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
