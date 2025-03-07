// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class MediaStream : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The direction property</summary>
        public Microsoft.Graph.Beta.Models.MediaDirection? Direction
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaDirection?>("direction"); }
            set { BackingStore?.Set("direction", value); }
        }
        /// <summary>The media stream label.</summary>
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
        /// <summary>The mediaType property</summary>
        public Microsoft.Graph.Beta.Models.Modality? MediaType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Modality?>("mediaType"); }
            set { BackingStore?.Set("mediaType", value); }
        }
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
        /// <summary>Indicates whether the server has muted the media.</summary>
        public bool? ServerMuted
        {
            get { return BackingStore?.Get<bool?>("serverMuted"); }
            set { BackingStore?.Set("serverMuted", value); }
        }
        /// <summary>The source ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId
        {
            get { return BackingStore?.Get<string?>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#nullable restore
#else
        public string SourceId
        {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MediaStream"/> and sets the default values.
        /// </summary>
        public MediaStream()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MediaStream"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.MediaStream CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MediaStream();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "direction", n => { Direction = n.GetEnumValue<Microsoft.Graph.Beta.Models.MediaDirection>(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "mediaType", n => { MediaType = n.GetEnumValue<Microsoft.Graph.Beta.Models.Modality>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "serverMuted", n => { ServerMuted = n.GetBoolValue(); } },
                { "sourceId", n => { SourceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MediaDirection>("direction", Direction);
            writer.WriteStringValue("label", Label);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Modality>("mediaType", MediaType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("serverMuted", ServerMuted);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
