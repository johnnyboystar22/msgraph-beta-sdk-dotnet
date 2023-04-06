using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ConditionalAccessPlatforms : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue, linux.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessDevicePlatform?>? ExcludePlatforms {
            get { return BackingStore?.Get<List<ConditionalAccessDevicePlatform?>?>("excludePlatforms"); }
            set { BackingStore?.Set("excludePlatforms", value); }
        }
#nullable restore
#else
        public List<ConditionalAccessDevicePlatform?> ExcludePlatforms {
            get { return BackingStore?.Get<List<ConditionalAccessDevicePlatform?>>("excludePlatforms"); }
            set { BackingStore?.Set("excludePlatforms", value); }
        }
#endif
        /// <summary>Possible values are: android, iOS, windows, windowsPhone, macOS, all, unknownFutureValue,linux``.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessDevicePlatform?>? IncludePlatforms {
            get { return BackingStore?.Get<List<ConditionalAccessDevicePlatform?>?>("includePlatforms"); }
            set { BackingStore?.Set("includePlatforms", value); }
        }
#nullable restore
#else
        public List<ConditionalAccessDevicePlatform?> IncludePlatforms {
            get { return BackingStore?.Get<List<ConditionalAccessDevicePlatform?>>("includePlatforms"); }
            set { BackingStore?.Set("includePlatforms", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new conditionalAccessPlatforms and sets the default values.
        /// </summary>
        public ConditionalAccessPlatforms() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessPlatforms CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessPlatforms();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludePlatforms", n => { ExcludePlatforms = n.GetCollectionOfEnumValues<ConditionalAccessDevicePlatform>()?.ToList(); } },
                {"includePlatforms", n => { IncludePlatforms = n.GetCollectionOfEnumValues<ConditionalAccessDevicePlatform>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ConditionalAccessDevicePlatform>("excludePlatforms", ExcludePlatforms);
            writer.WriteCollectionOfEnumValues<ConditionalAccessDevicePlatform>("includePlatforms", IncludePlatforms);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
