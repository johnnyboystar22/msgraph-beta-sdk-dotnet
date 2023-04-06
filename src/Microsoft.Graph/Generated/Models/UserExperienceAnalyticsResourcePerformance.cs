using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics resource performance entity.
    /// </summary>
    public class UserExperienceAnalyticsResourcePerformance : Entity, IParsable {
        /// <summary>AverageSpikeTimeScore of a device or a model type. Valid values 0 to 100</summary>
        public int? AverageSpikeTimeScore {
            get { return BackingStore?.Get<int?>("averageSpikeTimeScore"); }
            set { BackingStore?.Set("averageSpikeTimeScore", value); }
        }
        /// <summary>CPU spike time in percentage. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentage {
            get { return BackingStore?.Get<double?>("cpuSpikeTimePercentage"); }
            set { BackingStore?.Set("cpuSpikeTimePercentage", value); }
        }
        /// <summary>Threshold of cpuSpikeTimeScore. Valid values 0 to 100</summary>
        public double? CpuSpikeTimePercentageThreshold {
            get { return BackingStore?.Get<double?>("cpuSpikeTimePercentageThreshold"); }
            set { BackingStore?.Set("cpuSpikeTimePercentageThreshold", value); }
        }
        /// <summary>The user experience analytics device CPU spike time score. Valid values 0 to 100</summary>
        public int? CpuSpikeTimeScore {
            get { return BackingStore?.Get<int?>("cpuSpikeTimeScore"); }
            set { BackingStore?.Set("cpuSpikeTimeScore", value); }
        }
        /// <summary>User experience analytics summarized device count.</summary>
        public long? DeviceCount {
            get { return BackingStore?.Get<long?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>The id of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The name of the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>Resource performance score of a specific device. Valid values 0 to 100</summary>
        public int? DeviceResourcePerformanceScore {
            get { return BackingStore?.Get<int?>("deviceResourcePerformanceScore"); }
            set { BackingStore?.Set("deviceResourcePerformanceScore", value); }
        }
        /// <summary>The user experience analytics device manufacturer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The user experience analytics device model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>RAM spike time in percentage. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentage {
            get { return BackingStore?.Get<double?>("ramSpikeTimePercentage"); }
            set { BackingStore?.Set("ramSpikeTimePercentage", value); }
        }
        /// <summary>Threshold of ramSpikeTimeScore. Valid values 0 to 100</summary>
        public double? RamSpikeTimePercentageThreshold {
            get { return BackingStore?.Get<double?>("ramSpikeTimePercentageThreshold"); }
            set { BackingStore?.Set("ramSpikeTimePercentageThreshold", value); }
        }
        /// <summary>The user experience analytics device RAM spike time score. Valid values 0 to 100</summary>
        public int? RamSpikeTimeScore {
            get { return BackingStore?.Get<int?>("ramSpikeTimeScore"); }
            set { BackingStore?.Set("ramSpikeTimeScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsResourcePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsResourcePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"averageSpikeTimeScore", n => { AverageSpikeTimeScore = n.GetIntValue(); } },
                {"cpuSpikeTimePercentage", n => { CpuSpikeTimePercentage = n.GetDoubleValue(); } },
                {"cpuSpikeTimePercentageThreshold", n => { CpuSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"cpuSpikeTimeScore", n => { CpuSpikeTimeScore = n.GetIntValue(); } },
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceResourcePerformanceScore", n => { DeviceResourcePerformanceScore = n.GetIntValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"ramSpikeTimePercentage", n => { RamSpikeTimePercentage = n.GetDoubleValue(); } },
                {"ramSpikeTimePercentageThreshold", n => { RamSpikeTimePercentageThreshold = n.GetDoubleValue(); } },
                {"ramSpikeTimeScore", n => { RamSpikeTimeScore = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("averageSpikeTimeScore", AverageSpikeTimeScore);
            writer.WriteDoubleValue("cpuSpikeTimePercentage", CpuSpikeTimePercentage);
            writer.WriteDoubleValue("cpuSpikeTimePercentageThreshold", CpuSpikeTimePercentageThreshold);
            writer.WriteIntValue("cpuSpikeTimeScore", CpuSpikeTimeScore);
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteIntValue("deviceResourcePerformanceScore", DeviceResourcePerformanceScore);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("ramSpikeTimePercentage", RamSpikeTimePercentage);
            writer.WriteDoubleValue("ramSpikeTimePercentageThreshold", RamSpikeTimePercentageThreshold);
            writer.WriteIntValue("ramSpikeTimeScore", RamSpikeTimeScore);
        }
    }
}
