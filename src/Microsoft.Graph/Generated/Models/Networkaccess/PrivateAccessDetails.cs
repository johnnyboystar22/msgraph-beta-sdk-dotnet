// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    #pragma warning disable CS1591
    public class PrivateAccessDetails : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The accessType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.AccessType? AccessType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.AccessType?>("accessType"); }
            set { BackingStore?.Set("accessType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The connectionStatus property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.ConnectionStatus? ConnectionStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ConnectionStatus?>("connectionStatus"); }
            set { BackingStore?.Set("connectionStatus", value); }
        }
        /// <summary>The connectorId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorId {
            get { return BackingStore?.Get<string?>("connectorId"); }
            set { BackingStore?.Set("connectorId", value); }
        }
#nullable restore
#else
        public string ConnectorId {
            get { return BackingStore?.Get<string>("connectorId"); }
            set { BackingStore?.Set("connectorId", value); }
        }
#endif
        /// <summary>The connectorIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorIp {
            get { return BackingStore?.Get<string?>("connectorIp"); }
            set { BackingStore?.Set("connectorIp", value); }
        }
#nullable restore
#else
        public string ConnectorIp {
            get { return BackingStore?.Get<string>("connectorIp"); }
            set { BackingStore?.Set("connectorIp", value); }
        }
#endif
        /// <summary>The connectorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorName {
            get { return BackingStore?.Get<string?>("connectorName"); }
            set { BackingStore?.Set("connectorName", value); }
        }
#nullable restore
#else
        public string ConnectorName {
            get { return BackingStore?.Get<string>("connectorName"); }
            set { BackingStore?.Set("connectorName", value); }
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
        /// <summary>The processingRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProcessingRegion {
            get { return BackingStore?.Get<string?>("processingRegion"); }
            set { BackingStore?.Set("processingRegion", value); }
        }
#nullable restore
#else
        public string ProcessingRegion {
            get { return BackingStore?.Get<string>("processingRegion"); }
            set { BackingStore?.Set("processingRegion", value); }
        }
#endif
        /// <summary>The thirdPartyTokenDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails? ThirdPartyTokenDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails?>("thirdPartyTokenDetails"); }
            set { BackingStore?.Set("thirdPartyTokenDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails ThirdPartyTokenDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails>("thirdPartyTokenDetails"); }
            set { BackingStore?.Set("thirdPartyTokenDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrivateAccessDetails"/> and sets the default values.
        /// </summary>
        public PrivateAccessDetails()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivateAccessDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrivateAccessDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivateAccessDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"accessType", n => { AccessType = n.GetEnumValue<AccessType>(); } },
                {"connectionStatus", n => { ConnectionStatus = n.GetEnumValue<ConnectionStatus>(); } },
                {"connectorId", n => { ConnectorId = n.GetStringValue(); } },
                {"connectorIp", n => { ConnectorIp = n.GetStringValue(); } },
                {"connectorName", n => { ConnectorName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"processingRegion", n => { ProcessingRegion = n.GetStringValue(); } },
                {"thirdPartyTokenDetails", n => { ThirdPartyTokenDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails>(Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessType>("accessType", AccessType);
            writer.WriteEnumValue<ConnectionStatus>("connectionStatus", ConnectionStatus);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("connectorIp", ConnectorIp);
            writer.WriteStringValue("connectorName", ConnectorName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("processingRegion", ProcessingRegion);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.ThirdPartyTokenDetails>("thirdPartyTokenDetails", ThirdPartyTokenDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
