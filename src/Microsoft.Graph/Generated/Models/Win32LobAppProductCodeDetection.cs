using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains product code and version properties to detect a Win32 App
    /// </summary>
    public class Win32LobAppProductCodeDetection : Win32LobAppDetection, IParsable {
        /// <summary>The product code of Win32 Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductCode {
            get { return BackingStore?.Get<string?>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#nullable restore
#else
        public string ProductCode {
            get { return BackingStore?.Get<string>("productCode"); }
            set { BackingStore?.Set("productCode", value); }
        }
#endif
        /// <summary>The product version of Win32 Line of Business (LoB) app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductVersion {
            get { return BackingStore?.Get<string?>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#nullable restore
#else
        public string ProductVersion {
            get { return BackingStore?.Get<string>("productVersion"); }
            set { BackingStore?.Set("productVersion", value); }
        }
#endif
        /// <summary>Contains properties for detection operator.</summary>
        public Win32LobAppDetectionOperator? ProductVersionOperator {
            get { return BackingStore?.Get<Win32LobAppDetectionOperator?>("productVersionOperator"); }
            set { BackingStore?.Set("productVersionOperator", value); }
        }
        /// <summary>
        /// Instantiates a new win32LobAppProductCodeDetection and sets the default values.
        /// </summary>
        public Win32LobAppProductCodeDetection() : base() {
            OdataType = "#microsoft.graph.win32LobAppProductCodeDetection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Win32LobAppProductCodeDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppProductCodeDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"productCode", n => { ProductCode = n.GetStringValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"productVersionOperator", n => { ProductVersionOperator = n.GetEnumValue<Win32LobAppDetectionOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("productCode", ProductCode);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteEnumValue<Win32LobAppDetectionOperator>("productVersionOperator", ProductVersionOperator);
        }
    }
}
