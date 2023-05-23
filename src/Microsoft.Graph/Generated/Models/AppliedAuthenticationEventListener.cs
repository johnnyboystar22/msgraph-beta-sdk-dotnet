using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AppliedAuthenticationEventListener : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The type of authentication event that triggered the custom authentication extension request. The possible values are: tokenIssuanceStart, pageRenderStart, unknownFutureValue.</summary>
        public AuthenticationEventType? EventType {
            get { return BackingStore?.Get<AuthenticationEventType?>("eventType"); }
            set { BackingStore?.Set("eventType", value); }
        }
        /// <summary>ID of the authentication event listener that was executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExecutedListenerId {
            get { return BackingStore?.Get<string?>("executedListenerId"); }
            set { BackingStore?.Set("executedListenerId", value); }
        }
#nullable restore
#else
        public string ExecutedListenerId {
            get { return BackingStore?.Get<string>("executedListenerId"); }
            set { BackingStore?.Set("executedListenerId", value); }
        }
#endif
        /// <summary>The result from the listening client, such as an Azure Logic App and Azure Functions, of this authentication event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuthenticationEventHandlerResult? HandlerResult {
            get { return BackingStore?.Get<AuthenticationEventHandlerResult?>("handlerResult"); }
            set { BackingStore?.Set("handlerResult", value); }
        }
#nullable restore
#else
        public AuthenticationEventHandlerResult HandlerResult {
            get { return BackingStore?.Get<AuthenticationEventHandlerResult>("handlerResult"); }
            set { BackingStore?.Set("handlerResult", value); }
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
        /// Instantiates a new appliedAuthenticationEventListener and sets the default values.
        /// </summary>
        public AppliedAuthenticationEventListener() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppliedAuthenticationEventListener CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppliedAuthenticationEventListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"eventType", n => { EventType = n.GetEnumValue<AuthenticationEventType>(); } },
                {"executedListenerId", n => { ExecutedListenerId = n.GetStringValue(); } },
                {"handlerResult", n => { HandlerResult = n.GetObjectValue<AuthenticationEventHandlerResult>(AuthenticationEventHandlerResult.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthenticationEventType>("eventType", EventType);
            writer.WriteStringValue("executedListenerId", ExecutedListenerId);
            writer.WriteObjectValue<AuthenticationEventHandlerResult>("handlerResult", HandlerResult);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
