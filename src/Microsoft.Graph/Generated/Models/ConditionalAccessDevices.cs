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
    public class ConditionalAccessDevices : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Filter that defines the dynamic-device-syntax rule to include/exclude devices. A filter can use device properties (such as extension attributes) to include/exclude them. Cannot be set if includeDevices or excludeDevices is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessFilter? DeviceFilter
        {
            get { return BackingStore?.Get<ConditionalAccessFilter?>("deviceFilter"); }
            set { BackingStore?.Set("deviceFilter", value); }
        }
#nullable restore
#else
        public ConditionalAccessFilter DeviceFilter
        {
            get { return BackingStore?.Get<ConditionalAccessFilter>("deviceFilter"); }
            set { BackingStore?.Set("deviceFilter", value); }
        }
#endif
        /// <summary>States excluded from the scope of the policy. Possible values: Compliant, DomainJoined. Cannot be set if deviceFIlter is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeDevices
        {
            get { return BackingStore?.Get<List<string>?>("excludeDevices"); }
            set { BackingStore?.Set("excludeDevices", value); }
        }
#nullable restore
#else
        public List<string> ExcludeDevices
        {
            get { return BackingStore?.Get<List<string>>("excludeDevices"); }
            set { BackingStore?.Set("excludeDevices", value); }
        }
#endif
        /// <summary>States excluded from the scope of the policy. Possible values: Compliant, DomainJoined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeDeviceStates
        {
            get { return BackingStore?.Get<List<string>?>("excludeDeviceStates"); }
            set { BackingStore?.Set("excludeDeviceStates", value); }
        }
#nullable restore
#else
        public List<string> ExcludeDeviceStates
        {
            get { return BackingStore?.Get<List<string>>("excludeDeviceStates"); }
            set { BackingStore?.Set("excludeDeviceStates", value); }
        }
#endif
        /// <summary>States in the scope of the policy. All is the only allowed value. Cannot be set if deviceFilter is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeDevices
        {
            get { return BackingStore?.Get<List<string>?>("includeDevices"); }
            set { BackingStore?.Set("includeDevices", value); }
        }
#nullable restore
#else
        public List<string> IncludeDevices
        {
            get { return BackingStore?.Get<List<string>>("includeDevices"); }
            set { BackingStore?.Set("includeDevices", value); }
        }
#endif
        /// <summary>States in the scope of the policy. All is the only allowed value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeDeviceStates
        {
            get { return BackingStore?.Get<List<string>?>("includeDeviceStates"); }
            set { BackingStore?.Set("includeDeviceStates", value); }
        }
#nullable restore
#else
        public List<string> IncludeDeviceStates
        {
            get { return BackingStore?.Get<List<string>>("includeDeviceStates"); }
            set { BackingStore?.Set("includeDeviceStates", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessDevices"/> and sets the default values.
        /// </summary>
        public ConditionalAccessDevices()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionalAccessDevices"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessDevices CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessDevices();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceFilter", n => { DeviceFilter = n.GetObjectValue<ConditionalAccessFilter>(ConditionalAccessFilter.CreateFromDiscriminatorValue); } },
                { "excludeDeviceStates", n => { ExcludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "excludeDevices", n => { ExcludeDevices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "includeDeviceStates", n => { IncludeDeviceStates = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "includeDevices", n => { IncludeDevices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessFilter>("deviceFilter", DeviceFilter);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeDevices", ExcludeDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("excludeDeviceStates", ExcludeDeviceStates);
            writer.WriteCollectionOfPrimitiveValues<string>("includeDevices", IncludeDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("includeDeviceStates", IncludeDeviceStates);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
