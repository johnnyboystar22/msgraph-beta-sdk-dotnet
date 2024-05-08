// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class SecurityProviderStatus : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The enabled property</summary>
        public bool? Enabled {
            get { return BackingStore?.Get<bool?>("enabled"); }
            set { BackingStore?.Set("enabled", value); }
        }
        /// <summary>The endpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Endpoint {
            get { return BackingStore?.Get<string?>("endpoint"); }
            set { BackingStore?.Set("endpoint", value); }
        }
#nullable restore
#else
        public string Endpoint {
            get { return BackingStore?.Get<string>("endpoint"); }
            set { BackingStore?.Set("endpoint", value); }
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
        /// <summary>The provider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Provider {
            get { return BackingStore?.Get<string?>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#nullable restore
#else
        public string Provider {
            get { return BackingStore?.Get<string>("provider"); }
            set { BackingStore?.Set("provider", value); }
        }
#endif
        /// <summary>The region property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>The vendor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Vendor {
            get { return BackingStore?.Get<string?>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
#nullable restore
#else
        public string Vendor {
            get { return BackingStore?.Get<string>("vendor"); }
            set { BackingStore?.Set("vendor", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SecurityProviderStatus"/> and sets the default values.
        /// </summary>
        public SecurityProviderStatus()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SecurityProviderStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecurityProviderStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityProviderStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"endpoint", n => { Endpoint = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"provider", n => { Provider = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
                {"vendor", n => { Vendor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteStringValue("endpoint", Endpoint);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("provider", Provider);
            writer.WriteStringValue("region", Region);
            writer.WriteStringValue("vendor", Vendor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
