using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSLobApp : MobileLobApp, IParsable {
        /// <summary>The build number of the package. This should match the package CFBundleShortVersionString of the .pkg file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BuildNumber {
            get { return BackingStore?.Get<string?>("buildNumber"); }
            set { BackingStore?.Set("buildNumber", value); }
        }
#nullable restore
#else
        public string BuildNumber {
            get { return BackingStore?.Get<string>("buildNumber"); }
            set { BackingStore?.Set("buildNumber", value); }
        }
#endif
        /// <summary>The primary bundleId of the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId {
            get { return BackingStore?.Get<string?>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#nullable restore
#else
        public string BundleId {
            get { return BackingStore?.Get<string>("bundleId"); }
            set { BackingStore?.Set("bundleId", value); }
        }
#endif
        /// <summary>List of ComplexType macOSLobChildApp objects. Represents the apps expected to be installed by the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSLobChildApp>? ChildApps {
            get { return BackingStore?.Get<List<MacOSLobChildApp>?>("childApps"); }
            set { BackingStore?.Set("childApps", value); }
        }
#nullable restore
#else
        public List<MacOSLobChildApp> ChildApps {
            get { return BackingStore?.Get<List<MacOSLobChildApp>>("childApps"); }
            set { BackingStore?.Set("childApps", value); }
        }
#endif
        /// <summary>When TRUE, indicates that the app&apos;s version will NOT be used to detect if the app is installed on a device. When FALSE, indicates that the app&apos;s version will be used to detect if the app is installed on a device. Set this to true for apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection {
            get { return BackingStore?.Get<bool?>("ignoreVersionDetection"); }
            set { BackingStore?.Set("ignoreVersionDetection", value); }
        }
        /// <summary>When TRUE, indicates that the app will be installed as managed (requires macOS 11.0 and other managed package restrictions). When FALSE, indicates that the app will be installed as unmanaged.</summary>
        public bool? InstallAsManaged {
            get { return BackingStore?.Get<bool?>("installAsManaged"); }
            set { BackingStore?.Set("installAsManaged", value); }
        }
        /// <summary>The MD5 hash codes. This is empty if the package was uploaded directly. If the Intune App Wrapping Tool is used to create a .intunemac, this value can be found inside the Detection.xml file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Md5Hash {
            get { return BackingStore?.Get<List<string>?>("md5Hash"); }
            set { BackingStore?.Set("md5Hash", value); }
        }
#nullable restore
#else
        public List<string> Md5Hash {
            get { return BackingStore?.Get<List<string>>("md5Hash"); }
            set { BackingStore?.Set("md5Hash", value); }
        }
#endif
        /// <summary>The chunk size for MD5 hash. This is &apos;0&apos; or empty if the package was uploaded directly. If the Intune App Wrapping Tool is used to create a .intunemac, this value can be found inside the Detection.xml file.</summary>
        public int? Md5HashChunkSize {
            get { return BackingStore?.Get<int?>("md5HashChunkSize"); }
            set { BackingStore?.Set("md5HashChunkSize", value); }
        }
        /// <summary>ComplexType macOSMinimumOperatingSystem that indicates the minimum operating system applicable for the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSMinimumOperatingSystem? MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<MacOSMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The version number of the package. This should match the package CFBundleVersion in the packageinfo file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionNumber {
            get { return BackingStore?.Get<string?>("versionNumber"); }
            set { BackingStore?.Set("versionNumber", value); }
        }
#nullable restore
#else
        public string VersionNumber {
            get { return BackingStore?.Get<string>("versionNumber"); }
            set { BackingStore?.Set("versionNumber", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new MacOSLobApp and sets the default values.
        /// </summary>
        public MacOSLobApp() : base() {
            OdataType = "#microsoft.graph.macOSLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buildNumber", n => { BuildNumber = n.GetStringValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"childApps", n => { ChildApps = n.GetCollectionOfObjectValues<MacOSLobChildApp>(MacOSLobChildApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                {"installAsManaged", n => { InstallAsManaged = n.GetBoolValue(); } },
                {"md5Hash", n => { Md5Hash = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"md5HashChunkSize", n => { Md5HashChunkSize = n.GetIntValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<MacOSMinimumOperatingSystem>(MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"versionNumber", n => { VersionNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("buildNumber", BuildNumber);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteCollectionOfObjectValues<MacOSLobChildApp>("childApps", ChildApps);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteBoolValue("installAsManaged", InstallAsManaged);
            writer.WriteCollectionOfPrimitiveValues<string>("md5Hash", Md5Hash);
            writer.WriteIntValue("md5HashChunkSize", Md5HashChunkSize);
            writer.WriteObjectValue<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("versionNumber", VersionNumber);
        }
    }
}
