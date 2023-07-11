using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class EntitiesSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of unique devices that were seen.</summary>
        public long? DeviceCount {
            get { return BackingStore?.Get<long?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
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
        /// <summary>The trafficType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.TrafficType? TrafficType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TrafficType?>("trafficType"); }
            set { BackingStore?.Set("trafficType", value); }
        }
        /// <summary>Count of unique Azure Active Directoy users that were seen.</summary>
        public long? UserCount {
            get { return BackingStore?.Get<long?>("userCount"); }
            set { BackingStore?.Set("userCount", value); }
        }
        /// <summary>Count of unique target workloads or hosts that were seen.</summary>
        public long? WorkloadCount {
            get { return BackingStore?.Get<long?>("workloadCount"); }
            set { BackingStore?.Set("workloadCount", value); }
        }
        /// <summary>
        /// Instantiates a new entitiesSummary and sets the default values.
        /// </summary>
        public EntitiesSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EntitiesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EntitiesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"trafficType", n => { TrafficType = n.GetEnumValue<TrafficType>(); } },
                {"userCount", n => { UserCount = n.GetLongValue(); } },
                {"workloadCount", n => { WorkloadCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TrafficType>("trafficType", TrafficType);
            writer.WriteLongValue("userCount", UserCount);
            writer.WriteLongValue("workloadCount", WorkloadCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
