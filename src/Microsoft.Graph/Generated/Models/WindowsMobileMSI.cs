// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties and inherited properties for Windows Mobile MSI Line Of Business apps.
    /// </summary>
    public class WindowsMobileMSI : Microsoft.Graph.Beta.Models.MobileLobApp, IParsable
    {
        /// <summary>The command line.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandLine
        {
            get { return BackingStore?.Get<string?>("commandLine"); }
            set { BackingStore?.Set("commandLine", value); }
        }
#nullable restore
#else
        public string CommandLine
        {
            get { return BackingStore?.Get<string>("commandLine"); }
            set { BackingStore?.Set("commandLine", value); }
        }
#endif
        /// <summary>The identity version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityVersion
        {
            get { return BackingStore?.Get<string?>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#nullable restore
#else
        public string IdentityVersion
        {
            get { return BackingStore?.Get<string>("identityVersion"); }
            set { BackingStore?.Set("identityVersion", value); }
        }
#endif
        /// <summary>A boolean to control whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for Windows Mobile MSI Line of Business (LoB) apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection
        {
            get { return BackingStore?.Get<bool?>("ignoreVersionDetection"); }
            set { BackingStore?.Set("ignoreVersionDetection", value); }
        }
        /// <summary>The product code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductCode
        {
            get { return BackingStore?.Get<string?>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#nullable restore
#else
        public string ProductCode
        {
            get { return BackingStore?.Get<string>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#endif
        /// <summary>The product version of Windows Mobile MSI Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion
        {
            get { return BackingStore?.Get<string?>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#nullable restore
#else
        public string ProductVersion
        {
            get { return BackingStore?.Get<string>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#endif
        /// <summary>Indicates whether to install a dual-mode MSI in the device context. If true, app will be installed for all users. If false, app will be installed per-user. If null, service will use the MSI package&apos;s default install context. In case of dual-mode MSI, this default will be per-user.  Cannot be set for non-dual-mode apps.  Cannot be changed after initial creation of the application.</summary>
        public bool? UseDeviceContext
        {
            get { return BackingStore?.Get<bool?>("useDeviceContext"); }
            set { BackingStore?.Set("useDeviceContext", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WindowsMobileMSI"/> and sets the default values.
        /// </summary>
        public WindowsMobileMSI() : base()
        {
            OdataType = "#microsoft.graph.windowsMobileMSI";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsMobileMSI"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsMobileMSI CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsMobileMSI();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "commandLine", n => { CommandLine = n.GetStringValue(); } },
                { "identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                { "ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                { "productCode", n => { ProductCode = n.GetStringValue(); } },
                { "productVersion", n => { ProductVersion = n.GetStringValue(); } },
                { "useDeviceContext", n => { UseDeviceContext = n.GetBoolValue(); } },
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
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteBoolValue("useDeviceContext", UseDeviceContext);
        }
    }
}
