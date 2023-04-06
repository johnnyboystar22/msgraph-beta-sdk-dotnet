using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics application performance entity contains app performance details by app version.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount {
            get { return BackingStore?.Get<int?>("appCrashCount"); }
            set { BackingStore?.Set("appCrashCount", value); }
        }
        /// <summary>The friendly name of the application.</summary>
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
        /// <summary>The name of the application.</summary>
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
        /// <summary>The publisher of the application.</summary>
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
        /// <summary>The total usage time of the application in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? AppUsageDuration {
            get { return BackingStore?.Get<int?>("appUsageDuration"); }
            set { BackingStore?.Set("appUsageDuration", value); }
        }
        /// <summary>The version of the application.</summary>
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
        /// <summary>The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appUsageDuration", n => { AppUsageDuration = n.GetIntValue(); } },
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteIntValue("appUsageDuration", AppUsageDuration);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
        }
    }
}
