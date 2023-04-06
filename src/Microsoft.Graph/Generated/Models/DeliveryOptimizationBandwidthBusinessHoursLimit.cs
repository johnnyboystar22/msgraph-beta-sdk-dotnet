using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Bandwidth business hours and percentages type
    /// </summary>
    public class DeliveryOptimizationBandwidthBusinessHoursLimit : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies the beginning of business hours using a 24-hour clock (0-23). Valid values 0 to 23</summary>
        public int? BandwidthBeginBusinessHours {
            get { return BackingStore?.Get<int?>("bandwidthBeginBusinessHours"); }
            set { BackingStore?.Set("bandwidthBeginBusinessHours", value); }
        }
        /// <summary>Specifies the end of business hours using a 24-hour clock (0-23). Valid values 0 to 23</summary>
        public int? BandwidthEndBusinessHours {
            get { return BackingStore?.Get<int?>("bandwidthEndBusinessHours"); }
            set { BackingStore?.Set("bandwidthEndBusinessHours", value); }
        }
        /// <summary>Specifies the percentage of bandwidth to limit during business hours (0-100). Valid values 0 to 100</summary>
        public int? BandwidthPercentageDuringBusinessHours {
            get { return BackingStore?.Get<int?>("bandwidthPercentageDuringBusinessHours"); }
            set { BackingStore?.Set("bandwidthPercentageDuringBusinessHours", value); }
        }
        /// <summary>Specifies the percentage of bandwidth to limit outsidse business hours (0-100). Valid values 0 to 100</summary>
        public int? BandwidthPercentageOutsideBusinessHours {
            get { return BackingStore?.Get<int?>("bandwidthPercentageOutsideBusinessHours"); }
            set { BackingStore?.Set("bandwidthPercentageOutsideBusinessHours", value); }
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
        /// <summary>
        /// Instantiates a new deliveryOptimizationBandwidthBusinessHoursLimit and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthBusinessHoursLimit() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeliveryOptimizationBandwidthBusinessHoursLimit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthBusinessHoursLimit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bandwidthBeginBusinessHours", n => { BandwidthBeginBusinessHours = n.GetIntValue(); } },
                {"bandwidthEndBusinessHours", n => { BandwidthEndBusinessHours = n.GetIntValue(); } },
                {"bandwidthPercentageDuringBusinessHours", n => { BandwidthPercentageDuringBusinessHours = n.GetIntValue(); } },
                {"bandwidthPercentageOutsideBusinessHours", n => { BandwidthPercentageOutsideBusinessHours = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("bandwidthBeginBusinessHours", BandwidthBeginBusinessHours);
            writer.WriteIntValue("bandwidthEndBusinessHours", BandwidthEndBusinessHours);
            writer.WriteIntValue("bandwidthPercentageDuringBusinessHours", BandwidthPercentageDuringBusinessHours);
            writer.WriteIntValue("bandwidthPercentageOutsideBusinessHours", BandwidthPercentageOutsideBusinessHours);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
