using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class DeviceAppPerformance : Entity, IParsable {
        /// <summary>The appFriendlyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppFriendlyName {
            get { return BackingStore?.Get<string?>("appFriendlyName"); }
            set { BackingStore?.Set("appFriendlyName", value); }
        }
#nullable restore
#else
        public string AppFriendlyName {
            get { return BackingStore?.Get<string>("appFriendlyName"); }
            set { BackingStore?.Set("appFriendlyName", value); }
        }
#endif
        /// <summary>The appName property</summary>
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
        /// <summary>The appPublisher property</summary>
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
        /// <summary>The appVersion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppVersion {
            get { return BackingStore?.Get<string?>("appVersion"); }
            set { BackingStore?.Set("appVersion", value); }
        }
#nullable restore
#else
        public string AppVersion {
            get { return BackingStore?.Get<string>("appVersion"); }
            set { BackingStore?.Set("appVersion", value); }
        }
#endif
        /// <summary>The deviceId property</summary>
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
        /// <summary>The deviceManufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer {
            get { return BackingStore?.Get<string?>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#nullable restore
#else
        public string DeviceManufacturer {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#endif
        /// <summary>The deviceModel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>The deviceName property</summary>
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
        /// <summary>The healthStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HealthStatus {
            get { return BackingStore?.Get<string?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
#nullable restore
#else
        public string HealthStatus {
            get { return BackingStore?.Get<string>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
#endif
        /// <summary>The isLatestUsedVersion property</summary>
        public int? IsLatestUsedVersion {
            get { return BackingStore?.Get<int?>("isLatestUsedVersion"); }
            set { BackingStore?.Set("isLatestUsedVersion", value); }
        }
        /// <summary>The isMostUsedVersion property</summary>
        public int? IsMostUsedVersion {
            get { return BackingStore?.Get<int?>("isMostUsedVersion"); }
            set { BackingStore?.Set("isMostUsedVersion", value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The tenantDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDisplayName {
            get { return BackingStore?.Get<string?>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#nullable restore
#else
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
#endif
        /// <summary>The tenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId {
            get { return BackingStore?.Get<string?>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#nullable restore
#else
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
#endif
        /// <summary>The totalAppCrashCount property</summary>
        public int? TotalAppCrashCount {
            get { return BackingStore?.Get<int?>("totalAppCrashCount"); }
            set { BackingStore?.Set("totalAppCrashCount", value); }
        }
        /// <summary>The totalAppFreezeCount property</summary>
        public int? TotalAppFreezeCount {
            get { return BackingStore?.Get<int?>("totalAppFreezeCount"); }
            set { BackingStore?.Set("totalAppFreezeCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAppPerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appFriendlyName", n => { AppFriendlyName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetStringValue(); } },
                {"isLatestUsedVersion", n => { IsLatestUsedVersion = n.GetIntValue(); } },
                {"isMostUsedVersion", n => { IsMostUsedVersion = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"totalAppCrashCount", n => { TotalAppCrashCount = n.GetIntValue(); } },
                {"totalAppFreezeCount", n => { TotalAppFreezeCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appFriendlyName", AppFriendlyName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("healthStatus", HealthStatus);
            writer.WriteIntValue("isLatestUsedVersion", IsLatestUsedVersion);
            writer.WriteIntValue("isMostUsedVersion", IsMostUsedVersion);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("totalAppCrashCount", TotalAppCrashCount);
            writer.WriteIntValue("totalAppFreezeCount", TotalAppFreezeCount);
        }
    }
}
