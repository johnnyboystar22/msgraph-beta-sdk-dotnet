// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties and inherited properties for Android Line Of Business apps.
    /// </summary>
    public class AndroidLobApp : MobileLobApp, IParsable {
        /// <summary>The value for the minimum applicable operating system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AndroidMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<AndroidMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<AndroidMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The package identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageId {
            get { return BackingStore?.Get<string?>("packageId"); }
            set { BackingStore?.Set("packageId", value); }
        }
#nullable restore
#else
        public string PackageId {
            get { return BackingStore?.Get<string>("packageId"); }
            set { BackingStore?.Set("packageId", value); }
        }
#endif
        /// <summary>Specifies which platform(s) can be targeted for a given Android LOB application or Managed Android LOB application.</summary>
        public AndroidTargetedPlatforms? TargetedPlatforms {
            get { return BackingStore?.Get<AndroidTargetedPlatforms?>("targetedPlatforms"); }
            set { BackingStore?.Set("targetedPlatforms", value); }
        }
        /// <summary>The version code of Android Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionCode {
            get { return BackingStore?.Get<string?>("versionCode"); }
            set { BackingStore?.Set("versionCode", value); }
        }
#nullable restore
#else
        public string VersionCode {
            get { return BackingStore?.Get<string>("versionCode"); }
            set { BackingStore?.Set("versionCode", value); }
        }
#endif
        /// <summary>The version name of Android Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionName {
            get { return BackingStore?.Get<string?>("versionName"); }
            set { BackingStore?.Set("versionName", value); }
        }
#nullable restore
#else
        public string VersionName {
            get { return BackingStore?.Get<string>("versionName"); }
            set { BackingStore?.Set("versionName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AndroidLobApp"/> and sets the default values.
        /// </summary>
        public AndroidLobApp() : base() {
            OdataType = "#microsoft.graph.androidLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AndroidLobApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<AndroidMinimumOperatingSystem>(AndroidMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"packageId", n => { PackageId = n.GetStringValue(); } },
                {"targetedPlatforms", n => { TargetedPlatforms = n.GetEnumValue<AndroidTargetedPlatforms>(); } },
                {"versionCode", n => { VersionCode = n.GetStringValue(); } },
                {"versionName", n => { VersionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AndroidMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("packageId", PackageId);
            writer.WriteEnumValue<AndroidTargetedPlatforms>("targetedPlatforms", TargetedPlatforms);
            writer.WriteStringValue("versionCode", VersionCode);
            writer.WriteStringValue("versionName", VersionName);
        }
    }
}
