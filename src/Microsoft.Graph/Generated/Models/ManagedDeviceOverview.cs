// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Summary data for managed devices
    /// </summary>
    public class ManagedDeviceOverview : Entity, IParsable {
        /// <summary>Distribution of Exchange Access State in Intune</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary? DeviceExchangeAccessStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary?>("deviceExchangeAccessStateSummary"); }
            set { BackingStore?.Set("deviceExchangeAccessStateSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary DeviceExchangeAccessStateSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary"); }
            set { BackingStore?.Set("deviceExchangeAccessStateSummary", value); }
        }
#endif
        /// <summary>Device operating system summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary? DeviceOperatingSystemSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary?>("deviceOperatingSystemSummary"); }
            set { BackingStore?.Set("deviceOperatingSystemSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary DeviceOperatingSystemSummary {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary"); }
            set { BackingStore?.Set("deviceOperatingSystemSummary", value); }
        }
#endif
        /// <summary>The number of devices enrolled in both MDM and EAS</summary>
        public int? DualEnrolledDeviceCount {
            get { return BackingStore?.Get<int?>("dualEnrolledDeviceCount"); }
            set { BackingStore?.Set("dualEnrolledDeviceCount", value); }
        }
        /// <summary>Total enrolled device count. Does not include PC devices managed via Intune PC Agent</summary>
        public int? EnrolledDeviceCount {
            get { return BackingStore?.Get<int?>("enrolledDeviceCount"); }
            set { BackingStore?.Set("enrolledDeviceCount", value); }
        }
        /// <summary>Last modified date time of device overview</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Models and Manufactures meatadata for managed devices in the account</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers? ManagedDeviceModelsAndManufacturers {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers?>("managedDeviceModelsAndManufacturers"); }
            set { BackingStore?.Set("managedDeviceModelsAndManufacturers", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers ManagedDeviceModelsAndManufacturers {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers>("managedDeviceModelsAndManufacturers"); }
            set { BackingStore?.Set("managedDeviceModelsAndManufacturers", value); }
        }
#endif
        /// <summary>The number of devices enrolled in MDM</summary>
        public int? MdmEnrolledCount {
            get { return BackingStore?.Get<int?>("mdmEnrolledCount"); }
            set { BackingStore?.Set("mdmEnrolledCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ManagedDeviceOverview"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDeviceOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceExchangeAccessStateSummary", n => { DeviceExchangeAccessStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary>(Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceOperatingSystemSummary", n => { DeviceOperatingSystemSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary>(Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary.CreateFromDiscriminatorValue); } },
                {"dualEnrolledDeviceCount", n => { DualEnrolledDeviceCount = n.GetIntValue(); } },
                {"enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceModelsAndManufacturers", n => { ManagedDeviceModelsAndManufacturers = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers>(Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers.CreateFromDiscriminatorValue); } },
                {"mdmEnrolledCount", n => { MdmEnrolledCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceExchangeAccessStateSummary>("deviceExchangeAccessStateSummary", DeviceExchangeAccessStateSummary);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceOperatingSystemSummary>("deviceOperatingSystemSummary", DeviceOperatingSystemSummary);
            writer.WriteIntValue("dualEnrolledDeviceCount", DualEnrolledDeviceCount);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedDeviceModelsAndManufacturers>("managedDeviceModelsAndManufacturers", ManagedDeviceModelsAndManufacturers);
            writer.WriteIntValue("mdmEnrolledCount", MdmEnrolledCount);
        }
    }
}
