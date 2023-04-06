using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MessageSecurityState : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The connectingIP property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectingIP {
            get { return BackingStore?.Get<string?>("connectingIP"); }
            set { BackingStore?.Set("connectingIP", value); }
        }
#nullable restore
#else
        public string ConnectingIP {
            get { return BackingStore?.Get<string>("connectingIP"); }
            set { BackingStore?.Set("connectingIP", value); }
        }
#endif
        /// <summary>The deliveryAction property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryAction {
            get { return BackingStore?.Get<string?>("deliveryAction"); }
            set { BackingStore?.Set("deliveryAction", value); }
        }
#nullable restore
#else
        public string DeliveryAction {
            get { return BackingStore?.Get<string>("deliveryAction"); }
            set { BackingStore?.Set("deliveryAction", value); }
        }
#endif
        /// <summary>The deliveryLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryLocation {
            get { return BackingStore?.Get<string?>("deliveryLocation"); }
            set { BackingStore?.Set("deliveryLocation", value); }
        }
#nullable restore
#else
        public string DeliveryLocation {
            get { return BackingStore?.Get<string>("deliveryLocation"); }
            set { BackingStore?.Set("deliveryLocation", value); }
        }
#endif
        /// <summary>The directionality property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Directionality {
            get { return BackingStore?.Get<string?>("directionality"); }
            set { BackingStore?.Set("directionality", value); }
        }
#nullable restore
#else
        public string Directionality {
            get { return BackingStore?.Get<string>("directionality"); }
            set { BackingStore?.Set("directionality", value); }
        }
#endif
        /// <summary>The internetMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId {
            get { return BackingStore?.Get<string?>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#nullable restore
#else
        public string InternetMessageId {
            get { return BackingStore?.Get<string>("internetMessageId"); }
            set { BackingStore?.Set("internetMessageId", value); }
        }
#endif
        /// <summary>The messageFingerprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageFingerprint {
            get { return BackingStore?.Get<string?>("messageFingerprint"); }
            set { BackingStore?.Set("messageFingerprint", value); }
        }
#nullable restore
#else
        public string MessageFingerprint {
            get { return BackingStore?.Get<string>("messageFingerprint"); }
            set { BackingStore?.Set("messageFingerprint", value); }
        }
#endif
        /// <summary>The messageReceivedDateTime property</summary>
        public DateTimeOffset? MessageReceivedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("messageReceivedDateTime"); }
            set { BackingStore?.Set("messageReceivedDateTime", value); }
        }
        /// <summary>The messageSubject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageSubject {
            get { return BackingStore?.Get<string?>("messageSubject"); }
            set { BackingStore?.Set("messageSubject", value); }
        }
#nullable restore
#else
        public string MessageSubject {
            get { return BackingStore?.Get<string>("messageSubject"); }
            set { BackingStore?.Set("messageSubject", value); }
        }
#endif
        /// <summary>The networkMessageId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId {
            get { return BackingStore?.Get<string?>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
        }
#nullable restore
#else
        public string NetworkMessageId {
            get { return BackingStore?.Get<string>("networkMessageId"); }
            set { BackingStore?.Set("networkMessageId", value); }
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
        /// Instantiates a new messageSecurityState and sets the default values.
        /// </summary>
        public MessageSecurityState() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MessageSecurityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageSecurityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectingIP", n => { ConnectingIP = n.GetStringValue(); } },
                {"deliveryAction", n => { DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", n => { DeliveryLocation = n.GetStringValue(); } },
                {"directionality", n => { Directionality = n.GetStringValue(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"messageFingerprint", n => { MessageFingerprint = n.GetStringValue(); } },
                {"messageReceivedDateTime", n => { MessageReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"messageSubject", n => { MessageSubject = n.GetStringValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("connectingIP", ConnectingIP);
            writer.WriteStringValue("deliveryAction", DeliveryAction);
            writer.WriteStringValue("deliveryLocation", DeliveryLocation);
            writer.WriteStringValue("directionality", Directionality);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("messageFingerprint", MessageFingerprint);
            writer.WriteDateTimeOffsetValue("messageReceivedDateTime", MessageReceivedDateTime);
            writer.WriteStringValue("messageSubject", MessageSubject);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
