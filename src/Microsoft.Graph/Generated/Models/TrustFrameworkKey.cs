// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TrustFrameworkKey : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>RSA Key - private exponent. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? D {
            get { return BackingStore?.Get<string?>("d"); }
            set { BackingStore?.Set("d", value); }
        }
#nullable restore
#else
        public string D {
            get { return BackingStore?.Get<string>("d"); }
            set { BackingStore?.Set("d", value); }
        }
#endif
        /// <summary>RSA Key - first exponent. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Dp {
            get { return BackingStore?.Get<string?>("dp"); }
            set { BackingStore?.Set("dp", value); }
        }
#nullable restore
#else
        public string Dp {
            get { return BackingStore?.Get<string>("dp"); }
            set { BackingStore?.Set("dp", value); }
        }
#endif
        /// <summary>RSA Key - second exponent. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Dq {
            get { return BackingStore?.Get<string?>("dq"); }
            set { BackingStore?.Set("dq", value); }
        }
#nullable restore
#else
        public string Dq {
            get { return BackingStore?.Get<string>("dq"); }
            set { BackingStore?.Set("dq", value); }
        }
#endif
        /// <summary>RSA Key - public exponent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? E {
            get { return BackingStore?.Get<string?>("e"); }
            set { BackingStore?.Set("e", value); }
        }
#nullable restore
#else
        public string E {
            get { return BackingStore?.Get<string>("e"); }
            set { BackingStore?.Set("e", value); }
        }
#endif
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Exp {
            get { return BackingStore?.Get<long?>("exp"); }
            set { BackingStore?.Set("exp", value); }
        }
        /// <summary>Symmetric Key for oct key type. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? K {
            get { return BackingStore?.Get<string?>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#nullable restore
#else
        public string K {
            get { return BackingStore?.Get<string>("k"); }
            set { BackingStore?.Set("k", value); }
        }
#endif
        /// <summary>The unique identifier for the key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kid {
            get { return BackingStore?.Get<string?>("kid"); }
            set { BackingStore?.Set("kid", value); }
        }
#nullable restore
#else
        public string Kid {
            get { return BackingStore?.Get<string>("kid"); }
            set { BackingStore?.Set("kid", value); }
        }
#endif
        /// <summary>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, The valid values are rsa, oct.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kty {
            get { return BackingStore?.Get<string?>("kty"); }
            set { BackingStore?.Set("kty", value); }
        }
#nullable restore
#else
        public string Kty {
            get { return BackingStore?.Get<string>("kty"); }
            set { BackingStore?.Set("kty", value); }
        }
#endif
        /// <summary>RSA Key - modulus</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? N {
            get { return BackingStore?.Get<string?>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#nullable restore
#else
        public string N {
            get { return BackingStore?.Get<string>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#endif
        /// <summary>This value is a NumericDate as defined in RFC 7519 (A JSON numeric value representing the number of seconds from 1970-01-01T00:00:00Z UTC until the specified UTC date/time, ignoring leap seconds.)</summary>
        public long? Nbf {
            get { return BackingStore?.Get<long?>("nbf"); }
            set { BackingStore?.Set("nbf", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>RSA Key - first prime. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? P {
            get { return BackingStore?.Get<string?>("p"); }
            set { BackingStore?.Set("p", value); }
        }
#nullable restore
#else
        public string P {
            get { return BackingStore?.Get<string>("p"); }
            set { BackingStore?.Set("p", value); }
        }
#endif
        /// <summary>RSA Key - second prime. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Q {
            get { return BackingStore?.Get<string?>("q"); }
            set { BackingStore?.Set("q", value); }
        }
#nullable restore
#else
        public string Q {
            get { return BackingStore?.Get<string>("q"); }
            set { BackingStore?.Set("q", value); }
        }
#endif
        /// <summary>RSA Key - Coefficient. Field can&apos;t be read back.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Qi {
            get { return BackingStore?.Get<string?>("qi"); }
            set { BackingStore?.Set("qi", value); }
        }
#nullable restore
#else
        public string Qi {
            get { return BackingStore?.Get<string>("qi"); }
            set { BackingStore?.Set("qi", value); }
        }
#endif
        /// <summary>The use (public key use) parameter identifies the intended use of the public key.  The use parameter is employed to indicate whether a public key is used for encrypting data or verifying the signature on data. Possible values are: sig (signature), enc (encryption)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Use {
            get { return BackingStore?.Get<string?>("use"); }
            set { BackingStore?.Set("use", value); }
        }
#nullable restore
#else
        public string Use {
            get { return BackingStore?.Get<string>("use"); }
            set { BackingStore?.Set("use", value); }
        }
#endif
        /// <summary>The x5c (X.509 certificate chain) parameter contains a chain of one or more PKIX certificates RFC 5280.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? X5c {
            get { return BackingStore?.Get<List<string>?>("x5c"); }
            set { BackingStore?.Set("x5c", value); }
        }
#nullable restore
#else
        public List<string> X5c {
            get { return BackingStore?.Get<List<string>>("x5c"); }
            set { BackingStore?.Set("x5c", value); }
        }
#endif
        /// <summary>The x5t (X.509 certificate SHA-1 thumbprint) parameter is a base64url-encoded SHA-1 thumbprint (also known as digest) of the DER encoding of an X.509 certificate RFC 5280.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? X5t {
            get { return BackingStore?.Get<string?>("x5t"); }
            set { BackingStore?.Set("x5t", value); }
        }
#nullable restore
#else
        public string X5t {
            get { return BackingStore?.Get<string>("x5t"); }
            set { BackingStore?.Set("x5t", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TrustFrameworkKey"/> and sets the default values.
        /// </summary>
        public TrustFrameworkKey() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrustFrameworkKey"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrustFrameworkKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrustFrameworkKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"d", n => { D = n.GetStringValue(); } },
                {"dp", n => { Dp = n.GetStringValue(); } },
                {"dq", n => { Dq = n.GetStringValue(); } },
                {"e", n => { E = n.GetStringValue(); } },
                {"exp", n => { Exp = n.GetLongValue(); } },
                {"k", n => { K = n.GetStringValue(); } },
                {"kid", n => { Kid = n.GetStringValue(); } },
                {"kty", n => { Kty = n.GetStringValue(); } },
                {"n", n => { N = n.GetStringValue(); } },
                {"nbf", n => { Nbf = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"p", n => { P = n.GetStringValue(); } },
                {"q", n => { Q = n.GetStringValue(); } },
                {"qi", n => { Qi = n.GetStringValue(); } },
                {"use", n => { Use = n.GetStringValue(); } },
                {"x5c", n => { X5c = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"x5t", n => { X5t = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("d", D);
            writer.WriteStringValue("dp", Dp);
            writer.WriteStringValue("dq", Dq);
            writer.WriteStringValue("e", E);
            writer.WriteLongValue("exp", Exp);
            writer.WriteStringValue("k", K);
            writer.WriteStringValue("kid", Kid);
            writer.WriteStringValue("kty", Kty);
            writer.WriteStringValue("n", N);
            writer.WriteLongValue("nbf", Nbf);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("p", P);
            writer.WriteStringValue("q", Q);
            writer.WriteStringValue("qi", Qi);
            writer.WriteStringValue("use", Use);
            writer.WriteCollectionOfPrimitiveValues<string>("x5c", X5c);
            writer.WriteStringValue("x5t", X5t);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
