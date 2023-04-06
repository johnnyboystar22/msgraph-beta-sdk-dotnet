using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// iOS available update version details
    /// </summary>
    public class IosAvailableUpdateVersion : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The expiration date of the update.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
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
        /// <summary>The posting date of the update.</summary>
        public DateTimeOffset? PostingDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("postingDateTime"); }
            set { BackingStore?.Set("postingDateTime", value); }
        }
        /// <summary>The version of the update.</summary>
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
        /// <summary>List of supported devices for the update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedDevices {
            get { return BackingStore?.Get<List<string>?>("supportedDevices"); }
            set { BackingStore?.Set("supportedDevices", value); }
        }
#nullable restore
#else
        public List<string> SupportedDevices {
            get { return BackingStore?.Get<List<string>>("supportedDevices"); }
            set { BackingStore?.Set("supportedDevices", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new iosAvailableUpdateVersion and sets the default values.
        /// </summary>
        public IosAvailableUpdateVersion() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IosAvailableUpdateVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosAvailableUpdateVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postingDateTime", n => { PostingDateTime = n.GetDateTimeOffsetValue(); } },
                {"productVersion", n => { ProductVersion = n.GetStringValue(); } },
                {"supportedDevices", n => { SupportedDevices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("postingDateTime", PostingDateTime);
            writer.WriteStringValue("productVersion", ProductVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedDevices", SupportedDevices);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
