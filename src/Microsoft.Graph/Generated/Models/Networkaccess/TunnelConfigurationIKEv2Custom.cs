using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class TunnelConfigurationIKEv2Custom : TunnelConfiguration, IParsable {
        /// <summary>The dhGroup property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.DhGroup? DhGroup {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.DhGroup?>("dhGroup"); }
            set { BackingStore?.Set("dhGroup", value); }
        }
        /// <summary>The ikeEncryption property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.IkeEncryption? IkeEncryption {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.IkeEncryption?>("ikeEncryption"); }
            set { BackingStore?.Set("ikeEncryption", value); }
        }
        /// <summary>The ikeIntegrity property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.IkeIntegrity? IkeIntegrity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.IkeIntegrity?>("ikeIntegrity"); }
            set { BackingStore?.Set("ikeIntegrity", value); }
        }
        /// <summary>The ipSecEncryption property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.IpSecEncryption? IpSecEncryption {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.IpSecEncryption?>("ipSecEncryption"); }
            set { BackingStore?.Set("ipSecEncryption", value); }
        }
        /// <summary>The ipSecIntegrity property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.IpSecIntegrity? IpSecIntegrity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.IpSecIntegrity?>("ipSecIntegrity"); }
            set { BackingStore?.Set("ipSecIntegrity", value); }
        }
        /// <summary>The pfsGroup property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.PfsGroup? PfsGroup {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.PfsGroup?>("pfsGroup"); }
            set { BackingStore?.Set("pfsGroup", value); }
        }
        /// <summary>a standard specifiying Security Association lifetime with recommended values from an RFC standard.</summary>
        public long? SaLifeTimeSeconds {
            get { return BackingStore?.Get<long?>("saLifeTimeSeconds"); }
            set { BackingStore?.Set("saLifeTimeSeconds", value); }
        }
        /// <summary>
        /// Instantiates a new tunnelConfigurationIKEv2Custom and sets the default values.
        /// </summary>
        public TunnelConfigurationIKEv2Custom() : base() {
            OdataType = "#microsoft.graph.networkaccess.tunnelConfigurationIKEv2Custom";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TunnelConfigurationIKEv2Custom CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TunnelConfigurationIKEv2Custom();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"dhGroup", n => { DhGroup = n.GetEnumValue<DhGroup>(); } },
                {"ikeEncryption", n => { IkeEncryption = n.GetEnumValue<IkeEncryption>(); } },
                {"ikeIntegrity", n => { IkeIntegrity = n.GetEnumValue<IkeIntegrity>(); } },
                {"ipSecEncryption", n => { IpSecEncryption = n.GetEnumValue<IpSecEncryption>(); } },
                {"ipSecIntegrity", n => { IpSecIntegrity = n.GetEnumValue<IpSecIntegrity>(); } },
                {"pfsGroup", n => { PfsGroup = n.GetEnumValue<PfsGroup>(); } },
                {"saLifeTimeSeconds", n => { SaLifeTimeSeconds = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DhGroup>("dhGroup", DhGroup);
            writer.WriteEnumValue<IkeEncryption>("ikeEncryption", IkeEncryption);
            writer.WriteEnumValue<IkeIntegrity>("ikeIntegrity", IkeIntegrity);
            writer.WriteEnumValue<IpSecEncryption>("ipSecEncryption", IpSecEncryption);
            writer.WriteEnumValue<IpSecIntegrity>("ipSecIntegrity", IpSecIntegrity);
            writer.WriteEnumValue<PfsGroup>("pfsGroup", PfsGroup);
            writer.WriteLongValue("saLifeTimeSeconds", SaLifeTimeSeconds);
        }
    }
}
