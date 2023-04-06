using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// MacOS software update account summary report for a device and user
    /// </summary>
    public class MacOSSoftwareUpdateAccountSummary : Entity, IParsable {
        /// <summary>Summary of the updates by category.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSSoftwareUpdateCategorySummary>? CategorySummaries {
            get { return BackingStore?.Get<List<MacOSSoftwareUpdateCategorySummary>?>("categorySummaries"); }
            set { BackingStore?.Set("categorySummaries", value); }
        }
#nullable restore
#else
        public List<MacOSSoftwareUpdateCategorySummary> CategorySummaries {
            get { return BackingStore?.Get<List<MacOSSoftwareUpdateCategorySummary>>("categorySummaries"); }
            set { BackingStore?.Set("categorySummaries", value); }
        }
#endif
        /// <summary>The device ID.</summary>
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
        /// <summary>The device name.</summary>
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
        /// <summary>The name of the report</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Number of failed updates on the device.</summary>
        public int? FailedUpdateCount {
            get { return BackingStore?.Get<int?>("failedUpdateCount"); }
            set { BackingStore?.Set("failedUpdateCount", value); }
        }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The OS version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>Number of successful updates on the device.</summary>
        public int? SuccessfulUpdateCount {
            get { return BackingStore?.Get<int?>("successfulUpdateCount"); }
            set { BackingStore?.Set("successfulUpdateCount", value); }
        }
        /// <summary>Number of total updates on the device.</summary>
        public int? TotalUpdateCount {
            get { return BackingStore?.Get<int?>("totalUpdateCount"); }
            set { BackingStore?.Set("totalUpdateCount", value); }
        }
        /// <summary>The user ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The user principal name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSSoftwareUpdateAccountSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateAccountSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"categorySummaries", n => { CategorySummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateCategorySummary>(MacOSSoftwareUpdateCategorySummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"failedUpdateCount", n => { FailedUpdateCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"successfulUpdateCount", n => { SuccessfulUpdateCount = n.GetIntValue(); } },
                {"totalUpdateCount", n => { TotalUpdateCount = n.GetIntValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MacOSSoftwareUpdateCategorySummary>("categorySummaries", CategorySummaries);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("failedUpdateCount", FailedUpdateCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteIntValue("successfulUpdateCount", SuccessfulUpdateCount);
            writer.WriteIntValue("totalUpdateCount", TotalUpdateCount);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
