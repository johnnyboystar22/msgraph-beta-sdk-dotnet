// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.BulkRestoreCloudPc {
    #pragma warning disable CS1591
    public class BulkRestoreCloudPcPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The managedDeviceIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ManagedDeviceIds {
            get { return BackingStore?.Get<List<string>?>("managedDeviceIds"); }
            set { BackingStore?.Set("managedDeviceIds", value); }
        }
#nullable restore
#else
        public List<string> ManagedDeviceIds {
            get { return BackingStore?.Get<List<string>>("managedDeviceIds"); }
            set { BackingStore?.Set("managedDeviceIds", value); }
        }
#endif
        /// <summary>The restorePointDateTime property</summary>
        public DateTimeOffset? RestorePointDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("restorePointDateTime"); }
            set { BackingStore?.Set("restorePointDateTime", value); }
        }
        /// <summary>The timeRange property</summary>
        public RestoreTimeRange? TimeRange {
            get { return BackingStore?.Get<RestoreTimeRange?>("timeRange"); }
            set { BackingStore?.Set("timeRange", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="BulkRestoreCloudPcPostRequestBody"/> and sets the default values.
        /// </summary>
        public BulkRestoreCloudPcPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BulkRestoreCloudPcPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkRestoreCloudPcPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkRestoreCloudPcPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"managedDeviceIds", n => { ManagedDeviceIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"restorePointDateTime", n => { RestorePointDateTime = n.GetDateTimeOffsetValue(); } },
                {"timeRange", n => { TimeRange = n.GetEnumValue<RestoreTimeRange>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("managedDeviceIds", ManagedDeviceIds);
            writer.WriteDateTimeOffsetValue("restorePointDateTime", RestorePointDateTime);
            writer.WriteEnumValue<RestoreTimeRange>("timeRange", TimeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
