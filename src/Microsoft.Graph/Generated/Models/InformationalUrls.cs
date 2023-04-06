using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class InformationalUrls : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The appSignUpUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppSignUpUrl {
            get { return BackingStore?.Get<string?>("appSignUpUrl"); }
            set { BackingStore?.Set("appSignUpUrl", value); }
        }
#nullable restore
#else
        public string AppSignUpUrl {
            get { return BackingStore?.Get<string>("appSignUpUrl"); }
            set { BackingStore?.Set("appSignUpUrl", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>The singleSignOnDocumentationUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SingleSignOnDocumentationUrl {
            get { return BackingStore?.Get<string?>("singleSignOnDocumentationUrl"); }
            set { BackingStore?.Set("singleSignOnDocumentationUrl", value); }
        }
#nullable restore
#else
        public string SingleSignOnDocumentationUrl {
            get { return BackingStore?.Get<string>("singleSignOnDocumentationUrl"); }
            set { BackingStore?.Set("singleSignOnDocumentationUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new informationalUrls and sets the default values.
        /// </summary>
        public InformationalUrls() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InformationalUrls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationalUrls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appSignUpUrl", n => { AppSignUpUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"singleSignOnDocumentationUrl", n => { SingleSignOnDocumentationUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appSignUpUrl", AppSignUpUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("singleSignOnDocumentationUrl", SingleSignOnDocumentationUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
