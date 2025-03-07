// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The result of the triggered device scope action.
    /// </summary>
    public class DeviceScopeActionResult : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Trigger on the service to either START or STOP computing metrics data based on a device scope configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceScopeAction
        {
            get { return BackingStore?.Get<string?>("deviceScopeAction"); }
            set { BackingStore?.Set("deviceScopeAction", value); }
        }
#nullable restore
#else
        public string DeviceScopeAction
        {
            get { return BackingStore?.Get<string>("deviceScopeAction"); }
            set { BackingStore?.Set("deviceScopeAction", value); }
        }
#endif
        /// <summary>The unique identifier of the device scope the action was triggered on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceScopeId
        {
            get { return BackingStore?.Get<string?>("deviceScopeId"); }
            set { BackingStore?.Set("deviceScopeId", value); }
        }
#nullable restore
#else
        public string DeviceScopeId
        {
            get { return BackingStore?.Get<string>("deviceScopeId"); }
            set { BackingStore?.Set("deviceScopeId", value); }
        }
#endif
        /// <summary>The message indicates the reason the device scope action failed to trigger.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailedMessage
        {
            get { return BackingStore?.Get<string?>("failedMessage"); }
            set { BackingStore?.Set("failedMessage", value); }
        }
#nullable restore
#else
        public string FailedMessage
        {
            get { return BackingStore?.Get<string>("failedMessage"); }
            set { BackingStore?.Set("failedMessage", value); }
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
        /// <summary>Indicates the status of the attempted device scope action</summary>
        public Microsoft.Graph.Beta.Models.DeviceScopeActionStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceScopeActionStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceScopeActionResult"/> and sets the default values.
        /// </summary>
        public DeviceScopeActionResult()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceScopeActionResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.DeviceScopeActionResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceScopeActionResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceScopeAction", n => { DeviceScopeAction = n.GetStringValue(); } },
                { "deviceScopeId", n => { DeviceScopeId = n.GetStringValue(); } },
                { "failedMessage", n => { FailedMessage = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.DeviceScopeActionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceScopeAction", DeviceScopeAction);
            writer.WriteStringValue("deviceScopeId", DeviceScopeId);
            writer.WriteStringValue("failedMessage", FailedMessage);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DeviceScopeActionStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
