// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TrustedCertificateAuthorityAsEntityBase : DirectoryObject, IParsable {
        /// <summary>Collection of trusted certificate authorities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CertificateAuthorityAsEntity>? TrustedCertificateAuthorities {
            get { return BackingStore?.Get<List<CertificateAuthorityAsEntity>?>("trustedCertificateAuthorities"); }
            set { BackingStore?.Set("trustedCertificateAuthorities", value); }
        }
#nullable restore
#else
        public List<CertificateAuthorityAsEntity> TrustedCertificateAuthorities {
            get { return BackingStore?.Get<List<CertificateAuthorityAsEntity>>("trustedCertificateAuthorities"); }
            set { BackingStore?.Set("trustedCertificateAuthorities", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TrustedCertificateAuthorityAsEntityBase"/> and sets the default values.
        /// </summary>
        public TrustedCertificateAuthorityAsEntityBase() : base() {
            OdataType = "#microsoft.graph.trustedCertificateAuthorityAsEntityBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrustedCertificateAuthorityAsEntityBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TrustedCertificateAuthorityAsEntityBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.certificateBasedApplicationConfiguration" => new CertificateBasedApplicationConfiguration(),
                _ => new TrustedCertificateAuthorityAsEntityBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"trustedCertificateAuthorities", n => { TrustedCertificateAuthorities = n.GetCollectionOfObjectValues<CertificateAuthorityAsEntity>(CertificateAuthorityAsEntity.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CertificateAuthorityAsEntity>("trustedCertificateAuthorities", TrustedCertificateAuthorities);
        }
    }
}
