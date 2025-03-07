// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The user experience analytics battery health runtime entity contains count of devices broken down into 3 categories - devices with runtime &gt; 5 hours, devices with runtime 3-5 hours and devices with runtime &lt; 3 hours.This API provides the count of devices in these 3 categories.
    /// </summary>
    public class UserExperienceAnalyticsBatteryHealthRuntimeDetails : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Number of active devices within the tenant. Valid values 0 to 2147483647</summary>
        public int? ActiveDevices
        {
            get { return BackingStore?.Get<int?>("activeDevices"); }
            set { BackingStore?.Set("activeDevices", value); }
        }
        /// <summary>Number of devices whose active runtime is greater than 3 hours but lesser than 5 hours. Valid values 0 to 2147483647</summary>
        public int? BatteryRuntimeFair
        {
            get { return BackingStore?.Get<int?>("batteryRuntimeFair"); }
            set { BackingStore?.Set("batteryRuntimeFair", value); }
        }
        /// <summary>Number of devices  whose active runtime is greater than 5 hours. Valid values 0 to 2147483647</summary>
        public int? BatteryRuntimeGood
        {
            get { return BackingStore?.Get<int?>("batteryRuntimeGood"); }
            set { BackingStore?.Set("batteryRuntimeGood", value); }
        }
        /// <summary>Number of devices whose active runtime is lesser than 3 hours. Valid values 0 to 2147483647</summary>
        public int? BatteryRuntimePoor
        {
            get { return BackingStore?.Get<int?>("batteryRuntimePoor"); }
            set { BackingStore?.Set("batteryRuntimePoor", value); }
        }
        /// <summary>Recorded date time of this runtime details instance.</summary>
        public DateTimeOffset? LastRefreshedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UserExperienceAnalyticsBatteryHealthRuntimeDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDevices", n => { ActiveDevices = n.GetIntValue(); } },
                { "batteryRuntimeFair", n => { BatteryRuntimeFair = n.GetIntValue(); } },
                { "batteryRuntimeGood", n => { BatteryRuntimeGood = n.GetIntValue(); } },
                { "batteryRuntimePoor", n => { BatteryRuntimePoor = n.GetIntValue(); } },
                { "lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDevices", ActiveDevices);
            writer.WriteIntValue("batteryRuntimeFair", BatteryRuntimeFair);
            writer.WriteIntValue("batteryRuntimeGood", BatteryRuntimeGood);
            writer.WriteIntValue("batteryRuntimePoor", BatteryRuntimePoor);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
        }
    }
}
