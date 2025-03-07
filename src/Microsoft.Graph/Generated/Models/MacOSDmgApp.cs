// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties and inherited properties for the MacOS DMG (Apple Disk Image) App.
    /// </summary>
    public class MacOSDmgApp : Microsoft.Graph.Beta.Models.MobileLobApp, IParsable
    {
        /// <summary>When TRUE, indicates that the app&apos;s version will NOT be used to detect if the app is installed on a device. When FALSE, indicates that the app&apos;s version will be used to detect if the app is installed on a device. Set this to true for apps that use a self update feature. The default value is FALSE.</summary>
        public bool? IgnoreVersionDetection
        {
            get { return BackingStore?.Get<bool?>("ignoreVersionDetection"); }
            set { BackingStore?.Set("ignoreVersionDetection", value); }
        }
        /// <summary>The list of .apps expected to be installed by the DMG (Apple Disk Image). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MacOSIncludedApp>? IncludedApps
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MacOSIncludedApp>?>("includedApps"); }
            set { BackingStore?.Set("includedApps", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MacOSIncludedApp> IncludedApps
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MacOSIncludedApp>>("includedApps"); }
            set { BackingStore?.Set("includedApps", value); }
        }
#endif
        /// <summary>ComplexType macOSMinimumOperatingSystem that indicates the minimum operating system applicable for the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem? MinimumSupportedOperatingSystem
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem?>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem"); }
            set { BackingStore?.Set("minimumSupportedOperatingSystem", value); }
        }
#endif
        /// <summary>The bundleId of the primary .app in the DMG (Apple Disk Image). This maps to the CFBundleIdentifier in the app&apos;s bundle configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleId
        {
            get { return BackingStore?.Get<string?>("primaryBundleId"); }
            set { BackingStore?.Set("primaryBundleId", value); }
        }
#nullable restore
#else
        public string PrimaryBundleId
        {
            get { return BackingStore?.Get<string>("primaryBundleId"); }
            set { BackingStore?.Set("primaryBundleId", value); }
        }
#endif
        /// <summary>The version of the primary .app in the DMG (Apple Disk Image). This maps to the CFBundleShortVersion in the app&apos;s bundle configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryBundleVersion
        {
            get { return BackingStore?.Get<string?>("primaryBundleVersion"); }
            set { BackingStore?.Set("primaryBundleVersion", value); }
        }
#nullable restore
#else
        public string PrimaryBundleVersion
        {
            get { return BackingStore?.Get<string>("primaryBundleVersion"); }
            set { BackingStore?.Set("primaryBundleVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MacOSDmgApp"/> and sets the default values.
        /// </summary>
        public MacOSDmgApp() : base()
        {
            OdataType = "#microsoft.graph.macOSDmgApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MacOSDmgApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MacOSDmgApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MacOSDmgApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                { "includedApps", n => { IncludedApps = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSIncludedApp>(Microsoft.Graph.Beta.Models.MacOSIncludedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                { "minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem>(Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                { "primaryBundleId", n => { PrimaryBundleId = n.GetStringValue(); } },
                { "primaryBundleVersion", n => { PrimaryBundleVersion = n.GetStringValue(); } },
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
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSIncludedApp>("includedApps", IncludedApps);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("primaryBundleId", PrimaryBundleId);
            writer.WriteStringValue("primaryBundleVersion", PrimaryBundleVersion);
        }
    }
}
