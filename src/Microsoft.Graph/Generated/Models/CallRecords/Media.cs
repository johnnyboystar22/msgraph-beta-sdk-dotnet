// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords
{
    #pragma warning disable CS1591
    public class Media : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device information associated with the callee endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo? CalleeDevice
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo?>("calleeDevice"); }
            set { BackingStore?.Set("calleeDevice", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo CalleeDevice
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>("calleeDevice"); }
            set { BackingStore?.Set("calleeDevice", value); }
        }
#endif
        /// <summary>Network information associated with the callee endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo? CalleeNetwork
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo?>("calleeNetwork"); }
            set { BackingStore?.Set("calleeNetwork", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo CalleeNetwork
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>("calleeNetwork"); }
            set { BackingStore?.Set("calleeNetwork", value); }
        }
#endif
        /// <summary>Device information associated with the caller endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo? CallerDevice
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo?>("callerDevice"); }
            set { BackingStore?.Set("callerDevice", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo CallerDevice
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>("callerDevice"); }
            set { BackingStore?.Set("callerDevice", value); }
        }
#endif
        /// <summary>Network information associated with the caller endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo? CallerNetwork
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo?>("callerNetwork"); }
            set { BackingStore?.Set("callerNetwork", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo CallerNetwork
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>("callerNetwork"); }
            set { BackingStore?.Set("callerNetwork", value); }
        }
#endif
        /// <summary>How the media was identified during media negotiation stage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label
        {
            get { return BackingStore?.Get<string?>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#nullable restore
#else
        public string Label
        {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Network streams associated with this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CallRecords.MediaStream>? Streams
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.MediaStream>?>("streams"); }
            set { BackingStore?.Set("streams", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CallRecords.MediaStream> Streams
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.MediaStream>>("streams"); }
            set { BackingStore?.Set("streams", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CallRecords.Media"/> and sets the default values.
        /// </summary>
        public Media()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CallRecords.Media"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CallRecords.Media CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CallRecords.Media();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "calleeDevice", n => { CalleeDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>(Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo.CreateFromDiscriminatorValue); } },
                { "calleeNetwork", n => { CalleeNetwork = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>(Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo.CreateFromDiscriminatorValue); } },
                { "callerDevice", n => { CallerDevice = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>(Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo.CreateFromDiscriminatorValue); } },
                { "callerNetwork", n => { CallerNetwork = n.GetObjectValue<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>(Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo.CreateFromDiscriminatorValue); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "streams", n => { Streams = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.MediaStream>(Microsoft.Graph.Beta.Models.CallRecords.MediaStream.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>("calleeDevice", CalleeDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>("calleeNetwork", CalleeNetwork);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallRecords.DeviceInfo>("callerDevice", CallerDevice);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CallRecords.NetworkInfo>("callerNetwork", CallerNetwork);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.MediaStream>("streams", Streams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
