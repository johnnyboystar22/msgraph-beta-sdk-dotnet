using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics battery health device app impact entity contains battery usage related information at an app level for a given device.
    /// </summary>
    public class UserExperienceAnalyticsBatteryHealthDeviceAppImpact : Entity, IParsable {
        /// <summary>User friendly display name for the app. Eg: Outlook</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>App name. Eg: oltk.exe</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName {
            get { return BackingStore?.Get<string?>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#nullable restore
#else
        public string AppName {
            get { return BackingStore?.Get<string>("appName"); }
            set { BackingStore?.Set("appName", value); }
        }
#endif
        /// <summary>App publisher. Eg: Microsoft Corporation</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppPublisher {
            get { return BackingStore?.Get<string?>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
#nullable restore
#else
        public string AppPublisher {
            get { return BackingStore?.Get<string>("appPublisher"); }
            set { BackingStore?.Set("appPublisher", value); }
        }
#endif
        /// <summary>The percent of total battery power used by this application when the device was not plugged into AC power, over 14 days. Unit in percentage. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryUsagePercentage {
            get { return BackingStore?.Get<double?>("batteryUsagePercentage"); }
            set { BackingStore?.Set("batteryUsagePercentage", value); }
        }
        /// <summary>The unique identifier of the device, Intune DeviceID or SCCM device id.</summary>
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
        /// <summary>true if the user had active interaction with the app.</summary>
        public bool? IsForegroundApp {
            get { return BackingStore?.Get<bool?>("isForegroundApp"); }
            set { BackingStore?.Set("isForegroundApp", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsBatteryHealthDeviceAppImpact CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthDeviceAppImpact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"batteryUsagePercentage", n => { BatteryUsagePercentage = n.GetDoubleValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"isForegroundApp", n => { IsForegroundApp = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteDoubleValue("batteryUsagePercentage", BatteryUsagePercentage);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteBoolValue("isForegroundApp", IsForegroundApp);
        }
    }
}
