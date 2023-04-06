using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization.Jobs.Item.ValidateCredentials {
    public class ValidateCredentialsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The applicationIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationIdentifier {
            get { return BackingStore?.Get<string?>("applicationIdentifier"); }
            set { BackingStore?.Set("applicationIdentifier", value); }
        }
#nullable restore
#else
        public string ApplicationIdentifier {
            get { return BackingStore?.Get<string>("applicationIdentifier"); }
            set { BackingStore?.Set("applicationIdentifier", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The credentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationSecretKeyStringValuePair>? Credentials {
            get { return BackingStore?.Get<List<SynchronizationSecretKeyStringValuePair>?>("credentials"); }
            set { BackingStore?.Set("credentials", value); }
        }
#nullable restore
#else
        public List<SynchronizationSecretKeyStringValuePair> Credentials {
            get { return BackingStore?.Get<List<SynchronizationSecretKeyStringValuePair>>("credentials"); }
            set { BackingStore?.Set("credentials", value); }
        }
#endif
        /// <summary>The templateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#nullable restore
#else
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>The useSavedCredentials property</summary>
        public bool? UseSavedCredentials {
            get { return BackingStore?.Get<bool?>("useSavedCredentials"); }
            set { BackingStore?.Set("useSavedCredentials", value); }
        }
        /// <summary>
        /// Instantiates a new validateCredentialsPostRequestBody and sets the default values.
        /// </summary>
        public ValidateCredentialsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ValidateCredentialsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateCredentialsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationIdentifier", n => { ApplicationIdentifier = n.GetStringValue(); } },
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"useSavedCredentials", n => { UseSavedCredentials = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationIdentifier", ApplicationIdentifier);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("credentials", Credentials);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteBoolValue("useSavedCredentials", UseSavedCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
