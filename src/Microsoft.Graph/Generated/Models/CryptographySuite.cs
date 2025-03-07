// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// VPN Security Association Parameters
    /// </summary>
    public class CryptographySuite : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Authentication Transform Constants. Possible values are: md596, sha196, sha256128, aes128Gcm, aes192Gcm, aes256Gcm.</summary>
        public Microsoft.Graph.Beta.Models.AuthenticationTransformConstant? AuthenticationTransformConstants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationTransformConstant?>("authenticationTransformConstants"); }
            set { BackingStore?.Set("authenticationTransformConstants", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Cipher Transform Constants. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm, chaCha20Poly1305.</summary>
        public Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType? CipherTransformConstants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType?>("cipherTransformConstants"); }
            set { BackingStore?.Set("cipherTransformConstants", value); }
        }
        /// <summary>Diffie Hellman Group. Possible values are: group1, group2, group14, ecp256, ecp384, group24.</summary>
        public Microsoft.Graph.Beta.Models.DiffieHellmanGroup? DhGroup
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DiffieHellmanGroup?>("dhGroup"); }
            set { BackingStore?.Set("dhGroup", value); }
        }
        /// <summary>Encryption Method. Possible values are: aes256, des, tripleDes, aes128, aes128Gcm, aes256Gcm, aes192, aes192Gcm, chaCha20Poly1305.</summary>
        public Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType? EncryptionMethod
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType?>("encryptionMethod"); }
            set { BackingStore?.Set("encryptionMethod", value); }
        }
        /// <summary>Integrity Check Method. Possible values are: sha2256, sha196, sha1160, sha2384, sha2_512, md5.</summary>
        public Microsoft.Graph.Beta.Models.VpnIntegrityAlgorithmType? IntegrityCheckMethod
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VpnIntegrityAlgorithmType?>("integrityCheckMethod"); }
            set { BackingStore?.Set("integrityCheckMethod", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Perfect Forward Secrecy Group. Possible values are: pfs1, pfs2, pfs2048, ecp256, ecp384, pfsMM, pfs24.</summary>
        public Microsoft.Graph.Beta.Models.PerfectForwardSecrecyGroup? PfsGroup
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PerfectForwardSecrecyGroup?>("pfsGroup"); }
            set { BackingStore?.Set("pfsGroup", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CryptographySuite"/> and sets the default values.
        /// </summary>
        public CryptographySuite()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CryptographySuite"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CryptographySuite CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CryptographySuite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticationTransformConstants", n => { AuthenticationTransformConstants = n.GetEnumValue<Microsoft.Graph.Beta.Models.AuthenticationTransformConstant>(); } },
                { "cipherTransformConstants", n => { CipherTransformConstants = n.GetEnumValue<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType>(); } },
                { "dhGroup", n => { DhGroup = n.GetEnumValue<Microsoft.Graph.Beta.Models.DiffieHellmanGroup>(); } },
                { "encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType>(); } },
                { "integrityCheckMethod", n => { IntegrityCheckMethod = n.GetEnumValue<Microsoft.Graph.Beta.Models.VpnIntegrityAlgorithmType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "pfsGroup", n => { PfsGroup = n.GetEnumValue<Microsoft.Graph.Beta.Models.PerfectForwardSecrecyGroup>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AuthenticationTransformConstant>("authenticationTransformConstants", AuthenticationTransformConstants);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType>("cipherTransformConstants", CipherTransformConstants);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DiffieHellmanGroup>("dhGroup", DhGroup);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.VpnEncryptionAlgorithmType>("encryptionMethod", EncryptionMethod);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.VpnIntegrityAlgorithmType>("integrityCheckMethod", IntegrityCheckMethod);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.PerfectForwardSecrecyGroup>("pfsGroup", PfsGroup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
