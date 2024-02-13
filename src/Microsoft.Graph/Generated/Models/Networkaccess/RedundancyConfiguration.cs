// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class RedundancyConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
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
        /// <summary>The redundancyTier property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.RedundancyTier? RedundancyTier {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.RedundancyTier?>("redundancyTier"); }
            set { BackingStore?.Set("redundancyTier", value); }
        }
        /// <summary>Indicate the specific IP address used for establishing the Border Gateway Protocol (BGP) connection with Microsoft&apos;s network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ZoneLocalIpAddress {
            get { return BackingStore?.Get<string?>("zoneLocalIpAddress"); }
            set { BackingStore?.Set("zoneLocalIpAddress", value); }
        }
#nullable restore
#else
        public string ZoneLocalIpAddress {
            get { return BackingStore?.Get<string>("zoneLocalIpAddress"); }
            set { BackingStore?.Set("zoneLocalIpAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RedundancyConfiguration"/> and sets the default values.
        /// </summary>
        public RedundancyConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RedundancyConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RedundancyConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedundancyConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"redundancyTier", n => { RedundancyTier = n.GetEnumValue<RedundancyTier>(); } },
                {"zoneLocalIpAddress", n => { ZoneLocalIpAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RedundancyTier>("redundancyTier", RedundancyTier);
            writer.WriteStringValue("zoneLocalIpAddress", ZoneLocalIpAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
