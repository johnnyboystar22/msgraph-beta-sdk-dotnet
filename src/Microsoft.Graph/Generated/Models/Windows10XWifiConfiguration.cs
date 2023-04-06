using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10XWifiConfiguration : DeviceManagementResourceAccessProfileBase, IParsable {
        /// <summary>ID to the Authentication Certificate</summary>
        public Guid? AuthenticationCertificateId {
            get { return BackingStore?.Get<Guid?>("authenticationCertificateId"); }
            set { BackingStore?.Set("authenticationCertificateId", value); }
        }
        /// <summary>Custom XML commands that configures the VPN connection. (UTF8 byte encoding)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? CustomXml {
            get { return BackingStore?.Get<byte[]?>("customXml"); }
            set { BackingStore?.Set("customXml", value); }
        }
#nullable restore
#else
        public byte[] CustomXml {
            get { return BackingStore?.Get<byte[]>("customXml"); }
            set { BackingStore?.Set("customXml", value); }
        }
#endif
        /// <summary>Custom Xml file name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomXmlFileName {
            get { return BackingStore?.Get<string?>("customXmlFileName"); }
            set { BackingStore?.Set("customXmlFileName", value); }
        }
#nullable restore
#else
        public string CustomXmlFileName {
            get { return BackingStore?.Get<string>("customXmlFileName"); }
            set { BackingStore?.Set("customXmlFileName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Windows10XWifiConfiguration and sets the default values.
        /// </summary>
        public Windows10XWifiConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10XWifiConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10XWifiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10XWifiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationCertificateId", n => { AuthenticationCertificateId = n.GetGuidValue(); } },
                {"customXml", n => { CustomXml = n.GetByteArrayValue(); } },
                {"customXmlFileName", n => { CustomXmlFileName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("authenticationCertificateId", AuthenticationCertificateId);
            writer.WriteByteArrayValue("customXml", CustomXml);
            writer.WriteStringValue("customXmlFileName", CustomXmlFileName);
        }
    }
}
